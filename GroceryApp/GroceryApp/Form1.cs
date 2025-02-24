namespace GroceryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Delete" button column
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Get the item name for confirmation message
                string itemName = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();

                // Confirm deletion
                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{itemName}'?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                // If user confirms, remove the row
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string item = itemNameTextBox.Text;
            int quantity;
            double pricePerUnit;

            // Check if the item name contains only numbers (invalid case)
            if (int.TryParse(item, out _))
            {
                MessageBox.Show("Please enter a valid item name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if quantity is a valid integer
            if (!int.TryParse(quantityTextBox.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if price per unit is a valid double
            if (!double.TryParse(pricePerUnitTextBox.Text, out pricePerUnit))
            {
                MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate total price
            double totalPrice = quantity * pricePerUnit;

            // Add the valid data to the DataGridView
            dataGridView1.Rows.Add(item, quantity, totalPrice);

            itemNameTextBox.Clear();
            quantityTextBox.Clear();
            pricePerUnitTextBox.Clear();


        }


        private void itemLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

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

            // Loop through each row in DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null) // Ensure the cell is not empty
                {
                    if (double.TryParse(row.Cells[2].Value.ToString(), out double totalPrice))
                    {
                        sum += totalPrice;
                    }
                }
            }

            return sum;
        }
        private int calDiscount()
        {
            double totalPrice = calculatePrice();

            if (totalPrice < 100)
            {
                return 0;  // No discount if total is less than 100
            }
            else if (totalPrice >= 100 && totalPrice < 200)
            {
                return 10; // 10% discount for 100 to 199
            }
            else if (totalPrice >= 200 && totalPrice <= 500)
            {
                return 15; // 15% discount for 200 to 500
            }
            else
            {
                return 20; // 20% discount for anything above 500
            }
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            // Check if there are any items in the DataGridView
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                // Show a MessageBox if no items exist
                MessageBox.Show("No items to checkout. Please add items to the list.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double totalPrice = calculatePrice();
            int discountPercentage = calDiscount(); // Store discount value to avoid multiple calls
            double discountAmount = (totalPrice * discountPercentage) / 100;
            double finalPrice = totalPrice - discountAmount;

            // Display values with Peso sign and proper formatting
            percentDiscountTextBox.Text = $"{discountPercentage}%";  // Corrected percent formatting
            totalCostTextBox.Text = $"₱{totalPrice:N2}";
            discountAmountTextBox.Text = $"₱{discountAmount:N2}";
            totalAmountTextBox.Text = $"₱{finalPrice:N2}"; // Final price after discount
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
            dataGridView1.Rows.Clear();
            percentDiscountTextBox.Clear();
            totalAmountTextBox.Clear();
            discountAmountTextBox.Clear();
            totalCostTextBox.Clear();
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
