namespace Yatzy.Controls
{
    partial class InGameRollSystem
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitleTurn = new System.Windows.Forms.Label();
            this.btnDice = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cube5 = new System.Windows.Forms.PictureBox();
            this.cube2 = new System.Windows.Forms.PictureBox();
            this.cube4 = new System.Windows.Forms.PictureBox();
            this.cube3 = new System.Windows.Forms.PictureBox();
            this.cube1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cube5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleTurn
            // 
            this.lblTitleTurn.AutoSize = true;
            this.lblTitleTurn.Location = new System.Drawing.Point(17, 20);
            this.lblTitleTurn.Name = "lblTitleTurn";
            this.lblTitleTurn.Size = new System.Drawing.Size(81, 13);
            this.lblTitleTurn.TabIndex = 0;
            this.lblTitleTurn.Text = "It\'s your turn XX";
            // 
            // btnDice
            // 
            this.btnDice.Location = new System.Drawing.Point(20, 118);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(75, 23);
            this.btnDice.TabIndex = 6;
            this.btnDice.Text = "Roll (X)";
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(101, 118);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // cube5
            // 
            this.cube5.BackColor = System.Drawing.SystemColors.Control;
            this.cube5.Image = global::Yatzy.Properties.Resources.dice_1_md;
            this.cube5.Location = new System.Drawing.Point(228, 52);
            this.cube5.Name = "cube5";
            this.cube5.Size = new System.Drawing.Size(46, 44);
            this.cube5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cube5.TabIndex = 5;
            this.cube5.TabStop = false;
            this.cube5.Click += new System.EventHandler(this.cube5_Click);
            // 
            // cube2
            // 
            this.cube2.Image = global::Yatzy.Properties.Resources.dice_1_md;
            this.cube2.Location = new System.Drawing.Point(72, 52);
            this.cube2.Name = "cube2";
            this.cube2.Size = new System.Drawing.Size(46, 44);
            this.cube2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cube2.TabIndex = 4;
            this.cube2.TabStop = false;
            this.cube2.Click += new System.EventHandler(this.cube2_Click);
            // 
            // cube4
            // 
            this.cube4.Image = global::Yatzy.Properties.Resources.dice_1_md;
            this.cube4.Location = new System.Drawing.Point(176, 52);
            this.cube4.Name = "cube4";
            this.cube4.Size = new System.Drawing.Size(46, 44);
            this.cube4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cube4.TabIndex = 3;
            this.cube4.TabStop = false;
            this.cube4.Click += new System.EventHandler(this.cube4_Click);
            // 
            // cube3
            // 
            this.cube3.Image = global::Yatzy.Properties.Resources.dice_1_md;
            this.cube3.Location = new System.Drawing.Point(124, 52);
            this.cube3.Name = "cube3";
            this.cube3.Size = new System.Drawing.Size(46, 44);
            this.cube3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cube3.TabIndex = 2;
            this.cube3.TabStop = false;
            this.cube3.Click += new System.EventHandler(this.cube3_Click);
            // 
            // cube1
            // 
            this.cube1.Image = global::Yatzy.Properties.Resources.dice_1_md;
            this.cube1.Location = new System.Drawing.Point(20, 52);
            this.cube1.Name = "cube1";
            this.cube1.Size = new System.Drawing.Size(46, 44);
            this.cube1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cube1.TabIndex = 1;
            this.cube1.TabStop = false;
            this.cube1.Click += new System.EventHandler(this.cube1_Click);
            // 
            // InGameRollSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.cube5);
            this.Controls.Add(this.cube2);
            this.Controls.Add(this.cube4);
            this.Controls.Add(this.cube3);
            this.Controls.Add(this.cube1);
            this.Controls.Add(this.lblTitleTurn);
            this.Name = "InGameRollSystem";
            this.Size = new System.Drawing.Size(295, 155);
            ((System.ComponentModel.ISupportInitialize)(this.cube5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cube1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleTurn;
        private System.Windows.Forms.PictureBox cube1;
        private System.Windows.Forms.PictureBox cube3;
        private System.Windows.Forms.PictureBox cube4;
        private System.Windows.Forms.PictureBox cube2;
        private System.Windows.Forms.PictureBox cube5;
        private System.Windows.Forms.Button btnDice;
        private System.Windows.Forms.Button btnPlay;
    }
}
