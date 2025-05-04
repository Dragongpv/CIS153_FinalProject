namespace CIS153_FinalGroupProject_Group6
{
    partial class form_gameOver
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
            this.lbl_winner = new System.Windows.Forms.Label();
            this.btn_review = new System.Windows.Forms.Button();
            this.btn_singlePlayer = new System.Windows.Forms.Button();
            this.btn_twoPlayer = new System.Windows.Forms.Button();
            this.btn_EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_winner.Location = new System.Drawing.Point(297, 12);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(0, 31);
            this.lbl_winner.TabIndex = 0;
            // 
            // btn_review
            // 
            this.btn_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_review.Location = new System.Drawing.Point(12, 402);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(175, 53);
            this.btn_review.TabIndex = 1;
            this.btn_review.Text = "Review ";
            this.btn_review.UseVisualStyleBackColor = true;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // btn_singlePlayer
            // 
            this.btn_singlePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_singlePlayer.Location = new System.Drawing.Point(193, 402);
            this.btn_singlePlayer.Name = "btn_singlePlayer";
            this.btn_singlePlayer.Size = new System.Drawing.Size(179, 53);
            this.btn_singlePlayer.TabIndex = 2;
            this.btn_singlePlayer.Text = "Single Player";
            this.btn_singlePlayer.UseVisualStyleBackColor = true;
            this.btn_singlePlayer.Click += new System.EventHandler(this.btn_singlePlayer_Click);
            // 
            // btn_twoPlayer
            // 
            this.btn_twoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_twoPlayer.Location = new System.Drawing.Point(574, 402);
            this.btn_twoPlayer.Name = "btn_twoPlayer";
            this.btn_twoPlayer.Size = new System.Drawing.Size(179, 53);
            this.btn_twoPlayer.TabIndex = 3;
            this.btn_twoPlayer.Text = "Two Player";
            this.btn_twoPlayer.UseVisualStyleBackColor = true;
            this.btn_twoPlayer.Click += new System.EventHandler(this.btn_twoPlayer_Click);
            // 
            // btn_EXIT
            // 
            this.btn_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_EXIT.Location = new System.Drawing.Point(759, 402);
            this.btn_EXIT.Name = "btn_EXIT";
            this.btn_EXIT.Size = new System.Drawing.Size(179, 53);
            this.btn_EXIT.TabIndex = 4;
            this.btn_EXIT.Text = "EXIT";
            this.btn_EXIT.UseVisualStyleBackColor = true;
            this.btn_EXIT.Click += new System.EventHandler(this.btn_EXIT_Click);
            // 
            // form_gameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 467);
            this.Controls.Add(this.btn_EXIT);
            this.Controls.Add(this.btn_twoPlayer);
            this.Controls.Add(this.btn_singlePlayer);
            this.Controls.Add(this.btn_review);
            this.Controls.Add(this.lbl_winner);
            this.Name = "form_gameOver";
            this.Text = "form_gameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Button btn_review;
        private System.Windows.Forms.Button btn_singlePlayer;
        private System.Windows.Forms.Button btn_twoPlayer;
        private System.Windows.Forms.Button btn_EXIT;
    }
}