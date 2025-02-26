namespace GroceryApp
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            itemLabel = new Label();
            quantityLabel = new Label();
            pricePerUnitLabel = new Label();
            fillUpPanel = new Panel();
            groceryName = new Label();
            pricePerUnitTextBox = new TextBox();
            quantityTextBox = new TextBox();
            itemNameTextBox = new TextBox();
            addButton = new Button();
            dataGridView1 = new DataGridView();
            item = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            fileSystemWatcher1 = new FileSystemWatcher();
            calcuPanel = new Panel();
            totalAmountTextBox = new TextBox();
            discountAmountTextBox = new TextBox();
            percentDiscountTextBox = new TextBox();
            totalCostTextBox = new TextBox();
            doneButton = new Button();
            totalAmount = new Label();
            discountAmountLabel = new Label();
            discountPercentLabel = new Label();
            totalCostLabel = new Label();
            checkOutButton = new Button();
            exitButton = new Button();
            Date = new DateTimePicker();
            fillUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            calcuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemLabel.Location = new Point(24, 31);
            itemLabel.Margin = new Padding(2, 0, 2, 0);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(75, 15);
            itemLabel.TabIndex = 0;
            itemLabel.Text = "ITEM LABEL:";
            itemLabel.Click += itemLabel_Click;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.FlatStyle = FlatStyle.Popup;
            quantityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(31, 65);
            quantityLabel.Margin = new Padding(2, 0, 2, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(70, 15);
            quantityLabel.TabIndex = 1;
            quantityLabel.Text = "QUANTITY:";
            // 
            // pricePerUnitLabel
            // 
            pricePerUnitLabel.AutoSize = true;
            pricePerUnitLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pricePerUnitLabel.Location = new Point(0, 100);
            pricePerUnitLabel.Margin = new Padding(2, 0, 2, 0);
            pricePerUnitLabel.Name = "pricePerUnitLabel";
            pricePerUnitLabel.Size = new Size(98, 15);
            pricePerUnitLabel.TabIndex = 2;
            pricePerUnitLabel.Text = "PRICE PER UNIT:";
            // 
            // fillUpPanel
            // 
            fillUpPanel.BackColor = SystemColors.AppWorkspace;
            fillUpPanel.Controls.Add(groceryName);
            fillUpPanel.Controls.Add(pricePerUnitTextBox);
            fillUpPanel.Controls.Add(quantityTextBox);
            fillUpPanel.Controls.Add(itemNameTextBox);
            fillUpPanel.Controls.Add(addButton);
            fillUpPanel.Controls.Add(pricePerUnitLabel);
            fillUpPanel.Controls.Add(quantityLabel);
            fillUpPanel.Controls.Add(itemLabel);
            fillUpPanel.Location = new Point(24, 122);
            fillUpPanel.Margin = new Padding(2, 2, 2, 2);
            fillUpPanel.Name = "fillUpPanel";
            fillUpPanel.Size = new Size(278, 165);
            fillUpPanel.TabIndex = 3;
            // 
            // groceryName
            // 
            groceryName.AutoSize = true;
            groceryName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groceryName.Location = new Point(48, 5);
            groceryName.Margin = new Padding(2, 0, 2, 0);
            groceryName.Name = "groceryName";
            groceryName.Size = new Size(143, 15);
            groceryName.TabIndex = 7;
            groceryName.Text = "TINDAHAN DE ALKANSE";
            // 
            // pricePerUnitTextBox
            // 
            pricePerUnitTextBox.Location = new Point(120, 98);
            pricePerUnitTextBox.Margin = new Padding(2, 2, 2, 2);
            pricePerUnitTextBox.Name = "pricePerUnitTextBox";
            pricePerUnitTextBox.Size = new Size(86, 23);
            pricePerUnitTextBox.TabIndex = 6;
            pricePerUnitTextBox.TextChanged += pricePerUnitTextBox_TextChanged;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(120, 64);
            quantityTextBox.Margin = new Padding(2, 2, 2, 2);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(86, 23);
            quantityTextBox.TabIndex = 5;
            quantityTextBox.TextChanged += quantityTextBox_TextChanged;
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(120, 29);
            itemNameTextBox.Margin = new Padding(2, 2, 2, 2);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(124, 23);
            itemNameTextBox.TabIndex = 4;
            itemNameTextBox.TextChanged += itemLabel_TextChanged;
            // 
            // addButton
            // 
            addButton.ForeColor = SystemColors.ActiveCaptionText;
            addButton.Location = new Point(76, 126);
            addButton.Margin = new Padding(2, 2, 2, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(78, 20);
            addButton.TabIndex = 3;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { item, quantity, totalPrice, delete });
            dataGridView1.GridColor = SystemColors.Menu;
            dataGridView1.Location = new Point(331, 13);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.Size = new Size(458, 164);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // item
            // 
            item.FillWeight = 150F;
            item.HeaderText = "ITEM";
            item.MinimumWidth = 8;
            item.Name = "item";
            item.ReadOnly = true;
            item.Width = 150;
            // 
            // quantity
            // 
            quantity.FillWeight = 75F;
            quantity.HeaderText = "QUANTITY";
            quantity.MinimumWidth = 8;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Width = 150;
            // 
            // totalPrice
            // 
            totalPrice.HeaderText = "TOTAL PRICE";
            totalPrice.MinimumWidth = 8;
            totalPrice.Name = "totalPrice";
            totalPrice.ReadOnly = true;
            totalPrice.Width = 150;
            // 
            // delete
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            delete.DefaultCellStyle = dataGridViewCellStyle2;
            delete.FlatStyle = FlatStyle.Popup;
            delete.HeaderText = "DELETE";
            delete.MinimumWidth = 8;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Text = "delete";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 150;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // calcuPanel
            // 
            calcuPanel.BackColor = SystemColors.AppWorkspace;
            calcuPanel.Controls.Add(totalAmountTextBox);
            calcuPanel.Controls.Add(discountAmountTextBox);
            calcuPanel.Controls.Add(percentDiscountTextBox);
            calcuPanel.Controls.Add(totalCostTextBox);
            calcuPanel.Controls.Add(doneButton);
            calcuPanel.Controls.Add(totalAmount);
            calcuPanel.Controls.Add(discountAmountLabel);
            calcuPanel.Controls.Add(discountPercentLabel);
            calcuPanel.Controls.Add(totalCostLabel);
            calcuPanel.Location = new Point(430, 222);
            calcuPanel.Margin = new Padding(2, 2, 2, 2);
            calcuPanel.Name = "calcuPanel";
            calcuPanel.Size = new Size(272, 140);
            calcuPanel.TabIndex = 5;
            // 
            // totalAmountTextBox
            // 
            totalAmountTextBox.Location = new Point(155, 88);
            totalAmountTextBox.Margin = new Padding(2, 2, 2, 2);
            totalAmountTextBox.Name = "totalAmountTextBox";
            totalAmountTextBox.ReadOnly = true;
            totalAmountTextBox.Size = new Size(106, 23);
            totalAmountTextBox.TabIndex = 15;
            totalAmountTextBox.TextChanged += totalAmountTextBox_TextChanged;
            // 
            // discountAmountTextBox
            // 
            discountAmountTextBox.Location = new Point(155, 65);
            discountAmountTextBox.Margin = new Padding(2, 2, 2, 2);
            discountAmountTextBox.Name = "discountAmountTextBox";
            discountAmountTextBox.ReadOnly = true;
            discountAmountTextBox.Size = new Size(106, 23);
            discountAmountTextBox.TabIndex = 14;
            discountAmountTextBox.TextChanged += discountAmountTextBox_TextChanged;
            // 
            // percentDiscountTextBox
            // 
            percentDiscountTextBox.Location = new Point(155, 43);
            percentDiscountTextBox.Margin = new Padding(2, 2, 2, 2);
            percentDiscountTextBox.Name = "percentDiscountTextBox";
            percentDiscountTextBox.ReadOnly = true;
            percentDiscountTextBox.Size = new Size(106, 23);
            percentDiscountTextBox.TabIndex = 13;
            percentDiscountTextBox.TextChanged += percentDiscountTextBox_TextChanged;
            // 
            // totalCostTextBox
            // 
            totalCostTextBox.BackColor = SystemColors.Control;
            totalCostTextBox.Location = new Point(155, 20);
            totalCostTextBox.Margin = new Padding(2, 2, 2, 2);
            totalCostTextBox.Name = "totalCostTextBox";
            totalCostTextBox.ReadOnly = true;
            totalCostTextBox.Size = new Size(106, 23);
            totalCostTextBox.TabIndex = 12;
            totalCostTextBox.TextChanged += totalCostTextBox_TextChanged;
            // 
            // doneButton
            // 
            doneButton.Location = new Point(112, 110);
            doneButton.Margin = new Padding(2, 2, 2, 2);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(78, 20);
            doneButton.TabIndex = 8;
            doneButton.Text = "DONE";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += doneButton_Click;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmount.Location = new Point(36, 85);
            totalAmount.Margin = new Padding(2, 0, 2, 0);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(99, 15);
            totalAmount.TabIndex = 11;
            totalAmount.Text = "TOTAL AMOUNT";
            // 
            // discountAmountLabel
            // 
            discountAmountLabel.AutoSize = true;
            discountAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountAmountLabel.Location = new Point(10, 62);
            discountAmountLabel.Margin = new Padding(2, 0, 2, 0);
            discountAmountLabel.Name = "discountAmountLabel";
            discountAmountLabel.Size = new Size(124, 15);
            discountAmountLabel.TabIndex = 10;
            discountAmountLabel.Text = "DISCOUNT AMOUNT";
            // 
            // discountPercentLabel
            // 
            discountPercentLabel.AutoSize = true;
            discountPercentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountPercentLabel.Location = new Point(13, 41);
            discountPercentLabel.Margin = new Padding(2, 0, 2, 0);
            discountPercentLabel.Name = "discountPercentLabel";
            discountPercentLabel.Size = new Size(121, 15);
            discountPercentLabel.TabIndex = 9;
            discountPercentLabel.Text = "PERCENT DISCOUNT";
            discountPercentLabel.Click += discountPercentLabel_Click;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCostLabel.Location = new Point(62, 20);
            totalCostLabel.Margin = new Padding(2, 0, 2, 0);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(76, 15);
            totalCostLabel.TabIndex = 8;
            totalCostLabel.Text = "TOTAL COST";
            // 
            // checkOutButton
            // 
            checkOutButton.Location = new Point(529, 181);
            checkOutButton.Margin = new Padding(2, 2, 2, 2);
            checkOutButton.Name = "checkOutButton";
            checkOutButton.Size = new Size(94, 29);
            checkOutButton.TabIndex = 6;
            checkOutButton.Text = "CHECK OUT";
            checkOutButton.UseVisualStyleBackColor = true;
            checkOutButton.Click += checkOutButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(318, 361);
            exitButton.Margin = new Padding(2, 2, 2, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(78, 20);
            exitButton.TabIndex = 7;
            exitButton.Text = "CLOSE";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Date
            // 
            Date.Location = new Point(57, 95);
            Date.Margin = new Padding(2, 2, 2, 2);
            Date.Name = "Date";
            Date.Size = new Size(211, 23);
            Date.TabIndex = 8;
            Date.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(827, 388);
            Controls.Add(Date);
            Controls.Add(exitButton);
            Controls.Add(checkOutButton);
            Controls.Add(calcuPanel);
            Controls.Add(dataGridView1);
            Controls.Add(fillUpPanel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "TINDAHAN DE ALKANSE";
            Load += Form1_Load;
            fillUpPanel.ResumeLayout(false);
            fillUpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            calcuPanel.ResumeLayout(false);
            calcuPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label itemLabel;
        private Label quantityLabel;
        private Label pricePerUnitLabel;
        private Panel fillUpPanel;
        private TextBox pricePerUnitTextBox;
        private TextBox quantityTextBox;
        private TextBox itemNameTextBox;
        private Button addButton;
        private DataGridView dataGridView1;
        private FileSystemWatcher fileSystemWatcher1;
        private Label groceryName;
        private Panel calcuPanel;
        private Button checkOutButton;
        private Label totalAmount;
        private Label discountAmountLabel;
        private Label discountPercentLabel;
        private Label totalCostLabel;
        private Button doneButton;
        private TextBox totalAmountTextBox;
        private TextBox discountAmountTextBox;
        private TextBox percentDiscountTextBox;
        private TextBox totalCostTextBox;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn totalPrice;
        private DataGridViewButtonColumn delete;
        private Button exitButton;
        private DateTimePicker Date;
    }
}
