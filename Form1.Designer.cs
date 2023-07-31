namespace RacingGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.picBox_car2 = new System.Windows.Forms.PictureBox();
            this.picBox_car1 = new System.Windows.Forms.PictureBox();
            this.picBox_road = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_HS = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_road)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.picBox_car2);
            this.panel1.Controls.Add(this.picBox_car1);
            this.panel1.Controls.Add(this.picBox_road);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 523);
            this.panel1.TabIndex = 0;
            // 
            // explosion
            // 
            this.explosion.Image = global::RacingGame.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(231, 314);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(48, 52);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 2;
            this.explosion.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::RacingGame.Properties.Resources.araba5;
            this.player.Location = new System.Drawing.Point(231, 361);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(58, 117);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // picBox_car2
            // 
            this.picBox_car2.Image = global::RacingGame.Properties.Resources.araba8;
            this.picBox_car2.Location = new System.Drawing.Point(359, 72);
            this.picBox_car2.Name = "picBox_car2";
            this.picBox_car2.Size = new System.Drawing.Size(80, 121);
            this.picBox_car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_car2.TabIndex = 1;
            this.picBox_car2.TabStop = false;
            // 
            // picBox_car1
            // 
            this.picBox_car1.Image = global::RacingGame.Properties.Resources.araba4;
            this.picBox_car1.Location = new System.Drawing.Point(101, 72);
            this.picBox_car1.Name = "picBox_car1";
            this.picBox_car1.Size = new System.Drawing.Size(60, 127);
            this.picBox_car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_car1.TabIndex = 1;
            this.picBox_car1.TabStop = false;
            // 
            // picBox_road
            // 
            this.picBox_road.Image = global::RacingGame.Properties.Resources.yol;
            this.picBox_road.Location = new System.Drawing.Point(-3, -251);
            this.picBox_road.Name = "picBox_road";
            this.picBox_road.Size = new System.Drawing.Size(513, 775);
            this.picBox_road.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_road.TabIndex = 0;
            this.picBox_road.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_score.Location = new System.Drawing.Point(116, 557);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(21, 22);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "0";
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_start.Location = new System.Drawing.Point(216, 595);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(92, 38);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(351, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "High Score:";
            // 
            // lbl_HS
            // 
            this.lbl_HS.AutoSize = true;
            this.lbl_HS.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_HS.Location = new System.Drawing.Point(476, 557);
            this.lbl_HS.Name = "lbl_HS";
            this.lbl_HS.Size = new System.Drawing.Size(21, 22);
            this.lbl_HS.TabIndex = 1;
            this.lbl_HS.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 685);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_HS);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Racing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_road)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBox_road;
        private System.Windows.Forms.PictureBox picBox_car1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox picBox_car2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_HS;
    }
}

