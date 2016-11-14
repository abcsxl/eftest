namespace DXEFTestApp
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
            this.bloggingContextView1 = new DXEFTestApp.Views.BloggingContextView.BloggingContextView();
            this.SuspendLayout();
            // 
            // bloggingContextView1
            // 
            this.bloggingContextView1.Appearance.BackColor = System.Drawing.Color.White;
            this.bloggingContextView1.Appearance.Options.UseBackColor = true;
            this.bloggingContextView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bloggingContextView1.Location = new System.Drawing.Point(0, 0);
            this.bloggingContextView1.Name = "bloggingContextView1";
            this.bloggingContextView1.Size = new System.Drawing.Size(753, 449);
            this.bloggingContextView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 449);
            this.Controls.Add(this.bloggingContextView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Views.BloggingContextView.BloggingContextView bloggingContextView1;
    }
}

