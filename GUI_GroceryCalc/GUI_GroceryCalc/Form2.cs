using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_GroceryCalc
{
    public partial class Calculationsform : Form
    {
        public Calculationsform(double totalCost, double discount, double finalAmount)
        {
            InitializeComponent();

            labelTotalCost.Text = $"Total Cost: ₱{totalCost:F2}";
            labelDiscount.Text = $"Discount: ₱{discount:F2}";
            labelFinalAmount.Text = $"Final Amount: ₱{finalAmount:F2}";
        }

        private void Calculationsform_Load(object sender, EventArgs e)
        {

        }
    }
}
