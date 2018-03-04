using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Pracownik
    {
        public string Imie { get; set; }

        public string Nazwisko { get; set; }
        
        public string Ulica { get; set; }
        
        public string Miasto { get; set; }
        
        public string Stanowisko { get; set; }
        
        public decimal Pensja { get; set; }

        private string _pesel;
        
        public string Pesel
        {
            get { return _pesel; }
            set
            {
                long result;
                
                if (value.Length == 11 && long.TryParse(value, out result))
                {
                    _pesel = value;
                }
                else
                {
                    throw new Exception("Błąd Walidacji");
                }
            }
        }

        private Pracownik()
        {
            
        }

        public void Zapis()
        {
            // TODO: metoda ma zapisywać wszystkie dane osoby do pliku o nazwie [Pesel].txt
        }

        public static Pracownik Otworz(string Pesel)
        {
            var p = new Pracownik
            {
                _pesel = "1234567890",
                Imie = "Janusz",
                Nazwisko = "Kowalski",
                Miasto = "Warszawa",
                Ulica = "Warszawska 122",
                Pensja = (decimal) 1234.56,
                Stanowisko = "IT"
            };
            
            // TODO: metoda tworzy obiekt Pracownik z danych pobranych z pliku i zwraca jego instancję.
            // 1.	otwiera plik o nazwie zgodnej z podanym peselem [pesel].txt 
            // 2.	tworzy obiekt Pracownik
            // 3.	uzupełnia dane
            // 4.	zwraca utworzony obiekt 

            return p;
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}";
        }
    }
}
