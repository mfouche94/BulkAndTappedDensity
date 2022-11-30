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
            //Ignore this method.  Was created accidentally when setting up Form. App seems to break when you delete this, however
        }

        //Calculates Hausner Ratio, Inter-particle Porosity and Carr Index
        private void btnCalculateParameters_Click(object sender, EventArgs e)
        {
            bulkDensity = Convert.ToDouble(textBoxBulkDensity.Text);
            tappedDensity = Convert.ToDouble(textBoxTappedDensity.Text);
            hausnerRatio = tappedDensity / bulkDensity;
            textBoxHausnerRatio.Text = hausnerRatio.ToString();
            interParticlePorosity = (tappedDensity - bulkDensity) / (tappedDensity * bulkDensity);
            textBoxInterParticlePorosity.Text = interParticlePorosity.ToString();
            carrIndex = (tappedDensity - bulkDensity) / tappedDensity;
            textBoxCarrIndex.Text = carrIndex.ToString();
        }
    }
}
