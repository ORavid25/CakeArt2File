using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeArtToFile
{
    public partial class Form1 : Form
    {
        string path = @"G:\txtfile3.txt";//מיקום הקובץ

        public Form1()
        {
            InitializeComponent();
        }

        //כפתור הוספה
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string type = "";
            if (rbCake.Checked)
            {
                type = rbCake.Text;
            }
            else if (rbCookie.Checked)
            {
                type = rbCookie.Text;
            }
            else
            {
                type = rbSpecial.Text;
            }

            Items item = new Items(txtName.Text, txtPrice.Text, type);
            
            
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(item.ToString());
                    MessageBox.Show("File Created");
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(item.ToString());
                    MessageBox.Show("File Affected");
                }
            }
        }

        //מחיקת תוכן הקובץ
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                File.Create(path).Close();
                MessageBox.Show("File Cleared");
            }
        }

        //כפתור להצגת תוכן הקובץ ב LABEL
        private void BtnContent_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                lblFinishText.Text += line + "\n";
            }

        }
    }
}
