using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Translator;

namespace English_RussianDictionary
{
    public partial class Form1 : Form
    {
        private string directory = @"dictionary";
        private TranslationManager _manager;
        public Form1()
        {
            InitializeComponent();
            string path = $@"{directory}\English.dsl";
            string path2 = $@"{directory}\Russian.dsl";
            path = path2;

            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
            if (!File.Exists(path)) using (File.Create(path)) ;

            _manager = new TranslationManager(path);
            _manager.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = _manager.Search(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show($"Перевод для '{textBox1.Text}' не найден");
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pTranslations.Visible = false;
            pSettings.Visible = true;
            pSetting2.Visible = true;
        }

        private void btnTranslation_Click(object sender, EventArgs e)
        {
            pTranslations.Visible = true;
            pSettings.Visible = false;
            pSetting2.Visible = false;
        }



        private void btnUrl_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/";
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void btcCreateDictionary_Click(object sender, EventArgs e)
        {
            string path = $@"{directory}\{nameDictionary.Text}.dsl";
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
            if (!File.Exists(path)) using (File.Create(path)) ;
        }

        private void chengeDictionary_Click(object sender, EventArgs e)
        {
            _manager = new TranslationManager(nameDictionary.Text);
            nameLableDictionari.Text = nameDictionary.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
