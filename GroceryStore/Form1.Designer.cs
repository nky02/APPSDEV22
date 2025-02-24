namespace GroceryStore
{
    partial class GroceryDeALkanse
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label7 = new Label();
            button1 = new Button();
            priceTextBox = new TextBox();
            quanTextBox = new TextBox();
            itemTextBox = new TextBox();
            quantityLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            item = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            checkoutButton = new Button();
            totalCostTxtBox = new TextBox();
            discountTextBox = new TextBox();
            totalAmountTextBox = new TextBox();
            panel2 = new Panel();
            percentDiscountTxtLabel = new TextBox();
            discountPrcntLabel = new Label();
            doneButton = new Button();
            exitButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(priceTextBox);
            panel1.Controls.Add(quanTextBox);
            panel1.Controls.Add(itemTextBox);
            panel1.Controls.Add(quantityLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 347);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 344);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gill Sans Ultra Bold Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(74, 21);
            label7.Name = "label7";
            label7.Size = new Size(210, 27);
            label7.TabIndex = 7;
            label7.Text = "GROCERY DE ALKANSE";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(144, 280);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += addButton_Click;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(197, 197);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(156, 31);
            priceTextBox.TabIndex = 5;
            priceTextBox.TextChanged += pricePerUnitTextBox_TextChanged;
            // 
            // quanTextBox
            // 
            quanTextBox.Location = new Point(197, 139);
            quanTextBox.Name = "quanTextBox";
            quanTextBox.Size = new Size(156, 31);
            quanTextBox.TabIndex = 4;
            quanTextBox.TextChanged += quanTextBox_TextChanged;
            // 
            // itemTextBox
            // 
            itemTextBox.Location = new Point(197, 74);
            itemTextBox.Name = "itemTextBox";
            itemTextBox.Size = new Size(156, 31);
            itemTextBox.TabIndex = 3;
            itemTextBox.TextChanged += itemTextBox_TextChanged;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(25, 139);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(105, 25);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "QUANTITY";
            quantityLabel.Click += quantityLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 197);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 1;
            label2.Text = "PRICE per unit";
            label2.Click += priceLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 75);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "ITEM NAME";
            label1.Click += itemLabel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 36);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 2;
            label3.Text = "TOTAL COST: ";
            label3.Click += totalCostLabel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 119);
            label4.Name = "label4";
            label4.Size = new Size(196, 25);
            label4.TabIndex = 3;
            label4.Text = "DISCOUNT AMOUNT:";
            label4.Click += discountLabel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 388);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 162);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 5;
            label6.Text = "TOTAL AMOUNT:";
            label6.Click += label6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { item, quantity, price, delete });
            dataGridView1.Location = new Point(154, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(666, 275);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // item
            // 
            dataGridViewCellStyle1.NullValue = "₱";
            item.DefaultCellStyle = dataGridViewCellStyle1;
            item.HeaderText = "ITEM";
            item.MinimumWidth = 8;
            item.Name = "item";
            item.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.HeaderText = "QUANTITY";
            quantity.MinimumWidth = 8;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // price
            // 
            price.HeaderText = "PRICE";
            price.MinimumWidth = 8;
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // delete
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            delete.DefaultCellStyle = dataGridViewCellStyle2;
            delete.FlatStyle = FlatStyle.Popup;
            delete.HeaderText = "DELETE";
            delete.MinimumWidth = 8;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Text = "delete";
            delete.UseColumnTextForButtonValue = true;
            // 
            // checkoutButton
            // 
            checkoutButton.BackColor = SystemColors.ActiveCaption;
            checkoutButton.Location = new Point(381, 293);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(189, 37);
            checkoutButton.TabIndex = 7;
            checkoutButton.Text = "CHECK OUT";
            checkoutButton.UseVisualStyleBackColor = false;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // totalCostTxtBox
            // 
            totalCostTxtBox.Location = new Point(230, 30);
            totalCostTxtBox.Name = "totalCostTxtBox";
            totalCostTxtBox.ReadOnly = true;
            totalCostTxtBox.Size = new Size(176, 31);
            totalCostTxtBox.TabIndex = 8;
            totalCostTxtBox.TextChanged += totalCostTxtBox_TextChanged;
            // 
            // discountTextBox
            // 
            discountTextBox.Location = new Point(230, 113);
            discountTextBox.Name = "discountTextBox";
            discountTextBox.ReadOnly = true;
            discountTextBox.Size = new Size(176, 31);
            discountTextBox.TabIndex = 9;
            discountTextBox.TextChanged += discountTextBox_TextChanged;
            // 
            // totalAmountTextBox
            // 
            totalAmountTextBox.Location = new Point(230, 162);
            totalAmountTextBox.Name = "totalAmountTextBox";
            totalAmountTextBox.ReadOnly = true;
            totalAmountTextBox.Size = new Size(176, 31);
            totalAmountTextBox.TabIndex = 10;
            totalAmountTextBox.TextChanged += totalAmountTextBox_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(percentDiscountTxtLabel);
            panel2.Controls.Add(discountPrcntLabel);
            panel2.Controls.Add(doneButton);
            panel2.Controls.Add(totalAmountTextBox);
            panel2.Controls.Add(discountTextBox);
            panel2.Controls.Add(totalCostTxtBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(593, 347);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 282);
            panel2.TabIndex = 11;
            // 
            // percentDiscountTxtLabel
            // 
            percentDiscountTxtLabel.Location = new Point(230, 71);
            percentDiscountTxtLabel.Name = "percentDiscountTxtLabel";
            percentDiscountTxtLabel.ReadOnly = true;
            percentDiscountTxtLabel.Size = new Size(176, 31);
            percentDiscountTxtLabel.TabIndex = 13;
            percentDiscountTxtLabel.TextChanged += textBox1_TextChanged;
            // 
            // discountPrcntLabel
            // 
            discountPrcntLabel.AutoSize = true;
            discountPrcntLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountPrcntLabel.Location = new Point(27, 77);
            discountPrcntLabel.Name = "discountPrcntLabel";
            discountPrcntLabel.Size = new Size(193, 25);
            discountPrcntLabel.TabIndex = 12;
            discountPrcntLabel.Text = "PERCENT DISCOUNT:";
            discountPrcntLabel.Click += discountPrcntLabel_Click;
            // 
            // doneButton
            // 
            doneButton.BackColor = SystemColors.ActiveCaption;
            doneButton.ForeColor = SystemColors.Desktop;
            doneButton.Location = new Point(179, 222);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(112, 37);
            doneButton.TabIndex = 11;
            doneButton.Text = "DONE";
            doneButton.UseVisualStyleBackColor = false;
            doneButton.Click += doneButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(425, 663);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(145, 40);
            exitButton.TabIndex = 12;
            exitButton.Text = "CLOSE";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // GroceryDeALkanse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1065, 760);
            Controls.Add(exitButton);
            Controls.Add(panel2);
            Controls.Add(checkoutButton);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "GroceryDeALkanse";
            Text = "GroceryDeALkanse";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label quantityLabel;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox priceTextBox;
        private TextBox quanTextBox;
        private TextBox itemTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Button checkoutButton;
        private TextBox totalCostTxtBox;
        private TextBox discountTextBox;
        private TextBox totalAmountTextBox;
        private Panel panel2;
        private Label label7;
        private Button doneButton;
        private Label discountPrcntLabel;
        private TextBox percentDiscountTxtLabel;
        private Button exitButton;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private DataGridViewButtonColumn delete;
    }
}
