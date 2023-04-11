using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using PluginBiblioteca1;

namespace PluginForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Param2_Click(object sender, EventArgs e)
        {

        }

        private void Param1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarPlugInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                if (VerificarCargarPlugIn(openFileDialog1.FileName) == false)
                    MessageBox.Show("No es un plugin valid para nuestra aplicacion");
            }
        }

        private bool VerificarCargarPlugIn(string plugin)
        {
            bool encontrado = false;

            Assembly pluginAsm = null;

            double a = Convert.ToDouble(textBoxParametro1.Text);
            double b = Convert.ToDouble(textBoxParametro2.Text);
            double r = 0.0;

            try
            {
                pluginAsm = Assembly.LoadFrom(plugin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return encontrado;
            }

            var clases = from t in pluginAsm.GetTypes()
                         where t.IsClass && (t.GetInterface("IPlugInMates") != null)
                         select t;

            foreach (Type t in clases)
            {
                encontrado = true;

                IPlugInMates objeto = (IPlugInMates)pluginAsm.CreateInstance(t.FullName, true);

                r = objeto.Calcular(a, b);

                lblResultado.Text = r.ToString();

                var pluginInfo = from ci in t.GetCustomAttributes(false)
                                 where (ci.GetType() == typeof(CInfoPlugin))
                                 select ci;

                foreach (CInfoPlugin c in pluginInfo)
                {
                    lblInfo.Text = c.Creator + ", " + c.Information;
                }
            }

            return encontrado;
             
        }
    }
}
