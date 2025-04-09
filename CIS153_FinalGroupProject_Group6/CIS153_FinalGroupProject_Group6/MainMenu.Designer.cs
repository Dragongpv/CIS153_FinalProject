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
            this.SuspendLayout();
            // 
            // btn_TwoPlayer
            // 
            this.btn_TwoPlayer.Location = new System.Drawing.Point(630, 338);
            this.btn_TwoPlayer.Name = "btn_TwoPlayer";
            this.btn_TwoPlayer.Size = new System.Drawing.Size(158, 100);
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
            // form_mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

