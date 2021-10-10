
namespace GUI
{
    partial class Task1
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
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amountCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOfTask1 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 107);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(114, 51);
            this.back.TabIndex = 4;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дано натуральное число 1 ≤ n ≤ 9999, определяющее стоимость товара в копейках. \r\n" +
    "Выразить стоимость в рублях и копейках, например, 3 рубля 21 копейка, 15 рублей " +
    "5 копеек, 1 рубль ровно и т. п.";
            // 
            // amountCost
            // 
            this.amountCost.Location = new System.Drawing.Point(360, 52);
            this.amountCost.Name = "amountCost";
            this.amountCost.Size = new System.Drawing.Size(146, 23);
            this.amountCost.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стоимость товара в копейках:";
            // 
            // buttonOfTask1
            // 
            this.buttonOfTask1.Location = new System.Drawing.Point(276, 121);
            this.buttonOfTask1.Name = "buttonOfTask1";
            this.buttonOfTask1.Size = new System.Drawing.Size(114, 37);
            this.buttonOfTask1.TabIndex = 3;
            this.buttonOfTask1.Text = "Выполнить";
            this.buttonOfTask1.UseVisualStyleBackColor = true;
            this.buttonOfTask1.Click += new System.EventHandler(this.buttonOfTask1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(534, 107);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 51);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Очистить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(360, 81);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(146, 23);
            this.answerBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ответ:";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 170);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonOfTask1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "Task1";
            this.Text = "Задание 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOfTask1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label label3;
    }
}