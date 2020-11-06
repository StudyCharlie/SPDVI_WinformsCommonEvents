using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinformsCommonEvents
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            messagesTextBox.Text += "Main Form loaded." + Environment.NewLine;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {
            String leftClick = "Left button of the mouse has been clicked over main form.";
            String rightClick = "Right button of the mouse has been clicked over main form.";

            switch (e.Button)
            {
                case MouseButtons.Left:
                    messagesTextBox.Text += leftClick+ Environment.NewLine;
                    break;

                case MouseButtons.Right:
                    messagesTextBox.Text += rightClick+ Environment.NewLine;
                    break;
            }
        }

        private void DoubleClickLabel_DoubleClick(object sender, EventArgs e)
        {
            messagesTextBox.Text += "The system has detected a Double click on the label." + Environment.NewLine;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            messagesTextBox.Text += "Numeric Up Down Value has changed to " + numericUpDown1.Value + Environment.NewLine;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            messagesTextBox.Text += "List box Selected Index has changed to " + listBoxSelectedIndex.SelectedIndex + Environment.NewLine;
        }

        private void textBoxFocus_Enter(object sender, EventArgs e)
        {
            messagesTextBox.Text += "textBoxFocus has got the focus. " + Environment.NewLine;
        }

        private void textBoxFocus_Leave(object sender, EventArgs e)
        {
            messagesTextBox.Text += "textBoxFocus has lost the focus. " + Environment.NewLine;
        }

        private void textBoxFocus_KeyPress(object sender, KeyPressEventArgs e)
        {
            messagesTextBox.Text += $"The key '{e.KeyChar}' has been pressed and released." + Environment.NewLine;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            messagesTextBox.Text += "The mouse pointer is inside of the image." + Environment.NewLine;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            messagesTextBox.Text += "The mouse pointer is outside of the image." + Environment.NewLine;
        }
    }
}
