namespace SiuntosRN
{
    partial class CreateNewItemForm
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
            this.NameNewItem = new System.Windows.Forms.TextBox();
            this.AmmNewItem = new System.Windows.Forms.TextBox();
            this.PriceNewItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveNewItem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameNewItem
            // 
            this.NameNewItem.Location = new System.Drawing.Point(93, 12);
            this.NameNewItem.Name = "NameNewItem";
            this.NameNewItem.Size = new System.Drawing.Size(100, 20);
            this.NameNewItem.TabIndex = 0;
            // 
            // AmmNewItem
            // 
            this.AmmNewItem.Location = new System.Drawing.Point(93, 38);
            this.AmmNewItem.Name = "AmmNewItem";
            this.AmmNewItem.Size = new System.Drawing.Size(100, 20);
            this.AmmNewItem.TabIndex = 1;
            // 
            // PriceNewItem
            // 
            this.PriceNewItem.Location = new System.Drawing.Point(93, 64);
            this.PriceNewItem.Name = "PriceNewItem";
            this.PriceNewItem.Size = new System.Drawing.Size(100, 20);
            this.PriceNewItem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pavadinimas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kiekis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kaina";
            // 
            // SaveNewItem
            // 
            this.SaveNewItem.Location = new System.Drawing.Point(37, 98);
            this.SaveNewItem.Name = "SaveNewItem";
            this.SaveNewItem.Size = new System.Drawing.Size(75, 23);
            this.SaveNewItem.TabIndex = 7;
            this.SaveNewItem.Text = "Save";
            this.SaveNewItem.UseVisualStyleBackColor = true;
            this.SaveNewItem.Click += new System.EventHandler(this.SaveNewItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateNewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 149);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveNewItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceNewItem);
            this.Controls.Add(this.AmmNewItem);
            this.Controls.Add(this.NameNewItem);
            this.Name = "CreateNewItemForm";
            this.Text = "NaujaPreke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameNewItem;
        private System.Windows.Forms.TextBox AmmNewItem;
        private System.Windows.Forms.TextBox PriceNewItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveNewItem;
        private System.Windows.Forms.Button button2;
    }
}