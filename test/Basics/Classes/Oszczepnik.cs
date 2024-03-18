using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Basics.Classes
{
    using System;

    public class Oszczepnik
    {
        private string _imie;
        private string _nazwisko;
        private string _kraj;
        private int _liczbaProb;
        private double _wynikNajlepszy;
        private double _wynikSredni;
        private string _wynikOstatni;

        public string Imie
        {
            get => _imie;
            set
            {
                ValidateName(value);
                _imie = FormatName(value);
            }
        }

        public string Nazwisko
        {
            get => _nazwisko;
            set
            {
                ValidateName(value);
                _nazwisko = FormatName(value);
            }
        }

        public string Kraj
        {
            get => _kraj;
            set
            {
                if (value.Trim().Length != 3)
                    throw new ArgumentException("Niepoprawny kod kraju!");
                _kraj = value.Trim().ToUpper();
            }
        }

        public int LiczbaProb => _liczbaProb;
        public double WynikNajlepszy => _wynikNajlepszy;
        public double WynikSredni => Math.Round(_wynikSredni, 2);
        public string WynikOstatni => _wynikOstatni;

        public Oszczepnik(string imie, string nazwisko, string kraj)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Kraj = kraj;
        }

        public void ZarejestrujWynik(string wynik)
        {
            if (_liczbaProb >= 6)
                throw new ArgumentException("Limit wykorzystany.");

            if (wynik.Equals("x", StringComparison.OrdinalIgnoreCase)) _wynikOstatni = "X";

            wynik = wynik.Contains(".") ? wynik : $"{wynik}.0";

            if (!double.TryParse(wynik, out double result)) throw new ArgumentException("Niepoprawny format.");

            _wynikOstatni = result.ToString("F2");
            if (result > _wynikNajlepszy)
                _wynikNajlepszy = result;
            _wynikSredni = (_wynikSredni * _liczbaProb + result) / (_liczbaProb + 1);


            _liczbaProb++;
        }

        public bool ProbujZarejestrowacWynik(string wynik)
        {
            try
            {
                ZarejestrujWynik(wynik);
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public override string ToString()
        {
            string wyniki = _liczbaProb > 0 ? string.Join(", ", Enumerable.Range(1, _liczbaProb).Select(i => _wynikOstatni)) : "-";
            return $"{Imie} {Nazwisko} ({Kraj})\n" +
                   $"wyniki: {wyniki}\n" +
                   $"liczba prob: {_liczbaProb}, wynik najlepszy: {_wynikNajlepszy:F2}, wynik sredni: {_wynikSredni:F2}";
        }

        private static void ValidateName(string name)
        {
            if (name == null)
                throw new ArgumentException("Nazwa nie moze byc null!");

            if (name.Length < 3 || !name.All(char.IsLetter))
                throw new ArgumentException("Niepoprawna nazwa!");
        }

        private static string FormatName(string name)
        {
            return char.ToUpper(name[0]) + name.Substring(1).ToLower().Replace(" ", "");
        }
    }

}
