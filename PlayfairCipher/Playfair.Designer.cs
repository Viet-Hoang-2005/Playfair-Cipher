using System.Windows.Forms;

namespace PlayfairCipher
{
    partial class Playfair
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtn5x5 = new System.Windows.Forms.RadioButton();
            this.rbtn6x6 = new System.Windows.Forms.RadioButton();
            this.tbResult = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.tbSplit = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEncrypt = new Guna.UI2.WinForms.Guna2Button();
            this.btnDecrypt = new Guna.UI2.WinForms.Guna2Button();
            this.tbKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbText = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnOpenFileText = new Guna.UI2.WinForms.Guna2Button();
            this.btnOpenFileKey = new Guna.UI2.WinForms.Guna2Button();
            this.dgvKeyMatrix = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playfair Cipher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Key:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Split:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Result:";
            // 
            // rbtn5x5
            // 
            this.rbtn5x5.AutoSize = true;
            this.rbtn5x5.Checked = true;
            this.rbtn5x5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn5x5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtn5x5.Location = new System.Drawing.Point(779, 397);
            this.rbtn5x5.Name = "rbtn5x5";
            this.rbtn5x5.Size = new System.Drawing.Size(53, 24);
            this.rbtn5x5.TabIndex = 7;
            this.rbtn5x5.TabStop = true;
            this.rbtn5x5.Text = "5x5";
            this.rbtn5x5.UseVisualStyleBackColor = true;
            // 
            // rbtn6x6
            // 
            this.rbtn6x6.AutoSize = true;
            this.rbtn6x6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn6x6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbtn6x6.Location = new System.Drawing.Point(864, 397);
            this.rbtn6x6.Name = "rbtn6x6";
            this.rbtn6x6.Size = new System.Drawing.Size(53, 24);
            this.rbtn6x6.TabIndex = 7;
            this.rbtn6x6.Text = "6x6";
            this.rbtn6x6.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.AutoScroll = true;
            this.tbResult.BorderRadius = 10;
            this.tbResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbResult.DefaultText = "";
            this.tbResult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbResult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbResult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbResult.ForeColor = System.Drawing.Color.Black;
            this.tbResult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbResult.Location = new System.Drawing.Point(118, 485);
            this.tbResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.PlaceholderText = "";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.SelectedText = "";
            this.tbResult.Size = new System.Drawing.Size(896, 245);
            this.tbResult.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(883, 737);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 47);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete All";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.LightBlue;
            this.btnSave.Location = new System.Drawing.Point(746, 737);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 47);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save file";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbSplit
            // 
            this.tbSplit.AutoScroll = true;
            this.tbSplit.BorderRadius = 10;
            this.tbSplit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSplit.DefaultText = "";
            this.tbSplit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSplit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSplit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSplit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSplit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSplit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSplit.ForeColor = System.Drawing.Color.Black;
            this.tbSplit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSplit.Location = new System.Drawing.Point(118, 366);
            this.tbSplit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSplit.Multiline = true;
            this.tbSplit.Name = "tbSplit";
            this.tbSplit.PlaceholderText = "";
            this.tbSplit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSplit.SelectedText = "";
            this.tbSplit.Size = new System.Drawing.Size(516, 100);
            this.tbSplit.TabIndex = 8;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Animated = true;
            this.btnEncrypt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnEncrypt.BorderRadius = 10;
            this.btnEncrypt.BorderThickness = 1;
            this.btnEncrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncrypt.FillColor = System.Drawing.Color.White;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEncrypt.ForeColor = System.Drawing.Color.Black;
            this.btnEncrypt.HoverState.FillColor = System.Drawing.Color.LightBlue;
            this.btnEncrypt.Location = new System.Drawing.Point(118, 303);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(131, 47);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Animated = true;
            this.btnDecrypt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnDecrypt.BorderRadius = 10;
            this.btnDecrypt.BorderThickness = 1;
            this.btnDecrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecrypt.FillColor = System.Drawing.Color.White;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecrypt.ForeColor = System.Drawing.Color.Black;
            this.btnDecrypt.HoverState.FillColor = System.Drawing.Color.LightBlue;
            this.btnDecrypt.Location = new System.Drawing.Point(503, 303);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(131, 47);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // tbKey
            // 
            this.tbKey.BorderRadius = 10;
            this.tbKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKey.DefaultText = "";
            this.tbKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbKey.ForeColor = System.Drawing.Color.Black;
            this.tbKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbKey.Location = new System.Drawing.Point(118, 254);
            this.tbKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbKey.Name = "tbKey";
            this.tbKey.PlaceholderText = "";
            this.tbKey.SelectedText = "";
            this.tbKey.Size = new System.Drawing.Size(516, 33);
            this.tbKey.TabIndex = 8;
            // 
            // tbText
            // 
            this.tbText.AutoScroll = true;
            this.tbText.BorderRadius = 10;
            this.tbText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbText.DefaultText = "";
            this.tbText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbText.ForeColor = System.Drawing.Color.Black;
            this.tbText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbText.Location = new System.Drawing.Point(118, 98);
            this.tbText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.PlaceholderText = "";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbText.SelectedText = "";
            this.tbText.Size = new System.Drawing.Size(516, 100);
            this.tbText.TabIndex = 8;
            // 
            // btnOpenFileText
            // 
            this.btnOpenFileText.Animated = true;
            this.btnOpenFileText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnOpenFileText.BorderRadius = 10;
            this.btnOpenFileText.BorderThickness = 1;
            this.btnOpenFileText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFileText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFileText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenFileText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenFileText.FillColor = System.Drawing.Color.White;
            this.btnOpenFileText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenFileText.ForeColor = System.Drawing.Color.Black;
            this.btnOpenFileText.HoverState.FillColor = System.Drawing.Color.LightBlue;
            this.btnOpenFileText.Location = new System.Drawing.Point(118, 214);
            this.btnOpenFileText.Name = "btnOpenFileText";
            this.btnOpenFileText.Size = new System.Drawing.Size(102, 33);
            this.btnOpenFileText.TabIndex = 9;
            this.btnOpenFileText.Text = "Open file";
            this.btnOpenFileText.Click += new System.EventHandler(this.btnOpenFileKey_Click);
            // 
            // btnOpenFileKey
            // 
            this.btnOpenFileKey.Animated = true;
            this.btnOpenFileKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnOpenFileKey.BorderRadius = 10;
            this.btnOpenFileKey.BorderThickness = 1;
            this.btnOpenFileKey.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFileKey.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFileKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenFileKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenFileKey.FillColor = System.Drawing.Color.White;
            this.btnOpenFileKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenFileKey.ForeColor = System.Drawing.Color.Black;
            this.btnOpenFileKey.HoverState.FillColor = System.Drawing.Color.LightBlue;
            this.btnOpenFileKey.Location = new System.Drawing.Point(118, 58);
            this.btnOpenFileKey.Name = "btnOpenFileKey";
            this.btnOpenFileKey.Size = new System.Drawing.Size(102, 33);
            this.btnOpenFileKey.TabIndex = 9;
            this.btnOpenFileKey.Text = "Open file";
            this.btnOpenFileKey.Click += new System.EventHandler(this.btnOpenFileText_Click);
            // 
            // dgvKeyMatrix
            // 
            this.dgvKeyMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKeyMatrix.BackgroundColor = System.Drawing.Color.White;
            this.dgvKeyMatrix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKeyMatrix.ColumnHeadersHeight = 4;
            this.dgvKeyMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKeyMatrix.Location = new System.Drawing.Point(681, 98);
            this.dgvKeyMatrix.Name = "dgvKeyMatrix";
            this.dgvKeyMatrix.RowHeadersWidth = 4;
            this.dgvKeyMatrix.RowTemplate.Height = 47;
            this.dgvKeyMatrix.RowTemplate.ReadOnly = true;
            this.dgvKeyMatrix.Size = new System.Drawing.Size(333, 288);
            this.dgvKeyMatrix.TabIndex = 4;
            // 
            // Playfair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 800);
            this.Controls.Add(this.dgvKeyMatrix);
            this.Controls.Add(this.btnOpenFileKey);
            this.Controls.Add(this.btnOpenFileText);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.tbSplit);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.rbtn6x6);
            this.Controls.Add(this.rbtn5x5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Playfair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playfair";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private RadioButton rbtn5x5;
        private RadioButton rbtn6x6;
        private Guna.UI2.WinForms.Guna2TextBox tbResult;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox tbSplit;
        private Guna.UI2.WinForms.Guna2Button btnEncrypt;
        private Guna.UI2.WinForms.Guna2Button btnDecrypt;
        private Guna.UI2.WinForms.Guna2TextBox tbKey;
        private Guna.UI2.WinForms.Guna2TextBox tbText;
        private Guna.UI2.WinForms.Guna2Button btnOpenFileText;
        private Guna.UI2.WinForms.Guna2Button btnOpenFileKey;
        private DataGridView dgvKeyMatrix;
    }
}

