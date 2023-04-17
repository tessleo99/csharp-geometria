using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        //ATTRIBUTI
        public float baseRettangolo;
        public float altezzaRettangolo;

        //STATI

        //COSTRUTTORE
        public Rettangolo(float baseRettangolo, float altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        //METODI
       
        //METODO PER IL CALCOLO DEL PERIMETRO
        public float CalcolaPerimetroRettangolo()
        {
            float perimetroRettangolo = (baseRettangolo + altezzaRettangolo) * 2;
            return perimetroRettangolo;
        }

        //METODO PER IL CALCOLO DELL'AREA
        public float CalcolaAreaRettangolo()
        {
            float areaRettangolo = (baseRettangolo * altezzaRettangolo);
            return areaRettangolo;
        }

        //METODO PER LA STAMPA DEI VALORI DEL RETTANGOLO
        public void StampaRettangolo()
        {
            Console.WriteLine("--Rettangolo--");
            Console.WriteLine("Base: " + baseRettangolo + "cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + "cm");
            Console.WriteLine("Perimetro: " + CalcolaPerimetroRettangolo() + "cm");
            Console.WriteLine("Area:" + CalcolaAreaRettangolo() + "cm^2");
        }
    }
}
