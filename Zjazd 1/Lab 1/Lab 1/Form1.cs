using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        List<Product> products;

        public Form1()
        {
            products = new List<Product>();
            
            InitializeComponent();

            try
            {
                string[] suppliers = System.IO.File.ReadAllLines("producenci.txt");
                CBSupplier.DataSource = suppliers;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Wystąpił błąd z odczytem pliku z listą producentów!",
                    "Błąd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            Product P = new Product();
            P.Name = TBName.Text;
            P.Quanity = decimal.Parse(TBQuanity.Text);
            P.Supplier = CBSupplier.Text;

            products.Add(P);

            TBName.Clear();
            TBQuanity.Text = "1";
            CBSupplier.Text = "";

            TSSLQuanity.Text = products.Count.ToString();

            MessageBox.Show(
                "Dodano produkt numer " + products.Count.ToString() + "!",
                "Pomyślnie dodano",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void TSMIProductsList_Click(object sender, EventArgs e)
        {
            FProductsList F = new FProductsList(products);
            F.ShowDialog();
        }

        private void TBQuanity_TextChanged(object sender, EventArgs e)
        {
            decimal result;
            if (decimal.TryParse(TBQuanity.Text, out result))
            {
                TBQuanity.BackColor = Color.White;
                BAdd.Enabled = true;
            }
            else
            {
                TBQuanity.BackColor = Color.Red;
                BAdd.Enabled = false;
            }
        }
    }
}
