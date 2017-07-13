namespace WindowsFormsApplication2
{
    partial class takeSelfieForm
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
            this.Discover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Discover
            // 
            this.Discover.Location = new System.Drawing.Point(247, 634);
            this.Discover.Name = "Discover";
            this.Discover.Size = new System.Drawing.Size(120, 23);
            this.Discover.TabIndex = 0;
            this.Discover.Text = "Take Selfie With Her";
            this.Discover.UseVisualStyleBackColor = true;
            this.Discover.Click += new System.EventHandler(this.button1_Click);
            // 
            // takeSelfieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(624, 741);
            this.Controls.Add(this.Discover);
            this.MaximumSize = new System.Drawing.Size(640, 960);
            this.Name = "takeSelfieForm";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "takeSelfieForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Discover;
    }
}