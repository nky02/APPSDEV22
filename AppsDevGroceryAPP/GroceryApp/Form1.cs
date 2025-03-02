using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;

namespace GroceryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Attach KeyDown event handlers for Enter key navigation
            itemNameTextBox.KeyDown += itemNameTextBox_KeyDown;
            quantityTextBox.KeyDown += quantityTextBox_KeyDown;
            pricePerUnitTextBox.KeyDown += pricePerUnitTextBox_KeyDown;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string itemName = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{itemName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddItemToGrid();
        }
        private void AddItemToGrid()
        {
            string item = itemNameTextBox.Text.Trim();
            int quantity;
            double pricePerUnit;

            if (int.TryParse(item, out _)|| item == "")
            {
                MessageBox.Show("Please enter a valid item name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(quantityTextBox.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(pricePerUnitTextBox.Text, out pricePerUnit))
            {
                MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalPrice = quantity * pricePerUnit;
            dataGridView1.Rows.Add(item, quantity, totalPrice);

            // Clear fields and set focus to the first input
            itemNameTextBox.Clear();
            quantityTextBox.Clear();
            pricePerUnitTextBox.Clear();
            itemNameTextBox.Focus();
        }

        private void itemNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                quantityTextBox.Focus();
            }
        }

        private void quantityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                pricePerUnitTextBox.Focus();
            }
        }

        private void itemLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void pricePerUnitTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AddItemToGrid(); // Auto-add item on Enter
            }
        }
        private void pricePerUnitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void discountPercentLabel_Click(object sender, EventArgs e)
        {

        }

        private void itemLabel_Click(object sender, EventArgs e)
        {

        }
        private double calculatePrice()
        {
            double sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null && double.TryParse(row.Cells[2].Value.ToString(), out double totalPrice))
                {
                    sum += totalPrice;
                }
            }
            return sum;
        }
        private int calDiscount()
        {
            double totalPrice = calculatePrice();
            if (totalPrice < 100) return 0;
            else if (totalPrice < 200) return 10;
            else if (totalPrice <= 500) return 15;
            else return 20;
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("No items to checkout. Please add items to the list.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalPrice = calculatePrice();
            int discountPercentage = calDiscount();
            double discountAmount = (totalPrice * discountPercentage) / 100;
            double finalPrice = totalPrice - discountAmount;

            percentDiscountTextBox.Text = $"{discountPercentage}%";
            totalCostTextBox.Text = $"${totalPrice:N2}";
            discountAmountTextBox.Text = $"${discountAmount:N2}";
            totalAmountTextBox.Text = $"${finalPrice:N2}";
        }


        private void totalAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void percentDiscountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalCostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("No items to checkout.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Values
            double totalPrice = calculatePrice();
            int discountPercentage = calDiscount(); // Store discount value to avoid multiple calls
            double discountAmount = (totalPrice * discountPercentage) / 100;
            double finalPrice = totalPrice - discountAmount;

            StringBuilder sbitems = new StringBuilder();
            StringBuilder sbprice = new StringBuilder();
            StringBuilder sbqnty = new StringBuilder();

            // Process each row in DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Skip empty rows
                if (row.IsNewRow) continue;

                bool hasData = false; // Track if row has valid data

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    DataGridViewCell cell = row.Cells[i];

                    if (cell.Value != null && !cell.Value.ToString().Equals("delete", StringComparison.OrdinalIgnoreCase))
                    {
                        hasData = true; // Mark that row has valid data

                        if (i == 2)
                        {
                            double Price;
                            if (cell.Value != null && double.TryParse(cell.Value.ToString(), out Price))
                            {
                                sbprice.Append($"${Price:N2}" + Environment.NewLine);
                            }
                        }
                        else if (i == 1)
                        {
                            sbqnty.Append(cell.Value.ToString() + Environment.NewLine);
                        }
                        else
                        {
                            sbitems.Append(cell.Value.ToString() + Environment.NewLine);
                        }
                    }
                }

                // Only append new lines if row had data
                if (hasData)
                {
                    sbitems.AppendLine();
                    sbqnty.AppendLine();
                    sbprice.AppendLine();
                }
            }

            // Convert to string
            string items = sbitems.ToString().Trim();  //Gets Items
            string quantity = sbqnty.ToString().Trim();
            string price = sbprice.ToString().Trim();
            string values = $"${totalPrice:N2}\n" +
                $"{discountPercentage}%\n" +  //Gets totals
                $"${discountAmount:N2}\n";
            string finalamnt = $"${finalPrice:N2}";
            try
            {
                this.Hide();

                ReceiptForm receipt = new ReceiptForm(items, quantity, price, values, finalamnt);

                if (!string.IsNullOrEmpty(items))
                {
                    if (receipt != null)
                    {
                        dataGridView1.Rows.Clear();
                        percentDiscountTextBox.Clear();
                        totalAmountTextBox.Clear();
                        discountAmountTextBox.Clear();
                        totalCostTextBox.Clear();
                        receipt.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No valid items to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No valid items to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Show();
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
