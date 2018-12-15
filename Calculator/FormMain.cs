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

        string lastSign;

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

        private void button_change_sign_Click(object sender, EventArgs e)
        {
          //  lastSign = "-"
           // if (lastSign == ) Screen.AppendText("-");
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            Screen.AppendText(" " + (sender as Button).Text);
        }

        private void button_open_bracket_Click(object sender, EventArgs e)
        {
            Screen.AppendText(" " + (sender as Button).Text);
        }

        private void button_close_bracket_Click(object sender, EventArgs e)
        {
            Screen.AppendText(" " + (sender as Button).Text);
        }

        private void Number_Click(object sender, EventArgs e)
        {
          //  int x = Screen.ToInt32((sender as Button).Text);
          //  lastSign = x;
           // Screen.AppendText((sender as Button).Text);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Screen.Text = string.Empty;
            operation = eOperation.empty;
        }

        private void Button_Plus_Click(object sender, EventArgs e)
        {
            Screen.AppendText(" " + (sender as Button).Text + " ");
        }

        private void Button_Minus_Click(object sender, EventArgs e)
        {
            Screen.AppendText(" " + (sender as Button).Text + " ");
        }

        private void Button_Multi_Click(object sender, EventArgs e)
        {
            Screen.AppendText(" " + (sender as Button).Text + " ");
        }

        private void Button_Divide_Click(object sender, EventArgs e)
        {
            Screen.AppendText(" " + (sender as Button).Text + " ");
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Screen.Text))
            {
                MessageBox.Show("Введите число и выберите операцию");
                return;
            }            
        }

        #endregion

        #region Methods

        private void SetValueA()
        {
            if (string.IsNullOrWhiteSpace(Screen.Text))
            {
                MessageBox.Show("Сначала необходимо ввести первое число");
                return;
            }
            a = Convert.ToInt32(Screen.Text);
            Screen.Text = string.Empty;
        }




        #endregion


    }
}
