//CONSEGNA: Partendo dall'esercizio precedente, inserire correttamente le eccezioni nei prodotti e sotto prodotti.

using СSharpShop3;
using static СSharpShop3.Water;

//Viene usato l'encoding per vedere correttamente il prezzo in console (€)


Console.OutputEncoding = System.Text.Encoding.UTF8;

Water Guizza = new Water("Acqua_Guizza", "Acqua naturale, povera di sodio.", 0.24, 1.5, 7.5, "Scorzè");

try
{
    Guizza.Print(1);
    Guizza.Drink(2);
    Guizza.Fill(1);
}
catch (EmptyBottleException)
{
    Console.WriteLine("La bottiglia è vuota");
}
