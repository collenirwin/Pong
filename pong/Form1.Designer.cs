namespace pong {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.Label();
            this.ai = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblScores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.player.ForeColor = System.Drawing.Color.SeaGreen;
            this.player.Location = new System.Drawing.Point(12, 170);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(16, 54);
            this.player.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 394);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.ForeColor = System.Drawing.Color.SeaGreen;
            this.ball.Location = new System.Drawing.Point(368, 189);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(16, 16);
            this.ball.TabIndex = 2;
            this.ball.Tag = "";
            // 
            // ai
            // 
            this.ai.BackColor = System.Drawing.Color.IndianRed;
            this.ai.ForeColor = System.Drawing.Color.SeaGreen;
            this.ai.Location = new System.Drawing.Point(724, 170);
            this.ai.Name = "ai";
            this.ai.Size = new System.Drawing.Size(16, 54);
            this.ai.TabIndex = 3;
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblScores
            // 
            this.lblScores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblScores.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.Color.White;
            this.lblScores.Location = new System.Drawing.Point(328, 9);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(96, 25);
            this.lblScores.TabIndex = 4;
            this.lblScores.Tag = " to ";
            this.lblScores.Text = "0 to 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 394);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.ai);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ball;
        private System.Windows.Forms.Label ai;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblScores;
    }
}

