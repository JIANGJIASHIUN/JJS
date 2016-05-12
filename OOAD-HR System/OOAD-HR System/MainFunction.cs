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
    public partial class _female : Form
    {

        private Form _login = new Form();

        public _female(Form login)
        {
            _login = login;

            InitializeComponent();
        }

        private void ClickLogoutButton(object sender, EventArgs e)
        {
            _login.Visible = true;
            this.Close();
        }

        private void CloseMainFunvrion(object sender, FormClosedEventArgs e)
        {
            _login.Visible = true;
        }
    }
}
