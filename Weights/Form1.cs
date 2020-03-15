using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weights
{
  public partial class Form1 : Form
  {
    SortedList<string, Double> WeightConversionFactors = new SortedList<string, double>();
    public Form1()
    {
      InitializeComponent();
      // You make a sortedlist and you add the conversions to it
      WeightConversionFactors.Add("Mercury", 0.3772);
      WeightConversionFactors.Add("Venus"  , 0.9042);
      WeightConversionFactors.Add("Mars"   , 0.3783);
    }

    private void btnConvert_Click(object sender, EventArgs e)
    {
      // Real basic math is done + displayed
      double earthWeight = Convert.ToDouble(txtEarthWeight.Text);
      double mercuryWeight = earthWeight * WeightConversionFactors["Mercury"];
      double venusWeight = earthWeight * WeightConversionFactors["Venus"];
      double marsWeight = earthWeight * WeightConversionFactors["Mars"];

      txtMercWeight.Text = mercuryWeight.ToString();
      txtVenusWeight.Text = venusWeight.ToString();
      txtMarsWeight.Text = marsWeight.ToString();
    }
  }
}
