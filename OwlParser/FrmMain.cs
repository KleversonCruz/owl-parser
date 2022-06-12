using OwlParser.Lib;
using System;
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
        private string fileContent;

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                fileContent = Encoding.UTF8.GetString(File.ReadAllBytes(openFileDialog1.FileName));
            }
        }

        private void BtnParse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSaveLocation.Text))
            {
                try
                {
                    Parser parser = new(fileContent);
                    var bpmnString = parser.ToBpmnString();
                    File.WriteAllText(TxtSaveLocation.Text, bpmnString.First(), Encoding.UTF8);
                    MessageBox.Show("XML convertido com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Text, ex.Message);
                }
            }
        }


    }
}
