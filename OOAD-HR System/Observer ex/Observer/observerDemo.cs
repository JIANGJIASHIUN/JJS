using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ObserverDemo
    {
        public delegate void ViewChangeHandler();
        public ViewChangeHandler labelHandler;

        public void ClickDemoBtn()
        {
            ObserverNotify(labelHandler);
        }

        private void ObserverNotify(ViewChangeHandler handler)
        {
            if (handler != null)
                handler();
        }
    }
}
