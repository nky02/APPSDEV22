using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace GUI_GroceryCalc
{
    public partial class GroceryCalcForm : Form
    {
        double totalcost = 0;
        double discountamnt = 0;
        double finalAmount = 0;
        public GroceryCalcForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GroceryCalcForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Additem_btn_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(item_txt.Text)) && (double.TryParse(itemprice.Text, out double price) && price > 0) && (int.TryParse(itemquantity.Text, out int quantity ) && quantity > 0)) // Check if the textbox is not empty
            {
                ItemList.Items.Add("Item: "+item_txt.Text); 
                ItemList.Items.Add("Quantity: " + quantity);
                ItemList.Items.Add($"Price: ₱{price:F2}");
                item_txt.Clear(); 
                itemprice.Clear();
                itemquantity.Clear();
                

                totalcost += quantity * price;

                ItemList.Items.Add($"Total cost:₱{totalcost:F2}");
            }
            else
            {
                MessageBox.Show("Please enter valid inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
           
        }

        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (totalcost > 500)
            {
                discountamnt = totalcost * 0.20;
            }
            else if (totalcost > 200)
            {
                discountamnt = totalcost * 0.15;
            }
            else if (totalcost > 100)
            {
                discountamnt = totalcost * 0.10;
            }

            finalAmount = totalcost - discountamnt;

            Calculationsform calculations = new Calculationsform(totalcost,discountamnt,finalAmount);
            calculations.ShowDialog();
            this.Show();
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void remvitem_btn_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
