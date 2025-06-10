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
    public partial class Playfair: Form
    {
        public Playfair()
        {
            InitializeComponent();
            dgvKeyMatrix.ColumnCount = 6;
            dgvKeyMatrix.RowCount = 6;
        }

        private void createMatrix(string key, char[,] a, int size)
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
                        if (size == 5 && (char)('A' + h) == 'J')
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

        private string Encryption(char x, char y, char[, ] a, int k)
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
        private string Decryption(char x, char y, char[, ] a, int k)
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
        private string stringFilter(string s, bool b)
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

        private string standardText(string s, bool b)
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

        private void btnOpenFileText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                string content = sr.ReadToEnd();
                tbText.Text = content;

                sr.Close();
                fs.Close();
            }
        }

        private void btnOpenFileKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                string content = sr.ReadToEnd();
                tbKey.Text = content;

                sr.Close();
                fs.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                        writer.Write(tbResult.Text);
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
                    File.WriteAllText(outputPath, tbKey.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the file: {ex.Message}");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbText.Clear();
            tbKey.Clear();
            tbSplit.Clear();
            tbResult.Clear();

            dgvKeyMatrix.Rows.Clear();
            dgvKeyMatrix.Columns.Clear();
            dgvKeyMatrix.ColumnCount = 6;
            dgvKeyMatrix.RowCount = 6;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                int size = rbtn5x5.Checked ? 5 : 6;
                char[,] a = new char[size, size];
                List<string> listStr = new List<string>();

                tbSplit.Clear();
                tbResult.Clear();

                createMatrix(stringFilter(tbKey.Text, rbtn5x5.Checked), a, size);
                listStr = SplitText(standardText(tbText.Text, rbtn5x5.Checked));

                foreach (string x in listStr)
                    tbSplit.Text += x + " ";
                foreach (string x in listStr)
                    tbResult.Text += Encryption(x[0], x[1], a, size) + " ";

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                        dgvKeyMatrix.Rows[i].Cells[j].Value = a[i, j];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during encryption: {ex.Message}");
            }
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                int size = rbtn5x5.Checked ? 5 : 6;
                char[,] a = new char[size, size];
                List<string> listStr = new List<string>();

                tbSplit.Clear();
                tbResult.Clear();

                createMatrix(stringFilter(tbKey.Text, rbtn5x5.Checked), a, size);
                listStr = SplitText(standardText(tbText.Text, rbtn5x5.Checked));

                foreach (string x in listStr)
                    tbSplit.Text += x + " ";
                foreach (string x in listStr)
                    tbResult.Text += Decryption(x[0], x[1], a, size) + " ";

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                        dgvKeyMatrix.Rows[i].Cells[j].Value = a[i, j];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during decryption: {ex.Message}");
            }
        }
    }
}
