namespace SiuntosRN
{
    partial class Form1
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
            this.NewItemCreate = new System.Windows.Forms.Button();
            this.PrekiuKatalogas = new System.Windows.Forms.DataGridView();
            this.CurrentItem = new System.Windows.Forms.Label();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.UpdatePrice = new System.Windows.Forms.Button();
            this.NaujaKaina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrekiuKrepselisDG = new System.Windows.Forms.DataGridView();
            this.KatalogasLabel = new System.Windows.Forms.Label();
            this.KrepselisLabel = new System.Windows.Forms.Label();
            this.AddKrepselisButton = new System.Windows.Forms.Button();
            this.RemoveKrepselisButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.CurrentPurchItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrekiuKatalogas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrekiuKrepselisDG)).BeginInit();
            this.SuspendLayout();
            // 
            // NewItemCreate
            // 
            this.NewItemCreate.Location = new System.Drawing.Point(552, 44);
            this.NewItemCreate.Name = "NewItemCreate";
            this.NewItemCreate.Size = new System.Drawing.Size(110, 58);
            this.NewItemCreate.TabIndex = 0;
            this.NewItemCreate.Text = "Nauja Preke";
            this.NewItemCreate.UseVisualStyleBackColor = true;
            this.NewItemCreate.Click += new System.EventHandler(this.NewItemCreate_Click);
            // 
            // PrekiuKatalogas
            // 
            this.PrekiuKatalogas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrekiuKatalogas.Location = new System.Drawing.Point(13, 36);
            this.PrekiuKatalogas.Name = "PrekiuKatalogas";
            this.PrekiuKatalogas.Size = new System.Drawing.Size(533, 257);
            this.PrekiuKatalogas.TabIndex = 1;
            this.PrekiuKatalogas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrekiuKatalogas_CellContentClick);
            // 
            // CurrentItem
            // 
            this.CurrentItem.AutoSize = true;
            this.CurrentItem.Location = new System.Drawing.Point(552, 13);
            this.CurrentItem.Name = "CurrentItem";
            this.CurrentItem.Size = new System.Drawing.Size(33, 13);
            this.CurrentItem.TabIndex = 2;
            this.CurrentItem.Text = "None";
            // 
            // DeleteItem
            // 
            this.DeleteItem.Location = new System.Drawing.Point(552, 108);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(110, 58);
            this.DeleteItem.TabIndex = 3;
            this.DeleteItem.Text = "Trinti Preke";
            this.DeleteItem.UseVisualStyleBackColor = true;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // UpdatePrice
            // 
            this.UpdatePrice.Location = new System.Drawing.Point(552, 172);
            this.UpdatePrice.Name = "UpdatePrice";
            this.UpdatePrice.Size = new System.Drawing.Size(110, 58);
            this.UpdatePrice.TabIndex = 4;
            this.UpdatePrice.Text = "Nauja Kaina";
            this.UpdatePrice.UseVisualStyleBackColor = true;
            this.UpdatePrice.Click += new System.EventHandler(this.UpdatePrice_Click);
            // 
            // NaujaKaina
            // 
            this.NaujaKaina.Location = new System.Drawing.Point(555, 252);
            this.NaujaKaina.Name = "NaujaKaina";
            this.NaujaKaina.Size = new System.Drawing.Size(100, 20);
            this.NaujaKaina.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nauja Kaina";
            // 
            // PrekiuKrepselisDG
            // 
            this.PrekiuKrepselisDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrekiuKrepselisDG.Location = new System.Drawing.Point(13, 325);
            this.PrekiuKrepselisDG.Name = "PrekiuKrepselisDG";
            this.PrekiuKrepselisDG.Size = new System.Drawing.Size(533, 252);
            this.PrekiuKrepselisDG.TabIndex = 7;
            this.PrekiuKrepselisDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrekiuKrepselisDG_CellContentClick);
            // 
            // KatalogasLabel
            // 
            this.KatalogasLabel.AutoSize = true;
            this.KatalogasLabel.Location = new System.Drawing.Point(13, 13);
            this.KatalogasLabel.Name = "KatalogasLabel";
            this.KatalogasLabel.Size = new System.Drawing.Size(87, 13);
            this.KatalogasLabel.TabIndex = 8;
            this.KatalogasLabel.Text = "Prekiu Katalogas";
            // 
            // KrepselisLabel
            // 
            this.KrepselisLabel.AutoSize = true;
            this.KrepselisLabel.Location = new System.Drawing.Point(16, 306);
            this.KrepselisLabel.Name = "KrepselisLabel";
            this.KrepselisLabel.Size = new System.Drawing.Size(82, 13);
            this.KrepselisLabel.TabIndex = 9;
            this.KrepselisLabel.Text = "Prekiu Krepselis";
            // 
            // AddKrepselisButton
            // 
            this.AddKrepselisButton.Location = new System.Drawing.Point(552, 325);
            this.AddKrepselisButton.Name = "AddKrepselisButton";
            this.AddKrepselisButton.Size = new System.Drawing.Size(110, 58);
            this.AddKrepselisButton.TabIndex = 10;
            this.AddKrepselisButton.Text = "Prideti I Krepseli";
            this.AddKrepselisButton.UseVisualStyleBackColor = true;
            this.AddKrepselisButton.Click += new System.EventHandler(this.AddKrepselisButton_Click);
            // 
            // RemoveKrepselisButton
            // 
            this.RemoveKrepselisButton.Location = new System.Drawing.Point(552, 389);
            this.RemoveKrepselisButton.Name = "RemoveKrepselisButton";
            this.RemoveKrepselisButton.Size = new System.Drawing.Size(110, 58);
            this.RemoveKrepselisButton.TabIndex = 11;
            this.RemoveKrepselisButton.Text = "Isimti is krepselio";
            this.RemoveKrepselisButton.UseVisualStyleBackColor = true;
            this.RemoveKrepselisButton.Click += new System.EventHandler(this.RemoveKrepselisButton_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(552, 453);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(110, 58);
            this.BuyButton.TabIndex = 12;
            this.BuyButton.Text = "Pirkti";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // CurrentPurchItem
            // 
            this.CurrentPurchItem.AutoSize = true;
            this.CurrentPurchItem.Location = new System.Drawing.Point(552, 306);
            this.CurrentPurchItem.Name = "CurrentPurchItem";
            this.CurrentPurchItem.Size = new System.Drawing.Size(35, 13);
            this.CurrentPurchItem.TabIndex = 13;
            this.CurrentPurchItem.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 589);
            this.Controls.Add(this.CurrentPurchItem);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.RemoveKrepselisButton);
            this.Controls.Add(this.AddKrepselisButton);
            this.Controls.Add(this.KrepselisLabel);
            this.Controls.Add(this.KatalogasLabel);
            this.Controls.Add(this.PrekiuKrepselisDG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NaujaKaina);
            this.Controls.Add(this.UpdatePrice);
            this.Controls.Add(this.DeleteItem);
            this.Controls.Add(this.CurrentItem);
            this.Controls.Add(this.PrekiuKatalogas);
            this.Controls.Add(this.NewItemCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PrekiuKatalogas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrekiuKrepselisDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewItemCreate;
        private System.Windows.Forms.DataGridView PrekiuKatalogas;
        private System.Windows.Forms.Label CurrentItem;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.Button UpdatePrice;
        private System.Windows.Forms.TextBox NaujaKaina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PrekiuKrepselisDG;
        private System.Windows.Forms.Label KatalogasLabel;
        private System.Windows.Forms.Label KrepselisLabel;
        private System.Windows.Forms.Button AddKrepselisButton;
        private System.Windows.Forms.Button RemoveKrepselisButton;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Label CurrentPurchItem;
    }
}

