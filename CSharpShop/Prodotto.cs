using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop
{
    public class Prodotto
    {
        private int codice;
        private string name;
        private string description;
        private double prezzo;
        private double IVA;

        /// <summary>
        /// In questo Costruttore di base sono già presenti obbligatoriamente nome, prezzo e IVA, in quanto base obbligatoria per qualsiasi prodotto in vendita
        /// </summary>
        /// <param name="name">Il nome del prodotto</param>
        /// <param name="prezzo">il prezzo deve presentare massimo 2 decimali, in caso ne presenti ulteriori verrà tagliato a un formato corretto</param>
        /// <param name="IVA">l'IVA non ha bisogno di essere presentata in percentuale, ma semplicemente in numero</param>
        public Prodotto(string name, double prezzo, double IVA)
        {
            this.codice = CalcoloCodice();
            this.name = name;
            this.prezzo = Math.Round(prezzo,2); //In questo passaggio arrotondo il prezzo a due cifre decimali
            this.IVA = IVA;
        }

        /// <summary>
        /// Creo il costruttore completo
        /// </summary>
        /// <param name="name">Il nome del prodotto</param>
        /// <param name="description"></param>
        /// <param name="prezzo">il prezzo deve presentare massimo 2 decimali, in caso ne presenti ulteriori verrà tagliato a un formato corretto</param>
        /// <param name="IVA">l'IVA non ha bisogno di essere presentata in percentuale, ma semplicemente in numero</param>
        public Prodotto(string name, string description, double prezzo, double iVA)
        {
            this.codice = CalcoloCodice();
            this.name = name;
            this.description = description;
            this.prezzo = Math.Round(prezzo, 2);
            IVA = iVA;
        }

        public int GetCodice()
        {
            return this.codice;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public void SetDescription (string description)
        {
            this.description = description;
        }

        public double GetPrezzo()
        {
            return this.prezzo;
        }

        public void SetPrezzo(double prezzo)
        {
            this.prezzo= prezzo;
        }

        public double GetIVA()
        {
            return this.IVA;
        }

        public void SetIVA(double IVA)
        {
            this.IVA = IVA;
        }

        /// <summary>
        /// Creo un metodo, privato, che calcoli in maniera randomica il codice da assegnare a un prodotto, da 0 a 99999999
        /// </summary>
        /// <returns></returns>
        private int CalcoloCodice()
        {

            Random generatoreRandom = new Random();
            int numeroCodice = generatoreRandom.Next(100000000);
            return numeroCodice;
        }

        public string GetPrezzoBase()
        {
            string prezzoBase = (this.prezzo).ToString();
            prezzoBase += " euro";
            return prezzoBase;
        }

        public string GetPrezzoIVA()
        {
            double prezzoIVA = (this.prezzo + (this.prezzo * this.IVA) / 100);
            prezzoIVA = Math.Round(prezzoIVA, 2);
            string prezzo = (prezzoIVA.ToString());
            prezzo += " euro";
            return prezzo;
        }

        public string GetNomeEsteso()  //Qui ho unito il bonus al compito Nome Esteso, generando di base un codice prodotto nella forma NomeCodice, con padding di 0 se necessario
        {
            string stringaZeri = "";
            string codiceStringa=codice.ToString();
            for (int i=0; i < (8-codiceStringa.Length); i++)
            {
                stringaZeri += "0";
            }
            string nomeEsteso = this.name + stringaZeri + codiceStringa;
            return nomeEsteso;
        }

        public void StampaProdotto()
        {
            Console.WriteLine("------ " + this.name + " -----");
            Console.WriteLine();
            Console.WriteLine(this.description);
            Console.WriteLine("Il codice del prodotto è: " + this.codice);
            Console.WriteLine("Il prezzo del prodotto è: " + this.prezzo + " euro");
            Console.WriteLine("L'IVA del prodotto è al: " + this.IVA + "%");
            Console.WriteLine();
            Console.WriteLine("Il codice NomeEsteso è: " + this.GetNomeEsteso());
            Console.WriteLine();
        }
    }

}
