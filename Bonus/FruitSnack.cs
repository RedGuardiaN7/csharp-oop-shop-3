using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    internal class FruitSnack : Product
    {
        //Attributi
        
        public int MaxPieces { get; }

        private int _WeightValue;
        public int Weight
        {
            get
            {
                return _WeightValue;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Peso (Snack frutta)");
                }
                else
                {
                    _WeightValue = value;
                }
            }

        }

        private int _PiecesValue;
        public int Pieces {
            get
            {
                return _PiecesValue;
            } set 
            {
                if (value <= 0 || value > 5) 
                {
                    throw new ArgumentOutOfRangeException("Pezzi di frutta, devono essere compresi tra 0 e 5");        // Questo viene fatto per mantenere il numero massimo di pezzi
                } 
                else
                {
                    _PiecesValue= value;
                }       
            }
        
        }

        public bool AddedSugars { get; set; }

        public bool Compostable { get; set; }

        //------------ COSTRUTTORE ------------ //

        public FruitSnack(string name, string description, double price, int Weigth, int Pieces, bool AddedSugars, bool Compostable) : base(name, description, price)
        {
            this.Weight = Weigth;
            this.Pieces = Pieces;
            this.AddedSugars = AddedSugars;
            this.Compostable = Compostable;
        }

        //---------- Definizioni dei metodi ---------- //

        //Metodo che informa l'utente se lo snack è salutare o meno

        public void Healthy()
        {
            if (this.AddedSugars) {
                
                Console.WriteLine("Questo prodotto non è tanto salutare, siccome contiene zuccheri aggiunti!");
            } else
            {
                Console.WriteLine("Questo prodotto è salutare, siccome non contiene zuccheri aggiunti!");
            }
        }

        //Metodo che informa l'utente se il packaging dello snack e compostabile

        public void EcoFriendly()
        {
            if (this.Compostable) {

                Console.WriteLine("Questo prodotto è eco-friendly, in quanto il packaging è compostabile!");
            } else {
                Console.WriteLine("Questo prodotto non è eco-friendly, in quanto il packaging non è compostabile!");
            }
        }

        public void Eat()
        {
            if (this.Pieces == 0)
            {
                Console.WriteLine("Avevi già mangiato questo snack, non ricordi?");
            }
            else
            {
                this.Pieces = 0;
                Console.WriteLine("Hai mangiato lo snack");
            }
        }

        //Metodo che stampa a video tutte le informazioni del prodotto (override del product.cs)
        public override void Print(int num)
        {
            Console.WriteLine("-------------------- Fruit snack, prodotto n. " + num + " ---------------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + this.Name);
            Console.WriteLine();
            Console.WriteLine("Codice: " + this.Code);
            Console.WriteLine();
            Console.WriteLine("Descrizione: " + this.Description);
            Console.WriteLine();
            Console.WriteLine("Il nome esteso del prodotto è: " + this.ExtendedName());
            Console.WriteLine();
            Console.WriteLine("Pezzi presenti nello snack: " + this.Pieces);
            Console.WriteLine();
            Console.WriteLine("Peso: " + this.Weight + "g");
            Console.WriteLine();
            Console.WriteLine("Zuccheri aggiunti? " + ConvertBoolean(this.AddedSugars));
            Console.WriteLine();
            Console.WriteLine("Eco-friendly? " + ConvertBoolean(this.Compostable));
            Console.WriteLine();

            double FullPrice = this.FullPrice();

            Console.WriteLine("Prezzo: " + FullPrice + "€");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine();

        }

        //Metodo che converte la booleana
        private static string ConvertBoolean(bool b)
        {
            if (b)
            {
                return "Sì";
            }
            else
            {
                return "No";
            }
        }
    }

}
