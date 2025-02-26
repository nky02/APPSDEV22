namespace GroceryApp
{
    partial class ReceiptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            receiptpanel = new Panel();
            label6 = new Label();
            valuesPanel = new Panel();
            labeldate = new Label();
            label8 = new Label();
            label7 = new Label();
            labelValues = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelprice = new Label();
            labelqnty = new Label();
            labelItems = new Label();
            label1 = new Label();
            check_icn = new PictureBox();
            receiptpanel.SuspendLayout();
            valuesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)check_icn).BeginInit();
            SuspendLayout();
            // 
            // receiptpanel
            // 
            receiptpanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            receiptpanel.AutoSize = true;
            receiptpanel.Controls.Add(label6);
            receiptpanel.Controls.Add(valuesPanel);
            receiptpanel.Controls.Add(label5);
            receiptpanel.Controls.Add(label4);
            receiptpanel.Controls.Add(label3);
            receiptpanel.Controls.Add(label2);
            receiptpanel.Controls.Add(labelprice);
            receiptpanel.Controls.Add(labelqnty);
            receiptpanel.Controls.Add(labelItems);
            receiptpanel.Controls.Add(label1);
            receiptpanel.Controls.Add(check_icn);
            receiptpanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receiptpanel.Location = new Point(82, 63);
            receiptpanel.Name = "receiptpanel";
            receiptpanel.Size = new Size(405, 291);
            receiptpanel.TabIndex = 0;
            receiptpanel.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Bottom;
            label6.Location = new Point(0, 188);
            label6.Name = "label6";
            label6.Size = new Size(402, 15);
            label6.TabIndex = 13;
            label6.Text = "-------------------------------------------------------------------------------";
            // 
            // valuesPanel
            // 
            valuesPanel.AutoSize = true;
            valuesPanel.Controls.Add(labeldate);
            valuesPanel.Controls.Add(label8);
            valuesPanel.Controls.Add(label7);
            valuesPanel.Controls.Add(labelValues);
            valuesPanel.Dock = DockStyle.Bottom;
            valuesPanel.Location = new Point(0, 203);
            valuesPanel.Name = "valuesPanel";
            valuesPanel.Size = new Size(405, 88);
            valuesPanel.TabIndex = 12;
            valuesPanel.Paint += valuesPanel_Paint;
            // 
            // labeldate
            // 
            labeldate.AutoSize = true;
            labeldate.ForeColor = SystemColors.WindowFrame;
            labeldate.Location = new Point(163, 0);
            labeldate.Name = "labeldate";
            labeldate.Size = new Size(38, 15);
            labeldate.TabIndex = 3;
            labeldate.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.WindowFrame;
            label8.Location = new Point(120, 0);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 2;
            label8.Text = "Date: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.WindowFrame;
            label7.Location = new Point(3, 21);
            label7.Name = "label7";
            label7.Padding = new Padding(7, 2, 0, 5);
            label7.Size = new Size(135, 67);
            label7.TabIndex = 1;
            label7.Text = "TOTAL COST :\r\nPERCENT DISCOUNT :\r\nDISCOUNT AMOUNT :\r\nFINAL AMOUNT :";
            // 
            // labelValues
            // 
            labelValues.AutoSize = true;
            labelValues.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValues.ForeColor = SystemColors.WindowFrame;
            labelValues.Location = new Point(310, 21);
            labelValues.Name = "labelValues";
            labelValues.Padding = new Padding(0, 2, 5, 5);
            labelValues.Size = new Size(71, 22);
            labelValues.TabIndex = 0;
            labelValues.Text = "labelValues";
            labelValues.Click += labelValues_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 60);
            label5.Name = "label5";
            label5.Size = new Size(402, 15);
            label5.TabIndex = 8;
            label5.Text = "-------------------------------------------------------------------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(310, 84);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "PRICE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(166, 84);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "QUANTITY:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(32, 84);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 5;
            label2.Text = "ITEMS:";
            // 
            // labelprice
            // 
            labelprice.AutoSize = true;
            labelprice.ForeColor = SystemColors.WindowFrame;
            labelprice.Location = new Point(310, 113);
            labelprice.Name = "labelprice";
            labelprice.Size = new Size(35, 15);
            labelprice.TabIndex = 4;
            labelprice.Text = "ttlprc";
            // 
            // labelqnty
            // 
            labelqnty.AutoSize = true;
            labelqnty.ForeColor = SystemColors.WindowFrame;
            labelqnty.Location = new Point(184, 113);
            labelqnty.Name = "labelqnty";
            labelqnty.Size = new Size(31, 15);
            labelqnty.TabIndex = 3;
            labelqnty.Text = "qnty";
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.ForeColor = SystemColors.WindowFrame;
            labelItems.Location = new Point(32, 113);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(36, 15);
            labelItems.TabIndex = 2;
            labelItems.Text = "items";
            labelItems.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(111, 39);
            label1.Name = "label1";
            label1.Size = new Size(171, 21);
            label1.TabIndex = 1;
            label1.Text = "Transaction Successful";
            label1.Click += label1_Click;
            // 
            // check_icn
            // 
            check_icn.Image = Properties.Resources.icons8_check_48;
            check_icn.Location = new Point(181, 2);
            check_icn.Margin = new Padding(2);
            check_icn.Name = "check_icn";
            check_icn.Size = new Size(34, 35);
            check_icn.SizeMode = PictureBoxSizeMode.StretchImage;
            check_icn.TabIndex = 0;
            check_icn.TabStop = false;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources._3dc9c8646d7a5935b7b6192112c2f72b;
            ClientSize = new Size(574, 450);
            Controls.Add(receiptpanel);
            Name = "ReceiptForm";
            Text = "RECEIPT DE ALKANSE";
            Load += Form2_Load;
            receiptpanel.ResumeLayout(false);
            receiptpanel.PerformLayout();
            valuesPanel.ResumeLayout(false);
            valuesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)check_icn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel receiptpanel;
        private PictureBox check_icn;
        private Label label1;
        private Label labelItems;
        private Label labelprice;
        private Label labelqnty;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private Panel valuesPanel;
        private Label labelValues;
        private Label label7;
        private Label labeldate;
        private Label label8;
    }
}