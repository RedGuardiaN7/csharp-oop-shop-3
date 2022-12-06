using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static СSharpShop3.Water.EmptyBottleException;

namespace СSharpShop3
{
    public class Water : Product
    {
        //Attributi

        private double _LitresValue;
        public double Litres
        {
            get
            {
                return _LitresValue;
            }
            set
            {
                if (value > 1.5 || value < 0)
                {
                    throw new ArgumentOutOfRangeException("Litri, devono essere compresi tra 0 e 1,5");        // Questo viene fatto per mantenere il numero massimo di pezzi
                }
                else
                {
                    _LitresValue = value;
                }
            }

        }

        public double Ph { get; }

        public string Source { get; set; }

        public double MaxCapacity { get; }

        //------------ COSTRUTTORE ------------ //

        public Water(string name,string description, double price, double Litres, double Ph, string Source, double MaxCapacity = 1.5) : base(name, description, price)
        {
            if (Ph <= 0 || Ph > 10)
            {
                throw new ArgumentOutOfRangeException("Ph, deve essere compreso tra 0 e 10");
            }
            this.Litres = Litres;
            this.Ph = Ph;
            this.Source = Source;
            this.MaxCapacity = MaxCapacity;
        }

        //---------- Definizioni dei metodi ---------- //

        //Metodo statico che converte i litri in galloni

        public static double ConvertToGallons(double litres)
        {
            return litres * 3.785;
        }

        //Metodo bevi, che toglie dall’attributo litri una quantità pari a litriDaBere di acqua se presenti

        public void Drink(double DrinkLitres)
        {
            if (DrinkLitres == this.Litres)
            {

                throw new EmptyBottleException("Hai bevuto tutta l'acqua, la bottiglia è vuota!");
            } if (DrinkLitres > this.Litres)
            {
                throw new EmptyBottleException("Non puoi bere più di quanta acqua è presente nella bottiglia!");
            }
            else
            {
                this.Litres = this.Litres - DrinkLitres;
                Console.WriteLine("Dopo aver bevuto " + DrinkLitres + " l dalla bottiglia, ne sono rimasti " + this.Litres + " l");
            }
        }

        //Metodo riempi(double litri) che riempie la bottiglia di acqua con tot litri di acqua

        public void Fill(double Fill_Litres)
        {
            if ((Fill_Litres + this.Litres) > MaxCapacity)
            {
                throw new OverfillBottleException("Wow, hai riempito troppo la bottiglia! (Max capacità: 1.5 l)");
            }
            else
            {
                this.Litres += Fill_Litres;
                Console.WriteLine("Hai riempito la bottiglia di " + Fill_Litres + " l, ora la bottiglia ha " + this.Litres + " l");
            }
        }

        //Metodo svuota che rimuove tutta l’acqua dalla bottiglia

        public void Empty()
        {
            this.Litres = 0;
            Console.WriteLine("La bottiglia è stata svuotata");
        }

        //Metodo che stampa a video tutte le informazioni del prodotto (override del product.cs)
        public virtual void Print(int num)
        {
            Console.WriteLine("-------------------- Bottiglia " + num + " ---------------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + this.Name);
            Console.WriteLine();
            Console.WriteLine("Codice: " + this.Code);
            Console.WriteLine();
            Console.WriteLine("Descrizione: " + this.Description);
            Console.WriteLine();
            Console.WriteLine("Il nome esteso del prodotto è: " + this.ExtendedName());
            Console.WriteLine();
            Console.WriteLine("Litri presenti nella bottiglia: " + this.Litres + " l");
            Console.WriteLine();
            Console.WriteLine("PH: " + this.Ph);
            Console.WriteLine();
            Console.WriteLine("Sorgente: " + this.Source);
            Console.WriteLine();

            double FullPrice = this.FullPrice();

            Console.WriteLine("Prezzo: " + FullPrice + "€");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

        }

        //Eccezione personalizzata per il metodo Drink

        internal class EmptyBottleException : Exception
        {
            public EmptyBottleException() { }

            public EmptyBottleException(string message) : base(message) { }
        }

        //Eccezione personalizzata per il metodo Fill

        internal class OverfillBottleException : Exception 
        { 
            public OverfillBottleException() { }

            public OverfillBottleException(string message) : base(message) { }
        }
    }
}


