using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverApp
{
    public partial class MainForm : Form
    {
        public static DeanOffice deanOffice = new DeanOffice();
        public MainForm()
        {
            InitializeComponent();
        }
        public void UpdateLog()
        {
           // logTextBox.Text += ;
        }

        private void sessionStartButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text += deanOffice.SessionStart();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBox1.Text, textBox2.Text, checkedListBox1.GetItemChecked(0), checkedListBox1.GetItemChecked(1), checkedListBox1.GetItemChecked(2));
        }

        private void sendMsgButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text += deanOffice.NewMessage();
        }

        private void newEventButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text += deanOffice.NewShedule();
        }
    }
}
