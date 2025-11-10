namespace Akia_MatchingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Playbtn = new System.Windows.Forms.Button();
            this.Quitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Playbtn
            // 
            this.Playbtn.BackColor = System.Drawing.Color.Transparent;
            this.Playbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Playbtn.BackgroundImage")));
            this.Playbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playbtn.FlatAppearance.BorderSize = 0;
            this.Playbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Playbtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playbtn.Location = new System.Drawing.Point(83, 363);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.Size = new System.Drawing.Size(191, 77);
            this.Playbtn.TabIndex = 1;
            this.Playbtn.UseVisualStyleBackColor = false;
            this.Playbtn.Click += new System.EventHandler(this.Playbtn_Click);
            // 
            // Quitbtn
            // 
            this.Quitbtn.BackColor = System.Drawing.Color.Transparent;
            this.Quitbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Quitbtn.BackgroundImage")));
            this.Quitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Quitbtn.FlatAppearance.BorderSize = 0;
            this.Quitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quitbtn.Location = new System.Drawing.Point(313, 368);
            this.Quitbtn.Name = "Quitbtn";
            this.Quitbtn.Size = new System.Drawing.Size(179, 68);
            this.Quitbtn.TabIndex = 2;
            this.Quitbtn.UseVisualStyleBackColor = false;
            this.Quitbtn.Click += new System.EventHandler(this.Quitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Quitbtn);
            this.Controls.Add(this.Playbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Playbtn;
        private System.Windows.Forms.Button Quitbtn;
    }
}

