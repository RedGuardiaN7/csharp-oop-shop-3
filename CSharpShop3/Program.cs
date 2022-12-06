//CONSEGNA: Partendo dall'esercizio precedente, inserire correttamente le eccezioni nei prodotti e sotto prodotti.

using СSharpShop3;
using static СSharpShop3.Water;
using static СSharpShop3.Product;

//Viene usato l'encoding per vedere correttamente il prezzo in console (€)


Console.OutputEncoding = System.Text.Encoding.UTF8;

//Prova del metodo statico di conversione in galloni

Console.WriteLine(ConvertToGallons(2) + " galloni");
Console.WriteLine();

try
{
    Water Guizza = new Water("Acqua_Guizza", "Acqua naturale, povera di sodio.", 0.24, 1.5, 7.5, "Scorzè");

    Guizza.Print(Count);
    Guizza.Drink(1);
    Guizza.Fill(1);
    Console.WriteLine();

    Water Pippo = new Water("Acqua_Pippo", "Ancora più buona!", 0.33, 1.5, 8, "Monte Baudo");

    Pippo.Print(Count);

    FruitSnack ZIG = new FruitSnack("ZIG_Crunchy", "Frutta secca di provenienza certificata", 0.59, 30, 5, false, true);

    ZIG.Print(Count);
    ZIG.EcoFriendly();
    ZIG.Healthy();
    Console.WriteLine();

    LEGO Millenium_Falcon = new LEGO("Millenium_Falcon", "L'astronave più famosa della galassia, tutta da costruire!", 693.99, 75192, 7500, 1700, 18, false, false);

    Millenium_Falcon.Print(Count);
    Millenium_Falcon.BuyBatteries();
    Millenium_Falcon.ChildFriendly();
    Console.WriteLine();

    Blender Bosch = new Blender("Bosch_MultiTalent", "Il frullatore multi-funzione", 200, 1250, 220, 5.7, 3.9, "Rosso");

    Bosch.Print(Count);
    Console.WriteLine();
    
    Console.WriteLine("I prodotti presenti in catalogo sono: " + Count);

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