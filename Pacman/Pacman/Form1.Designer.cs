namespace Pacman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picturegrape = new System.Windows.Forms.PictureBox();
            this.pictureghost_red = new System.Windows.Forms.PictureBox();
            this.picturecherry = new System.Windows.Forms.PictureBox();
            this.pictureghost_pink = new System.Windows.Forms.PictureBox();
            this.picture_pacman = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelN = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelpacman = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.Btn_scores = new System.Windows.Forms.Button();
            this.buttonjugar = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturegrape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureghost_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturecherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureghost_pink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturegrape
            // 
            this.picturegrape.Image = global::Pacman.Properties.Resources.tile114;
            this.picturegrape.Location = new System.Drawing.Point(464, 278);
            this.picturegrape.Name = "picturegrape";
            this.picturegrape.Size = new System.Drawing.Size(21, 20);
            this.picturegrape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturegrape.TabIndex = 5;
            this.picturegrape.TabStop = false;
            // 
            // pictureghost_red
            // 
            this.pictureghost_red.Image = global::Pacman.Properties.Resources.red_left1;
            this.pictureghost_red.InitialImage = global::Pacman.Properties.Resources.red_left1;
            this.pictureghost_red.Location = new System.Drawing.Point(465, 104);
            this.pictureghost_red.Name = "pictureghost_red";
            this.pictureghost_red.Size = new System.Drawing.Size(20, 20);
            this.pictureghost_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureghost_red.TabIndex = 4;
            this.pictureghost_red.TabStop = false;
            this.pictureghost_red.Tag = "ghost";
            // 
            // picturecherry
            // 
            this.picturecherry.Image = global::Pacman.Properties.Resources.cherry;
            this.picturecherry.Location = new System.Drawing.Point(88, 278);
            this.picturecherry.Name = "picturecherry";
            this.picturecherry.Size = new System.Drawing.Size(21, 20);
            this.picturecherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturecherry.TabIndex = 3;
            this.picturecherry.TabStop = false;
            // 
            // pictureghost_pink
            // 
            this.pictureghost_pink.Image = global::Pacman.Properties.Resources.pink_left1;
            this.pictureghost_pink.InitialImage = global::Pacman.Properties.Resources.pink_left1;
            this.pictureghost_pink.Location = new System.Drawing.Point(165, 104);
            this.pictureghost_pink.Name = "pictureghost_pink";
            this.pictureghost_pink.Size = new System.Drawing.Size(20, 20);
            this.pictureghost_pink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureghost_pink.TabIndex = 2;
            this.pictureghost_pink.TabStop = false;
            this.pictureghost_pink.Tag = "ghost";
            // 
            // picture_pacman
            // 
            this.picture_pacman.Image = global::Pacman.Properties.Resources.pacman_right1;
            this.picture_pacman.InitialImage = ((System.Drawing.Image)(resources.GetObject("picture_pacman.InitialImage")));
            this.picture_pacman.Location = new System.Drawing.Point(272, 196);
            this.picture_pacman.Name = "picture_pacman";
            this.picture_pacman.Size = new System.Drawing.Size(20, 20);
            this.picture_pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_pacman.TabIndex = 1;
            this.picture_pacman.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Location = new System.Drawing.Point(1, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(602, 15);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(1, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 15);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox3.Location = new System.Drawing.Point(1, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 379);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox4.Location = new System.Drawing.Point(587, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 379);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "wall";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonjugar);
            this.panel1.Controls.Add(this.Btn_scores);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.labelN);
            this.panel1.Controls.Add(this.labelB);
            this.panel1.Controls.Add(this.labelpacman);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 379);
            this.panel1.TabIndex = 10;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(150, 195);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(38, 13);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "Name:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(197, 101);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(147, 34);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "Welcome!!";
            // 
            // labelpacman
            // 
            this.labelpacman.AutoSize = true;
            this.labelpacman.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpacman.Location = new System.Drawing.Point(195, 55);
            this.labelpacman.Name = "labelpacman";
            this.labelpacman.Size = new System.Drawing.Size(167, 46);
            this.labelpacman.TabIndex = 0;
            this.labelpacman.Text = "Pacman";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(203, 192);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(141, 20);
            this.textBoxNombre.TabIndex = 11;
            // 
            // Btn_scores
            // 
            this.Btn_scores.Location = new System.Drawing.Point(260, 255);
            this.Btn_scores.Name = "Btn_scores";
            this.Btn_scores.Size = new System.Drawing.Size(75, 23);
            this.Btn_scores.TabIndex = 12;
            this.Btn_scores.Text = "Scores";
            this.Btn_scores.UseVisualStyleBackColor = true;
            // 
            // buttonjugar
            // 
            this.buttonjugar.Location = new System.Drawing.Point(153, 255);
            this.buttonjugar.Name = "buttonjugar";
            this.buttonjugar.Size = new System.Drawing.Size(75, 23);
            this.buttonjugar.TabIndex = 13;
            this.buttonjugar.Text = "Play";
            this.buttonjugar.UseVisualStyleBackColor = true;
            this.buttonjugar.Click += new System.EventHandler(this.buttonjugar_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(9, 7);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(44, 13);
            this.labelScore.TabIndex = 14;
            this.labelScore.Text = "Score : ";
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame.Location = new System.Drawing.Point(201, 58);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(0, 60);
            this.labelGame.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 414);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picturegrape);
            this.Controls.Add(this.pictureghost_red);
            this.Controls.Add(this.picturecherry);
            this.Controls.Add(this.pictureghost_pink);
            this.Controls.Add(this.picture_pacman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picturegrape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureghost_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturecherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureghost_pink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_pacman;
        private System.Windows.Forms.PictureBox pictureghost_pink;
        private System.Windows.Forms.PictureBox picturecherry;
        private System.Windows.Forms.PictureBox pictureghost_red;
        private System.Windows.Forms.PictureBox picturegrape;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelpacman;
        private System.Windows.Forms.Button buttonjugar;
        private System.Windows.Forms.Button Btn_scores;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelGame;
    }
}

