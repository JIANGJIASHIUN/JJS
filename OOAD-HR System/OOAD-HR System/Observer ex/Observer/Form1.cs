using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        ObserverDemo _observer;
        public Form1()
        {
            InitializeComponent();
            _observer = new ObserverDemo();
            _observer.labelHandler += RefreshBtnContent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _observer.ClickDemoBtn();
        }

        private void RefreshBtnContent()
        {
            label1.Text = "Observer";
        }
    }
}
