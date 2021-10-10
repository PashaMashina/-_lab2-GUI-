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
    public partial class Task2 : Form
    {
        private void tb_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        Thread th;
        public Task2()
        {
            InitializeComponent();
            depositBox.Text = Properties.Settings.Default.deposit.ToString();
            inputBBox.Text = Properties.Settings.Default.B.ToString();
            inputCBox.Text = Properties.Settings.Default.C.ToString();
            answerClable.Text = Properties.Settings.Default.answerC;
            answerBlable.Text = Properties.Settings.Default.answerB;

            depositBox.KeyUp += tb_KeyUp;
            inputBBox.KeyUp += tb_KeyUp;
            inputCBox.KeyUp += tb_KeyUp;
        }
        private void depositBox_TextChanged(object sender, EventArgs e)
        {

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            depositBox.Text = "";
            answerClable.Text = "___________________________________________________________________";
            answerBlable.Text = "___________________________________________________________________";
            inputBBox.Text = "";
            inputCBox.Text = "";
        }

        private void buttonTaskB_Click(object sender, EventArgs e)
        {
            double deposit;
            double B;
            try
            {
                deposit = double.Parse(this.depositBox.Text);   
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод депозита", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (deposit <= 0)
            {
                MessageBox.Show("Введёный депозит меньше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Properties.Settings.Default.deposit = deposit;
            try
            {
                B = double.Parse(this.inputBBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод B", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (B <= 0)
            {
                MessageBox.Show("Введёный B меньше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Properties.Settings.Default.B = B;

            var resultMonth = Logic2.Task1(deposit, B);
            var resultYear = Logic2.Year((Logic2.NumberOfMonth(deposit, B, 0)), 3);
            string answerB = "За "+ resultMonth + " " + resultYear + " года величина ежемесячного увеличения вклада превысит " + B + " руб.";

            answerBlable.Text = answerB;

            Properties.Settings.Default.answerB = answerB;
            Properties.Settings.Default.Save();
        }

        private void buttonTaskC_Click(object sender, EventArgs e)
        {
            double deposit;
            double C;
            try
            {
                deposit = double.Parse(this.depositBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод депозита", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (deposit <= 0)
            {
                MessageBox.Show("Введёный депозит меньше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Properties.Settings.Default.deposit = deposit;
            try
            {
                C = double.Parse(this.inputCBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод C", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (C <= 0)
            {
                MessageBox.Show("Введёный C меньше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Properties.Settings.Default.C = C;

            var resultDeposit = Logic2.Task2(deposit, C);
            string answerC = "Через " + resultDeposit + " месяцев размер вклада превысит " + C + " руб";

            answerClable.Text = answerC;

            Properties.Settings.Default.answerC = answerC;
            //Properties.Settings.Default.Save();
        }
    }
    public class Months
    {
        public static string month1 = "Январь";
        public static string month2 = "Февраль";
        public static string month3 = "Март";
        public static string month4 = "Апрель";
        public static string month5 = "Май";
        public static string month6 = "Июнь";
        public static string month7 = "Июль";
        public static string month8 = "Август";
        public static string month9 = "Сентябрь";
        public static string month10 = "Октябрь";
        public static string month11 = "Ноябрь";
        public static string month12 = "Декабрь";
    }

    public class Logic2
    {
        public static int NumberOfMonth(double deposit, double B, int amonth)
        {
            double perMonth = 0;

            for (int i = 1; perMonth <= B; i++)
            {
                perMonth = deposit * 0.02;
                deposit = deposit + perMonth;
                amonth = i;
            }
            return amonth;
        }
        public static int Year(int amonth, int thisMonth)
        {
            int thisYear = 2021;
            for (int i = 1; amonth > 0; i++)
            {
                thisMonth++;
                if (thisMonth == 13)
                {
                    thisMonth = 1;
                    thisYear++;
                }
                amonth--;
            }
            return thisYear;
        }
        public static int ThisNumberMonth(int amonth, int thisMonth)
        {
            thisMonth++;
            for (int i = 1; amonth >= 0; i++)
            {
                thisMonth++;
                if (thisMonth == 13)
                {
                    thisMonth = 1;
                }
                amonth--;
            }
            return thisMonth;
        }
        public static string Task1(double deposit, double B)
        {
            string strThisMonth = Months.month3;


            int amonth = 0;

            Year(amonth, ThisNumberMonth(NumberOfMonth(deposit, B, 3), 0));

            switch (ThisNumberMonth(NumberOfMonth(deposit, B, 3), 0))
            {
                case 1:
                    strThisMonth = Months.month1;
                    break;
                case 2:
                    strThisMonth = Months.month2;
                    break;
                case 3:
                    strThisMonth = Months.month3;
                    break;
                case 4:
                    strThisMonth = Months.month4;
                    break;
                case 5:
                    strThisMonth = Months.month5;
                    break;
                case 6:
                    strThisMonth = Months.month6;
                    break;
                case 7:
                    strThisMonth = Months.month7;
                    break;
                case 8:
                    strThisMonth = Months.month8;
                    break;
                case 9:
                    strThisMonth = Months.month9;
                    break;
                case 10:
                    strThisMonth = Months.month10;
                    break;
                case 11:
                    strThisMonth = Months.month11;
                    break;
                case 12:
                    strThisMonth = Months.month12;
                    break;
                case 13:
                    strThisMonth = Months.month12;
                    break;
            }
            return strThisMonth;
        }

        public static int Task2(double deposit, double C)
        {
            int bmonth = 0;

            double perMonth = 0;

            for (int i = 1; deposit <= C; i++)
            {
                perMonth = deposit * 0.02;
                deposit = deposit + perMonth;
                bmonth = i;
            }
            return bmonth;
        }

    }
}
