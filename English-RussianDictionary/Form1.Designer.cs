
namespace English_RussianDictionary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUrl = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnTranslation = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLableDictionari = new System.Windows.Forms.Label();
            this.pTranslations = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pSettings = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nameDictionary = new System.Windows.Forms.TextBox();
            this.chengeDictionary = new System.Windows.Forms.Button();
            this.pSetting2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btcCreateDictionary = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pTranslations.SuspendLayout();
            this.pSettings.SuspendLayout();
            this.pSetting2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Перевод";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ввод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnUrl);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnTranslation);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 322);
            this.panel1.TabIndex = 3;
            // 
            // btnUrl
            // 
            this.btnUrl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUrl.FlatAppearance.BorderSize = 0;
            this.btnUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUrl.Location = new System.Drawing.Point(0, 277);
            this.btnUrl.Name = "btnUrl";
            this.btnUrl.Size = new System.Drawing.Size(186, 45);
            this.btnUrl.TabIndex = 5;
            this.btnUrl.Text = "GitHub.com";
            this.btnUrl.UseVisualStyleBackColor = true;
            this.btnUrl.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSettings.Location = new System.Drawing.Point(0, 157);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 45);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnTranslation
            // 
            this.btnTranslation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTranslation.FlatAppearance.BorderSize = 0;
            this.btnTranslation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTranslation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnTranslation.Location = new System.Drawing.Point(0, 112);
            this.btnTranslation.Name = "btnTranslation";
            this.btnTranslation.Size = new System.Drawing.Size(186, 45);
            this.btnTranslation.TabIndex = 1;
            this.btnTranslation.Text = "Перевод";
            this.btnTranslation.UseVisualStyleBackColor = true;
            this.btnTranslation.Click += new System.EventHandler(this.btnTranslation_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 112);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(60, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Словарь";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::English_RussianDictionary.Properties.Resources._3000_3000_max;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nameLableDictionari
            // 
            this.nameLableDictionari.AutoSize = true;
            this.nameLableDictionari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLableDictionari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.nameLableDictionari.Location = new System.Drawing.Point(205, 234);
            this.nameLableDictionari.Name = "nameLableDictionari";
            this.nameLableDictionari.Size = new System.Drawing.Size(0, 16);
            this.nameLableDictionari.TabIndex = 2;
            this.nameLableDictionari.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pTranslations
            // 
            this.pTranslations.Controls.Add(this.textBox1);
            this.pTranslations.Controls.Add(this.button1);
            this.pTranslations.Controls.Add(this.label1);
            this.pTranslations.Location = new System.Drawing.Point(203, 12);
            this.pTranslations.Name = "pTranslations";
            this.pTranslations.Size = new System.Drawing.Size(200, 100);
            this.pTranslations.TabIndex = 4;
            // 
            // pSettings
            // 
            this.pSettings.Controls.Add(this.label4);
            this.pSettings.Controls.Add(this.nameDictionary);
            this.pSettings.Controls.Add(this.chengeDictionary);
            this.pSettings.Location = new System.Drawing.Point(206, 144);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(306, 36);
            this.pSettings.TabIndex = 5;
            this.pSettings.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Выбрать словарь";
            // 
            // nameDictionary
            // 
            this.nameDictionary.Location = new System.Drawing.Point(122, 3);
            this.nameDictionary.Name = "nameDictionary";
            this.nameDictionary.Size = new System.Drawing.Size(100, 23);
            this.nameDictionary.TabIndex = 2;
            // 
            // chengeDictionary
            // 
            this.chengeDictionary.Location = new System.Drawing.Point(228, 4);
            this.chengeDictionary.Name = "chengeDictionary";
            this.chengeDictionary.Size = new System.Drawing.Size(75, 23);
            this.chengeDictionary.TabIndex = 1;
            this.chengeDictionary.Text = "Изменить";
            this.chengeDictionary.UseVisualStyleBackColor = true;
            this.chengeDictionary.Click += new System.EventHandler(this.chengeDictionary_Click);
            // 
            // pSetting2
            // 
            this.pSetting2.Controls.Add(this.label5);
            this.pSetting2.Controls.Add(this.btcCreateDictionary);
            this.pSetting2.Controls.Add(this.textBox3);
            this.pSetting2.Location = new System.Drawing.Point(200, 12);
            this.pSetting2.Name = "pSetting2";
            this.pSetting2.Size = new System.Drawing.Size(312, 73);
            this.pSetting2.TabIndex = 6;
            this.pSetting2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Создать новый словарь";
            // 
            // btcCreateDictionary
            // 
            this.btcCreateDictionary.Location = new System.Drawing.Point(119, 41);
            this.btcCreateDictionary.Name = "btcCreateDictionary";
            this.btcCreateDictionary.Size = new System.Drawing.Size(75, 23);
            this.btcCreateDictionary.TabIndex = 1;
            this.btcCreateDictionary.Text = "Создать";
            this.btcCreateDictionary.UseVisualStyleBackColor = true;
            this.btcCreateDictionary.Click += new System.EventHandler(this.btcCreateDictionary_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(577, 322);
            this.Controls.Add(this.nameLableDictionari);
            this.Controls.Add(this.pSetting2);
            this.Controls.Add(this.pSettings);
            this.Controls.Add(this.pTranslations);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(593, 361);
            this.Name = "Form1";
            this.Text = "Словарь";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pTranslations.ResumeLayout(false);
            this.pTranslations.PerformLayout();
            this.pSettings.ResumeLayout(false);
            this.pSettings.PerformLayout();
            this.pSetting2.ResumeLayout(false);
            this.pSetting2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUrl;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnTranslation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pTranslations;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pSettings;
        private System.Windows.Forms.TextBox nameDictionary;
        private System.Windows.Forms.Button chengeDictionary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pSetting2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btcCreateDictionary;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label nameLableDictionari;
    }
}

