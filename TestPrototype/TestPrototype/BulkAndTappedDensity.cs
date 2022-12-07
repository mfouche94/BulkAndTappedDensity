using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPrototype
{
    public partial class BulkAndTappedDensity : Form
    {
        public BulkAndTappedDensity()
        {
            InitializeComponent();
        }

        double bulkDensity;
        double tappedDensity;
        double interParticlePorosity;
        double carrIndex;
        double hausnerRatio;
        public DataTable parameters = new DataTable();

        private void HausnerRatio(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxBulkDensity.Text) && !string.IsNullOrEmpty(textBoxTappedDensity.Text))
            {
                
            }
        }

        private void File_Click(object sender, EventArgs e)
        {
            //Ignore this method.  Was created accidentally when setting up Form. App seems to break when you delete this however.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Ignore this method.  Was created accidentally when setting up Form. App seems to break when you delete this, however.
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //Ignore this method.  Was created accidentally when setting up Form. App seems to break when you delete this, however.
        }

        //Calculates Hausner Ratio, Inter-particle Porosity and Carr Index
        private void btnCalculateParameters_Click(object sender, EventArgs e)
        {
            bool testBulkDensity = double.TryParse(textBoxBulkDensity.Text, out bulkDensity);
            if (testBulkDensity == false)
            {
                MessageBox.Show("Bulk Density value invalid");
                return;
            }
            bool testTappedDensity = double.TryParse(textBoxTappedDensity.Text, out tappedDensity);
            if (testTappedDensity == false)
            {
                MessageBox.Show("Tapped Density value invalid");
                return;
            }
            bulkDensity = Convert.ToDouble(textBoxBulkDensity.Text);
            tappedDensity = Convert.ToDouble(textBoxTappedDensity.Text);
            if (bulkDensity == 0 || tappedDensity == 0)
            {
                MessageBox.Show("Density values must be greater than zero");
                return;
            }

            hausnerRatio = tappedDensity / bulkDensity;
            textBoxHausnerRatio.Text = hausnerRatio.ToString();
            interParticlePorosity = (tappedDensity - bulkDensity) / (tappedDensity * bulkDensity);
            textBoxInterParticlePorosity.Text = interParticlePorosity.ToString();
            carrIndex = (tappedDensity - bulkDensity) / tappedDensity;
            textBoxCarrIndex.Text = carrIndex.ToString();
            parameters.Rows.Add(bulkDensity, tappedDensity, interParticlePorosity, hausnerRatio, carrIndex);

            textBoxBulkDensity.Text = "";
            textBoxTappedDensity.Text = "";
            
          
             
        }

        private void BulkAndTappedDensity_Load(object sender, EventArgs e)
        {
            
            parameters.Columns.Add("Bulk Density");
            parameters.Columns.Add("Tapped Density");
            parameters.Columns.Add("Inter particle porosity");
            parameters.Columns.Add("Hausner Ratio");
            parameters.Columns.Add("Carr Index");
            dataGridView1.DataSource = parameters;

        }

        private void saveCSV_Click(object sender, EventArgs e)
        {
            if (parameters == null || parameters.Rows.Count == 0)
            {
                MessageBox.Show("No Data to Save");
                return;
            }
            System.Windows.Forms.SaveFileDialog saveFileDialog1;
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.Filter = "CSV File|*.csv";
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                csvUtilities.ToCSV(parameters, filename);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (parameters.Rows.Count == 0)
            {
                return;
            }
            int rownumber = dataGridView1.SelectedRows[0].Index;
            parameters.Rows.RemoveAt(rownumber);
        }
    }
}
