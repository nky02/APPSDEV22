namespace GUI_GroceryCalc
{
    partial class GroceryCalcForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.item_txt = new System.Windows.Forms.TextBox();
            this.itemprice = new System.Windows.Forms.TextBox();
            this.itemquantity = new System.Windows.Forms.TextBox();
            this.Additem_btn = new System.Windows.Forms.Button();
            this.Calculate_btn = new System.Windows.Forms.Button();
            this.ItemList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.remvitem_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM LIST";
            // 
            // item_txt
            // 
            this.item_txt.Location = new System.Drawing.Point(250, 115);
            this.item_txt.Name = "item_txt";
            this.item_txt.Size = new System.Drawing.Size(100, 20);
            this.item_txt.TabIndex = 4;
            this.item_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // itemprice
            // 
            this.itemprice.Location = new System.Drawing.Point(249, 228);
            this.itemprice.Name = "itemprice";
            this.itemprice.Size = new System.Drawing.Size(100, 20);
            this.itemprice.TabIndex = 5;
            this.itemprice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // itemquantity
            // 
            this.itemquantity.Location = new System.Drawing.Point(249, 172);
            this.itemquantity.Name = "itemquantity";
            this.itemquantity.Size = new System.Drawing.Size(100, 20);
            this.itemquantity.TabIndex = 5;
            this.itemquantity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Additem_btn
            // 
            this.Additem_btn.Location = new System.Drawing.Point(274, 338);
            this.Additem_btn.Name = "Additem_btn";
            this.Additem_btn.Size = new System.Drawing.Size(75, 23);
            this.Additem_btn.TabIndex = 6;
            this.Additem_btn.Text = "Add Item";
            this.Additem_btn.UseVisualStyleBackColor = true;
            this.Additem_btn.Click += new System.EventHandler(this.Additem_btn_Click);
            // 
            // Calculate_btn
            // 
            this.Calculate_btn.Location = new System.Drawing.Point(435, 338);
            this.Calculate_btn.Name = "Calculate_btn";
            this.Calculate_btn.Size = new System.Drawing.Size(75, 23);
            this.Calculate_btn.TabIndex = 7;
            this.Calculate_btn.Text = "Calculate";
            this.Calculate_btn.UseVisualStyleBackColor = true;
            this.Calculate_btn.Click += new System.EventHandler(this.Calculate_btn_Click);
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(435, 118);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(308, 134);
            this.ItemList.TabIndex = 8;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = " Enter item name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = " Enter quantity of the item:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = " Enter price per unit:";
            // 
            // remvitem_btn
            // 
            this.remvitem_btn.Location = new System.Drawing.Point(532, 258);
            this.remvitem_btn.Name = "remvitem_btn";
            this.remvitem_btn.Size = new System.Drawing.Size(104, 23);
            this.remvitem_btn.TabIndex = 12;
            this.remvitem_btn.Text = "Remove item";
            this.remvitem_btn.UseVisualStyleBackColor = true;
            this.remvitem_btn.Click += new System.EventHandler(this.remvitem_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // GroceryCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 401);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.remvitem_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.Calculate_btn);
            this.Controls.Add(this.Additem_btn);
            this.Controls.Add(this.itemquantity);
            this.Controls.Add(this.itemprice);
            this.Controls.Add(this.item_txt);
            this.Controls.Add(this.label1);
            this.Name = "GroceryCalcForm";
            this.Text = "Grocery calculator";
            this.Load += new System.EventHandler(this.GroceryCalcForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox item_txt;
        private System.Windows.Forms.TextBox itemprice;
        private System.Windows.Forms.TextBox itemquantity;
        private System.Windows.Forms.Button Additem_btn;
        private System.Windows.Forms.Button Calculate_btn;
        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button remvitem_btn;
        private System.Windows.Forms.Label label6;
    }
}

