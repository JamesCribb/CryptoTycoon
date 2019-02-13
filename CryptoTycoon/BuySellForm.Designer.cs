namespace CryptoTycoon
{
    partial class BuySellForm
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
            this.buySellLabel = new System.Windows.Forms.Label();
            this.buySellOkButton = new System.Windows.Forms.Button();
            this.buySellCancelButton = new System.Windows.Forms.Button();
            this.buySellNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxButton = new System.Windows.Forms.Button();
            this.halfButton = new System.Windows.Forms.Button();
            this.profitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buySellNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // buySellLabel
            // 
            this.buySellLabel.AutoSize = true;
            this.buySellLabel.Location = new System.Drawing.Point(13, 13);
            this.buySellLabel.Name = "buySellLabel";
            this.buySellLabel.Size = new System.Drawing.Size(271, 13);
            this.buySellLabel.TabIndex = 0;
            this.buySellLabel.Text = "How many units of X would you like to buy/sell? (Max Y)";
            // 
            // buySellOkButton
            // 
            this.buySellOkButton.Location = new System.Drawing.Point(16, 81);
            this.buySellOkButton.Name = "buySellOkButton";
            this.buySellOkButton.Size = new System.Drawing.Size(75, 23);
            this.buySellOkButton.TabIndex = 1;
            this.buySellOkButton.Text = "OK";
            this.buySellOkButton.UseVisualStyleBackColor = true;
            this.buySellOkButton.Click += new System.EventHandler(this.buySellOkButton_Click);
            // 
            // buySellCancelButton
            // 
            this.buySellCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buySellCancelButton.Location = new System.Drawing.Point(97, 81);
            this.buySellCancelButton.Name = "buySellCancelButton";
            this.buySellCancelButton.Size = new System.Drawing.Size(75, 23);
            this.buySellCancelButton.TabIndex = 2;
            this.buySellCancelButton.Text = "Cancel";
            this.buySellCancelButton.UseVisualStyleBackColor = true;
            // 
            // buySellNumericUpDown
            // 
            this.buySellNumericUpDown.Location = new System.Drawing.Point(16, 43);
            this.buySellNumericUpDown.Name = "buySellNumericUpDown";
            this.buySellNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.buySellNumericUpDown.TabIndex = 3;
            this.buySellNumericUpDown.ValueChanged += new System.EventHandler(this.buySellNumericUpDown_ValueChanged);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(142, 41);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(56, 23);
            this.maxButton.TabIndex = 4;
            this.maxButton.Text = "Sell Max";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // halfButton
            // 
            this.halfButton.Location = new System.Drawing.Point(204, 41);
            this.halfButton.Name = "halfButton";
            this.halfButton.Size = new System.Drawing.Size(56, 23);
            this.halfButton.TabIndex = 5;
            this.halfButton.Text = "Sell 50%";
            this.halfButton.UseVisualStyleBackColor = true;
            this.halfButton.Click += new System.EventHandler(this.halfButton_Click);
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Location = new System.Drawing.Point(191, 86);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(115, 13);
            this.profitLabel.TabIndex = 6;
            this.profitLabel.Text = "Profit per unit sold: $54";
            // 
            // BuySellForm
            // 
            this.AcceptButton = this.buySellOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buySellCancelButton;
            this.ClientSize = new System.Drawing.Size(352, 121);
            this.Controls.Add(this.profitLabel);
            this.Controls.Add(this.halfButton);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.buySellNumericUpDown);
            this.Controls.Add(this.buySellCancelButton);
            this.Controls.Add(this.buySellOkButton);
            this.Controls.Add(this.buySellLabel);
            this.Name = "BuySellForm";
            this.Text = "BuySellForm";
            ((System.ComponentModel.ISupportInitialize)(this.buySellNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buySellLabel;
        private System.Windows.Forms.Button buySellOkButton;
        private System.Windows.Forms.Button buySellCancelButton;
        private System.Windows.Forms.NumericUpDown buySellNumericUpDown;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button halfButton;
        private System.Windows.Forms.Label profitLabel;
    }
}