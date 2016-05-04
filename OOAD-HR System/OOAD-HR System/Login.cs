using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_HR_System
{
    public partial class _login : Form
    {

        private Form _mainFunction;

        public _login()
        {
            InitializeComponent();
        }

        private void ClickLoginButton(object sender, EventArgs e)
        {
            _mainFunction = new _mainFunction(this);
            _mainFunction.Show();
            this.Visible = false;
        }
    }
}
