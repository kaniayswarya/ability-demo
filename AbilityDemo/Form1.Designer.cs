namespace AbilityDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUserCtrl1 = new System.Windows.Forms.Button();
            this.btnUserCtrl2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserCtrl1
            // 
            this.btnUserCtrl1.Location = new System.Drawing.Point(12, 356);
            this.btnUserCtrl1.Name = "btnUserCtrl1";
            this.btnUserCtrl1.Size = new System.Drawing.Size(161, 56);
            this.btnUserCtrl1.TabIndex = 0;
            this.btnUserCtrl1.Text = "ADD UC1";
            this.btnUserCtrl1.UseVisualStyleBackColor = true;
            this.btnUserCtrl1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUserCtrl2
            // 
            this.btnUserCtrl2.Location = new System.Drawing.Point(627, 356);
            this.btnUserCtrl2.Name = "btnUserCtrl2";
            this.btnUserCtrl2.Size = new System.Drawing.Size(139, 56);
            this.btnUserCtrl2.TabIndex = 1;
            this.btnUserCtrl2.Text = "ADD UC2";
            this.btnUserCtrl2.UseVisualStyleBackColor = true;
            this.btnUserCtrl2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserCtrl2);
            this.Controls.Add(this.btnUserCtrl1);
            this.Name = "Form1";
            this.Text = "Ability Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUserCtrl1;
        private Button btnUserCtrl2;
    }
}