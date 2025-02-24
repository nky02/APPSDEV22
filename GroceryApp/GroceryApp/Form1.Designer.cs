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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dateTimePicker1 = new DateTimePicker();
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
            itemLabel.Location = new Point(35, 52);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(119, 25);
            itemLabel.TabIndex = 0;
            itemLabel.Text = "ITEM LABEL:";
            itemLabel.Click += itemLabel_Click;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.FlatStyle = FlatStyle.Popup;
            quantityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(44, 109);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(110, 25);
            quantityLabel.TabIndex = 1;
            quantityLabel.Text = "QUANTITY:";
            // 
            // pricePerUnitLabel
            // 
            pricePerUnitLabel.AutoSize = true;
            pricePerUnitLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pricePerUnitLabel.Location = new Point(0, 166);
            pricePerUnitLabel.Name = "pricePerUnitLabel";
            pricePerUnitLabel.Size = new Size(154, 25);
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
            fillUpPanel.Location = new Point(34, 204);
            fillUpPanel.Name = "fillUpPanel";
            fillUpPanel.Size = new Size(397, 275);
            fillUpPanel.TabIndex = 3;
            // 
            // groceryName
            // 
            groceryName.AutoSize = true;
            groceryName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groceryName.Location = new Point(68, 9);
            groceryName.Name = "groceryName";
            groceryName.Size = new Size(224, 25);
            groceryName.TabIndex = 7;
            groceryName.Text = "TINDAHAN DE ALKANSE";
            // 
            // pricePerUnitTextBox
            // 
            pricePerUnitTextBox.Location = new Point(171, 163);
            pricePerUnitTextBox.Name = "pricePerUnitTextBox";
            pricePerUnitTextBox.Size = new Size(121, 31);
            pricePerUnitTextBox.TabIndex = 6;
            pricePerUnitTextBox.TextChanged += pricePerUnitTextBox_TextChanged;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(171, 106);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(121, 31);
            quantityTextBox.TabIndex = 5;
            quantityTextBox.TextChanged += quantityTextBox_TextChanged;
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(171, 49);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(176, 31);
            itemNameTextBox.TabIndex = 4;
            itemNameTextBox.TextChanged += itemLabel_TextChanged;
            // 
            // addButton
            // 
            addButton.ForeColor = SystemColors.ActiveCaptionText;
            addButton.Location = new Point(108, 210);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
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
            dataGridView1.Location = new Point(473, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.Size = new Size(654, 274);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            delete.DefaultCellStyle = dataGridViewCellStyle1;
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
            calcuPanel.Location = new Point(615, 370);
            calcuPanel.Name = "calcuPanel";
            calcuPanel.Size = new Size(389, 233);
            calcuPanel.TabIndex = 5;
            // 
            // totalAmountTextBox
            // 
            totalAmountTextBox.Location = new Point(222, 146);
            totalAmountTextBox.Name = "totalAmountTextBox";
            totalAmountTextBox.ReadOnly = true;
            totalAmountTextBox.Size = new Size(150, 31);
            totalAmountTextBox.TabIndex = 15;
            totalAmountTextBox.TextChanged += totalAmountTextBox_TextChanged;
            // 
            // discountAmountTextBox
            // 
            discountAmountTextBox.Location = new Point(222, 108);
            discountAmountTextBox.Name = "discountAmountTextBox";
            discountAmountTextBox.ReadOnly = true;
            discountAmountTextBox.Size = new Size(150, 31);
            discountAmountTextBox.TabIndex = 14;
            discountAmountTextBox.TextChanged += discountAmountTextBox_TextChanged;
            // 
            // percentDiscountTextBox
            // 
            percentDiscountTextBox.Location = new Point(222, 71);
            percentDiscountTextBox.Name = "percentDiscountTextBox";
            percentDiscountTextBox.ReadOnly = true;
            percentDiscountTextBox.Size = new Size(150, 31);
            percentDiscountTextBox.TabIndex = 13;
            percentDiscountTextBox.TextChanged += percentDiscountTextBox_TextChanged;
            // 
            // totalCostTextBox
            // 
            totalCostTextBox.BackColor = SystemColors.Control;
            totalCostTextBox.Location = new Point(222, 34);
            totalCostTextBox.Name = "totalCostTextBox";
            totalCostTextBox.ReadOnly = true;
            totalCostTextBox.Size = new Size(150, 31);
            totalCostTextBox.TabIndex = 12;
            totalCostTextBox.TextChanged += totalCostTextBox_TextChanged;
            // 
            // doneButton
            // 
            doneButton.Location = new Point(160, 183);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(112, 34);
            doneButton.TabIndex = 8;
            doneButton.Text = "DONE";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += doneButton_Click;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAmount.Location = new Point(52, 142);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(154, 25);
            totalAmount.TabIndex = 11;
            totalAmount.Text = "TOTAL AMOUNT";
            // 
            // discountAmountLabel
            // 
            discountAmountLabel.AutoSize = true;
            discountAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountAmountLabel.Location = new Point(15, 104);
            discountAmountLabel.Name = "discountAmountLabel";
            discountAmountLabel.Size = new Size(191, 25);
            discountAmountLabel.TabIndex = 10;
            discountAmountLabel.Text = "DISCOUNT AMOUNT";
            // 
            // discountPercentLabel
            // 
            discountPercentLabel.AutoSize = true;
            discountPercentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountPercentLabel.Location = new Point(18, 69);
            discountPercentLabel.Name = "discountPercentLabel";
            discountPercentLabel.Size = new Size(188, 25);
            discountPercentLabel.TabIndex = 9;
            discountPercentLabel.Text = "PERCENT DISCOUNT";
            discountPercentLabel.Click += discountPercentLabel_Click;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCostLabel.Location = new Point(88, 34);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(118, 25);
            totalCostLabel.TabIndex = 8;
            totalCostLabel.Text = "TOTAL COST";
            // 
            // checkOutButton
            // 
            checkOutButton.Location = new Point(756, 302);
            checkOutButton.Name = "checkOutButton";
            checkOutButton.Size = new Size(135, 49);
            checkOutButton.TabIndex = 6;
            checkOutButton.Text = "CHECK OUT";
            checkOutButton.UseVisualStyleBackColor = true;
            checkOutButton.Click += checkOutButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(455, 601);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 7;
            exitButton.Text = "CLOSE";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(81, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1181, 647);
            Controls.Add(dateTimePicker1);
            Controls.Add(exitButton);
            Controls.Add(checkOutButton);
            Controls.Add(calcuPanel);
            Controls.Add(dataGridView1);
            Controls.Add(fillUpPanel);
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
        private DateTimePicker dateTimePicker1;
    }
}
