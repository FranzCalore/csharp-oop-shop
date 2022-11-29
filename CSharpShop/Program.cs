// See https://aka.ms/new-console-template for more information

using CSharpShop;

Prodotto prodotto1 = new Prodotto("Goleador", "Una buona caramella", 0.10, 22);

Prodotto prodotto2 = new Prodotto("Pokémon Scarlatto", "Il nuovo gioco dei Pokémon", 60, 22);

Prodotto prodotto3 = new Prodotto("Evangelion#1", "Il primo volume del manga di Evangelion", 4.5, 4);

Prodotto prodotto4 = new Prodotto("Bottiglia di Latte", "Una bottiglia da un litro di latte", 1.6, 4);

List<Prodotto> scaffaliNegozio = new List<Prodotto>() {prodotto1, prodotto2, prodotto3, prodotto4 };

foreach (var articolo in scaffaliNegozio)
{
    articolo.StampaProdotto();
}
