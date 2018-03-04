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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void MWLoad(object sender, EventArgs e)
        {
            // TODO: Directory.GetFiles(".", "*.txt");
            
            LBPracownicy.Items.Add(Pracownik.Otworz("12345678901"));
            LBPracownicy.Items.Add(Pracownik.Otworz("12345678902"));
            LBPracownicy.Items.Add(Pracownik.Otworz("12345678903"));
        }

        private void BEdytuj_Click(object sender, EventArgs e)
        {
            if (LBPracownicy.SelectedItem != null)
            {
                var window = new EditEmployeeWindow();

                window.Edytuj(
                    (Pracownik) LBPracownicy.SelectedItem
                );

                window.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Aby edytować, zaznacz pracownika!",
                    "Błąd!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
