namespace CIS153_FinalGroupProject_Group6
{
    partial class form_mainMenu
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
            this.btn_TwoPlayer = new System.Windows.Forms.Button();
            this.lbl_youGotThis = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.bttn_single = new System.Windows.Forms.Button();
            this.bttn_stats = new System.Windows.Forms.Button();
            this.lbl_game = new System.Windows.Forms.Label();
            this.lbl_rarrow = new System.Windows.Forms.Label();
            this.lbl_larrow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nofriends = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
=======
            this.btn_singleplayer = new System.Windows.Forms.Button();
            this.btn_stats = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
>>>>>>> c260ee2e4576bce661596ad60b929132b03aa44e
            this.SuspendLayout();
            // 
            // btn_TwoPlayer
            // 
<<<<<<< HEAD
            this.btn_TwoPlayer.Location = new System.Drawing.Point(546, 284);
=======
            this.btn_TwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_TwoPlayer.Location = new System.Drawing.Point(584, 56);
>>>>>>> c260ee2e4576bce661596ad60b929132b03aa44e
            this.btn_TwoPlayer.Name = "btn_TwoPlayer";
            this.btn_TwoPlayer.Size = new System.Drawing.Size(111, 73);
            this.btn_TwoPlayer.TabIndex = 0;
            this.btn_TwoPlayer.Text = "Two Player";
            this.btn_TwoPlayer.UseVisualStyleBackColor = true;
            this.btn_TwoPlayer.Click += new System.EventHandler(this.btn_TwoPlayer_Click);
            // 
            // lbl_youGotThis
            // 
            this.lbl_youGotThis.AutoSize = true;
            this.lbl_youGotThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_youGotThis.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_youGotThis.Location = new System.Drawing.Point(293, 9);
            this.lbl_youGotThis.Name = "lbl_youGotThis";
            this.lbl_youGotThis.Size = new System.Drawing.Size(180, 31);
            this.lbl_youGotThis.TabIndex = 1;
            this.lbl_youGotThis.Text = "You Got This!";
            // 
            // bttn_single
            // 
<<<<<<< HEAD
            this.bttn_single.Location = new System.Drawing.Point(101, 287);
            this.bttn_single.Name = "bttn_single";
            this.bttn_single.Size = new System.Drawing.Size(106, 73);
            this.bttn_single.TabIndex = 2;
            this.bttn_single.Text = "One Player";
            this.bttn_single.UseVisualStyleBackColor = true;
=======
            this.btn_singleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_singleplayer.Location = new System.Drawing.Point(39, 56);
            this.btn_singleplayer.Name = "btn_singleplayer";
            this.btn_singleplayer.Size = new System.Drawing.Size(174, 105);
            this.btn_singleplayer.TabIndex = 2;
            this.btn_singleplayer.Text = "Single Player";
            this.btn_singleplayer.UseVisualStyleBackColor = true;
            this.btn_singleplayer.Click += new System.EventHandler(this.btn_singleplayer_Click);
>>>>>>> c260ee2e4576bce661596ad60b929132b03aa44e
            // 
            // bttn_stats
            // 
<<<<<<< HEAD
            this.bttn_stats.Location = new System.Drawing.Point(326, 287);
            this.bttn_stats.Name = "bttn_stats";
            this.bttn_stats.Size = new System.Drawing.Size(108, 70);
            this.bttn_stats.TabIndex = 3;
            this.bttn_stats.Text = "Stats";
            this.bttn_stats.UseVisualStyleBackColor = true;
            // 
            // lbl_game
            // 
            this.lbl_game.AutoSize = true;
            this.lbl_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game.Location = new System.Drawing.Point(91, 45);
            this.lbl_game.Name = "lbl_game";
            this.lbl_game.Size = new System.Drawing.Size(558, 55);
            this.lbl_game.TabIndex = 4;
            this.lbl_game.Text = "Its time to play the game!";
            // 
            // lbl_rarrow
            // 
            this.lbl_rarrow.AutoSize = true;
            this.lbl_rarrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rarrow.Location = new System.Drawing.Point(41, 290);
            this.lbl_rarrow.Name = "lbl_rarrow";
            this.lbl_rarrow.Size = new System.Drawing.Size(59, 55);
            this.lbl_rarrow.TabIndex = 5;
            this.lbl_rarrow.Text = "⇒";
            // 
            // lbl_larrow
            // 
            this.lbl_larrow.AutoSize = true;
            this.lbl_larrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_larrow.Location = new System.Drawing.Point(663, 290);
            this.lbl_larrow.Name = "lbl_larrow";
            this.lbl_larrow.Size = new System.Drawing.Size(59, 55);
            this.lbl_larrow.TabIndex = 6;
            this.lbl_larrow.Text = "⇐";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 55);
            this.label4.TabIndex = 7;
            this.label4.Text = "⇗";
            // 
            // lbl_nofriends
            // 
            this.lbl_nofriends.AutoSize = true;
            this.lbl_nofriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nofriends.Location = new System.Drawing.Point(96, 259);
            this.lbl_nofriends.Name = "lbl_nofriends";
            this.lbl_nofriends.Size = new System.Drawing.Size(122, 25);
            this.lbl_nofriends.TabIndex = 8;
            this.lbl_nofriends.Text = "No friends?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(653, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 55);
            this.label6.TabIndex = 9;
            this.label6.Text = "⇖";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 55);
            this.label7.TabIndex = 10;
            this.label7.Text = "⇘";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 55);
            this.label8.TabIndex = 11;
            this.label8.Text = "⇑";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "⇓";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 55);
            this.label2.TabIndex = 13;
            this.label2.Text = "⇙";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Arrows are ways you can win the game!";
=======
            this.btn_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_stats.Location = new System.Drawing.Point(39, 312);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(174, 104);
            this.btn_stats.TabIndex = 3;
            this.btn_stats.Text = "Stats";
            this.btn_stats.UseVisualStyleBackColor = true;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
>>>>>>> c260ee2e4576bce661596ad60b929132b03aa44e
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_exit.Location = new System.Drawing.Point(584, 312);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(174, 104);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // form_mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< HEAD
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_nofriends);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_larrow);
            this.Controls.Add(this.lbl_rarrow);
            this.Controls.Add(this.lbl_game);
            this.Controls.Add(this.bttn_stats);
            this.Controls.Add(this.bttn_single);
=======
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_singleplayer);
>>>>>>> c260ee2e4576bce661596ad60b929132b03aa44e
            this.Controls.Add(this.lbl_youGotThis);
            this.Controls.Add(this.btn_TwoPlayer);
            this.Name = "form_mainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TwoPlayer;
        private System.Windows.Forms.Label lbl_youGotThis;
<<<<<<< HEAD
        private System.Windows.Forms.Button bttn_single;
        private System.Windows.Forms.Button bttn_stats;
        private System.Windows.Forms.Label lbl_game;
        private System.Windows.Forms.Label lbl_rarrow;
        private System.Windows.Forms.Label lbl_larrow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nofriends;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
=======
        private System.Windows.Forms.Button btn_singleplayer;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_exit;
>>>>>>> c260ee2e4576bce661596ad60b929132b03aa44e
    }
}

