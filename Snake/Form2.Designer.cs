namespace Snake
{
    partial class GameOver_Screen
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
            this.button1 = new System.Windows.Forms.Button();
            this.GameOver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOver.Location = new System.Drawing.Point(145, 41);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(188, 39);
            this.GameOver.TabIndex = 2;
            this.GameOver.Text = "GameOver";
            // 
            // GameOver_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(469, 193);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.button1);
            this.Name = "GameOver_Screen";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.GameOver_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GameOver;
    }
}