namespace THA_W8_Megan_R
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.comboBox_player = new System.Windows.Forms.ComboBox();
            this.label_pName = new System.Windows.Forms.Label();
            this.label_tName = new System.Windows.Forms.Label();
            this.label_pos = new System.Windows.Forms.Label();
            this.label_sNum = new System.Windows.Forms.Label();
            this.label_yCard = new System.Windows.Forms.Label();
            this.label_rCard = new System.Windows.Forms.Label();
            this.label_goal = new System.Windows.Forms.Label();
            this.label_ownGoal = new System.Windows.Forms.Label();
            this.label_gPenalty = new System.Windows.Forms.Label();
            this.label_pMissed = new System.Windows.Forms.Label();
            this.label_nat = new System.Windows.Forms.Label();
            this.label_whatpName = new System.Windows.Forms.Label();
            this.label_whattName = new System.Windows.Forms.Label();
            this.label_whatPos = new System.Windows.Forms.Label();
            this.label_whatsNum = new System.Windows.Forms.Label();
            this.label_whatyCard = new System.Windows.Forms.Label();
            this.label_whatrCard = new System.Windows.Forms.Label();
            this.label_whatGoal = new System.Windows.Forms.Label();
            this.label_whatownGoal = new System.Windows.Forms.Label();
            this.label_whatgPenalty = new System.Windows.Forms.Label();
            this.label_whatpMissed = new System.Windows.Forms.Label();
            this.label_whatNat = new System.Windows.Forms.Label();
            this.comboBox_teamlagi = new System.Windows.Forms.ComboBox();
            this.comboBox_pilih = new System.Windows.Forms.ComboBox();
            this.dataGridView_home = new System.Windows.Forms.DataGridView();
            this.dataGridView_lainnya = new System.Windows.Forms.DataGridView();
            this.dataGridView_away = new System.Windows.Forms.DataGridView();
            this.label_homeTeam = new System.Windows.Forms.Label();
            this.label_awayTeam = new System.Windows.Forms.Label();
            this.label_Details = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lainnya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_away)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.showMatchDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.playerDataToolStripMenuItem.Text = "Player Data";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click);
            // 
            // showMatchDetailsToolStripMenuItem
            // 
            this.showMatchDetailsToolStripMenuItem.Name = "showMatchDetailsToolStripMenuItem";
            this.showMatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.showMatchDetailsToolStripMenuItem.Text = "Show Match Details";
            this.showMatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMatchDetailsToolStripMenuItem_Click);
            // 
            // comboBox_team
            // 
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(25, 40);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(121, 21);
            this.comboBox_team.TabIndex = 1;
            this.comboBox_team.SelectionChangeCommitted += new System.EventHandler(this.comboBox_team_SelectionChangeCommitted);
            // 
            // comboBox_player
            // 
            this.comboBox_player.FormattingEnabled = true;
            this.comboBox_player.Location = new System.Drawing.Point(152, 40);
            this.comboBox_player.Name = "comboBox_player";
            this.comboBox_player.Size = new System.Drawing.Size(121, 21);
            this.comboBox_player.TabIndex = 2;
            this.comboBox_player.SelectionChangeCommitted += new System.EventHandler(this.comboBox_player_SelectionChangeCommitted);
            // 
            // label_pName
            // 
            this.label_pName.AutoSize = true;
            this.label_pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pName.Location = new System.Drawing.Point(37, 100);
            this.label_pName.Name = "label_pName";
            this.label_pName.Size = new System.Drawing.Size(82, 13);
            this.label_pName.TabIndex = 3;
            this.label_pName.Text = "Player Name:";
            // 
            // label_tName
            // 
            this.label_tName.AutoSize = true;
            this.label_tName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tName.Location = new System.Drawing.Point(37, 125);
            this.label_tName.Name = "label_tName";
            this.label_tName.Size = new System.Drawing.Size(78, 13);
            this.label_tName.TabIndex = 4;
            this.label_tName.Text = "Team Name:";
            // 
            // label_pos
            // 
            this.label_pos.AutoSize = true;
            this.label_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pos.Location = new System.Drawing.Point(37, 155);
            this.label_pos.Name = "label_pos";
            this.label_pos.Size = new System.Drawing.Size(56, 13);
            this.label_pos.TabIndex = 5;
            this.label_pos.Text = "Position:";
            // 
            // label_sNum
            // 
            this.label_sNum.AutoSize = true;
            this.label_sNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sNum.Location = new System.Drawing.Point(37, 183);
            this.label_sNum.Name = "label_sNum";
            this.label_sNum.Size = new System.Drawing.Size(94, 13);
            this.label_sNum.TabIndex = 6;
            this.label_sNum.Text = "Squad Number:";
            // 
            // label_yCard
            // 
            this.label_yCard.AutoSize = true;
            this.label_yCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_yCard.Location = new System.Drawing.Point(37, 212);
            this.label_yCard.Name = "label_yCard";
            this.label_yCard.Size = new System.Drawing.Size(78, 13);
            this.label_yCard.TabIndex = 7;
            this.label_yCard.Text = "Yellow Card:";
            // 
            // label_rCard
            // 
            this.label_rCard.AutoSize = true;
            this.label_rCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rCard.Location = new System.Drawing.Point(37, 238);
            this.label_rCard.Name = "label_rCard";
            this.label_rCard.Size = new System.Drawing.Size(64, 13);
            this.label_rCard.TabIndex = 8;
            this.label_rCard.Text = "Red Card:";
            // 
            // label_goal
            // 
            this.label_goal.AutoSize = true;
            this.label_goal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_goal.Location = new System.Drawing.Point(37, 264);
            this.label_goal.Name = "label_goal";
            this.label_goal.Size = new System.Drawing.Size(37, 13);
            this.label_goal.TabIndex = 9;
            this.label_goal.Text = "Goal:";
            // 
            // label_ownGoal
            // 
            this.label_ownGoal.AutoSize = true;
            this.label_ownGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ownGoal.Location = new System.Drawing.Point(37, 289);
            this.label_ownGoal.Name = "label_ownGoal";
            this.label_ownGoal.Size = new System.Drawing.Size(66, 13);
            this.label_ownGoal.TabIndex = 10;
            this.label_ownGoal.Text = "Own Goal:";
            // 
            // label_gPenalty
            // 
            this.label_gPenalty.AutoSize = true;
            this.label_gPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gPenalty.Location = new System.Drawing.Point(37, 317);
            this.label_gPenalty.Name = "label_gPenalty";
            this.label_gPenalty.Size = new System.Drawing.Size(83, 13);
            this.label_gPenalty.TabIndex = 11;
            this.label_gPenalty.Text = "Goal Penalty:";
            // 
            // label_pMissed
            // 
            this.label_pMissed.AutoSize = true;
            this.label_pMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pMissed.Location = new System.Drawing.Point(37, 344);
            this.label_pMissed.Name = "label_pMissed";
            this.label_pMissed.Size = new System.Drawing.Size(96, 13);
            this.label_pMissed.TabIndex = 12;
            this.label_pMissed.Text = "Penalty Missed:";
            // 
            // label_nat
            // 
            this.label_nat.AutoSize = true;
            this.label_nat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nat.Location = new System.Drawing.Point(37, 373);
            this.label_nat.Name = "label_nat";
            this.label_nat.Size = new System.Drawing.Size(71, 13);
            this.label_nat.TabIndex = 13;
            this.label_nat.Text = "Nationality:";
            // 
            // label_whatpName
            // 
            this.label_whatpName.AutoSize = true;
            this.label_whatpName.Location = new System.Drawing.Point(149, 100);
            this.label_whatpName.Name = "label_whatpName";
            this.label_whatpName.Size = new System.Drawing.Size(10, 13);
            this.label_whatpName.TabIndex = 14;
            this.label_whatpName.Text = "-";
            // 
            // label_whattName
            // 
            this.label_whattName.AutoSize = true;
            this.label_whattName.Location = new System.Drawing.Point(149, 125);
            this.label_whattName.Name = "label_whattName";
            this.label_whattName.Size = new System.Drawing.Size(10, 13);
            this.label_whattName.TabIndex = 15;
            this.label_whattName.Text = "-";
            // 
            // label_whatPos
            // 
            this.label_whatPos.AutoSize = true;
            this.label_whatPos.Location = new System.Drawing.Point(149, 373);
            this.label_whatPos.Name = "label_whatPos";
            this.label_whatPos.Size = new System.Drawing.Size(10, 13);
            this.label_whatPos.TabIndex = 16;
            this.label_whatPos.Text = "-";
            // 
            // label_whatsNum
            // 
            this.label_whatsNum.AutoSize = true;
            this.label_whatsNum.Location = new System.Drawing.Point(149, 155);
            this.label_whatsNum.Name = "label_whatsNum";
            this.label_whatsNum.Size = new System.Drawing.Size(10, 13);
            this.label_whatsNum.TabIndex = 17;
            this.label_whatsNum.Text = "-";
            // 
            // label_whatyCard
            // 
            this.label_whatyCard.AutoSize = true;
            this.label_whatyCard.Location = new System.Drawing.Point(149, 183);
            this.label_whatyCard.Name = "label_whatyCard";
            this.label_whatyCard.Size = new System.Drawing.Size(10, 13);
            this.label_whatyCard.TabIndex = 18;
            this.label_whatyCard.Text = "-";
            // 
            // label_whatrCard
            // 
            this.label_whatrCard.AutoSize = true;
            this.label_whatrCard.Location = new System.Drawing.Point(149, 212);
            this.label_whatrCard.Name = "label_whatrCard";
            this.label_whatrCard.Size = new System.Drawing.Size(10, 13);
            this.label_whatrCard.TabIndex = 19;
            this.label_whatrCard.Text = "-";
            // 
            // label_whatGoal
            // 
            this.label_whatGoal.AutoSize = true;
            this.label_whatGoal.Location = new System.Drawing.Point(149, 238);
            this.label_whatGoal.Name = "label_whatGoal";
            this.label_whatGoal.Size = new System.Drawing.Size(10, 13);
            this.label_whatGoal.TabIndex = 20;
            this.label_whatGoal.Text = "-";
            // 
            // label_whatownGoal
            // 
            this.label_whatownGoal.AutoSize = true;
            this.label_whatownGoal.Location = new System.Drawing.Point(149, 264);
            this.label_whatownGoal.Name = "label_whatownGoal";
            this.label_whatownGoal.Size = new System.Drawing.Size(10, 13);
            this.label_whatownGoal.TabIndex = 21;
            this.label_whatownGoal.Text = "-";
            // 
            // label_whatgPenalty
            // 
            this.label_whatgPenalty.AutoSize = true;
            this.label_whatgPenalty.Location = new System.Drawing.Point(149, 289);
            this.label_whatgPenalty.Name = "label_whatgPenalty";
            this.label_whatgPenalty.Size = new System.Drawing.Size(10, 13);
            this.label_whatgPenalty.TabIndex = 22;
            this.label_whatgPenalty.Text = "-";
            // 
            // label_whatpMissed
            // 
            this.label_whatpMissed.AutoSize = true;
            this.label_whatpMissed.Location = new System.Drawing.Point(149, 317);
            this.label_whatpMissed.Name = "label_whatpMissed";
            this.label_whatpMissed.Size = new System.Drawing.Size(10, 13);
            this.label_whatpMissed.TabIndex = 23;
            this.label_whatpMissed.Text = "-";
            // 
            // label_whatNat
            // 
            this.label_whatNat.AutoSize = true;
            this.label_whatNat.Location = new System.Drawing.Point(149, 344);
            this.label_whatNat.Name = "label_whatNat";
            this.label_whatNat.Size = new System.Drawing.Size(10, 13);
            this.label_whatNat.TabIndex = 24;
            this.label_whatNat.Text = "-";
            // 
            // comboBox_teamlagi
            // 
            this.comboBox_teamlagi.FormattingEnabled = true;
            this.comboBox_teamlagi.Location = new System.Drawing.Point(477, 40);
            this.comboBox_teamlagi.Name = "comboBox_teamlagi";
            this.comboBox_teamlagi.Size = new System.Drawing.Size(121, 21);
            this.comboBox_teamlagi.TabIndex = 25;
            this.comboBox_teamlagi.SelectionChangeCommitted += new System.EventHandler(this.comboBox_teamlagi_SelectionChangeCommitted);
            // 
            // comboBox_pilih
            // 
            this.comboBox_pilih.FormattingEnabled = true;
            this.comboBox_pilih.Location = new System.Drawing.Point(604, 40);
            this.comboBox_pilih.Name = "comboBox_pilih";
            this.comboBox_pilih.Size = new System.Drawing.Size(121, 21);
            this.comboBox_pilih.TabIndex = 26;
            this.comboBox_pilih.SelectionChangeCommitted += new System.EventHandler(this.comboBox_pilih_SelectionChangeCommitted);
            // 
            // dataGridView_home
            // 
            this.dataGridView_home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_home.Location = new System.Drawing.Point(338, 89);
            this.dataGridView_home.Name = "dataGridView_home";
            this.dataGridView_home.Size = new System.Drawing.Size(260, 150);
            this.dataGridView_home.TabIndex = 27;
            // 
            // dataGridView_lainnya
            // 
            this.dataGridView_lainnya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lainnya.Location = new System.Drawing.Point(375, 264);
            this.dataGridView_lainnya.Name = "dataGridView_lainnya";
            this.dataGridView_lainnya.Size = new System.Drawing.Size(469, 169);
            this.dataGridView_lainnya.TabIndex = 28;
            // 
            // dataGridView_away
            // 
            this.dataGridView_away.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_away.Location = new System.Drawing.Point(613, 89);
            this.dataGridView_away.Name = "dataGridView_away";
            this.dataGridView_away.Size = new System.Drawing.Size(259, 150);
            this.dataGridView_away.TabIndex = 29;
            // 
            // label_homeTeam
            // 
            this.label_homeTeam.AutoSize = true;
            this.label_homeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_homeTeam.Location = new System.Drawing.Point(434, 71);
            this.label_homeTeam.Name = "label_homeTeam";
            this.label_homeTeam.Size = new System.Drawing.Size(12, 15);
            this.label_homeTeam.TabIndex = 30;
            this.label_homeTeam.Text = "-";
            // 
            // label_awayTeam
            // 
            this.label_awayTeam.AutoSize = true;
            this.label_awayTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_awayTeam.Location = new System.Drawing.Point(703, 71);
            this.label_awayTeam.Name = "label_awayTeam";
            this.label_awayTeam.Size = new System.Drawing.Size(12, 15);
            this.label_awayTeam.TabIndex = 31;
            this.label_awayTeam.Text = "-";
            // 
            // label_Details
            // 
            this.label_Details.AutoSize = true;
            this.label_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Details.Location = new System.Drawing.Point(559, 246);
            this.label_Details.Name = "label_Details";
            this.label_Details.Size = new System.Drawing.Size(12, 15);
            this.label_Details.TabIndex = 32;
            this.label_Details.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 458);
            this.Controls.Add(this.label_Details);
            this.Controls.Add(this.label_awayTeam);
            this.Controls.Add(this.label_homeTeam);
            this.Controls.Add(this.dataGridView_away);
            this.Controls.Add(this.dataGridView_lainnya);
            this.Controls.Add(this.dataGridView_home);
            this.Controls.Add(this.comboBox_pilih);
            this.Controls.Add(this.comboBox_teamlagi);
            this.Controls.Add(this.label_whatNat);
            this.Controls.Add(this.label_whatpMissed);
            this.Controls.Add(this.label_whatgPenalty);
            this.Controls.Add(this.label_whatownGoal);
            this.Controls.Add(this.label_whatGoal);
            this.Controls.Add(this.label_whatrCard);
            this.Controls.Add(this.label_whatyCard);
            this.Controls.Add(this.label_whatsNum);
            this.Controls.Add(this.label_whatPos);
            this.Controls.Add(this.label_whattName);
            this.Controls.Add(this.label_whatpName);
            this.Controls.Add(this.label_nat);
            this.Controls.Add(this.label_pMissed);
            this.Controls.Add(this.label_gPenalty);
            this.Controls.Add(this.label_ownGoal);
            this.Controls.Add(this.label_goal);
            this.Controls.Add(this.label_rCard);
            this.Controls.Add(this.label_yCard);
            this.Controls.Add(this.label_sNum);
            this.Controls.Add(this.label_pos);
            this.Controls.Add(this.label_tName);
            this.Controls.Add(this.label_pName);
            this.Controls.Add(this.comboBox_player);
            this.Controls.Add(this.comboBox_team);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lainnya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_away)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMatchDetailsToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.ComboBox comboBox_player;
        private System.Windows.Forms.Label label_pName;
        private System.Windows.Forms.Label label_tName;
        private System.Windows.Forms.Label label_pos;
        private System.Windows.Forms.Label label_sNum;
        private System.Windows.Forms.Label label_yCard;
        private System.Windows.Forms.Label label_rCard;
        private System.Windows.Forms.Label label_goal;
        private System.Windows.Forms.Label label_ownGoal;
        private System.Windows.Forms.Label label_gPenalty;
        private System.Windows.Forms.Label label_pMissed;
        private System.Windows.Forms.Label label_nat;
        private System.Windows.Forms.Label label_whatpName;
        private System.Windows.Forms.Label label_whattName;
        private System.Windows.Forms.Label label_whatPos;
        private System.Windows.Forms.Label label_whatsNum;
        private System.Windows.Forms.Label label_whatyCard;
        private System.Windows.Forms.Label label_whatrCard;
        private System.Windows.Forms.Label label_whatGoal;
        private System.Windows.Forms.Label label_whatownGoal;
        private System.Windows.Forms.Label label_whatgPenalty;
        private System.Windows.Forms.Label label_whatpMissed;
        private System.Windows.Forms.Label label_whatNat;
        private System.Windows.Forms.ComboBox comboBox_teamlagi;
        private System.Windows.Forms.ComboBox comboBox_pilih;
        private System.Windows.Forms.DataGridView dataGridView_home;
        private System.Windows.Forms.DataGridView dataGridView_lainnya;
        private System.Windows.Forms.DataGridView dataGridView_away;
        private System.Windows.Forms.Label label_homeTeam;
        private System.Windows.Forms.Label label_awayTeam;
        private System.Windows.Forms.Label label_Details;
    }
}

