using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CIS2225_Assignment4_Creamer_Kyle
{
    public partial class textEditor : Form
    {
        public textEditor()
        {
            InitializeComponent();
        }

        protected void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text File | *.txt";
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                 openFileDialog1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                Document childDoc = new Document(openFileDialog1);
                childDoc.MdiParent = this;
                childDoc.Text = openFileDialog1.FileName;
                childDoc.Show();

            }
            else {
                Document childDoc = new Document();
                childDoc.MdiParent = this;
                childDoc.Show();
            }
        }
    }
}
