using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLAdventureGame
{
    public partial class Error : Form
    {
        Exception ex;
        public Error()
        {
            InitializeComponent();
        }

        private void Error_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        public void doErrorMsg(string msg)
        {
            moreInfoButton.Enabled = false;
            errorText.Text = msg;
            
        }

        public void doErrorMsg(string msg, Exception exc)
        {
            moreInfoButton.Enabled = true;
            errorText.Text = msg;
            ex = exc;
           
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();

        }

        private void moreInfoButton_Click(object sender, EventArgs e)
        {
            new ErrorInfo().doErrorInfo(ex);
        }
    }
}
