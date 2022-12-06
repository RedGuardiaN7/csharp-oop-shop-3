using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    public class Blender : Product
    {
        ////Attributi

        public int Power { get; set; }

        public int Voltage { get; set; }

        public double Weight { get; set; }

        public double Capacity { get; set; }

        public string Color { get; set; }

        //------------ COSTRUTTORE ------------ //

        public Blender(string name, string description, double price, int Power, int Voltage, double Weight, double Capacity, string Color) : base(name, description, price) 
        {
            this.Power = Power;
            this.Voltage= Voltage;
            this.Weight = Weight;
            this.Capacity = Capacity;
            this.Color = Color;
        }

        //---------- Definizioni dei metodi ---------- //

        //Metodo che stampa a video tutte le informazioni del prodotto (override del product.cs)
        public virtual void Print(int num)
        {
            Console.WriteLine("-------------------- Frullatore, prodotto n. " + num + " ---------------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + this.Name);
            Console.WriteLine();
            Console.WriteLine("Codice: " + this.Code);
            Console.WriteLine();
            Console.WriteLine("Descrizione: " + this.Description);
            Console.WriteLine();
            Console.WriteLine("Il nome esteso del prodotto è: " + this.ExtendedName());
            Console.WriteLine();
            Console.WriteLine("Wattaggio: " + this.Power + "W");
            Console.WriteLine();
            Console.WriteLine("Voltaggio: " + this.Voltage + " Volt");
            Console.WriteLine();
            Console.WriteLine("Peso: " + this.Weight + " kg");
            Console.WriteLine();
            Console.WriteLine("Capacità contenitore: " + this.Capacity + " l");
            Console.WriteLine();
            Console.WriteLine("Colore: " + this.Color);
            Console.WriteLine();

            double FullPrice = this.FullPrice();

            Console.WriteLine("Prezzo: " + FullPrice + "€");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();

        }
    }
}
