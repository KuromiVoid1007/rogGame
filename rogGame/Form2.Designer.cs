namespace rogGame
{
    partial class Form2
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
            this.buttomExitPlay = new System.Windows.Forms.PictureBox();
            this.buttonMusic2 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttomExitPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMusic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttomExitPlay
            // 
            this.buttomExitPlay.BackgroundImage = global::rogGame.Properties.Resources.buttonExitPlay;
            this.buttomExitPlay.Location = new System.Drawing.Point(100, 356);
            this.buttomExitPlay.Margin = new System.Windows.Forms.Padding(0);
            this.buttomExitPlay.Name = "buttomExitPlay";
            this.buttomExitPlay.Size = new System.Drawing.Size(160, 28);
            this.buttomExitPlay.TabIndex = 2;
            this.buttomExitPlay.TabStop = false;
            this.buttomExitPlay.Click += new System.EventHandler(this.buttomExitPlay_Click);
            // 
            // buttonMusic2
            // 
            this.buttonMusic2.BackgroundImage = global::rogGame.Properties.Resources.buttonMusic;
            this.buttonMusic2.Location = new System.Drawing.Point(100, 253);
            this.buttonMusic2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMusic2.Name = "buttonMusic2";
            this.buttonMusic2.Size = new System.Drawing.Size(160, 28);
            this.buttonMusic2.TabIndex = 1;
            this.buttonMusic2.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.BackgroundImage = global::rogGame.Properties.Resources.buttonStart;
            this.buttonStart.Location = new System.Drawing.Point(100, 150);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(160, 28);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.TabStop = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.buttomExitPlay);
            this.Controls.Add(this.buttonMusic2);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.buttomExitPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMusic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonStart;
        private System.Windows.Forms.PictureBox buttonMusic2;
        private System.Windows.Forms.PictureBox buttomExitPlay;
        private System.Windows.Forms.Button buttonMusic;
    }
}