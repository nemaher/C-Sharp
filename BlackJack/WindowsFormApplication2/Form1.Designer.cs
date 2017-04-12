namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            this.DealersHand = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PlayersHand = new System.Windows.Forms.TextBox();
            this.Bet = new System.Windows.Forms.TextBox();
            this.TotalMoney = new System.Windows.Forms.TextBox();
            this.PlayerTotal = new System.Windows.Forms.TextBox();
            this.DealerTotal = new System.Windows.Forms.TextBox();
            this.Stay = new System.Windows.Forms.Button();
            this.Hit = new System.Windows.Forms.Button();
            this.Deal = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.Label();
            this.TotalChips = new System.Windows.Forms.Label();
            this.BetLabel = new System.Windows.Forms.Label();
            this.DealersTotal = new System.Windows.Forms.Label();
            this.PlayersTotal = new System.Windows.Forms.Label();
            this.Dealer = new System.Windows.Forms.Label();
            this.CashOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DealersHand
            // 
            this.DealersHand.Location = new System.Drawing.Point(190, 41);
            this.DealersHand.Name = "DealersHand";
            this.DealersHand.Size = new System.Drawing.Size(179, 20);
            this.DealersHand.TabIndex = 0;
            this.DealersHand.TextChanged += new System.EventHandler(this.DealersHand_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PlayersHand
            // 
            this.PlayersHand.Location = new System.Drawing.Point(190, 167);
            this.PlayersHand.Name = "PlayersHand";
            this.PlayersHand.Size = new System.Drawing.Size(179, 20);
            this.PlayersHand.TabIndex = 2;
            // 
            // Bet
            // 
            this.Bet.Location = new System.Drawing.Point(25, 126);
            this.Bet.Name = "Bet";
            this.Bet.Size = new System.Drawing.Size(100, 20);
            this.Bet.TabIndex = 3;
            this.Bet.TextChanged += new System.EventHandler(this.BetTextBox_TextChanged);
            // 
            // TotalMoney
            // 
            this.TotalMoney.Location = new System.Drawing.Point(25, 41);
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.Size = new System.Drawing.Size(100, 20);
            this.TotalMoney.TabIndex = 4;
            this.TotalMoney.TextChanged += new System.EventHandler(this.TotalMoney_TextChanged);
            // 
            // PlayerTotal
            // 
            this.PlayerTotal.Location = new System.Drawing.Point(429, 167);
            this.PlayerTotal.Name = "PlayerTotal";
            this.PlayerTotal.Size = new System.Drawing.Size(54, 20);
            this.PlayerTotal.TabIndex = 5;
            this.PlayerTotal.TextChanged += new System.EventHandler(this.PlayerTotal_TextChanged_1);
            // 
            // DealerTotal
            // 
            this.DealerTotal.Location = new System.Drawing.Point(429, 41);
            this.DealerTotal.Name = "DealerTotal";
            this.DealerTotal.Size = new System.Drawing.Size(54, 20);
            this.DealerTotal.TabIndex = 6;
            this.DealerTotal.TextChanged += new System.EventHandler(this.DealerTotal_TextChanged);
            // 
            // Stay
            // 
            this.Stay.Location = new System.Drawing.Point(294, 243);
            this.Stay.Name = "Stay";
            this.Stay.Size = new System.Drawing.Size(75, 23);
            this.Stay.TabIndex = 7;
            this.Stay.Text = "Stay";
            this.Stay.UseVisualStyleBackColor = true;
            this.Stay.Click += new System.EventHandler(this.Stay_Click);
            // 
            // Hit
            // 
            this.Hit.Location = new System.Drawing.Point(190, 243);
            this.Hit.Name = "Hit";
            this.Hit.Size = new System.Drawing.Size(75, 23);
            this.Hit.TabIndex = 8;
            this.Hit.Text = "Hit";
            this.Hit.UseVisualStyleBackColor = true;
            this.Hit.Click += new System.EventHandler(this.Hit_Click);
            // 
            // Deal
            // 
            this.Deal.Location = new System.Drawing.Point(242, 108);
            this.Deal.Name = "Deal";
            this.Deal.Size = new System.Drawing.Size(75, 23);
            this.Deal.TabIndex = 9;
            this.Deal.Text = "Deal";
            this.Deal.UseVisualStyleBackColor = true;
            this.Deal.Click += new System.EventHandler(this.Deal_Click);
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Location = new System.Drawing.Point(262, 201);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(36, 13);
            this.Player.TabIndex = 10;
            this.Player.Text = "Player";
            // 
            // TotalChips
            // 
            this.TotalChips.AutoSize = true;
            this.TotalChips.Location = new System.Drawing.Point(44, 81);
            this.TotalChips.Name = "TotalChips";
            this.TotalChips.Size = new System.Drawing.Size(57, 13);
            this.TotalChips.TabIndex = 11;
            this.TotalChips.Text = "TotalChips";
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.Location = new System.Drawing.Point(59, 167);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(23, 13);
            this.BetLabel.TabIndex = 12;
            this.BetLabel.Text = "Bet";
            // 
            // DealersTotal
            // 
            this.DealersTotal.AutoSize = true;
            this.DealersTotal.Location = new System.Drawing.Point(426, 81);
            this.DealersTotal.Name = "DealersTotal";
            this.DealersTotal.Size = new System.Drawing.Size(72, 13);
            this.DealersTotal.TabIndex = 13;
            this.DealersTotal.Text = "Dealer\'s Total";
            // 
            // PlayersTotal
            // 
            this.PlayersTotal.AutoSize = true;
            this.PlayersTotal.Location = new System.Drawing.Point(426, 201);
            this.PlayersTotal.Name = "PlayersTotal";
            this.PlayersTotal.Size = new System.Drawing.Size(70, 13);
            this.PlayersTotal.TabIndex = 14;
            this.PlayersTotal.Text = "Player\'s Total";
            // 
            // Dealer
            // 
            this.Dealer.AutoSize = true;
            this.Dealer.Location = new System.Drawing.Point(262, 81);
            this.Dealer.Name = "Dealer";
            this.Dealer.Size = new System.Drawing.Size(38, 13);
            this.Dealer.TabIndex = 15;
            this.Dealer.Text = "Dealer";
            // 
            // CashOut
            // 
            this.CashOut.Location = new System.Drawing.Point(38, 243);
            this.CashOut.Name = "CashOut";
            this.CashOut.Size = new System.Drawing.Size(75, 23);
            this.CashOut.TabIndex = 16;
            this.CashOut.Text = "Cash Out";
            this.CashOut.UseVisualStyleBackColor = true;
            this.CashOut.Click += new System.EventHandler(this.CashOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 338);
            this.Controls.Add(this.CashOut);
            this.Controls.Add(this.Dealer);
            this.Controls.Add(this.PlayersTotal);
            this.Controls.Add(this.DealersTotal);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.TotalChips);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Deal);
            this.Controls.Add(this.Hit);
            this.Controls.Add(this.Stay);
            this.Controls.Add(this.DealerTotal);
            this.Controls.Add(this.PlayerTotal);
            this.Controls.Add(this.TotalMoney);
            this.Controls.Add(this.Bet);
            this.Controls.Add(this.PlayersHand);
            this.Controls.Add(this.DealersHand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DealersHand;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox PlayersHand;
        private System.Windows.Forms.TextBox Bet;
        private System.Windows.Forms.TextBox TotalMoney;
        private System.Windows.Forms.TextBox PlayerTotal;
        private System.Windows.Forms.TextBox DealerTotal;
        private System.Windows.Forms.Button Stay;
        private System.Windows.Forms.Button Hit;
        private System.Windows.Forms.Button Deal;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Label TotalChips;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.Label DealersTotal;
        private System.Windows.Forms.Label PlayersTotal;
        private System.Windows.Forms.Label Dealer;
        private System.Windows.Forms.Button CashOut;
    }
}

