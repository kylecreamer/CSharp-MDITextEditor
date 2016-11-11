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
    public partial class Document : Form
    {

        String activeFile;

        public Document(OpenFileDialog dialog)
        {
            InitializeComponent();

            errorStatusBar.Panels[0].AutoSize = StatusBarPanelAutoSize.Spring;
            errorStatusBar.Panels[0].BorderStyle = StatusBarPanelBorderStyle.Raised;
            errorStatusBar.ShowPanels = true;
            dialog.CheckFileExists = false;
            try
            {
                documentText.LoadFile(dialog.FileName, RichTextBoxStreamType.PlainText);
            }
            catch (Exception ex)
            {
                documentText.SaveFile(dialog.FileName, RichTextBoxStreamType.PlainText);
            }

            activeFile = dialog.FileName;

        }
        public Document()
        {
            InitializeComponent();
            errorStatusBar.Panels[0].AutoSize = StatusBarPanelAutoSize.Spring;
            errorStatusBar.Panels[0].BorderStyle = StatusBarPanelBorderStyle.Raised;
            errorStatusBar.ShowPanels = true;

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (String.IsNullOrEmpty(documentText.Text))
                {
                    errorProvider1.SetError(errorStatusBar, "Your file must not be empty.");
                    errorStatusBar.Panels[0].Text = errorProvider1.GetError(errorStatusBar);
                }
                else
                {
                    errorProvider1.SetError(errorStatusBar, "");
                    errorStatusBar.Panels[0].Text = errorProvider1.GetError(errorStatusBar);
                    documentText.Text = documentText.Text + 
                        "\n" + dateTimePicker1.Value.ToShortDateString();
                       
                        saveFileDialog1.Filter = "Text File | *.txt";
                       if((saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                            saveFileDialog1.FileName.Length > 0))
                            {
                            documentText.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                            MessageBox.Show("File Saved", "File Saved Successfully");
                            }
 
                }
            }
        
            catch (Exception ex)
            {
                errorProvider1.SetError(errorStatusBar, "An error has occurred: " + ex);
                errorStatusBar.Panels[0].Text = errorProvider1.GetError(errorStatusBar);

            }

        }
    


        private void errorStatus_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void closeBar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit??", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }

        }

        private void saveBar_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        protected void openBar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                 openFileDialog1.FileName.Length > 0)
            {
                try
                {
                    documentText.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }

                catch (Exception ex)
                {

                    errorProvider1.SetError(errorStatusBar, "An error has occurred: " + ex);
                    errorStatusBar.Panels[0].Text = errorProvider1.GetError(errorStatusBar);

                    try
                    {
                        documentText.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    }

                    catch (Exception exx)
                    {
                        errorProvider1.SetError(errorStatusBar, "An error has occurred: " + exx);
                        errorStatusBar.Panels[0].Text = errorProvider1.GetError(errorStatusBar);
                    }
                }
            }
        }

        private void documentText_TextChanged(object sender, EventArgs e)
        {

        }


        }
    }

