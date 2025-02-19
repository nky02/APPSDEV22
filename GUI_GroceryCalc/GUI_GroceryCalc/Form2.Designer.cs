namespace GUI_GroceryCalc
{
    partial class Calculationsform
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
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelFinalAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(213, 102);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(35, 13);
            this.labelTotalCost.TabIndex = 0;
            this.labelTotalCost.Text = "label1";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(213, 137);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(35, 13);
            this.labelDiscount.TabIndex = 1;
            this.labelDiscount.Text = "label2";
            // 
            // labelFinalAmount
            // 
            this.labelFinalAmount.AutoSize = true;
            this.labelFinalAmount.Location = new System.Drawing.Point(213, 166);
            this.labelFinalAmount.Name = "labelFinalAmount";
            this.labelFinalAmount.Size = new System.Drawing.Size(35, 13);
            this.labelFinalAmount.TabIndex = 2;
            this.labelFinalAmount.Text = "label3";
            // 
            // Calculationsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFinalAmount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelTotalCost);
            this.Name = "Calculationsform";
            this.Text = "Calculations";
            this.Load += new System.EventHandler(this.Calculationsform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelFinalAmount;
    }
}