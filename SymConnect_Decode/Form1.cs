using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SymConnect_Decode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // tooltips for hover help here!!!
        ToolTip t1 = new ToolTip();
        ToolTip t2 = new ToolTip();

        // so you want to right click on a checkedlistbox

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            t2.Show("Dialog will appear and a delimited file will \n created or saved to include the enabled items", button2);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Dialog will appear so you pick the file to examine", button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // filepicker dialog will appear.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            
            // build defaults
            saveFileDialog1.FileName = "symconnect_csv.csv";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // enter open here!!!
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))

                    // write out richtextbox1 to file!!!
                    foreach (string line in richTextBox1.Lines)
                    {
                        sw.WriteLine(line + "\n");
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // clear out rtb
            richTextBox1.Clear();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // build defaults

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName.ToString();

                string holdString = ""; 
                string postString = "";

                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                // ok the log files look to be blocked at 80 chars.  The following will
                // look for a blank space at the beginning of the line and concat it and 
                // every other one onto the previous line.  This should work even if you 
                // happen to receive a file that isn't blocked at 80 chars.

                // richTextBox1.AppendText(sr.ReadToEnd());

                while ((holdString = sr.ReadLine()) != null)
                {
                    if (holdString.Length < 10)  // blank line don't need
                    {
                        richTextBox1.AppendText(postString + "\n");
                        saveBase.AppendText(postString + "\n");
                        postString = ""; // ok we are assuming that this is a new record starting point
                    }
                    else // if (holdString[0] == ' ' | holdString) // continuation line
                    {
                        postString += holdString.Trim();
                    }
                }

                sr.Close();
                
            }
        }

        private void deleteLineRichTextBox(List<string> keepThese)
        {
            // clean the edit rtb
            editRTB.Clear();

            // ok we will foreach through the richTextBox1 into editRTB that match keepThese
            // I looked around for a simple and easy method for this and well to tell you the truth 
            // none of them was simple... I'm a KISS person...

            foreach (string line in richTextBox1.Lines)
            {
                foreach (string mustHave in keepThese)
                {
                    if (line.Contains(mustHave))
                    {
                        editRTB.AppendText(line + "\n");
                    }
                }
            }
            
            // the steps
            // clear receiving object
            // copy back

            richTextBox1.Clear();

            foreach (string line in editRTB.Lines)
            {
                richTextBox1.AppendText(line + "\n");
            }

            // clearing out again because I'm stupid... deal with it:)
            editRTB.Clear();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void excludeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create string array to pass to only keep the lines that contain references
            List<string> findString = new List<string>();

            foreach (string boxChecked in checkedListBox1.CheckedItems)
            {
                findString.Add(boxChecked);
            }

            //call delete line in richtextbox1
            deleteLineRichTextBox(findString);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // clear the richTextBox1
                richTextBox1.Clear();

                foreach (string line in saveBase.Lines)
                {
                    richTextBox1.AppendText(line + "\n");
                }
                
            }
            catch
            {
            }
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {

                try
                {
                    // create string array to pass to only keep the lines that contain references
                    List<string> findString = new List<string>();

                    // use the clipboard to hold the stuff we want to adhoc look for... it's the easiest...
                    Clipboard.SetText(richTextBox1.SelectedText);
                    string getThis = Clipboard.GetText(TextDataFormat.Text).ToString();

                    DialogResult result2 = MessageBox.Show(getThis, "Adhoc Find", MessageBoxButtons.YesNoCancel);

                    if (result2 == DialogResult.Yes)
                    {
                        findString.Add(getThis);
                        deleteLineRichTextBox(findString);
                    }
                   
                }
                catch
                {
                }
            }
        }

        private void checkedListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            {
                MessageBox.Show("you got it!");
            }
        }


        private void checkedListBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = this.checkedListBox1.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    if (index == 5) // item index goes like this 0,1,2,3,... get the picture...
                    {
                        //MessageBox.Show(index.ToString());
                    }
                    else
                    {
                        //MessageBox.Show("you got it!");
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = richTextBox1.Lines.Count().ToString();
            textBox3.Text = richTextBox1.Text.Length.ToString();
        }

    }
}
