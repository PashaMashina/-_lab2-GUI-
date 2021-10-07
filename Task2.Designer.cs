
namespace GUI
{
    partial class Task2
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
            this.label2 = new System.Windows.Forms.Label();
            this.inputBBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.answerBlable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputCBox = new System.Windows.Forms.TextBox();
            this.buttonTaskB = new System.Windows.Forms.Button();
            this.buttonTaskC = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.answerClable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 308);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(114, 51);
            this.back.TabIndex = 1;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Гражданин 1 марта открыл счет в банке, вложив A руб. \r\nЧерез каждый месяц размер " +
    "вклада увеличивается на 2% от имеющейся суммы.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "За какой месяц величина ежемесячного увеличения вклада превысит B руб.";
            // 
            // inputBBox
            // 
            this.inputBBox.Location = new System.Drawing.Point(122, 117);
            this.inputBBox.Name = "inputBBox";
            this.inputBBox.Size = new System.Drawing.Size(100, 23);
            this.inputBBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "B = \r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // answerBlable
            // 
            this.answerBlable.AutoSize = true;
            this.answerBlable.Location = new System.Drawing.Point(12, 166);
            this.answerBlable.Name = "answerBlable";
            this.answerBlable.Size = new System.Drawing.Size(342, 15);
            this.answerBlable.TabIndex = 7;
            this.answerBlable.Text = "___________________________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Через сколько месяцев размер вклада превысит C руб.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "С = ";
            // 
            // inputCBox
            // 
            this.inputCBox.Location = new System.Drawing.Point(122, 219);
            this.inputCBox.Name = "inputCBox";
            this.inputCBox.Size = new System.Drawing.Size(100, 23);
            this.inputCBox.TabIndex = 11;
            // 
            // buttonTaskB
            // 
            this.buttonTaskB.Location = new System.Drawing.Point(269, 117);
            this.buttonTaskB.Name = "buttonTaskB";
            this.buttonTaskB.Size = new System.Drawing.Size(149, 23);
            this.buttonTaskB.TabIndex = 13;
            this.buttonTaskB.Text = "Расчитать";
            this.buttonTaskB.UseVisualStyleBackColor = true;
            this.buttonTaskB.Click += new System.EventHandler(this.buttonTaskB_Click);
            // 
            // buttonTaskC
            // 
            this.buttonTaskC.Location = new System.Drawing.Point(269, 219);
            this.buttonTaskC.Name = "buttonTaskC";
            this.buttonTaskC.Size = new System.Drawing.Size(149, 23);
            this.buttonTaskC.TabIndex = 14;
            this.buttonTaskC.Text = "Расчитать";
            this.buttonTaskC.UseVisualStyleBackColor = true;
            this.buttonTaskC.Click += new System.EventHandler(this.buttonTaskC_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(374, 308);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 51);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Очистить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Первоначальный депозит(А) = ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(282, 52);
            this.depositBox.Name = "depositBox";
            this.depositBox.Size = new System.Drawing.Size(100, 23);
            this.depositBox.TabIndex = 17;
            // 
            // answerClable
            // 
            this.answerClable.AutoSize = true;
            this.answerClable.Location = new System.Drawing.Point(12, 275);
            this.answerClable.Name = "answerClable";
            this.answerClable.Size = new System.Drawing.Size(342, 15);
            this.answerClable.TabIndex = 19;
            this.answerClable.Text = "___________________________________________________________________";
            this.answerClable.Click += new System.EventHandler(this.answerClable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ответ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ответ:";
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 371);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.answerClable);
            this.Controls.Add(this.depositBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonTaskC);
            this.Controls.Add(this.buttonTaskB);
            this.Controls.Add(this.inputCBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.answerBlable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputBBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "Task2";
            this.Text = "Задание 2";
            this.Load += new System.EventHandler(this.Task2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label answerBlable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputCBox;
        private System.Windows.Forms.Button buttonTaskB;
        private System.Windows.Forms.Button buttonTaskC;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox depositBox;
        private System.Windows.Forms.Label answerClable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}