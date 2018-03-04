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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class EditEmployeeWindow : Form
    {
        public EditEmployeeWindow()
        {
            InitializeComponent();
        }

        private Pracownik _pracownik;
        public void Edytuj(Pracownik pracownik)
        {
            _pracownik = pracownik;
            
            TBImie.Text = _pracownik.Imie;
            TBMiasto.Text = _pracownik.Miasto;
            TBNazwisko.Text = _pracownik.Nazwisko;
            TBPensja.Text = _pracownik.Pensja.ToString(CultureInfo.CurrentCulture);
            TBPesel.Text = _pracownik.Pesel;
            TBStanowisko.Text = _pracownik.Stanowisko;
            TBUlica.Text = _pracownik.Ulica;
        }

        private void BZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                _pracownik.Imie = TBImie.Text;
                _pracownik.Miasto = TBMiasto.Text;
                _pracownik.Nazwisko = TBNazwisko.Text;
                _pracownik.Pensja = decimal.Parse(TBPensja.Text);
                _pracownik.Pesel = TBPesel.Text;
                _pracownik.Stanowisko = TBStanowisko.Text;
                _pracownik.Ulica = TBUlica.Text;

                _pracownik.Zapisz();

                this.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }
    }
}
