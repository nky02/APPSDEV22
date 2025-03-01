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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            receiptpanel = new Panel();
            separator2 = new Label();
            valuesPanel = new Panel();
            labeldate = new Label();
            label8 = new Label();
            label7 = new Label();
            labelValues = new Label();
            btmpanel = new Panel();
            LabelFinalamnt = new Label();
            logo = new PictureBox();
            panel1 = new Panel();
            separator1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelprice = new Label();
            labelqnty = new Label();
            labelItems = new Label();
            labeltansac = new Label();
            check_icn = new PictureBox();
            receiptpanel.SuspendLayout();
            valuesPanel.SuspendLayout();
            btmpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)check_icn).BeginInit();
            SuspendLayout();
            // 
            // receiptpanel
            // 
            receiptpanel.AutoSize = true;
            receiptpanel.BackColor = Color.White;
            receiptpanel.Controls.Add(separator2);
            receiptpanel.Controls.Add(valuesPanel);
            receiptpanel.Controls.Add(btmpanel);
            receiptpanel.Controls.Add(logo);
            receiptpanel.Controls.Add(panel1);
            receiptpanel.Controls.Add(separator1);
            receiptpanel.Controls.Add(label4);
            receiptpanel.Controls.Add(label3);
            receiptpanel.Controls.Add(label2);
            receiptpanel.Controls.Add(labelprice);
            receiptpanel.Controls.Add(labelqnty);
            receiptpanel.Controls.Add(labelItems);
            receiptpanel.Controls.Add(labeltansac);
            receiptpanel.Controls.Add(check_icn);
            receiptpanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receiptpanel.Location = new Point(0, -1);
            receiptpanel.Name = "receiptpanel";
            receiptpanel.Size = new Size(425, 465);
            receiptpanel.TabIndex = 0;
            receiptpanel.Paint += receiptpanel_Paint;
            // 
            // separator2
            // 
            separator2.AutoSize = true;
            separator2.Dock = DockStyle.Bottom;
            separator2.Location = new Point(0, 364);
            separator2.Name = "separator2";
            separator2.Size = new Size(62, 15);
            separator2.TabIndex = 26;
            separator2.Text = "separator2";
            // 
            // valuesPanel
            // 
            valuesPanel.AutoSize = true;
            valuesPanel.Controls.Add(labeldate);
            valuesPanel.Controls.Add(label8);
            valuesPanel.Controls.Add(label7);
            valuesPanel.Controls.Add(labelValues);
            valuesPanel.Dock = DockStyle.Bottom;
            valuesPanel.Location = new Point(0, 379);
            valuesPanel.Name = "valuesPanel";
            valuesPanel.Size = new Size(425, 61);
            valuesPanel.TabIndex = 25;
            // 
            // labeldate
            // 
            labeldate.AutoSize = true;
            labeldate.ForeColor = SystemColors.WindowFrame;
            labeldate.Location = new Point(165, 0);
            labeldate.Name = "labeldate";
            labeldate.Size = new Size(30, 15);
            labeldate.TabIndex = 3;
            labeldate.Text = "date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.WindowFrame;
            label8.Location = new Point(126, 0);
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
            label7.Location = new Point(9, 6);
            label7.Name = "label7";
            label7.Padding = new Padding(7, 10, 0, 0);
            label7.Size = new Size(135, 55);
            label7.TabIndex = 1;
            label7.Text = "TOTAL COST :\r\nPERCENT DISCOUNT :\r\nDISCOUNT AMOUNT :";
            // 
            // labelValues
            // 
            labelValues.AutoSize = true;
            labelValues.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValues.ForeColor = SystemColors.WindowFrame;
            labelValues.Location = new Point(303, 6);
            labelValues.Name = "labelValues";
            labelValues.Padding = new Padding(0, 10, 5, 5);
            labelValues.Size = new Size(71, 30);
            labelValues.TabIndex = 0;
            labelValues.Text = "labelValues";
            // 
            // btmpanel
            // 
            btmpanel.AutoSize = true;
            btmpanel.Controls.Add(LabelFinalamnt);
            btmpanel.Dock = DockStyle.Bottom;
            btmpanel.Location = new Point(0, 440);
            btmpanel.Name = "btmpanel";
            btmpanel.Size = new Size(425, 25);
            btmpanel.TabIndex = 24;
            btmpanel.Paint += btmpanel_Paint;
            // 
            // LabelFinalamnt
            // 
            LabelFinalamnt.AutoSize = true;
            LabelFinalamnt.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelFinalamnt.ForeColor = Color.DarkSlateGray;
            LabelFinalamnt.Location = new Point(179, 4);
            LabelFinalamnt.Name = "LabelFinalamnt";
            LabelFinalamnt.Size = new Size(68, 21);
            LabelFinalamnt.TabIndex = 19;
            LabelFinalamnt.Text = "label10";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(149, 4);
            logo.Margin = new Padding(2);
            logo.Name = "logo";
            logo.Size = new Size(125, 111);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 11;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 465);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 0);
            panel1.TabIndex = 17;
            // 
            // separator1
            // 
            separator1.AutoSize = true;
            separator1.Location = new Point(0, 134);
            separator1.Name = "separator1";
            separator1.Size = new Size(62, 15);
            separator1.TabIndex = 8;
            separator1.Text = "separator1";
            separator1.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(323, 199);
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
            label3.Location = new Point(179, 199);
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
            label2.Location = new Point(45, 199);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 5;
            label2.Text = "ITEMS:";
            // 
            // labelprice
            // 
            labelprice.AutoSize = true;
            labelprice.ForeColor = SystemColors.WindowFrame;
            labelprice.Location = new Point(323, 228);
            labelprice.Name = "labelprice";
            labelprice.Size = new Size(35, 15);
            labelprice.TabIndex = 4;
            labelprice.Text = "ttlprc";
            // 
            // labelqnty
            // 
            labelqnty.AutoSize = true;
            labelqnty.ForeColor = SystemColors.WindowFrame;
            labelqnty.Location = new Point(183, 228);
            labelqnty.Name = "labelqnty";
            labelqnty.Size = new Size(31, 15);
            labelqnty.TabIndex = 3;
            labelqnty.Text = "qnty";
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.ForeColor = SystemColors.WindowFrame;
            labelItems.Location = new Point(45, 228);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(36, 15);
            labelItems.TabIndex = 2;
            labelItems.Text = "items";
            // 
            // labeltansac
            // 
            labeltansac.AutoSize = true;
            labeltansac.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labeltansac.ForeColor = Color.OliveDrab;
            labeltansac.Location = new Point(126, 117);
            labeltansac.Name = "labeltansac";
            labeltansac.Size = new Size(171, 21);
            labeltansac.TabIndex = 1;
            labeltansac.Text = "Transaction Successful";
            labeltansac.Click += label1_Click;
            // 
            // check_icn
            // 
            check_icn.Image = Properties.Resources.icons8_check_48;
            check_icn.Location = new Point(192, 152);
            check_icn.Name = "check_icn";
            check_icn.Size = new Size(40, 35);
            check_icn.SizeMode = PictureBoxSizeMode.StretchImage;
            check_icn.TabIndex = 14;
            check_icn.TabStop = false;
            check_icn.Click += check_icn_Click;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(425, 464);
            Controls.Add(receiptpanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReceiptForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RECEIPT DE ALKANSE";
            Load += Form3_Load;
            receiptpanel.ResumeLayout(false);
            receiptpanel.PerformLayout();
            valuesPanel.ResumeLayout(false);
            valuesPanel.PerformLayout();
            btmpanel.ResumeLayout(false);
            btmpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)check_icn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel receiptpanel;
        private PictureBox check_icn;
        private Label labeltansac;
        private Label labelItems;
        private Label labelprice;
        private Label labelqnty;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label separator1;
        private PictureBox logo;
        private Panel panel1;
        private Label LabelFinalamnt;
        private Label separator2;
        private Panel valuesPanel;
        private Label labeldate;
        private Label label8;
        private Label label7;
        private Label labelValues;
        private Panel btmpanel;
    }
}