using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOAD_HR_System.Controller;

namespace OOAD_HR_System
{
    public partial class _login : Form
    {

        private Form _mainFunction;
        private LoginController _loginController = new LoginController();

        public _login()
        {
            InitializeComponent();
        }

        private void ClickLoginButton(object sender, EventArgs e)
        {
            String emplID = _employeeID.Text;
            String password = _password.Text;

            if (_loginController.judgeAccountAndPassword(emplID, password))
            {
                _mainFunction = new _female(this);
                _mainFunction.Show();
                this.Visible = false;
            }
        }
    }
}
