namespace APIuseTest
{
    partial class CurrencyPriceCheck
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
            this.findPriceBTN = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // findPriceBTN
            // 
            this.findPriceBTN.Location = new System.Drawing.Point(127, 198);
            this.findPriceBTN.Name = "findPriceBTN";
            this.findPriceBTN.Size = new System.Drawing.Size(75, 23);
            this.findPriceBTN.TabIndex = 0;
            this.findPriceBTN.Text = "Find Price";
            this.findPriceBTN.UseVisualStyleBackColor = true;
            this.findPriceBTN.Click += new System.EventHandler(this.findPriceBTN_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(12, 12);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(310, 180);
            this.txtbox.TabIndex = 1;
            // 
            // CurrencyPriceCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 232);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.findPriceBTN);
            this.Name = "CurrencyPriceCheck";
            this.Text = "Currency Price Check";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button findPriceBTN;
        private TextBox txtbox;
    }
}