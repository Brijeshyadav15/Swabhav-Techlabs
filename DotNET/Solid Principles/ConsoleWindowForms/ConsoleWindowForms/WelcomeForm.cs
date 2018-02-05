using System;
using System.Windows.Forms;

namespace ConsoleWindowForms
{
    class WelcomeForm : Form
    {
        private Button _wishBtn;
        private Button _closeBtn;

        public WelcomeForm()
        {
            this.Text = "Hello";
            this.Width = 400;
            this.Height = 400;

            this._wishBtn = new Button();
            this.Controls.Add(_wishBtn);

            _wishBtn.Text = "Click Here";
            _wishBtn.SetBounds(50, 100, 200, 25);
            this._wishBtn.Click += WishClickHandler;

            this._closeBtn = new Button();
            _closeBtn.Text = "Close Window";
            _closeBtn.SetBounds(50, 150, 200, 25);
            this.Controls.Add(_closeBtn);
            this._closeBtn.Click += CloseClickHandler;
        }

        public void WishClickHandler(Object obj, EventArgs eve)
        {
            Console.WriteLine("Into Wish Click Handler");
            MessageBox.Show("Clicked Fired");
        }

        public void CloseClickHandler(Object obj, EventArgs eve)
        {
            this.Close();
        }
    }
}
