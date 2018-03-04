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
    public partial class FProductsList : Form
    {
        public FProductsList(List<Product> products)
        {
            InitializeComponent();

            DGWProducts.DataSource = products;
        }
    }
}
