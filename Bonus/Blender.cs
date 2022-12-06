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

        private int _PowerValue;
        public int Power
        {
            get
            {
                return _PowerValue;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Potenza (Frullatore)");
                }
                else
                {
                    _PowerValue = value;
                }
            }

        }
        private int _VoltageValue;
        public int Voltage
        {
            get
            {
                return _VoltageValue;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Voltaggio (Frullatore)");
                }
                else
                {
                    _VoltageValue = value;
                }
            }

        }

        private double _WeightValue;
        public double Weight
        {
            get
            {
                return _WeightValue;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Peso (Frullatore)");
                }
                else
                {
                    _WeightValue = value;
                }
            }

        }

        private double _CapacityValue;
        public double Capacity
        {
            get
            {
                return _CapacityValue;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Capacità (Frullatore)");
                }
                else
                {
                    _CapacityValue = value;
                }
            }

        }

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
        public override void Print(int num)
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
