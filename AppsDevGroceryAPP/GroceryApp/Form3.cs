using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryApp
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm(string items, string quantity, string price, string values, string finalamnt)
        {
            InitializeComponent();

            labelItems.Text = items;
            labelqnty.Text = quantity;
            labelprice.Text = price;
            labelValues.Text = values;
            LabelFinalamnt.Text = "FINAL AMOUNT :     " + finalamnt;

            DateTime now = DateTime.Now;
            labeldate.Text = now.ToString();

            int panelwdth = receiptpanel.Width;
            string separator = new string('-', (panelwdth / 5));
            separator1.Text = separator;
            separator2.Text = separator;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            logo.Left = (this.ClientSize.Width - logo.Width) / 2;

        }



        private void totalCostLabel_Click(object sender, EventArgs e) { }

        private void percentDiscountLabel_Click(object sender, EventArgs e) { }

        private void discountAmountLabel_Click(object sender, EventArgs e) { }

        private void finalAmountLabel_Click(object sender, EventArgs e) { }

        private void receiptDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LabelFinalamnt_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void check_icn_Click(object sender, EventArgs e)
        {

        }

        private void receiptpanel_Paint(object sender, PaintEventArgs e)
        {
            check_icn.Left = (receiptpanel.Width - check_icn.Width) / 2;
            labeltansac.Left = (receiptpanel.Width - labeltansac.Width) / 2;
        }

        private void LabelFinalamnt_Click_1(object sender, EventArgs e)
        {

        }

        private void separator2_Click_1(object sender, EventArgs e)
        {

        }

        private void valuesPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void LabelFinalamnt_Click_2(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void btmpanel_Paint(object sender, PaintEventArgs e)
        {
            LabelFinalamnt.Left = (btmpanel.Width - LabelFinalamnt.Width) / 2;
            LabelFinalamnt.Top = (btmpanel.Height - LabelFinalamnt.Height) / 2;
        }
    }
}
