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
        public FormMain()
        {
            InitializeComponent();
            a = 0;
            b = 0;
            operation = eOperation.empty;
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Screen.AppendText((sender as Button).Text);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Screen.Text = string.Empty;
            operation = eOperation.empty;
        }
    }
}
