using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayfairCipher
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            dataGridView1.ColumnCount = 6;
            dataGridView1.RowCount = 6;
        }

        static void createMatrix(string key, char[,] a, int size)
        {
            HashSet<char> hash = new HashSet<char>();
            int k = 0, h = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    while (k < key.Length && hash.Contains(key[k]))
                        k++;

                    if (k < key.Length)
                    {
                        a[i, j] = key[k];
                        hash.Add(key[k]);
                        k++;
                    }
                    else
                    {
                        char value;
                        while (h < 26 && hash.Contains((char)(h + 'A')))
                            h++;
                        if (h < 26)
                        {
                            value = (char)(h + 'A');
                            h++;
                        }
                        else
                        {
                            h = 0;
                            while (h < 10 && hash.Contains((char)(h + '0')))
                                h++;
                            value = (char)(h + '0');
                            h++;
                        }
                        a[i, j] = value;
                        hash.Add(value);
                    }
                }
            }
        }

        static string Encryption(char x, char y, char[, ] a, int k)
        {
            string result = "";
            int i1 = -1, j1 = -1, i2 = -1, j2 = -1;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (a[i,j] == x)
                    {
                        i1 = i;
                        j1 = j;
                    }
                    else if (a[i, j] == y)
                    {
                        i2 = i;
                        j2 = j;
                    }
                }
            }
            if (i1 == i2 && j1 != j2)
            {
                result += a[i1, (j1 + 1) % k];
                result += a[i2, (j2 + 1) % k];
            }
            else if (j1 == j2 && i1 != i2)
            {
                result += a[(i1 + 1) % k, j1];
                result += a[(i2 + 1) % k, j2];
            }
            else if (i1 != i2 && j1 != j2)
            {
                result += a[i1, j2];
                result += a[i2, j1];
            }
            return result;
        }
        static string Decryption(char x, char y, char[, ] a, int k)
        {
            string result = "";
            int i1 = -1, j1 = -1, i2 = -1, j2 = -1;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (a[i, j] == x)
                    {
                        i1 = i;
                        j1 = j;
                    }
                    else if (a[i, j] == y)
                    {
                        i2 = i;
                        j2 = j;
                    }
                }
            }
            if (i1 == i2 && j1 != j2)
            {
                result += a[i1, (j1 - 1 + k) % k];
                result += a[i2, (j2 - 1 + k) % k];
            }
            else if (j1 == j2 && i1 != i2)
            {
                result += a[(i1 - 1 + k) % k, j1];
                result += a[(i2 - 1 + k) % k, j2];
            }
            else if (i1 != i2 && j1 != j2)
            {
                result += a[i1, j2];
                result += a[i2, j1];
            }
            return result;
        }
        static string stringFilter(string s, bool b)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (!b)
                {
                    if (char.IsLetter(s[i]) || char.IsDigit(s[i]))
                        result += s[i];
                }
                else
                {
                    if (char.IsLetter(s[i]))
                    {
                        if (s[i] == 'j' || s[i] == 'J')
                            result += 'i';
                        else
                            result += s[i];
                    }
                }
            }

            string normalForm = result.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in normalForm)
            {
                UnicodeCategory unicodeCat = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCat != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
                
            }
            result = sb.ToString().ToUpper();
            result = result.Replace('Đ', 'D');
            return result;
        }

        static string standardText(string s, bool b)
        {
            string result = "";
            s = stringFilter(s, b);

            for (int i = 0; i < s.Length; i += 2)
            {
                result+= s[i];
                if (i == s.Length - 1) break;
                if (s[i] == s[i + 1])
                {
                    result += 'X';
                    i--;
                }
                else
                    result += s[i + 1];
            }

            if (result.Length % 2 != 0)
                result += 'X';
            return result;
        }

        static List <string> SplitText(string text)
        {
            List <string> listStr = new List<string>();

            for (int i = 0; i < text.Length - 1; i += 2)
                listStr.Add(text[i].ToString() + text[i + 1].ToString());

            return listStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[,] a = new char[6, 6];
            List<string> listStr = new List<string>();

            textBox3.Clear();
            textBox4.Clear();

            if (radioButton1.Checked)
            {
                createMatrix(stringFilter(textBox2.Text, true), a, 5);
                listStr = SplitText(standardText(textBox1.Text, true));

                foreach (string x in listStr)
                    textBox3.Text += x + " ";
                foreach (string x in listStr)
                    textBox4.Text += Encryption(x[0], x[1], a, 5) + " ";
            }
            else
            {
                createMatrix(stringFilter(textBox2.Text, false), a, 6);
                listStr = SplitText(standardText(textBox1.Text, false));

                foreach (string x in listStr)
                    textBox3.Text += x + " ";
                foreach (string x in listStr)
                    textBox4.Text += Encryption(x[0], x[1], a, 6) + " ";
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[,] a = new char[6, 6];
            List<string> listStr = new List<string>();

            textBox3.Clear();
            textBox4.Clear();

            if (radioButton1.Checked)
            {
                createMatrix(stringFilter(textBox2.Text, true), a, 5);
                listStr = SplitText(standardText(textBox1.Text, true));

                foreach (string x in listStr)
                    textBox3.Text += x + " ";
                foreach (string x in listStr)
                    textBox4.Text += Decryption(x[0], x[1], a, 5) + " ";
            }
            else
            {
                createMatrix(stringFilter(textBox2.Text, false), a, 6);
                listStr = SplitText(standardText(textBox1.Text, false));

                foreach (string x in listStr)
                    textBox3.Text += x + " ";
                foreach (string x in listStr)
                    textBox4.Text += Decryption(x[0], x[1], a, 6) + " ";
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader (fs);

                string content = sr.ReadToEnd();
                textBox1.Text = content;

                sr.Close();
                fs.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                
                string content = sr.ReadToEnd();
                textBox2.Text = content;
                
                sr.Close();
                fs.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 6;
            dataGridView1.RowCount = 6;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FileName = "Result.txt";
            sfd.Title = "Save Result File";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        writer.Write(textBox4.Text);
                    }
                    
                    string directoryPath = Path.GetDirectoryName(sfd.FileName);
                    string baseName = "Key.txt";
                    string outputPath = Path.Combine(directoryPath, baseName);
                    int cnt = 1;
                    
                    while (File.Exists(outputPath))
                    {
                        string newName = $"Key({cnt}).txt";
                        outputPath = Path.Combine(directoryPath, newName);
                        cnt++;
                    }
                    File.WriteAllText(outputPath, textBox2.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the file: {ex.Message}");
                }
            }
        }

    }
}
