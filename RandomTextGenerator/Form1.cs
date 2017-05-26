using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomTextGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int listLength = 0;
        int[] counter;
        Random rand = new Random();
        bool gateway = false;
        string[] store;
        int stringLimit = 0;

        private void buttonShowText_Click(object sender, EventArgs e)
        {
            listLength = 0;
            update(listLength);

            if (textBoxCharLimit.Text.Length != 0 && textBoxStringLimit.Text.Length != 0)
            {
                gateway = false;
                richTextBox1.Clear();
                richTextBox1.AppendText(textBoxCharLimit.Text.Trim() + "\n");
                richTextBox1.AppendText(textBoxStringLimit.Text.Trim() + "\n");
                counter = new int[Convert.ToInt32(textBoxStringLimit.Text.Trim())];
                int charLimit = Convert.ToInt32(textBoxCharLimit.Text.Trim());
                stringLimit = Convert.ToInt32(textBoxStringLimit.Text.Trim());
                store = new string[stringLimit];
                string constructString = "";
                
                char []createdChar = new char[charLimit];
                Random rand = new Random();

                for (int j = 0; j < stringLimit; j++)
                {
                    int superRand = rand.Next(3, charLimit);
                    for (int i = 0; i < superRand; i++)
                    {
                        char temp = (char)rand.Next(97, 122);
                        createdChar[i] = temp;                      
                        richTextBox1.AppendText(temp.ToString());
                    }
                    richTextBox1.AppendText(constructString + "\n");                   
                    store[j] = createdChar.ToString();
                    listLength++;
                    update(listLength);
                }
            }
            else
            {
                MessageBox.Show("Empty Fileds");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listLength = 0;
            gateway = true;
            update(listLength);
            if (textBoxCharLimit.Text.Length != 0 && textBoxStringLimit.Text.Length != 0)
            {
                richTextBox1.Clear();
                richTextBox1.AppendText(textBoxCharLimit.Text.Trim()+"\n");
                richTextBox1.AppendText(textBoxStringLimit.Text.Trim() + "\n");
                int charLimit = Convert.ToInt32(textBoxCharLimit.Text.Trim());
                int stringLimit = Convert.ToInt32(textBoxStringLimit.Text.Trim());
                string constructString = "";
                char[] createdChar = new char[charLimit];               

                for (int j = 0; j < stringLimit; j++)
                {
                    int superRand = rand.Next(3, charLimit);
                    for (int i = 0; i < superRand; i++)
                    {
                        char temp = (char)rand.Next(97, 122);
                        char temp1 = (char)rand.Next(65, 90);
                        int probable = rand.Next(2);
                        if (probable == 0)
                        {
                            createdChar[i] = temp;
                            richTextBox1.AppendText(temp.ToString());
                        }
                        else
                        {
                            createdChar[i] = temp1;
                            richTextBox1.AppendText(((char)temp1).ToString());
                        }
                    }
                    richTextBox1.AppendText(constructString + "\n");
                    store[j] = createdChar.ToString();
                    listLength++;
                    update(listLength);
                }
            }
            else
            {
                MessageBox.Show("Empty Fileds");
            }
        }

        void update(int newValue)
        {
            lableListLength.Text = newValue.ToString();
            return;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (gateway == false)
            {
                richTextBox1.Clear();
                richTextBox1.AppendText(textBoxRetundency.Text.Trim() + "\n");
                if (textBoxLoadFile.Text.Length != 0 && textBoxResultFile.Text.Length != 0 && textBoxRetundency.Text.Length != 0)
                {
                    int redundencyLimit = Convert.ToInt32(textBoxRetundency.Text.Trim());
                    for (int i = 0; i < redundencyLimit; i++)
                    { 
                           int num = rand.Next(0, stringLimit);
                           richTextBox1.AppendText(store[num].ToString()+"\n");
                           counter[num]++;
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fileds");
                }

                buttonFinalWrite.Enabled = true;
            }
        }
    }
}
