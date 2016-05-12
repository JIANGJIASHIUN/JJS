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
    public partial class _mainFunction : Form
    {

        private Form _login = new Form();

        public _mainFunction(Form login)
        {
            _login = login;

            InitializeComponent();
        }

        // form load
        private void LoadMainFunction(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'hrmsDataSet3.position' 資料表。您可以視需要進行移動或移除。
            this.positionTableAdapter.Fill(this.hrmsDataSet3.position);
            // TODO:  這行程式碼會將資料載入 'hrmsDataSet2.department' 資料表。您可以視需要進行移動或移除。
            this.departmentTableAdapter.Fill(this.hrmsDataSet2.department);

            // 設置所有combobox的預設值
            _newEmplJobStatCB.SelectedIndex = 0;
            _newEmplMarriedStatCB.SelectedIndex = 0;
            _newEmplMilitaryStatCB.SelectedIndex = 0;
        }

        // 按下登出鍵
        private void ClickLogoutButton(object sender, EventArgs e)
        {
            _login.Visible = true;
            this.Close();
        }

        // 按下右上角關閉
        private void CloseMainFunction(object sender, FormClosedEventArgs e)
        {
            _login.Visible = true;
        }

        // 根據婚姻狀況修改配偶欄是否可以填寫
        private void ChangedNewEmplMarriedStatCBSelectedIndex(object sender, EventArgs e)
        {
            // 1 為未婚
            // 0 為已婚
            if (_newEmplMarriedStatCB.SelectedIndex == 1)
            {
                _newEmplSpouseTB.ReadOnly = false;
            }
            else if (_newEmplMarriedStatCB.SelectedIndex == 0)
            {
                _newEmplSpouseTB.ReadOnly = true;
                _newEmplSpouseTB.Text = "";
            }
        }

        // 根據選取職位 顯示職位底薪
        private void ChangedNewEmplPositionCBSelectedIndex(object sender, EventArgs e)
        {

        }

    }
}
