using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GroceryStore
{
    public partial class GroceryDeALkanse : Form
    {

        public GroceryDeALkanse()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string item = itemTextBox.Text.Trim();
            string quantityText = quanTextBox.Text.Trim();
            string priceText = priceTextBox.Text.Trim();

            // Validate item (must contain only letters and spaces)
            if (string.IsNullOrWhiteSpace(item) || !Regex.IsMatch(item, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Item name must contain only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate quantity (must be a positive integer)
            if (!int.TryParse(quantityText, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate price (must be a positive decimal number)
            if (!double.TryParse(priceText, out double pricePerUnit) || pricePerUnit <= 0)
            {
                MessageBox.Show("Price must be a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate total price
            double totalPrice = quantity * pricePerUnit;

            // Add data to DataGridView
            dataGridView1.Rows.Add(item, quantity, totalPrice);

            // Clear input fields
            itemTextBox.Clear();
            quanTextBox.Clear();
            priceTextBox.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Confirm before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to remove this Item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
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


        private void checkoutButton_Click(object sender, EventArgs e)
        {

            // Check if there are any items in the DataGridView
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                // Show a MessageBox if no items exist
                MessageBox.Show("No items to checkout. Please add items to the list.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double totalPrice = calculatePrice();
            int discountPercentage = calDiscount();
            double discountAmount = (totalPrice * discountPercentage) / 100;
            double finalPrice = totalPrice - discountAmount;

            // Display values with Peso sign and Percent for discount
            percentDiscountTxtLabel.Text = $"%{calDiscount()}";
            totalCostTxtBox.Text = $"₱{totalPrice:F2}";
            discountTextBox.Text = $"₱{discountAmount:F2}";
            totalAmountTextBox.Text = $"₱{finalPrice:F2}"; // Final price after discount
        }

        private void quantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void itemLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void itemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quanTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pricePerUnitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalCostLabel_Click(object sender, EventArgs e)
        {

        }

        private void discountLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalCostTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            discountTextBox.Clear();
            totalCostTxtBox.Clear();
            totalAmountTextBox.Clear();
            discountTextBox.Clear();
            dataGridView1.Rows.Clear();
        }

        private void discountPrcntLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
