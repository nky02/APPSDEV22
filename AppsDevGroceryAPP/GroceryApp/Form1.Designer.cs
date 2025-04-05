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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            itemLabel = new Label();
            quantityLabel = new Label();
            pricePerUnitLabel = new Label();
            fillUpPanel = new Panel();
            pricePerUnitTextBox = new TextBox();
            itemNameTextBox = new TextBox();
            quantityTextBox = new TextBox();
            addButton = new Button();
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
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            item = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            checkOutButton = new Button();
            cartLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            label16 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            pictureBox6 = new PictureBox();
            panel7 = new Panel();
            label24 = new Label();
            button6 = new Button();
            textBox6 = new TextBox();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            pictureBox8 = new PictureBox();
            panel3 = new Panel();
            label8 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            label12 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            pictureBox5 = new PictureBox();
            panel6 = new Panel();
            label20 = new Label();
            button5 = new Button();
            textBox5 = new TextBox();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            fillUpPanel.SuspendLayout();
            calcuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemLabel.Location = new Point(24, 29);
            itemLabel.Margin = new Padding(2, 0, 2, 0);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(75, 15);
            itemLabel.TabIndex = 0;
            itemLabel.Text = "ITEM NAME:";
            itemLabel.Click += itemLabel_Click;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.FlatStyle = FlatStyle.Popup;
            quantityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(7, 150);
            quantityLabel.Margin = new Padding(2, 0, 2, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(89, 15);
            quantityLabel.TabIndex = 1;
            quantityLabel.Text = "Enter quantity:";
            // 
            // pricePerUnitLabel
            // 
            pricePerUnitLabel.AutoSize = true;
            pricePerUnitLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pricePerUnitLabel.Location = new Point(2, 98);
            pricePerUnitLabel.Margin = new Padding(2, 0, 2, 0);
            pricePerUnitLabel.Name = "pricePerUnitLabel";
            pricePerUnitLabel.Size = new Size(98, 15);
            pricePerUnitLabel.TabIndex = 2;
            pricePerUnitLabel.Text = "PRICE PER UNIT:";
            // 
            // fillUpPanel
            // 
            fillUpPanel.BackColor = Color.LightGray;
            fillUpPanel.BorderStyle = BorderStyle.Fixed3D;
            fillUpPanel.Controls.Add(pricePerUnitTextBox);
            fillUpPanel.Controls.Add(itemNameTextBox);
            fillUpPanel.Controls.Add(pricePerUnitLabel);
            fillUpPanel.Controls.Add(itemLabel);
            fillUpPanel.Location = new Point(11, 11);
            fillUpPanel.Margin = new Padding(2);
            fillUpPanel.Name = "fillUpPanel";
            fillUpPanel.Size = new Size(24, 18);
            fillUpPanel.TabIndex = 3;
            fillUpPanel.Paint += fillUpPanel_Paint;
            // 
            // pricePerUnitTextBox
            // 
            pricePerUnitTextBox.Location = new Point(120, 98);
            pricePerUnitTextBox.Margin = new Padding(2);
            pricePerUnitTextBox.Name = "pricePerUnitTextBox";
            pricePerUnitTextBox.Size = new Size(86, 23);
            pricePerUnitTextBox.TabIndex = 6;
            pricePerUnitTextBox.TextChanged += pricePerUnitTextBox_TextChanged;
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(120, 29);
            itemNameTextBox.Margin = new Padding(2);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(124, 23);
            itemNameTextBox.TabIndex = 4;
            itemNameTextBox.TextChanged += itemLabel_TextChanged;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(104, 147);
            quantityTextBox.Margin = new Padding(2);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(70, 23);
            quantityTextBox.TabIndex = 5;
            quantityTextBox.TextChanged += quantityTextBox_TextChanged;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ButtonHighlight;
            addButton.BackgroundImageLayout = ImageLayout.Zoom;
            addButton.ForeColor = SystemColors.ActiveCaptionText;
            addButton.Location = new Point(52, 175);
            addButton.Margin = new Padding(2);
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 24);
            addButton.TabIndex = 3;
            addButton.Tag = "";
            addButton.Text = "Add to Cart";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // calcuPanel
            // 
            calcuPanel.BackColor = Color.LightGray;
            calcuPanel.BorderStyle = BorderStyle.Fixed3D;
            calcuPanel.Controls.Add(totalAmountTextBox);
            calcuPanel.Controls.Add(discountAmountTextBox);
            calcuPanel.Controls.Add(percentDiscountTextBox);
            calcuPanel.Controls.Add(totalCostTextBox);
            calcuPanel.Controls.Add(doneButton);
            calcuPanel.Controls.Add(totalAmount);
            calcuPanel.Controls.Add(discountAmountLabel);
            calcuPanel.Controls.Add(discountPercentLabel);
            calcuPanel.Controls.Add(totalCostLabel);
            calcuPanel.Location = new Point(701, 396);
            calcuPanel.Margin = new Padding(2);
            calcuPanel.Name = "calcuPanel";
            calcuPanel.Size = new Size(340, 155);
            calcuPanel.TabIndex = 5;
            // 
            // totalAmountTextBox
            // 
            totalAmountTextBox.BackColor = SystemColors.ButtonHighlight;
            totalAmountTextBox.Location = new Point(176, 97);
            totalAmountTextBox.Margin = new Padding(2);
            totalAmountTextBox.Name = "totalAmountTextBox";
            totalAmountTextBox.ReadOnly = true;
            totalAmountTextBox.Size = new Size(130, 23);
            totalAmountTextBox.TabIndex = 15;
            totalAmountTextBox.TextChanged += totalAmountTextBox_TextChanged;
            // 
            // discountAmountTextBox
            // 
            discountAmountTextBox.BackColor = SystemColors.ButtonHighlight;
            discountAmountTextBox.Location = new Point(176, 69);
            discountAmountTextBox.Margin = new Padding(2);
            discountAmountTextBox.Name = "discountAmountTextBox";
            discountAmountTextBox.ReadOnly = true;
            discountAmountTextBox.Size = new Size(130, 23);
            discountAmountTextBox.TabIndex = 14;
            discountAmountTextBox.TextChanged += discountAmountTextBox_TextChanged;
            // 
            // percentDiscountTextBox
            // 
            percentDiscountTextBox.BackColor = SystemColors.ButtonHighlight;
            percentDiscountTextBox.Location = new Point(176, 41);
            percentDiscountTextBox.Margin = new Padding(2);
            percentDiscountTextBox.Name = "percentDiscountTextBox";
            percentDiscountTextBox.ReadOnly = true;
            percentDiscountTextBox.Size = new Size(130, 23);
            percentDiscountTextBox.TabIndex = 13;
            percentDiscountTextBox.TextChanged += percentDiscountTextBox_TextChanged;
            // 
            // totalCostTextBox
            // 
            totalCostTextBox.BackColor = SystemColors.ButtonHighlight;
            totalCostTextBox.Location = new Point(176, 12);
            totalCostTextBox.Margin = new Padding(2);
            totalCostTextBox.Name = "totalCostTextBox";
            totalCostTextBox.ReadOnly = true;
            totalCostTextBox.Size = new Size(130, 23);
            totalCostTextBox.TabIndex = 12;
            totalCostTextBox.TextChanged += totalCostTextBox_TextChanged;
            // 
            // doneButton
            // 
            doneButton.Location = new Point(130, 129);
            doneButton.Margin = new Padding(2);
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
            totalAmount.Location = new Point(56, 100);
            totalAmount.Margin = new Padding(2, 0, 2, 0);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(102, 15);
            totalAmount.TabIndex = 11;
            totalAmount.Text = "TOTAL AMOUNT:";
            // 
            // discountAmountLabel
            // 
            discountAmountLabel.AutoSize = true;
            discountAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountAmountLabel.Location = new Point(31, 72);
            discountAmountLabel.Margin = new Padding(2, 0, 2, 0);
            discountAmountLabel.Name = "discountAmountLabel";
            discountAmountLabel.Size = new Size(127, 15);
            discountAmountLabel.TabIndex = 10;
            discountAmountLabel.Text = "DISCOUNT AMOUNT:";
            // 
            // discountPercentLabel
            // 
            discountPercentLabel.AutoSize = true;
            discountPercentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountPercentLabel.Location = new Point(34, 44);
            discountPercentLabel.Margin = new Padding(2, 0, 2, 0);
            discountPercentLabel.Name = "discountPercentLabel";
            discountPercentLabel.Size = new Size(124, 15);
            discountPercentLabel.TabIndex = 9;
            discountPercentLabel.Text = "PERCENT DISCOUNT:";
            discountPercentLabel.Click += discountPercentLabel_Click;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalCostLabel.Location = new Point(79, 20);
            totalCostLabel.Margin = new Padding(2, 0, 2, 0);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(79, 15);
            totalCostLabel.TabIndex = 8;
            totalCostLabel.Text = "TOTAL COST:";
            totalCostLabel.Click += totalCostLabel_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(833, 553);
            exitButton.Margin = new Padding(2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(78, 20);
            exitButton.TabIndex = 7;
            exitButton.Text = "CLOSE";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(26, 54);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 281);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { item, quantity, totalPrice, delete });
            dataGridView1.GridColor = SystemColors.Menu;
            dataGridView1.Location = new Point(26, 396);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.Size = new Size(652, 155);
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
            // checkOutButton
            // 
            checkOutButton.Location = new Point(297, 553);
            checkOutButton.Margin = new Padding(2);
            checkOutButton.Name = "checkOutButton";
            checkOutButton.Size = new Size(83, 20);
            checkOutButton.TabIndex = 6;
            checkOutButton.Text = "CHECK OUT";
            checkOutButton.UseVisualStyleBackColor = true;
            checkOutButton.Click += checkOutButton_Click;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.BackColor = Color.DarkSlateGray;
            cartLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartLabel.ForeColor = SystemColors.Control;
            cartLabel.Location = new Point(26, 365);
            cartLabel.Margin = new Padding(2, 0, 2, 0);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(164, 25);
            cartLabel.TabIndex = 7;
            cartLabel.Text = "SHOPPING CART";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Location = new Point(358, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(683, 351);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(quantityTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(quantityLabel);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(30, 30);
            panel1.Margin = new Padding(30, 30, 15, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 206);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 128);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 3;
            label3.Text = "available stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 112);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 6);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "item name";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(33, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 85);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label16);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(pictureBox6);
            panel5.Location = new Point(249, 30);
            panel5.Margin = new Padding(15, 30, 15, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(188, 206);
            panel5.TabIndex = 8;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(54, 128);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 3;
            label16.Text = "available stock";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(52, 175);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(86, 24);
            button4.TabIndex = 3;
            button4.Tag = "";
            button4.Text = "Add to Cart";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(104, 147);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(70, 23);
            textBox4.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(80, 112);
            label17.Name = "label17";
            label17.Size = new Size(33, 15);
            label17.TabIndex = 2;
            label17.Text = "price";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(63, 6);
            label18.Name = "label18";
            label18.Size = new Size(64, 15);
            label18.TabIndex = 1;
            label18.Text = "item name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.FlatStyle = FlatStyle.Popup;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(7, 150);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(89, 15);
            label19.TabIndex = 1;
            label19.Text = "Enter quantity:";
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(33, 24);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(123, 85);
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gainsboro;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label24);
            panel7.Controls.Add(button6);
            panel7.Controls.Add(textBox6);
            panel7.Controls.Add(label25);
            panel7.Controls.Add(label26);
            panel7.Controls.Add(label27);
            panel7.Controls.Add(pictureBox8);
            panel7.Location = new Point(467, 30);
            panel7.Margin = new Padding(15, 30, 15, 15);
            panel7.Name = "panel7";
            panel7.Size = new Size(184, 206);
            panel7.TabIndex = 9;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(54, 128);
            label24.Name = "label24";
            label24.Size = new Size(84, 15);
            label24.TabIndex = 3;
            label24.Text = "available stock";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(52, 175);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(86, 24);
            button6.TabIndex = 3;
            button6.Tag = "";
            button6.Text = "Add to Cart";
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(104, 147);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(70, 23);
            textBox6.TabIndex = 5;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(80, 112);
            label25.Name = "label25";
            label25.Size = new Size(33, 15);
            label25.TabIndex = 2;
            label25.Text = "price";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(63, 6);
            label26.Name = "label26";
            label26.Size = new Size(64, 15);
            label26.TabIndex = 1;
            label26.Text = "item name";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.FlatStyle = FlatStyle.Popup;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(7, 150);
            label27.Margin = new Padding(2, 0, 2, 0);
            label27.Name = "label27";
            label27.Size = new Size(89, 15);
            label27.TabIndex = 1;
            label27.Text = "Enter quantity:";
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(33, 24);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(123, 85);
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(30, 281);
            panel3.Margin = new Padding(30, 30, 15, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 206);
            panel3.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 128);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 3;
            label8.Text = "available stock";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(52, 175);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(86, 24);
            button2.TabIndex = 3;
            button2.Tag = "";
            button2.Text = "Add to Cart";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 147);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(70, 23);
            textBox2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 112);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 2;
            label9.Text = "price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(63, 6);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 1;
            label10.Text = "item name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(7, 150);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 1;
            label11.Text = "Enter quantity:";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(33, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(123, 85);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(249, 281);
            panel2.Margin = new Padding(15, 30, 15, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 206);
            panel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 128);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "available stock";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(52, 175);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(86, 24);
            button1.TabIndex = 3;
            button1.Tag = "";
            button1.Text = "Add to Cart";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 147);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 23);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 112);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 2;
            label5.Text = "price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 6);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 1;
            label6.Text = "item name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(7, 150);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 1;
            label7.Text = "Enter quantity:";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(33, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(123, 85);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label12);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(pictureBox5);
            panel4.Location = new Point(467, 281);
            panel4.Margin = new Padding(15, 30, 15, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 206);
            panel4.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(54, 128);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 3;
            label12.Text = "available stock";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(52, 175);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(86, 24);
            button3.TabIndex = 3;
            button3.Tag = "";
            button3.Text = "Add to Cart";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(104, 147);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(70, 23);
            textBox3.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(80, 112);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 2;
            label13.Text = "price";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(63, 6);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 1;
            label14.Text = "item name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.FlatStyle = FlatStyle.Popup;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(7, 150);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(89, 15);
            label15.TabIndex = 1;
            label15.Text = "Enter quantity:";
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(33, 24);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(123, 85);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gainsboro;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label20);
            panel6.Controls.Add(button5);
            panel6.Controls.Add(textBox5);
            panel6.Controls.Add(label21);
            panel6.Controls.Add(label22);
            panel6.Controls.Add(label23);
            panel6.Controls.Add(pictureBox7);
            panel6.Location = new Point(30, 532);
            panel6.Margin = new Padding(30, 30, 15, 15);
            panel6.Name = "panel6";
            panel6.Size = new Size(188, 206);
            panel6.TabIndex = 8;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(54, 128);
            label20.Name = "label20";
            label20.Size = new Size(84, 15);
            label20.TabIndex = 3;
            label20.Text = "available stock";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(52, 175);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(86, 24);
            button5.TabIndex = 3;
            button5.Tag = "";
            button5.Text = "Add to Cart";
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(104, 147);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(70, 23);
            textBox5.TabIndex = 5;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(80, 112);
            label21.Name = "label21";
            label21.Size = new Size(33, 15);
            label21.TabIndex = 2;
            label21.Text = "price";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(63, 6);
            label22.Name = "label22";
            label22.Size = new Size(64, 15);
            label22.TabIndex = 1;
            label22.Text = "item name";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.FlatStyle = FlatStyle.Popup;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(7, 150);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(89, 15);
            label23.TabIndex = 1;
            label23.Text = "Enter quantity:";
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(33, 24);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(123, 85);
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.icons8_shopping_cart_48;
            pictureBox9.Location = new Point(187, 361);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(36, 33);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 6;
            pictureBox9.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1063, 576);
            ControlBox = false;
            Controls.Add(checkOutButton);
            Controls.Add(pictureBox9);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(cartLabel);
            Controls.Add(exitButton);
            Controls.Add(dataGridView1);
            Controls.Add(calcuPanel);
            Controls.Add(fillUpPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TINDAHAN DE ALKANSE";
            Load += Form1_Load;
            fillUpPanel.ResumeLayout(false);
            fillUpPanel.PerformLayout();
            calcuPanel.ResumeLayout(false);
            calcuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemLabel;
        private Label quantityLabel;
        private Label pricePerUnitLabel;
        private Panel fillUpPanel;
        private TextBox pricePerUnitTextBox;
        private TextBox quantityTextBox;
        private TextBox itemNameTextBox;
        private Panel calcuPanel;
        private Label totalAmount;
        private Label discountAmountLabel;
        private Label discountPercentLabel;
        private Label totalCostLabel;
        private Button doneButton;
        private TextBox totalAmountTextBox;
        private TextBox discountAmountTextBox;
        private TextBox percentDiscountTextBox;
        private TextBox totalCostTextBox;
        private Button exitButton;
        private Button addButton;
        private PictureBox pictureBox1;
        private Button checkOutButton;
        private Label cartLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn totalPrice;
        private DataGridViewButtonColumn delete;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Label label16;
        private Button button4;
        private TextBox textBox4;
        private Label label17;
        private Label label18;
        private Label label19;
        private PictureBox pictureBox6;
        private Panel panel3;
        private Label label8;
        private Button button2;
        private TextBox textBox2;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox3;
        private Panel panel7;
        private Label label24;
        private Button button6;
        private TextBox textBox6;
        private Label label25;
        private Label label26;
        private Label label27;
        private PictureBox pictureBox8;
        private Panel panel4;
        private Label label12;
        private Button button3;
        private TextBox textBox3;
        private Label label13;
        private Label label14;
        private Label label15;
        private PictureBox pictureBox5;
        private Panel panel6;
        private Label label20;
        private Button button5;
        private TextBox textBox5;
        private Label label21;
        private Label label22;
        private Label label23;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
    }
}
