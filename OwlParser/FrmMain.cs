using OwlParser.Lib;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OwlParser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void BtnParse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSaveLocation.Text))
                ParseAndSaveFiles();
        }

        private void ParseAndSaveFiles()
        {
            try
            {
                var fileContent = Encoding.UTF8.GetString(File.ReadAllBytes(openFileDialog1.FileName));
                Parser parser = new(fileContent);
                var bpmnFiles = parser.ToBpmnXmlFile();

                Directory.CreateDirectory(TxtSaveLocation.Text);
                foreach (var file in bpmnFiles)
                {
                    File.WriteAllText(Path.Combine(TxtSaveLocation.Text, file.Name), file.Content, Encoding.UTF8);
                }

                if(MessageBox.Show("Arquivo convertido com sucesso! \nDeseja abrir a pasta onde foi salvo?", "Sucesso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process.Start("explorer.exe", TxtSaveLocation.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ao converter");
            }
        }

    }
}
