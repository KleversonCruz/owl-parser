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

                PopulateComboBox(document.Declaration);
            }
        }

        private void btnSelectClass_Click(object sender, EventArgs e)
        {
            string selectedClass = cbxClasses.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedClass))
            {
                GenerateResultTree(selectedClass);
            }
        }

        private void GenerateResultTree(string selectedClass)
        {
            txtResult.Clear();
            List<string> subClassNamesList = new();

            var equivalentClasses = document.EquivalentClasses.ToList().Where(x => x.Class.IRI == selectedClass);

            foreach (var equivalentClass in equivalentClasses)
            {
                txtResult.AppendText($"{equivalentClass.Class.IRI} --> ");
                var subclassNames = GenerateObjectValues(equivalentClass.ObjectSomeValuesFrom, equivalentClass.ObjectIntersectionOf);
                subClassNamesList.AddRange(subclassNames);
            }

            foreach (var name in subClassNamesList)
            {
                var subClasses = document.SubClassOf.ToList().Where(x => x.Class.First().IRI == name && x.ObjectSomeValuesFrom != null).First();
                txtResult.AppendText($"{name} --> ");
                GenerateObjectValues(subClasses.ObjectSomeValuesFrom, subClasses.ObjectIntersectionOf);
            }
        }

        private List<string> GenerateObjectValues(OntologyObjectSomeValues objectSomeValue, OntologyObjectSomeValues[] objectIntersectionOf)
        {
            List<string> subClassNames = new();

            if (objectSomeValue != null)
            {
                txtResult.AppendText($"{objectSomeValue.ObjectProperty.IRI} --> ");
                txtResult.AppendText($"{objectSomeValue.Class.IRI}");
                subClassNames.Add(objectSomeValue.Class.IRI);
            }
            
            if (objectIntersectionOf != null)
            {
                txtResult.AppendText($"{objectIntersectionOf.First().ObjectProperty.IRI} --> ");
                foreach (var item in objectIntersectionOf)
                {
                    txtResult.AppendText($"{item.Class.IRI}/");
                    subClassNames.Add(item.Class.IRI);
                }
            }
            txtResult.AppendText(Environment.NewLine);

            return subClassNames;
        }

        private void PopulateComboBox(OntologyDeclaration[] ontologyDeclarations)
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
