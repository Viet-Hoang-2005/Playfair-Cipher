using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        static void PlayfairCipher(string key, char[, ] a)
        {
            HashSet <char> mp = new HashSet<char>();
            int k = 0, h = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    while (k < key.Length && mp.Contains(key[k]))
                        k++;

                    if (k < key.Length)
                    {
                        a[i, j] = key[k];
                        mp.Add(key[k]);
                        k++;
                    }
                    else
                    {
                        while (mp.Contains((char)('A' + h)) || (char)('A' + h) == 'J')
                            h++;

                        a[i, j] = (char)('A' + h);
                        mp.Add((char)('A' + h));
                        h++;
                    }
                }
            }
        }

        static string Encryption(char x, char y, char[, ] a)
        {
            string res = "";
            int i1 = -1, j1 = -1, i2 = -1, j2 = -1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
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
                res += a[i1, (j1 + 1) % 5];
                res += a[i2, (j2 + 1) % 5];
            }
            else if (j1 == j2 && i1 != i2)
            {
                res += a[(i1 + 1) % 5, j1];
                res += a[(i2 + 1) % 5, j2];
            }
            else if (i1 != i2 && j1 != j2)
            {
                res += a[i1, j2];
                res += a[i2, j1];
            }
            return res;
        }

        static string Decryption(char x, char y, char[, ] a)
        {
            string res = "";
            int i1 = -1, j1 = -1, i2 = -1, j2 = -1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
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
                res += a[i1, (j1 - 1 + 5) % 5];
                res += a[i2, (j2 - 1 + 5) % 5];
            }
            else if (j1 == j2 && i1 != i2)
            {
                res += a[(i1 - 1 + 5) % 5, j1];
                res += a[(i2 - 1 + 5) % 5, j2];
            }
            else if (i1 != i2 && j1 != j2)
            {
                res += a[i1, j2];
                res += a[i2, j1];
            }
            return res;
        }
        static string upperString(string s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    if (s[i] == 'j' || s[i] == 'J')
                        res += 'i';
                    else
                        res += s[i];
                }
            }
            res = res.ToUpper();
            return res;
        }

        static string standardText(string s)
        {
            string res = "";
            s = upperString(s);

            for (int i = 0; i < s.Length; i += 2)
            {
                res += s[i];
                if (i == s.Length - 1) break;
                if (s[i] == s[i + 1])
                {
                    res += 'X';
                    i--;
                }
                else res += s[i + 1];
            }

            if (res.Length % 2 != 0)
                res += 'X';
            return res;
        }

        static List <string> SplitText(string text, string key, char[, ]a)
        {
            List <string> vt = new List<string>();

            for (int i = 0; i < text.Length - 1; i += 2)
                vt.Add(text[i].ToString() + text[i + 1].ToString());

            return vt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[,] a = new char[5, 5];
            List<string> vt = new List<string>();

            textBox3.Clear();
            textBox4.Clear();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 5;

            PlayfairCipher(upperString(textBox2.Text), a);
            vt = SplitText(standardText(textBox1.Text), upperString(textBox2.Text), a);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
            }
            foreach (string x in vt)
                textBox3.Text += x + " ";
            foreach (string x in vt)
                textBox4.Text += Encryption(x[0], x[1], a) + " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[,] a = new char[5, 5];
            List<string> vt = new List<string>();
            
            textBox3.Clear();
            textBox4.Clear();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 5;
            
            PlayfairCipher(upperString(textBox2.Text), a);
            vt = SplitText(standardText(textBox1.Text), upperString(textBox2.Text), a);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                   dataGridView1.Rows[i].Cells[j].Value = a[i, j];
            }
            foreach (string x in vt)
                textBox3.Text += x + " ";
            foreach (string x in vt)
                textBox4.Text += Decryption(x[0], x[1], a) + " ";
        }

    }
}
