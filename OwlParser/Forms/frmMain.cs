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
using System.Xml.Serialization;
using OwlParser.App;
using OwlParser.App.Schemas.Bpmn;
using OwlParser.Models;
using OwlParser.Scripts;

namespace OwlParser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Ontology ontology = new();
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                ontology = LoadOwlFile.LoadDocument<Ontology>(openFileDialog1.FileName);
                cbxClasses.Items.AddRange(ontology.GetDeclarationNames());

                var teste = App.XmlReader.ReadFile<App.Schemas.Owl.Ontology>(openFileDialog1.FileName);
                Parser parser = new();
                var bpmn = parser.ToBpmn(teste);

                XmlSerializer serializer = new XmlSerializer(typeof(RootDefinitions));
                using (TextWriter writer = new StreamWriter(@"C:\dev\test.xml"))
                {
                    serializer.Serialize(writer, bpmn);
                }

                
            }
        }

        private void btnSelectClass_Click(object sender, EventArgs e)
        {
            string selectedClass = cbxClasses.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedClass))
            {
                GetClassTree(selectedClass);
            }
        }

        private void GetClassTree(string selectedClass)
        {
            txtResult.Clear();
            List<string> subClassNamesList = new();

            var equivalentClasses = ontology.GetEquivalentClassesList(selectedClass);

            foreach (var equivalentClass in equivalentClasses)
            {
                txtResult.AppendText($"{equivalentClass.Class.IRI} --> ");
                var subclassNames = GetObjectValues(equivalentClass.ObjectSomeValuesFrom, equivalentClass.ObjectIntersectionOf);
                subClassNamesList.AddRange(subclassNames);
            }

            foreach (var name in subClassNamesList)
            {
                var subClass = ontology.GetSubClassByName(name);
                txtResult.AppendText($"{name} --> ");
                GetObjectValues(subClass.ObjectSomeValuesFrom, subClass.ObjectIntersectionOf);
            }
        }

        private List<string> GetObjectValues(OntologyObjectSomeValues objectSomeValue, OntologyObjectSomeValues[] objectIntersectionOf)
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

    }
}
