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
    public partial class ErrorInfo : Form
    {
        public ErrorInfo()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorInfo_Load(object sender, EventArgs e)
        {

        }

        public void doErrorInfo(Exception ex)
        {
            errorInfoTextBox.Text = ex.Message;
            errorInfoTextBox.AppendText(Environment.NewLine + Environment.NewLine + "Stack Trace:" + Environment.NewLine + Environment.NewLine);
            errorInfoTextBox.AppendText(ex.StackTrace);
            this.ShowDialog();
        }
    }
}
