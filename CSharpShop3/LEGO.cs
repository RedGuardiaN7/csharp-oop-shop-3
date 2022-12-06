using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSharpShop3
{
    internal class LEGO : Product
    {
        //Attributi
        public int ID { get; set; }

        public int Pieces { get; set; }

        public int Weight { get; set; }

        public int RecommandedAge { get; set; }

        public bool NeedBatteries { get; set; }

        public bool BatteriesIncluded { get; set; }

        //------------ COSTRUTTORE ------------ //

        public LEGO(string name, string description, double price, int ID, int Pieces, int Weight, int RecommandedAge, bool NeedBatteries, bool BatteriesIncluded) : base(name, description, price)
        {
            this.ID = ID;
            this.Pieces = Pieces;
            this.Weight = Weight;
            this.RecommandedAge = RecommandedAge;
            this.NeedBatteries = NeedBatteries;
            this.BatteriesIncluded = BatteriesIncluded;
        }

        //---------- Definizioni dei metodi ---------- //

        //Metodo ChildFriendly, informa l'utente se il prodotto è adatto per i bambini

        public bool ChildFriendly()
        {
            if (this.RecommandedAge >= 18)
            {
                Console.WriteLine("Ci dispiace, questo prodotto e adatto ad un pubblico adulto");
                return false;

            } else {
                Console.WriteLine("Sì, questo prodotto è pefettamente adatto per i bambini");
                return false;
            }
        }

        //Metodo NeedBatteries, informa l'utente se c'è la necessità di comprare le batterie

        public void BuyBatteries()
        {
            if (this.NeedBatteries & this.BatteriesIncluded) {

                Console.WriteLine("No, le batterie sono incluse");
            } if (this.NeedBatteries & !this.BatteriesIncluded)
            {

                Console.WriteLine("Si, le batterie sono da acquistare separatamente");
            } else
            {
                Console.WriteLine("No, le batterie non sono necessarie");
            }
        }
        //Metodo che stampa a video tutte le informazioni del prodotto (override del product.cs)
        public virtual void Print(int num)
        {
            Console.WriteLine("--------------------- LEGO Set, prodotto n. " + num + " -----------------------");
            Console.WriteLine();
            Console.WriteLine("Nome: " + this.Name);
            Console.WriteLine();
            Console.WriteLine("Codice: " + this.Code);
            Console.WriteLine();
            Console.WriteLine("Descrizione: " + this.Description);
            Console.WriteLine();
            Console.WriteLine("Il nome esteso del prodotto è: " + this.ExtendedName());
            Console.WriteLine();
            Console.WriteLine("Numero modello: " + this.ID);
            Console.WriteLine();
            Console.WriteLine("Età consigliata: " + this.RecommandedAge);
            Console.WriteLine();
            Console.WriteLine("Numero pezzi: " + this.Pieces);
            Console.WriteLine();
            Console.WriteLine("Peso: " + this.Weight + "g");
            Console.WriteLine();
            Console.WriteLine("Le batterie servono? " + this.ConvertBoolean(this.NeedBatteries));
            Console.WriteLine();
            Console.WriteLine("Le batterie sono incluse? " + this.ConvertBoolean(this.BatteriesIncluded));
            Console.WriteLine();


            double FullPrice = this.FullPrice();

            Console.WriteLine("Prezzo: " + FullPrice + "€");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();

        }

        //Metodo che converte la booleana
        private string ConvertBoolean(bool b)
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
