using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSharpShop3
{
    internal class FruitSnack : Product
    {
        ////Attributi
        
        public int MaxPieces { get; }

        public int Weight { get; set; }

        private int _PiecesValue;
        public int Pieces {
            get
            {
                return _PiecesValue;
            } set 
            {
                if (value > 5 || value < 0) {
                    Console.WriteLine("Errore, numero di pezzi di frutta invalido");        // Questo viene fatto per mantenere il numero massimo di pezzi
                } else
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
            this.Pieces = 0;
            Console.WriteLine("Hai mangiato lo snack");
        }

        //Metodo che stampa a video tutte le informazioni del prodotto (override del product.cs)
        public virtual void Print(int num)
        {
            Console.WriteLine("-------------------- Fruit snack " + num + " ---------------------");
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
            Console.WriteLine("Zuccheri aggiunti? " + this.ConvertBoolean(this.AddedSugars));
            Console.WriteLine();
            Console.WriteLine("Eco-friendly? " + this.ConvertBoolean(this.Compostable));
            Console.WriteLine();

            double FullPrice = this.FullPrice();

            Console.WriteLine("Prezzo: " + FullPrice + "€");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
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
