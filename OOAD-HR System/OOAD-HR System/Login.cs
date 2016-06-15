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

        private Form _nextForm;
        private LoginController _loginController = new LoginController();

        public _login()
        {
            InitializeComponent();
        }

        private void ClickLoginButton(object sender, EventArgs e)
        {
            String emplID = _employeeID.Text;
            String password = _password.Text;

            int authoValue = _loginController.judgeAccountAndPassword(emplID, password);
            if (authoValue > 0)
            {
                _nextForm = new _mainFunction(this);
                _nextForm.Show();
                this.Visible = false;
            }
            else if(authoValue == 0)
            {
                _nextForm = new EmployeeData(this, emplID, password);
                _nextForm.Show();
                this.Visible = false;
            }
        }
    }
}
