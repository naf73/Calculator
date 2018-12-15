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
