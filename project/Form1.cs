using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Filter = "browse photos | *.jpg; *.png";
            browse.Multiselect = true;
            if (browse.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < browse.FileNames.Length; i++)
                {
                    listBox1.Items.Add(browse.FileNames[i]);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex - 1 == -1)
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                pictureBox1.ImageLocation = listBox1.Items[listBox1.SelectedIndex].ToString();
                return;
            }
            listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            pictureBox1.ImageLocation = listBox1.Items[listBox1.SelectedIndex].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex+1==listBox1.Items.Count)
            {
                listBox1.SelectedIndex = 0;
                pictureBox1.ImageLocation = listBox1.Items[listBox1.SelectedIndex].ToString();
                return;
            }
            listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            pictureBox1.ImageLocation = listBox1.Items[listBox1.SelectedIndex].ToString();
        }

        private void singleModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1)
            {
                return;
            }

            pictureBox1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;

            defaultModeToolStripMenuItem.Visible = true;

            multiphotosModeToolStripMenuItem.Visible = false;
            slideshowModeToolStripMenuItem.Visible = false;
            singleModeToolStripMenuItem.Visible = false;

            listBox1.SelectedIndex = 0;
            pictureBox1.ImageLocation = listBox1.Items[listBox1.SelectedIndex].ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
                pictureBox1.ImageLocation = listBox1.Items[listBox1.SelectedIndex].ToString();
        }

        private void defaultModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            button2.Visible = false;
            button3.Visible = false;

            panel1.Visible = false;

            timer1.Stop();

            listBox1.SelectionMode = SelectionMode.One;

            multiphotosModeToolStripMenuItem.Visible = true;
            slideshowModeToolStripMenuItem.Visible = true;
            singleModeToolStripMenuItem.Visible = true;

            defaultModeToolStripMenuItem.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex + 1 == listBox1.Items.Count)
            {
                timer1.Stop();
                return;
            }
            listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            pictureBox2.ImageLocation = listBox1.Items[listBox1.SelectedIndex].ToString();
        }

        private void listBox1_MouseClick(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Controls.Clear();

                for (int i = 0; i < listBox1.SelectedIndices.Count; i++)
                {
                    PictureBox photo = new PictureBox();

                    photo.Name = "pictureBox" + i;
                    photo.Top = 5;
                    photo.Left = 5;
                    photo.Width = 125;
                    photo.Height = 125;
                    photo.Location = new Point(5 + (130 * (i % 3)), 5 + (130 * (i / 3)));
                    photo.SizeMode = PictureBoxSizeMode.Zoom;
                    photo.ImageLocation = listBox1.Items[listBox1.SelectedIndices[i]].ToString();

                    panel1.Controls.Add(photo);
                }
            }
        }

        private void slideshowModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1)
            {
                return;
            }

            listBox1.SelectedIndex = 0;
            pictureBox2.ImageLocation = listBox1.Items[listBox1.SelectedIndex].ToString();

            pictureBox2.Visible = true;

            defaultModeToolStripMenuItem.Visible = true;

            multiphotosModeToolStripMenuItem.Visible = false;
            slideshowModeToolStripMenuItem.Visible = false;
            singleModeToolStripMenuItem.Visible = false;

            timer1.Start();
        }

        private void multiphotosModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1)
            {
                return;
            }

            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.SelectedIndex = 0;

            panel1.Visible = true;

            defaultModeToolStripMenuItem.Visible = true;

            multiphotosModeToolStripMenuItem.Visible = false;
            slideshowModeToolStripMenuItem.Visible = false;
            singleModeToolStripMenuItem.Visible = false;
        }
    }
}
