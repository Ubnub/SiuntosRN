namespace SiuntosRN
{
    partial class SiuntaForm
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
            this.SiuntaDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SiuntaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SiuntaDGV
            // 
            this.SiuntaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SiuntaDGV.Location = new System.Drawing.Point(13, 13);
            this.SiuntaDGV.Name = "SiuntaDGV";
            this.SiuntaDGV.Size = new System.Drawing.Size(473, 299);
            this.SiuntaDGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siuntos Dydis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Siuntos Kaina";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(87, 327);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(35, 13);
            this.SizeLabel.TabIndex = 3;
            this.SizeLabel.Text = "label3";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(87, 355);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(35, 13);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "label4";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(377, 355);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(109, 40);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Atsaukti";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(262, 355);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(109, 40);
            this.BuyButton.TabIndex = 6;
            this.BuyButton.Text = "Pirkti";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SiuntaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 409);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SiuntaDGV);
            this.Name = "SiuntaForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.SiuntaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SiuntaDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BuyButton;
    }
}