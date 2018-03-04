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
