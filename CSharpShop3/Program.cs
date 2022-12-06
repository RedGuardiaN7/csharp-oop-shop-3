//CONSEGNA: Partendo dall'esercizio precedente, inserire correttamente le eccezioni nei prodotti e sotto prodotti.

using СSharpShop3;
using static СSharpShop3.Water;

//Viene usato l'encoding per vedere correttamente il prezzo in console (€)


Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine(ConvertToGallons(2));

/*try
{
    Water Guizza = new Water("Acqua_Guizza", "Acqua naturale, povera di sodio.", 0.24, 1.5, 7.5, "Scorzè");

    Guizza.Print(1);
    Guizza.Drink(1);
    Guizza.Fill(2);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (EmptyBottleException e)
{
    Console.WriteLine(e.Message);
}
catch (OverfillBottleException e)
{
    Console.WriteLine(e.Message);
}
*/