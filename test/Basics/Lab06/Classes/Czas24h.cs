using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Basics.Lab06.Classes
{
    public class Czas24h
    {
        private int liczbaSekund;

        public Czas24h(int godzina, int minuta, int sekunda)
        {
            Check(sekunda, "sekunda");
            Check(minuta, "minuta");
            Check(godzina, "godzina");

            Sekunda = sekunda;
            Minuta = minuta;
            Godzina = godzina;

            liczbaSekund = sekunda + 60 * minuta + 3600 * godzina;
        }

        public int Sekunda
        {

            get => liczbaSekund - Godzina * 60 * 60 - Minuta * 60;
            set
            {
                Check(value, "sekunda");
                liczbaSekund = value + 60 * Minuta + 3600 * Godzina;
            }
        }

        public int Minuta
        {
            get => liczbaSekund / 60 % 60;
            set
            {
                Check(value, "minuta");
                liczbaSekund = Sekunda + 60 * value + 3600 * Godzina;
            }
        }

        public int Godzina
        {
            get => liczbaSekund / 3600;
            set
            {
                Check(value, "godzina");
                liczbaSekund = Sekunda + 60 * Minuta + 3600 * value;
            }
        }

        public void Check(int count, string type)
        {
            if (type == "sekunda" || type == "minuta")
            {
                if (count < 0 || count > 59)
                {
                    throw new ArgumentException("error");
                }
            }

            if (type == "godzina")
            {
                if (count < 0 || count > 23)
                {
                    throw new ArgumentException("error");
                }
            }
        }

        public override string ToString() => $"{Godzina}:{Minuta:D2}:{Sekunda:D2}";
    }
}
