namespace CryptoTycoon
{
    partial class GameForm
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
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.travelButton = new System.Windows.Forms.Button();
            this.newDayButton = new System.Windows.Forms.Button();
            this.dayLabel = new System.Windows.Forms.Label();
            this.fundsLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.messagesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.coinsListView = new System.Windows.Forms.ListView();
            this.locationPictureBox = new System.Windows.Forms.PictureBox();
            this.healthLabel = new System.Windows.Forms.Label();
            this.hospitalButton = new System.Windows.Forms.Button();
            this.blackMarketButton = new System.Windows.Forms.Button();
            this.rankLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.locationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(613, 396);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(170, 23);
            this.buyButton.TabIndex = 3;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(613, 425);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(170, 23);
            this.sellButton.TabIndex = 4;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // travelButton
            // 
            this.travelButton.Location = new System.Drawing.Point(613, 512);
            this.travelButton.Name = "travelButton";
            this.travelButton.Size = new System.Drawing.Size(170, 23);
            this.travelButton.TabIndex = 5;
            this.travelButton.Text = "Travel...";
            this.travelButton.UseVisualStyleBackColor = true;
            this.travelButton.Click += new System.EventHandler(this.travelButton_Click);
            // 
            // newDayButton
            // 
            this.newDayButton.Location = new System.Drawing.Point(613, 541);
            this.newDayButton.Name = "newDayButton";
            this.newDayButton.Size = new System.Drawing.Size(170, 23);
            this.newDayButton.TabIndex = 6;
            this.newDayButton.Text = "New Day";
            this.newDayButton.UseVisualStyleBackColor = true;
            this.newDayButton.Click += new System.EventHandler(this.newDayButton_Click);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(12, 227);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(50, 20);
            this.dayLabel.TabIndex = 7;
            this.dayLabel.Text = "Day: ";
            // 
            // fundsLabel
            // 
            this.fundsLabel.AutoSize = true;
            this.fundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundsLabel.Location = new System.Drawing.Point(12, 271);
            this.fundsLabel.Name = "fundsLabel";
            this.fundsLabel.Size = new System.Drawing.Size(69, 20);
            this.fundsLabel.TabIndex = 8;
            this.fundsLabel.Text = "Funds: ";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(596, 226);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(88, 20);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location: ";
            // 
            // messagesRichTextBox
            // 
            this.messagesRichTextBox.Location = new System.Drawing.Point(16, 12);
            this.messagesRichTextBox.Name = "messagesRichTextBox";
            this.messagesRichTextBox.ReadOnly = true;
            this.messagesRichTextBox.Size = new System.Drawing.Size(779, 197);
            this.messagesRichTextBox.TabIndex = 11;
            this.messagesRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Change";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Average";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Inventory";
            // 
            // drugsListView
            // 
            this.coinsListView.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinsListView.FullRowSelect = true;
            this.coinsListView.Location = new System.Drawing.Point(12, 326);
            this.coinsListView.MultiSelect = false;
            this.coinsListView.Name = "drugsListView";
            this.coinsListView.Size = new System.Drawing.Size(572, 238);
            this.coinsListView.TabIndex = 18;
            this.coinsListView.UseCompatibleStateImageBehavior = false;
            this.coinsListView.View = System.Windows.Forms.View.List;
            // 
            // locationPictureBox
            // 
            this.locationPictureBox.Location = new System.Drawing.Point(604, 249);
            this.locationPictureBox.Name = "locationPictureBox";
            this.locationPictureBox.Size = new System.Drawing.Size(179, 134);
            this.locationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.locationPictureBox.TabIndex = 19;
            this.locationPictureBox.TabStop = false;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(397, 226);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(67, 20);
            this.healthLabel.TabIndex = 20;
            this.healthLabel.Text = "Health:";
            // 
            // hospitalButton
            // 
            this.hospitalButton.Location = new System.Drawing.Point(613, 454);
            this.hospitalButton.Name = "hospitalButton";
            this.hospitalButton.Size = new System.Drawing.Size(170, 23);
            this.hospitalButton.TabIndex = 21;
            this.hospitalButton.Text = "Hospital";
            this.hospitalButton.UseVisualStyleBackColor = true;
            this.hospitalButton.Click += new System.EventHandler(this.hospitalButton_Click);
            // 
            // blackMarketButton
            // 
            this.blackMarketButton.Location = new System.Drawing.Point(613, 483);
            this.blackMarketButton.Name = "blackMarketButton";
            this.blackMarketButton.Size = new System.Drawing.Size(170, 23);
            this.blackMarketButton.TabIndex = 22;
            this.blackMarketButton.Text = "Black Market";
            this.blackMarketButton.UseVisualStyleBackColor = true;
            this.blackMarketButton.Click += new System.EventHandler(this.blackMarketButton_Click);
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankLabel.Location = new System.Drawing.Point(131, 226);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(56, 20);
            this.rankLabel.TabIndex = 23;
            this.rankLabel.Text = "Rank:";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(305, 271);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(88, 20);
            this.inventoryLabel.TabIndex = 24;
            this.inventoryLabel.Text = "Inventory:";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 576);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.rankLabel);
            this.Controls.Add(this.blackMarketButton);
            this.Controls.Add(this.hospitalButton);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.locationPictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coinsListView);
            this.Controls.Add(this.messagesRichTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.fundsLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.newDayButton);
            this.Controls.Add(this.travelButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.buyButton);
            this.Name = "GameForm";
            this.Text = "Drug Lord 2.2";
            ((System.ComponentModel.ISupportInitialize)(this.locationPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button travelButton;
        private System.Windows.Forms.Button newDayButton;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label fundsLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.RichTextBox messagesRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView coinsListView;
        private System.Windows.Forms.PictureBox locationPictureBox;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Button hospitalButton;
        private System.Windows.Forms.Button blackMarketButton;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label inventoryLabel;
    }
}

