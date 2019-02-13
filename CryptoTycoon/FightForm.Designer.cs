namespace CryptoTycoon
{
    partial class FightForm
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
            this.fightMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.enemyPictureBox = new System.Windows.Forms.PictureBox();
            this.fightButton = new System.Windows.Forms.Button();
            this.fleeButton = new System.Windows.Forms.Button();
            this.enemyHealthLabel = new System.Windows.Forms.Label();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerHealthPanel = new System.Windows.Forms.Panel();
            this.enemyHealthPanel = new System.Windows.Forms.Panel();
            this.weaponListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fightMessageRichTextBox
            // 
            this.fightMessageRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.fightMessageRichTextBox.Name = "fightMessageRichTextBox";
            this.fightMessageRichTextBox.ReadOnly = true;
            this.fightMessageRichTextBox.Size = new System.Drawing.Size(512, 186);
            this.fightMessageRichTextBox.TabIndex = 0;
            this.fightMessageRichTextBox.Text = "";
            // 
            // enemyPictureBox
            // 
            this.enemyPictureBox.Location = new System.Drawing.Point(530, 12);
            this.enemyPictureBox.Name = "enemyPictureBox";
            this.enemyPictureBox.Size = new System.Drawing.Size(166, 186);
            this.enemyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPictureBox.TabIndex = 1;
            this.enemyPictureBox.TabStop = false;
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(13, 415);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(154, 23);
            this.fightButton.TabIndex = 2;
            this.fightButton.Text = "Fight!";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // fleeButton
            // 
            this.fleeButton.Location = new System.Drawing.Point(547, 415);
            this.fleeButton.Name = "fleeButton";
            this.fleeButton.Size = new System.Drawing.Size(149, 23);
            this.fleeButton.TabIndex = 4;
            this.fleeButton.Text = "Try to Flee";
            this.fleeButton.UseVisualStyleBackColor = true;
            this.fleeButton.Click += new System.EventHandler(this.fleeButton_Click);
            // 
            // enemyHealthLabel
            // 
            this.enemyHealthLabel.AutoSize = true;
            this.enemyHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyHealthLabel.Location = new System.Drawing.Point(366, 209);
            this.enemyHealthLabel.Name = "enemyHealthLabel";
            this.enemyHealthLabel.Size = new System.Drawing.Size(68, 20);
            this.enemyHealthLabel.TabIndex = 5;
            this.enemyHealthLabel.Text = "Enemy:";
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealthLabel.Location = new System.Drawing.Point(12, 208);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(63, 20);
            this.playerHealthLabel.TabIndex = 6;
            this.playerHealthLabel.Text = "Player:";
            // 
            // playerHealthPanel
            // 
            this.playerHealthPanel.Location = new System.Drawing.Point(78, 204);
            this.playerHealthPanel.Name = "playerHealthPanel";
            this.playerHealthPanel.Size = new System.Drawing.Size(200, 30);
            this.playerHealthPanel.TabIndex = 7;
            this.playerHealthPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.playerHealthPanel_Paint);
            // 
            // enemyHealthPanel
            // 
            this.enemyHealthPanel.Location = new System.Drawing.Point(496, 204);
            this.enemyHealthPanel.Name = "enemyHealthPanel";
            this.enemyHealthPanel.Size = new System.Drawing.Size(200, 30);
            this.enemyHealthPanel.TabIndex = 8;
            this.enemyHealthPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.enemyHealthPanel_Paint);
            // 
            // weaponListBox
            // 
            this.weaponListBox.FormattingEnabled = true;
            this.weaponListBox.Location = new System.Drawing.Point(13, 274);
            this.weaponListBox.Name = "weaponListBox";
            this.weaponListBox.Size = new System.Drawing.Size(154, 134);
            this.weaponListBox.TabIndex = 10;
            this.weaponListBox.SelectedIndexChanged += new System.EventHandler(this.weaponListBox_SelectedIndexChanged);
            // 
            // FightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.weaponListBox);
            this.Controls.Add(this.enemyHealthPanel);
            this.Controls.Add(this.playerHealthPanel);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.enemyHealthLabel);
            this.Controls.Add(this.fleeButton);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.enemyPictureBox);
            this.Controls.Add(this.fightMessageRichTextBox);
            this.Name = "FightForm";
            this.Text = "Fight";
            ((System.ComponentModel.ISupportInitialize)(this.enemyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox fightMessageRichTextBox;
        private System.Windows.Forms.PictureBox enemyPictureBox;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Button fleeButton;
        private System.Windows.Forms.Label enemyHealthLabel;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.Panel playerHealthPanel;
        private System.Windows.Forms.Panel enemyHealthPanel;
        private System.Windows.Forms.ListBox weaponListBox;
    }
}