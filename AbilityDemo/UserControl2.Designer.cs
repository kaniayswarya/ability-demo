namespace AbilityDemo
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUser2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUser2
            // 
            this.txtUser2.Location = new System.Drawing.Point(3, 286);
            this.txtUser2.Name = "txtUser2";
            this.txtUser2.Size = new System.Drawing.Size(349, 31);
            this.txtUser2.TabIndex = 0;
            this.txtUser2.Text = "USER CONTROL 2";
            this.txtUser2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtUser2);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(519, 320);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUser2;
    }
}
