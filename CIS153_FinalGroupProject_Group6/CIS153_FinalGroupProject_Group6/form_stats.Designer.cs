namespace CIS153_FinalGroupProject_Group6
{
    partial class form_stats
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
            this.lbl_playerWins = new System.Windows.Forms.Label();
            this.lbl__aiwins = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_ties = new System.Windows.Forms.Label();
            this.lbl_playerpct = new System.Windows.Forms.Label();
            this.lbl_aipct = new System.Windows.Forms.Label();
            this.lbl_statstitle = new System.Windows.Forms.Label();
            this.lbl_pWIns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_playerWins
            // 
            this.lbl_playerWins.AutoSize = true;
            this.lbl_playerWins.Location = new System.Drawing.Point(70, 124);
            this.lbl_playerWins.Name = "lbl_playerWins";
            this.lbl_playerWins.Size = new System.Drawing.Size(0, 13);
            this.lbl_playerWins.TabIndex = 0;
            // 
            // lbl__aiwins
            // 
            this.lbl__aiwins.AutoSize = true;
            this.lbl__aiwins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__aiwins.Location = new System.Drawing.Point(69, 163);
            this.lbl__aiwins.Name = "lbl__aiwins";
            this.lbl__aiwins.Size = new System.Drawing.Size(56, 20);
            this.lbl__aiwins.TabIndex = 1;
            this.lbl__aiwins.Text = "ai wins";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(70, 250);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(40, 20);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "total";
            // 
            // lbl_ties
            // 
            this.lbl_ties.AutoSize = true;
            this.lbl_ties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ties.Location = new System.Drawing.Point(70, 209);
            this.lbl_ties.Name = "lbl_ties";
            this.lbl_ties.Size = new System.Drawing.Size(34, 20);
            this.lbl_ties.TabIndex = 3;
            this.lbl_ties.Text = "ties";
            // 
            // lbl_playerpct
            // 
            this.lbl_playerpct.AutoSize = true;
            this.lbl_playerpct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerpct.Location = new System.Drawing.Point(69, 292);
            this.lbl_playerpct.Name = "lbl_playerpct";
            this.lbl_playerpct.Size = new System.Drawing.Size(72, 20);
            this.lbl_playerpct.TabIndex = 4;
            this.lbl_playerpct.Text = "player pc";
            // 
            // lbl_aipct
            // 
            this.lbl_aipct.AutoSize = true;
            this.lbl_aipct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aipct.Location = new System.Drawing.Point(69, 333);
            this.lbl_aipct.Name = "lbl_aipct";
            this.lbl_aipct.Size = new System.Drawing.Size(43, 20);
            this.lbl_aipct.TabIndex = 5;
            this.lbl_aipct.Text = "aipct";
            // 
            // lbl_statstitle
            // 
            this.lbl_statstitle.AutoSize = true;
            this.lbl_statstitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statstitle.Location = new System.Drawing.Point(264, 25);
            this.lbl_statstitle.Name = "lbl_statstitle";
            this.lbl_statstitle.Size = new System.Drawing.Size(97, 39);
            this.lbl_statstitle.TabIndex = 6;
            this.lbl_statstitle.Text = "Stats";
            // 
            // lbl_pWIns
            // 
            this.lbl_pWIns.AutoSize = true;
            this.lbl_pWIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pWIns.Location = new System.Drawing.Point(69, 124);
            this.lbl_pWIns.Name = "lbl_pWIns";
            this.lbl_pWIns.Size = new System.Drawing.Size(83, 20);
            this.lbl_pWIns.TabIndex = 7;
            this.lbl_pWIns.Text = "Playerwins";
            // 
            // form_stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_pWIns);
            this.Controls.Add(this.lbl_statstitle);
            this.Controls.Add(this.lbl_aipct);
            this.Controls.Add(this.lbl_playerpct);
            this.Controls.Add(this.lbl_ties);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl__aiwins);
            this.Controls.Add(this.lbl_playerWins);
            this.Name = "form_stats";
            this.Text = "form_stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_playerWins;
        private System.Windows.Forms.Label lbl__aiwins;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_ties;
        private System.Windows.Forms.Label lbl_playerpct;
        private System.Windows.Forms.Label lbl_aipct;
        private System.Windows.Forms.Label lbl_statstitle;
        private System.Windows.Forms.Label lbl_pWIns;
    }
}