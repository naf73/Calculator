using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormMain : Form
    {
        #region Variables

        int a;

        int b;

        eOperation operation;

        #endregion

        #region Constructors
        
        public FormMain()
        {
            InitializeComponent();
            a = 0;
            b = 0;
            operation = eOperation.empty;
        }

        #endregion

        #region Events

        
        private void Number_Click(object sender, EventArgs e)
        {
            Screen.AppendText((sender as Button).Text);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Screen.Text = string.Empty;
            operation = eOperation.empty;
        }

        private void Button_Plus_Click(object sender, EventArgs e)
        {
            operation = eOperation.addition;
            SetValueA();
        }

        private void Button_Minus_Click(object sender, EventArgs e)
        {
            operation = eOperation.subtraction;
            SetValueA();
        }

        private void Button_Multi_Click(object sender, EventArgs e)
        {
            operation = eOperation.multiplication;
            SetValueA();
        }

        private void Button_Divide_Click(object sender, EventArgs e)
        {
            operation = eOperation.division;
            SetValueA();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Screen.Text))
            {
                MessageBox.Show("Введите второе число");
                return;
            }

            b = Convert.ToInt32(Screen.Text);
            switch (operation)
            {
                case eOperation.empty:
                    MessageBox.Show("Выберите операцию и введите второе число");
                    break;
                case eOperation.addition:
                    break;
                case eOperation.subtraction:
                    break;
                case eOperation.multiplication:
                    break;
                case eOperation.division:
                    break;
                default:
                    MessageBox.Show("Ошибка операции");
                    break;
            }
        }

        #endregion

        #region Methods

        private void SetValueA()
        {
            a = Convert.ToInt32(Screen.Text);
            Screen.Text = string.Empty;
        }

        #endregion
    }
}
