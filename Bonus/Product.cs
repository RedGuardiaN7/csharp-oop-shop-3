using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    public class Product
    {

        //Viene utilizzato "public" ma assieme ai setter e getter auto-implementati, che rendono le caratteristiche private, ma peremttono di usare i getter e i setter.
        public string Code { get; }                     //Il codice prodotto è accessibile solo in lettura

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public double Iva { get; set; }

        public static int Count { get; set; } = 0;          //Questo attributo statico permette di contare il numero dei prodotti man mano che vengono creati dei nuovi

        //------------ COSTRUTTORI ------------ //
        
        //Costruttore con nome, prezzo e descrizione

        public Product(string name,string desctiption, double price)
        {
            Random GeneratorRandomNumber = new Random();
            int RandomNumber = GeneratorRandomNumber.Next(0, 999999);
            string PaddedCode = RandomNumber.ToString("D8");
            Code = PaddedCode;

            this.Name = name;
            this.Description = desctiption;
            this.Price = price;
            Count++;

        }

        //Metodo che calcola l'iva del prodotto e ritorna il prezzo pieno
        public double FullPrice()
        {
            Iva = Math.Round(0.22 * Price);
            double FullPrice = Price + Iva;
            FullPrice = Math.Round(FullPrice, 2);
            return FullPrice;
        }

        //Metodo che ritorna il nome esteso del prodotto (codice + nome)

        public string ExtendedName()
        {
            string output = Code + Name;
            return output;
        }

        //Metodo che stampa a video tutte le informazioni del prodotto (con l'IVA)
        public virtual void Print(int num)
        {
            Console.WriteLine("-------------------- Prodotto " + num + " ---------------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + Name);
            Console.WriteLine();
            Console.WriteLine("Codice: " + Code);
            Console.WriteLine();
            Console.WriteLine("Descrizione: " + Description);
            Console.WriteLine();
            Console.WriteLine("Il nome esteso del prodotto è: " + this.ExtendedName());
            Console.WriteLine();

            double FullPrice = this.FullPrice();

            Console.WriteLine("Il prezzo del prodotto è di: " + FullPrice + "€ (senza IVA: " + this.Price + "€)");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

        }

        //Metodo che stampa a video tutte le informazioni del prodotto (senza l'IVA)
        public void NoIvaPrint(int num)
        {
            Console.WriteLine("--------------------- Prodotto " + num + " --------------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + Name);
            Console.WriteLine();
            Console.WriteLine("Codice: " + Code);
            Console.WriteLine();
            Console.WriteLine("Descrizione: " + Description);
            Console.WriteLine();
            Console.WriteLine("Il nome esteso del prodotto è: " + this.ExtendedName());
            Console.WriteLine();
            Console.WriteLine("Il prezzo del prodotto è di: " + this.Price + "€ (senza IVA)");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();

        }
    }
}
