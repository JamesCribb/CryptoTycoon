namespace CryptoTycoon
{
    partial class BlackMarketForm
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
            this.offensiveItemsLabel = new System.Windows.Forms.Label();
            this.offensiveItemsComboBox = new System.Windows.Forms.ComboBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.itemPictureBox = new System.Windows.Forms.PictureBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.defensiveItemsComboBox = new System.Windows.Forms.ComboBox();
            this.defensiveItemsLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // offensiveItemsLabel
            // 
            this.offensiveItemsLabel.AutoSize = true;
            this.offensiveItemsLabel.Location = new System.Drawing.Point(13, 13);
            this.offensiveItemsLabel.Name = "offensiveItemsLabel";
            this.offensiveItemsLabel.Size = new System.Drawing.Size(83, 13);
            this.offensiveItemsLabel.TabIndex = 0;
            this.offensiveItemsLabel.Text = "Offensive Items:";
            // 
            // offensiveItemsComboBox
            // 
            this.offensiveItemsComboBox.FormattingEnabled = true;
            this.offensiveItemsComboBox.Location = new System.Drawing.Point(16, 29);
            this.offensiveItemsComboBox.Name = "offensiveItemsComboBox";
            this.offensiveItemsComboBox.Size = new System.Drawing.Size(214, 21);
            this.offensiveItemsComboBox.TabIndex = 1;
            this.offensiveItemsComboBox.SelectedIndexChanged += new System.EventHandler(this.offensiveItemsComboBox_SelectedIndexChanged);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(13, 133);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(58, 13);
            this.itemNameLabel.TabIndex = 2;
            this.itemNameLabel.Text = "Item Name";
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(12, 192);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(96, 23);
            this.buyButton.TabIndex = 3;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(133, 192);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Leave";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // itemPictureBox
            // 
            this.itemPictureBox.Location = new System.Drawing.Point(253, 13);
            this.itemPictureBox.Name = "itemPictureBox";
            this.itemPictureBox.Size = new System.Drawing.Size(158, 155);
            this.itemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemPictureBox.TabIndex = 5;
            this.itemPictureBox.TabStop = false;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(13, 164);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(34, 13);
            this.costLabel.TabIndex = 6;
            this.costLabel.Text = "Cost: ";
            // 
            // defensiveItemsComboBox
            // 
            this.defensiveItemsComboBox.FormattingEnabled = true;
            this.defensiveItemsComboBox.Location = new System.Drawing.Point(16, 94);
            this.defensiveItemsComboBox.Name = "defensiveItemsComboBox";
            this.defensiveItemsComboBox.Size = new System.Drawing.Size(214, 21);
            this.defensiveItemsComboBox.TabIndex = 7;
            this.defensiveItemsComboBox.SelectedIndexChanged += new System.EventHandler(this.defensiveItemsComboBox_SelectedIndexChanged);
            // 
            // defensiveItemsLabel
            // 
            this.defensiveItemsLabel.AutoSize = true;
            this.defensiveItemsLabel.Location = new System.Drawing.Point(13, 78);
            this.defensiveItemsLabel.Name = "defensiveItemsLabel";
            this.defensiveItemsLabel.Size = new System.Drawing.Size(78, 13);
            this.defensiveItemsLabel.TabIndex = 8;
            this.defensiveItemsLabel.Text = "Defense Items:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(253, 175);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(148, 13);
            this.descriptionLabel.TabIndex = 9;
            this.descriptionLabel.Text = "Weapon / Armour Description";
            // 
            // BlackMarketForm
            // 
            this.AcceptButton = this.buyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(426, 227);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.defensiveItemsLabel);
            this.Controls.Add(this.defensiveItemsComboBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.itemPictureBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.offensiveItemsComboBox);
            this.Controls.Add(this.offensiveItemsLabel);
            this.Name = "BlackMarketForm";
            this.Text = "Black Market";
            ((System.ComponentModel.ISupportInitialize)(this.itemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label offensiveItemsLabel;
        private System.Windows.Forms.ComboBox offensiveItemsComboBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox itemPictureBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.ComboBox defensiveItemsComboBox;
        private System.Windows.Forms.Label defensiveItemsLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}