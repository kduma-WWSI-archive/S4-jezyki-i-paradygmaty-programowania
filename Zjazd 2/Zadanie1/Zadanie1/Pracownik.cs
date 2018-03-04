/*
  +--------------------------------------------------------------------------+
  |                                                                          |
  |                           [2018] Krystian Duma                           |\\
  |                           All Rights Reserved.                           |\\
  |                                                                          |\\
  |  NOTICE: All information contained herein is, and remains the property   |\\
  |   of Krystian Duma. The intellectual and technical concepts contained    |\\
  |  herein are proprietary to Krystian Duma and may be covered by U.S. and  |\\
  |  Foreign Patents, patents in process, and are protected by trade secret  |\\
  |  or copyright law. Dissemination of this information or reproduction of  |\\
  |  this material is strictly forbidden unless prior written permission is  |\\
  |                       obtained from Krystian Duma.                       |\\
  |                                                                          |\\
  +--------------------------------------------------------------------------+\\
    \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable LocalizableElement

namespace Zadanie1
{
    public class Pracownik
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

        public void Zapisz()
        {
            File.WriteAllText($"./dane/{_pesel}.txt", $"{Imie}\n{Nazwisko}\n{Miasto}\n{Ulica}\n{Pesel}\n{Stanowisko}\n{Pensja.ToString()}", Encoding.UTF8);
        }

        public static Pracownik Otworz(string pesel)
        {
            var dane = File.ReadAllLines($"./dane/{pesel}.txt", Encoding.UTF8);

            return new Pracownik
            {
                Imie = dane[0],
                Nazwisko = dane[1],
                Miasto = dane[2],
                Ulica = dane[3],
                _pesel = dane[4],
                Stanowisko = dane[5],
                Pensja = Convert.ToDecimal(dane[6])
            };
            
            // TODO: metoda tworzy obiekt Pracownik z danych pobranych z pliku i zwraca jego instancję.
            // 1.	otwiera plik o nazwie zgodnej z podanym peselem [pesel].txt 
            // 2.	tworzy obiekt Pracownik
            // 3.	uzupełnia dane
            // 4.	zwraca utworzony obiekt 
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}";
        }
    }
}
