namespace CryptoTycoon
{
    partial class HospitalForm
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
            this.healthLabel = new System.Windows.Forms.Label();
            this.recoveryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.costLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.hospitalPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.recoveryNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(13, 13);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(141, 13);
            this.healthLabel.TabIndex = 0;
            this.healthLabel.Text = "Amount of health to recover:";
            // 
            // recoveryNumericUpDown
            // 
            this.recoveryNumericUpDown.Location = new System.Drawing.Point(160, 11);
            this.recoveryNumericUpDown.Name = "recoveryNumericUpDown";
            this.recoveryNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.recoveryNumericUpDown.TabIndex = 1;
            this.recoveryNumericUpDown.ValueChanged += new System.EventHandler(this.recoveryNumericUpDown_ValueChanged);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(13, 46);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(46, 13);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Cost: $0";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(25, 107);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(92, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(132, 107);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // hospitalPictureBox
            // 
            this.hospitalPictureBox.Image = global::CryptoTycoon.Properties.Resources.tch;
            this.hospitalPictureBox.Location = new System.Drawing.Point(243, 11);
            this.hospitalPictureBox.Name = "hospitalPictureBox";
            this.hospitalPictureBox.Size = new System.Drawing.Size(198, 119);
            this.hospitalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hospitalPictureBox.TabIndex = 5;
            this.hospitalPictureBox.TabStop = false;
            // 
            // HospitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(453, 142);
            this.Controls.Add(this.hospitalPictureBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.recoveryNumericUpDown);
            this.Controls.Add(this.healthLabel);
            this.Name = "HospitalForm";
            this.Text = "Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.recoveryNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.NumericUpDown recoveryNumericUpDown;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox hospitalPictureBox;
    }
}