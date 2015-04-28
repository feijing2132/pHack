using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int sleepTime = 20;
        private int switchTime = 50;
        private string totalNumber = "100";
        public Form1()
        {
            InitializeComponent();
            textBoxNumber.Text = totalNumber;
        }

        private void buttonNoPay_Click(object sender, EventArgs e)
        {
            setTotalNumber();
            preHandle();
        }

        private void buttonYesPay_Click(object sender, EventArgs e)
        {
            setTotalNumber();
            preHandle();
            downAndPay();
        }

        private void preHandle()
        {
            SendKeys.Send("%{TAB}");
            Thread.Sleep(switchTime);
            int tabCount = int.Parse(textBoxTapcount.Text);
            for (int i = 0; i < tabCount; i++ )
            {
                SendKeys.Send("{TAB}");
                Thread.Sleep(sleepTime);
            }
            SendKeys.Send(totalNumber);
            Thread.Sleep(sleepTime);
        }

        private void downAndPay()
        {
            SendKeys.Send("{TAB}");
            Thread.Sleep(sleepTime);
            SendKeys.Send("{ENTER}");
            Thread.Sleep(sleepTime);
            //SendKeys.Send("{ENTER}");
            //Thread.Sleep(sleepTime);
        }

        private void buttonDirPay_Click(object sender, EventArgs e)
        {
            setTotalNumber();
            SendKeys.Send("%{TAB}");
            Thread.Sleep(switchTime);
            SendKeys.Send(totalNumber);
            Thread.Sleep(sleepTime);
            downAndPay();
        }

        private void setTotalNumber()
        {
            if (radioButton1.Checked)
            {
                totalNumber = radioButton1.Text;
                return;
            }

            if (radioButton2.Checked)
            {
                totalNumber = radioButton2.Text;
                return;
            }

            if (radioButton3.Checked)
            {
                totalNumber = radioButton3.Text;
                return;
            }

            if (radioButton4.Checked)
            {
                totalNumber = radioButton4.Text;
                return;
            }

            if (radioButton5.Checked)
            {
                totalNumber = radioButton5.Text;
                return;
            }

            if (radioButton6.Checked)
            {
                totalNumber = radioButton6.Text;
                return;
            }
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            radioButton6.Text = textBoxNumber.Text;
            radioButton6.Checked = true;
        }
    }
}
