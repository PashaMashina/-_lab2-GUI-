using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GUI
{
    public partial class Task1 : Form
    {
        private void tb_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        Thread th;
        public Task1()
        {
            InitializeComponent();
            amountCost.Text = Properties.Settings.Default.cost.ToString();
            answerBox.Text = Properties.Settings.Default.answer;
            amountCost.KeyUp += tb_KeyUp;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open(object obj)
        {
            Application.Run(new Menu());
        }

        private void buttonOfTask1_Click(object sender, EventArgs e)
        {
            int cost;

            try
            {
                cost = int.Parse(this.amountCost.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cost > 9999)
            {
                MessageBox.Show("Введенно число больше 9999!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Properties.Settings.Default.cost = cost;

            var resultRubKop = Logic.RubKop(cost);
            var resultWords = Logic.WordsRubKop(resultRubKop.rub, resultRubKop.kop);

            string answer = resultRubKop.rub.ToString() + " " + resultWords.rubstr + " " + resultRubKop.kop.ToString() + " " + resultWords.kopstr;

            answerBox.Text = answer;

            Properties.Settings.Default.answer = answer;
            Properties.Settings.Default.Save();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            amountCost.Text = "";
            answerBox.Text = "";
        }

        public class ResultRubKop
        {
            public int rub;
            public int kop;
        }

        //Класс окончаний
        public class ResultWords
        {
            public string rubstr = "Рублей";
            public string kopstr = "Копеек";
        }

        public class Logic
        {
            public static ResultRubKop RubKop(int cost)
            {
                int _rub = cost / 100;
                int _kop = cost % 100;
                return new ResultRubKop
                {
                    rub = _rub,
                    kop = _kop
                };
            }
            public static ResultWords WordsRubKop(int rub, int kop)
            {
                string _rubstr = "Рублей";
                string _kopstr = "Копеек";
                if ((rub % 10 == 1) && (rub != 11))  //Определение окончания "Рубль"                                                                             
                {
                    _rubstr = "Рубль";
                }

                if ((kop % 10 == 1) && (kop != 11)) //Определение окончания "Копейка"
                {
                    _kopstr = "Копейка";
                }

                //Определение окончания "Рубля"
                if (((rub % 10 == 2) && (rub != 12)) || ((rub % 10 == 3) && (rub != 13)) || ((rub % 10 == 4) && (rub != 14)))
                {
                    _rubstr = "Рубля";
                }
                //Определение окончания "Копейки"
                if (((kop % 10 == 2) && (kop != 12)) || ((kop % 10 == 3) && (kop != 13)) || ((kop % 10 == 4) && (kop != 14)))
                {
                    _kopstr = "Копейки";
                }
                return new ResultWords
                {
                    rubstr = _rubstr,
                    kopstr = _kopstr
                };
            }
        }
    }
}
