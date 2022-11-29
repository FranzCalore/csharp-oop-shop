// See https://aka.ms/new-console-template for more information

using CSharpShop;

Prodotto prodotto1 = new Prodotto("Goleador", "Una buona caramella", 0.10, 22);

Console.WriteLine(prodotto1.GetPrezzoIVA());
Console.WriteLine(prodotto1.GetNomeEsteso());