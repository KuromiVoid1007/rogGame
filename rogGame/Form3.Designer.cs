namespace rogGame
{
    partial class Form3
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
            this.buttonYes = new System.Windows.Forms.PictureBox();
            this.buttonNot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNot)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.Transparent;
            this.buttonYes.BackgroundImage = global::rogGame.Properties.Resources.buttonYes;
            this.buttonYes.Location = new System.Drawing.Point(23, 66);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(80, 22);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.TabStop = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNot
            // 
            this.buttonNot.BackColor = System.Drawing.Color.Transparent;
            this.buttonNot.BackgroundImage = global::rogGame.Properties.Resources.buttonNot;
            this.buttonNot.Location = new System.Drawing.Point(146, 66);
            this.buttonNot.Name = "buttonNot";
            this.buttonNot.Size = new System.Drawing.Size(80, 22);
            this.buttonNot.TabIndex = 1;
            this.buttonNot.TabStop = false;
            this.buttonNot.Click += new System.EventHandler(this.buttonNot_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::rogGame.Properties.Resources.FormClose2;
            this.ClientSize = new System.Drawing.Size(250, 140);
            this.Controls.Add(this.buttonNot);
            this.Controls.Add(this.buttonYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.buttonYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonYes;
        private System.Windows.Forms.PictureBox buttonNot;
    }
}