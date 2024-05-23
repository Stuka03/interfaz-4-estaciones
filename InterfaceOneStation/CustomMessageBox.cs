using System;
using System.Drawing;
using System.Windows.Forms;

namespace InterfaceOneStation
{
    public partial class CustomMessageBox : Form
    {
        public DialogResult CustomDialogResult { get; private set; }
        public CustomMessageBox(string message, Color color)
        {
            InitializeComponent();
            richTextBox1.Text = message;
            richTextBox1.BackColor = color;
            pictureBox1.BackColor = color;
            buttonOK.BackColor = color;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            CustomDialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
