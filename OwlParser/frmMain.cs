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
using System.Xml;
using System.Xml.Linq;

namespace OwlParser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Ontology document = new();
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;

                var ConteudoArquivo = Encoding.UTF8.GetString(File.ReadAllBytes(openFileDialog1.FileName));
                document = parser.LoadDocument<Ontology>(ConteudoArquivo);

                populateComboBox(document.Declaration);
            }
        }

        private void btnSelectClass_Click(object sender, EventArgs e)
        {
            string selectedClass = cbxClasses.SelectedItem?.ToString();
            var documentList = document.EquivalentClasses.ToList();

            if (!string.IsNullOrEmpty(selectedClass))
            {
                txtResult.Clear();

                var equivalentClasses = documentList.Where(x => x.Class.IRI == selectedClass);
                foreach (var equivalentClass in equivalentClasses)
                {
                    txtResult.AppendText($"{equivalentClass.Class.IRI} --> ");
                    if (equivalentClass.ObjectSomeValuesFrom != null)
                    {
                        txtResult.AppendText($"{equivalentClass.ObjectSomeValuesFrom.ObjectProperty.IRI} --> ");
                        txtResult.AppendText($"{equivalentClass.ObjectSomeValuesFrom.Class.IRI}");

                    }
                    if (equivalentClass.ObjectIntersectionOf != null)
                    {

                        txtResult.AppendText($"{equivalentClass.ObjectIntersectionOf.First().ObjectProperty.IRI} --> ");
                        foreach (var item in equivalentClass.ObjectIntersectionOf)
                        {
                            txtResult.AppendText($"{item.Class.IRI}/");
                        }
                    }
                    txtResult.AppendText(Environment.NewLine);
                }
            }
        }

        private void populateComboBox(OntologyDeclaration[] ontologyDeclarations)
        {
            cbxClasses.Items.Clear();
            foreach (var declaration in ontologyDeclarations)
            {
                if (declaration.Class != null)
                {
                    cbxClasses.Items.Add(declaration.Class.IRI);
                }
            }
        }
    }
}
