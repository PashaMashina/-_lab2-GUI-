
namespace GUI
{
    partial class Menu
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
            this.exp1 = new System.Windows.Forms.Button();
            this.exp2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exp1
            // 
            this.exp1.Location = new System.Drawing.Point(22, 29);
            this.exp1.Name = "exp1";
            this.exp1.Size = new System.Drawing.Size(134, 56);
            this.exp1.TabIndex = 0;
            this.exp1.Text = "Задание 1";
            this.exp1.UseVisualStyleBackColor = true;
            this.exp1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exp2
            // 
            this.exp2.Location = new System.Drawing.Point(183, 29);
            this.exp2.Name = "exp2";
            this.exp2.Size = new System.Drawing.Size(134, 56);
            this.exp2.TabIndex = 1;
            this.exp2.Text = "Задание 2";
            this.exp2.UseVisualStyleBackColor = true;
            this.exp2.Click += new System.EventHandler(this.exp2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 118);
            this.Controls.Add(this.exp2);
            this.Controls.Add(this.exp1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exp1;
        private System.Windows.Forms.Button exp2;
    }
}

