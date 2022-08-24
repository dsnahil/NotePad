using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Notepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();    
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();   
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();    
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog obj = new FontDialog();
            obj.ShowDialog();
            richTextBox1.SelectionFont = obj.Font;
        }
        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog obj = new ColorDialog();
            obj.ShowDialog();
            richTextBox1.SelectionColor = obj.Color;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory= "D:\\";
            sfd.Filter = "*.txt|*.txt";
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName,FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            string s = richTextBox1.Text;
            sw.Write(s);
            sw.Close();
            fs.Close();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "D:\\";
            sfd.Filter = "*.txt|*.txt";
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string s = richTextBox1.Text;
            sw.Write(s);
            sw.Close();
            fs.Close();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "";
            ofd.Filter = "*.txt|.txt|*All Files|*,*,*";
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName,FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();        }    }   }
