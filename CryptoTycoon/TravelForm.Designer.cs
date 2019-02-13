namespace CryptoTycoon
{
    partial class TravelForm
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
            this.travelLabel = new System.Windows.Forms.Label();
            this.travelComboBox = new System.Windows.Forms.ComboBox();
            this.travelOkButton = new System.Windows.Forms.Button();
            this.travelCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // travelLabel
            // 
            this.travelLabel.AutoSize = true;
            this.travelLabel.Location = new System.Drawing.Point(13, 13);
            this.travelLabel.Name = "travelLabel";
            this.travelLabel.Size = new System.Drawing.Size(126, 13);
            this.travelLabel.TabIndex = 0;
            this.travelLabel.Text = "Select Travel Destination";
            // 
            // travelComboBox
            // 
            this.travelComboBox.FormattingEnabled = true;
            this.travelComboBox.Location = new System.Drawing.Point(16, 39);
            this.travelComboBox.Name = "travelComboBox";
            this.travelComboBox.Size = new System.Drawing.Size(121, 21);
            this.travelComboBox.TabIndex = 1;
            this.travelComboBox.SelectedIndexChanged += new System.EventHandler(this.travelComboBox_SelectedIndexChanged);
            // 
            // travelOkButton
            // 
            this.travelOkButton.Location = new System.Drawing.Point(16, 77);
            this.travelOkButton.Name = "travelOkButton";
            this.travelOkButton.Size = new System.Drawing.Size(75, 23);
            this.travelOkButton.TabIndex = 2;
            this.travelOkButton.Text = "OK";
            this.travelOkButton.UseVisualStyleBackColor = true;
            this.travelOkButton.Click += new System.EventHandler(this.travelOkButton_Click);
            // 
            // travelCancelButton
            // 
            this.travelCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.travelCancelButton.Location = new System.Drawing.Point(107, 77);
            this.travelCancelButton.Name = "travelCancelButton";
            this.travelCancelButton.Size = new System.Drawing.Size(75, 23);
            this.travelCancelButton.TabIndex = 3;
            this.travelCancelButton.Text = "Cancel";
            this.travelCancelButton.UseVisualStyleBackColor = true;
            // 
            // TravelForm
            // 
            this.AcceptButton = this.travelOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.travelCancelButton;
            this.ClientSize = new System.Drawing.Size(206, 116);
            this.Controls.Add(this.travelCancelButton);
            this.Controls.Add(this.travelOkButton);
            this.Controls.Add(this.travelComboBox);
            this.Controls.Add(this.travelLabel);
            this.Name = "TravelForm";
            this.Text = "Travel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label travelLabel;
        private System.Windows.Forms.ComboBox travelComboBox;
        private System.Windows.Forms.Button travelOkButton;
        private System.Windows.Forms.Button travelCancelButton;
    }
}