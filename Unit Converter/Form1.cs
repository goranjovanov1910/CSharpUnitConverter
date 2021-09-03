using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class UnitConverter : Form
    {
        public const double pi = 3.14159265358979;
        public UnitConverter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbfrom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtype.SelectedItem == "Volume")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Mililitres");
                cbfrom.Items.Add("Cubic centimetres");
                cbfrom.Items.Add("Litres");
                cbfrom.Items.Add("Cubic metres");
                cbfrom.Items.Add("Teaspoons (US)");
                cbfrom.Items.Add("Tablespoons (US)");
                cbfrom.Items.Add("Fluid ounces (US)");
                cbfrom.Items.Add("Pints (US)");
                cbfrom.Items.Add("Quarts (US)");
                cbfrom.Items.Add("Gallons (US)");
                cbfrom.Items.Add("Cubic inches");
                cbfrom.Items.Add("Cubic feet");
                cbfrom.Items.Add("Cubic yards");
                cbfrom.Items.Add("Teaspoons (UK)");
                cbfrom.Items.Add("Tablespoons (UK)");
                cbfrom.Items.Add("Cubic feet");
                cbfrom.Items.Add("Fluid ounces (UK)");
                cbfrom.Items.Add("Pints (UK)");
                cbfrom.Items.Add("Quarts (UK)");
                cbfrom.Items.Add("Gallons (UK)");
                cbto.Items.Add("Mililitres");
                cbto.Items.Add("Cubic centimetres");
                cbto.Items.Add("Litres");
                cbto.Items.Add("Cubic metres");
                cbto.Items.Add("Teaspoons (US)");
                cbto.Items.Add("Tablespoons (US)");
                cbto.Items.Add("Fluid ounces (US)");
                cbto.Items.Add("Cups (US)");
                cbto.Items.Add("Pints (US)");
                cbto.Items.Add("Quarts (US)");
                cbto.Items.Add("Gallons (US)");
                cbto.Items.Add("Cubic inches");
                cbto.Items.Add("Cubic feet");
                cbto.Items.Add("Cubic yards");
                cbto.Items.Add("Teaspoons (UK)");
                cbto.Items.Add("Tablespoons (UK)");
                cbto.Items.Add("Fluid ounces (UK)");
                cbto.Items.Add("Pints (UK)");
                cbto.Items.Add("Quarts (UK)");
                cbto.Items.Add("Gallons (UK)");
            }
            if (cbtype.SelectedItem == "Length")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Nanometres");
                cbfrom.Items.Add("Microns");
                cbfrom.Items.Add("Millimetres");
                cbfrom.Items.Add("Centimetres");
                cbfrom.Items.Add("Metres");
                cbfrom.Items.Add("Kilometres");
                cbfrom.Items.Add("Inches");
                cbfrom.Items.Add("Feet");
                cbfrom.Items.Add("Yards");
                cbfrom.Items.Add("Miles");
                cbfrom.Items.Add("Nautical Miles");
                cbto.Items.Add("Nanometres");
                cbto.Items.Add("Microns");
                cbto.Items.Add("Millimetres");
                cbto.Items.Add("Centimetres");
                cbto.Items.Add("Metres");
                cbto.Items.Add("Kilometres");
                cbto.Items.Add("Inches");
                cbto.Items.Add("Feet");
                cbto.Items.Add("Yards");
                cbto.Items.Add("Miles");
                cbto.Items.Add("Nautical Miles");
            }
            if (cbtype.SelectedItem == "Weight")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Carats");
                cbfrom.Items.Add("Milligrams");
                cbfrom.Items.Add("Centigrams");
                cbfrom.Items.Add("Decigrams");
                cbfrom.Items.Add("Grams");
                cbfrom.Items.Add("Decagrams");
                cbfrom.Items.Add("Hectograms");
                cbfrom.Items.Add("Kilograms");
                cbfrom.Items.Add("Metric tonnes");
                cbfrom.Items.Add("Ounces");
                cbfrom.Items.Add("Pounds");
                cbfrom.Items.Add("Stone");
                cbfrom.Items.Add("Short tons (US)");
                cbfrom.Items.Add("Long tons (UK)");
                cbto.Items.Add("Carats");
                cbto.Items.Add("Milligrams");
                cbto.Items.Add("Centigrams");
                cbto.Items.Add("Decigrams");
                cbto.Items.Add("Grams");
                cbto.Items.Add("Decagrams");
                cbto.Items.Add("Hectograms");
                cbto.Items.Add("Kilograms");
                cbto.Items.Add("Metric tonnes");
                cbto.Items.Add("Ounces");
                cbto.Items.Add("Pounds");
                cbto.Items.Add("Stone");
                cbto.Items.Add("Short tons (US)");
                cbto.Items.Add("Long tons (UK)");
            }
            if (cbtype.SelectedItem == "Temperature")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Celsius");
                cbfrom.Items.Add("Fahrenheit");
                cbfrom.Items.Add("Kelvin");
                cbto.Items.Add("Celsius");
                cbto.Items.Add("Fahrenheit");
                cbto.Items.Add("Kelvin");
            }
            if (cbtype.SelectedItem == "Energy")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Electron volts");
                cbfrom.Items.Add("Joules");
                cbfrom.Items.Add("Kilojoules");
                cbfrom.Items.Add("Thermal calories");
                cbfrom.Items.Add("Food calories");
                cbfrom.Items.Add("Foot-pounds");
                cbfrom.Items.Add("British thermal units");
                cbto.Items.Add("Electron volts");
                cbto.Items.Add("Joules");
                cbto.Items.Add("Kilojoules");
                cbto.Items.Add("Thermal calories");
                cbto.Items.Add("Food calories");
                cbto.Items.Add("Foot-pounds");
                cbto.Items.Add("British thermal units");
            }
            if (cbtype.SelectedItem == "Area")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Square millimetres");
                cbfrom.Items.Add("Square centimetres");
                cbfrom.Items.Add("Square metres");
                cbfrom.Items.Add("Hectares");
                cbfrom.Items.Add("Square kilometres");
                cbfrom.Items.Add("Square inches");
                cbfrom.Items.Add("Square feet");
                cbfrom.Items.Add("Square yards");
                cbfrom.Items.Add("Acres");
                cbto.Items.Add("Square millimetres");
                cbto.Items.Add("Square centimetres");
                cbto.Items.Add("Square metres");
                cbto.Items.Add("Hectares");
                cbto.Items.Add("Square kilometres");
                cbto.Items.Add("Square inches");
                cbto.Items.Add("Square feet");
                cbto.Items.Add("Square yards");
                cbto.Items.Add("Acres");
            }
            if (cbtype.SelectedItem == "Speed")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Centimetres per second");
                cbfrom.Items.Add("Metres per second");
                cbfrom.Items.Add("Kilometres per hour");
                cbfrom.Items.Add("Feet per second");
                cbfrom.Items.Add("Miles per hour");
                cbfrom.Items.Add("Knots");
                cbfrom.Items.Add("Mach");
                cbto.Items.Add("Centimetres per second");
                cbto.Items.Add("Metres per second");
                cbto.Items.Add("Kilometres per hour");
                cbto.Items.Add("Feet per second");
                cbto.Items.Add("Miles per hour");
                cbto.Items.Add("Knots");
                cbto.Items.Add("Mach");
            }
            if (cbtype.SelectedItem == "Time")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Microseconds");
                cbfrom.Items.Add("Milliseconds");
                cbfrom.Items.Add("Seconds");
                cbfrom.Items.Add("Minutes");
                cbfrom.Items.Add("Hours");
                cbfrom.Items.Add("Days");
                cbfrom.Items.Add("Weeks");
                cbfrom.Items.Add("Years");
                cbto.Items.Add("Microseconds");
                cbto.Items.Add("Milliseconds");
                cbto.Items.Add("Seconds");
                cbto.Items.Add("Minutes");
                cbto.Items.Add("Hours");
                cbto.Items.Add("Days");
                cbto.Items.Add("Weeks");
                cbto.Items.Add("Years");
            }
            if (cbtype.SelectedItem == "Power")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Walts");
                cbfrom.Items.Add("Kilowalts");
                cbfrom.Items.Add("Horsepower (US)");
                cbfrom.Items.Add("Foot-pounds/minute");
                cbfrom.Items.Add("BTUs/minute");
                cbto.Items.Add("Walts");
                cbto.Items.Add("Kilowalts");
                cbto.Items.Add("Horsepower (US)");
                cbto.Items.Add("Foot-pounds/minute");
                cbto.Items.Add("BTUs/minute");
            }
            if (cbtype.SelectedItem == "Pressure")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Atmospheres");
                cbfrom.Items.Add("Bars");
                cbfrom.Items.Add("Kilopascals");
                cbfrom.Items.Add("Millimetres of mercury");
                cbfrom.Items.Add("Pascals");
                cbfrom.Items.Add("Pounds per square inch");
                cbto.Items.Add("Atmospheres");
                cbto.Items.Add("Bars");
                cbto.Items.Add("Kilopascals");
                cbto.Items.Add("Millimetres of mercury");
                cbto.Items.Add("Pascals");
                cbto.Items.Add("Pounds per square inch");
            }
            if (cbtype.SelectedItem == "Angle")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Degrees");
                cbfrom.Items.Add("Radians");
                cbfrom.Items.Add("Gradians");
                cbto.Items.Add("Degrees");
                cbto.Items.Add("Radians");
                cbto.Items.Add("Gradians");
            }
        }
        private void tbto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            if(tbfrom.Text!="")
            {
                if(cbtype.SelectedItem == "Volume")
                {
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4.928922);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 14.78677);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 29.57353);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 236.5882);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 473.1765);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 946.3529);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3785.412);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 16.38706);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 28316.85);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 764544.9);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 5.919388);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 17.75816);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 28.41306);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 568.2613);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1136.523);
                    }
                    if (cbfrom.SelectedItem == "Millilitres" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4546.09);
                    }

                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4.928922);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 14.78677);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 29.57353);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 236.5882);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 473.1765);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 946.3529);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3785.412);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 16.38706);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 28316.85);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 764544.9);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 5.919388);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 17.75816);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 28.41306);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 568.2613);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1136.523);
                    }
                    if (cbfrom.SelectedItem == "Cubic centimetres" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4546.09);
                    }

                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 202.8841);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 67.62804);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 33.81402);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4.226753);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.113376);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.056688);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3.785412);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 61.02374);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 28.31685);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 764.5549);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 168.9364);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 56.31213);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 35.19508);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) *1.759754);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.136523);
                    }
                    if (cbfrom.SelectedItem == "Litres" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4.54609);
                    }

                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 202884.1);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 67628.04);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 33814.02);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4226.753);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2113.376);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1056.688);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 264.1721);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 61023.74);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 35.31467);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.307951);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 168936.4);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 56312.13);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 35195.08);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1759.754);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 879.877);
                    }
                    if (cbfrom.SelectedItem == "Cubic metres" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 219.9692);
                    }

                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4.928922);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4.928922);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 202.8841);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 202884.1);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 6);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 48);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 95.99999);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 192);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 767.9999);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3.324675);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 574.038);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 155116);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.20095);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3.602849);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 5.764559);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 115.2912);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 230.5824);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (US)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 922.3295);
                    }

                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 14.78677);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 14.78677);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 67.62804);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 67628.04);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 16);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 32);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 64);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 256);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.108225);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1915.013);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 51705.35);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.498023);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.20095);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.92512);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 38.4304);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 76.86079);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (US)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 307.4432);
                    }

                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 29.57353);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 29.57353);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 33.81402);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 33814.02);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Tablespoons (US))")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 8);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 16);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 32);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 128);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.804688);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 957.5065);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 25852.68);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4.996045);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.665348);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.040843);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 19.2152);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 38.4304);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (US)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 153.7216);
                    }

                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 236.5882);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 236.5882);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4.226753);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4226.753);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 48);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 16);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 8);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4  );
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 16);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 14.4375);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 119.6883);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 321.584);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 39.96836);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 13.32279);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 8.326742);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2.4019);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4.8038);
                    }
                    if (cbfrom.SelectedItem == "Cups (US)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 19.2152);
                    }

                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 473.1765);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 473.1765);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2.113376);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2113.376);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 95.99999);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 32);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 16);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 8);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 28.875);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 59.84416);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1615.792);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 79.93672);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 26.64557);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1665348);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.20095);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2.4019);
                    }
                    if (cbfrom.SelectedItem == "Pints (US)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 9.607599);
                    }

                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 946.3529);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 946.3529);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.0566688);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1056.688);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 192);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 64);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 32);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 57.75);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 29.92208);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 807.8961);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 159.8734);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 53.29115);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 33.30697);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.665348);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.20095);
                    }
                    if (cbfrom.SelectedItem == "Quarts (US)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4.8038);
                    }

                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3785.412);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3785.412);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3.785412);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 264.1721);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 767.9999);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 256);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 128);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 16);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 8);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 231);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 7.480519);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 201.974);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 639.4938);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 213.1646);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 133.2279);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6.661993);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3.330697);
                    }
                    if (cbfrom.SelectedItem == "Gallons (US)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.20095);
                    }

                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 16.68706);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 16.68706);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 61.02374);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 61023.74);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3.324675);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.108225);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.804688);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 14.4375);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 28.875);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 57.75);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 231);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1728);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 46656);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.768371);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.08367);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.733871);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 34.67743);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 69.35486);
                    }
                    if (cbfrom.SelectedItem == "Cubic inches" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 277.4194);
                    }

                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 28316.85);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 28316.85);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 28.31685);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 35.31467);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 5745.038);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1915.013);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 957.5065);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 119.6883);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 59.84416);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 29.92208);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 7.480519);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1728);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 27);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4783.746);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1594.582);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 996.6137);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 49.83068);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 24.91534);
                    }
                    if (cbfrom.SelectedItem == "Cubic feet" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6.228835);
                    }

                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 764554.9);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 764554.9);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 764.5549);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.307951);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 155116);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 51705.35);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 25852.68);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3231.584);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1615.792);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 807.8961);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 201.974);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 46656);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 27);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 129161.1);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 43053.71);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 26908.57);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1345.428);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 672.7142);
                    }
                    if (cbfrom.SelectedItem == "Cubic yards" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 168.1786);
                    }

                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 5.919388);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 5.919388);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 168.9364);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 168936.4);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 120095);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2.498023);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4.996045);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 39.96836);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 79.93672);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 159.8734);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 639.4938);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2.768371);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4783.746);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 129161.1);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4.8);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 96);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 192);
                    }
                    if (cbfrom.SelectedItem == "Teaspoons (UK)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 768);
                    }

                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 17.75816);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 17.75816);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 56.31213);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 56312.13);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3.602849);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.20095);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.665348);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 13.32279);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 26.64557);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 53.29115);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 213.1646);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.08367);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1594.582);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 49053.71);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.6);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 32);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 64);
                    }
                    if (cbfrom.SelectedItem == "Tablespoons (UK)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 256);
                    }

                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 28.41306);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 28.41306);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 35.19508);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 35195.08);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Teapoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 5.764559);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.92152);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.040843);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 8.326742);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 16.65348);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 33.30697);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 133.2279);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.733871);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 996.6137);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 26908.57);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4.8);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.6);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 20);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 40);
                    }
                    if (cbfrom.SelectedItem == "Fluid ounces (UK)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 160);
                    }

                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 568.2613);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 568.2613);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.759754);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1759.754);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 115.2912);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 38.4304);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 19.2152);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.4019);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.20095);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.665348);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 6.661393);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 34.67743);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 49.83068);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1345.428);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 96);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 32);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 20);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2);
                    }
                    if (cbfrom.SelectedItem == "Pints (UK)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 8);
                    }

                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1136.523);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1136.523);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.136523);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 879.877);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 230.8524);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 76.86079);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 38.4304);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4.8038);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.4019);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.20095);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3.330697);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 69.35486);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 24.91534);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 672.7142);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 192);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 64);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 40);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2);
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Quarts (UK)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4);
                    }

                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Millilitres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4546.09);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Cubic centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4546.09);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Litres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4.54609);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Cubic metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 219.9692);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Teaspoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 922.3295);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Tablespoons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 307.4432);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Fluid ounces (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 153.7216);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Cups (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 19.2152);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Pints (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 9.607599);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Quarts (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4.8038);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Gallons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.20095);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Cubic inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 277.4194);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Cubic feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6.228835);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Cubic yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 168.1786);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Teaspoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 768);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Tablespoons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 256);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Fluid ounces (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 160);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Pints (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 8);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Quarts (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4);
                    }
                    if (cbfrom.SelectedItem == "Gallons (UK)" && cbto.SelectedItem == "Gallons (UK)")
                    {
                        tbto.Text = tbfrom.Text;
                    }



                }
                if (cbtype.SelectedItem == "Length")
                {
                    if (cbfrom.SelectedItem == "Nanometres" && cbto.SelectedItem == "Nanometres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Nanometres" && cbto.SelectedItem == "Microns")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Nanometres" && cbto.SelectedItem == "Millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000);
                    }
                    if (cbfrom.SelectedItem == "Nanometres" && cbto.SelectedItem == "Centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10000000);
                    }
                    if (cbfrom.SelectedItem == "Nanometres" && cbto.SelectedItem == "Metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000000);
                    }
                    if (cbfrom.SelectedItem == "Nanometres" && cbto.SelectedItem == "Kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000000000);
                    }
                    if (cbfrom.SelectedItem == "Nanometres" && cbto.SelectedItem == "Inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 25400000);
                    }
                    if (cbfrom.SelectedItem == "Nanometres" && cbto.SelectedItem == "Feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 304800000);
                    }
                    if (cbfrom.SelectedItem == "Nanometres" && cbto.SelectedItem == "Yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 914400000);
                    }
                    if (cbfrom.SelectedItem == "Nanometres" && cbto.SelectedItem == "Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1609344000000);
                    }
                    if (cbfrom.SelectedItem == "Nanometres" && cbto.SelectedItem == "Nautical Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1852000000000);
                    }

                    if (cbfrom.SelectedItem == "Microns" && cbto.SelectedItem == "Nanometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Microns" && cbto.SelectedItem == "Microns")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Microns" && cbto.SelectedItem == "Millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Microns" && cbto.SelectedItem == "Centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10000);
                    }
                    if (cbfrom.SelectedItem == "Microns" && cbto.SelectedItem == "Metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000);
                    }
                    if (cbfrom.SelectedItem == "Microns" && cbto.SelectedItem == "Kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000000);
                    }
                    if (cbfrom.SelectedItem == "Microns" && cbto.SelectedItem == "Inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 25400);
                    }
                    if (cbfrom.SelectedItem == "Microns" && cbto.SelectedItem == "Feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3048000);
                    }
                    if (cbfrom.SelectedItem == "Microns" && cbto.SelectedItem == "Yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 914400);
                    }
                    if (cbfrom.SelectedItem == "Microns" && cbto.SelectedItem == "Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1609344000);
                    }
                    if (cbfrom.SelectedItem == "Microns" && cbto.SelectedItem == "Nautical Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1852000000);
                    }

                    if (cbfrom.SelectedItem == "Millimetres" && cbto.SelectedItem == "Nanometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000);
                    }
                    if (cbfrom.SelectedItem == "Millimetres" && cbto.SelectedItem == "Microns")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Millimetres" && cbto.SelectedItem == "Millimetres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Millimetres" && cbto.SelectedItem == "Centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10);
                    }
                    if (cbfrom.SelectedItem == "Millimetres" && cbto.SelectedItem == "Metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Millimetres" && cbto.SelectedItem == "Kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000);
                    }
                    if (cbfrom.SelectedItem == "Millimetres" && cbto.SelectedItem == "Inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 25.4);
                    }
                    if (cbfrom.SelectedItem == "Millimetres" && cbto.SelectedItem == "Feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 304.8);
                    }
                    if (cbfrom.SelectedItem == "Millimetres" && cbto.SelectedItem == "Yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 914.4);
                    }
                    if (cbfrom.SelectedItem == "Millimetres" && cbto.SelectedItem == "Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1609344);
                    }
                    if (cbfrom.SelectedItem == "Millimetres" && cbto.SelectedItem == "Nautical Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1852000);
                    }

                    if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Nanometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10000000);
                    }
                    if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Microns")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10000);
                    }
                    if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10);
                    }
                    if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Centimetres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100);
                    }
                    if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100000);
                    }
                    if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2.54);
                    }
                    if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 30.48);
                    }
                    if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 91.44);
                    }
                    if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 160934.4);
                    }
                    if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Nautical Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 185200);
                    }

                    if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Nanometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000000);
                    }
                    if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Microns")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000);
                    }
                    if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100);
                    }
                    if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Metres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 39.37008);
                    }
                    if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3.28084);
                    }
                    if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.093613);
                    }
                    if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1609.344);
                    }
                    if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Nautical Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1852);
                    }

                    if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Nanometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000000000);
                    }
                    if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Microns")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000000);
                    }
                    if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000);
                    }
                    if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100000);
                    }
                    if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Kilometres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 39370.08);
                    }
                    if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3280.84);
                    }
                    if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1093.613);
                    }
                    if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.609344);
                    }
                    if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Nautical Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.852);
                    }

                    if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Nanometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 25400000);
                    }
                    if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Microns")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 25400);
                    }
                    if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 25.4);
                    }
                    if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.54);
                    }
                    if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 39.37008);
                    }
                    if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Inches")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 39370.08);
                    }
                    if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 12);
                    }
                    if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 36);
                    }
                    if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 63360);
                    }
                    if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Nautical Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 72913.39);
                    }

                    if (cbfrom.SelectedItem == "Feet" && cbto.SelectedItem == "Nanometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 304800000);
                    }
                    if (cbfrom.SelectedItem == "Feet" && cbto.SelectedItem == "Microns")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 304800);
                    }
                    if (cbfrom.SelectedItem == "Feet" && cbto.SelectedItem == "Millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 304.8);
                    }
                    if (cbfrom.SelectedItem == "Feet" && cbto.SelectedItem == "Centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 30.48);
                    }
                    if (cbfrom.SelectedItem == "Feet" && cbto.SelectedItem == "Metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3.8084);
                    }
                    if (cbfrom.SelectedItem == "Feet" && cbto.SelectedItem == "Kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3280.84);
                    }
                    if (cbfrom.SelectedItem == "Feet" && cbto.SelectedItem == "Inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 12);
                    }
                    if (cbfrom.SelectedItem == "Feet" && cbto.SelectedItem == "Feet")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Feet" && cbto.SelectedItem == "Yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3);
                    }
                    if (cbfrom.SelectedItem == "Feet" && cbto.SelectedItem == "Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 5280);
                    }
                    if (cbfrom.SelectedItem == "Feet" && cbto.SelectedItem == "Nautical Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 6076.115);
                    }

                    if (cbfrom.SelectedItem == "Yards" && cbto.SelectedItem == "Nanometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 914400000);
                    }
                    if (cbfrom.SelectedItem == "Yards" && cbto.SelectedItem == "Microns")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) *  914400);
                    }
                    if (cbfrom.SelectedItem == "Yards" && cbto.SelectedItem == "Millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 914.4);
                    }
                    if (cbfrom.SelectedItem == "Yards" && cbto.SelectedItem == "Centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 91.44);
                    }
                    if (cbfrom.SelectedItem == "Yards" && cbto.SelectedItem == "Metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.093613);
                    }
                    if (cbfrom.SelectedItem == "Yards" && cbto.SelectedItem == "Kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1093.613);
                    }
                    if (cbfrom.SelectedItem == "Yards" && cbto.SelectedItem == "Inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 36);
                    }
                    if (cbfrom.SelectedItem == "Yards" && cbto.SelectedItem == "Feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3);
                    }
                    if (cbfrom.SelectedItem == "Yards" && cbto.SelectedItem == "Yards")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Yards" && cbto.SelectedItem == "Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1760);
                    }
                    if (cbfrom.SelectedItem == "Yards" && cbto.SelectedItem == "Nautical Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2025.372);
                    }

                    if (cbfrom.SelectedItem == "Miles" && cbto.SelectedItem == "Nanometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1609344000000);
                    }
                    if (cbfrom.SelectedItem == "Miles" && cbto.SelectedItem == "Microns")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1609344000);
                    }
                    if (cbfrom.SelectedItem == "Miles" && cbto.SelectedItem == "Millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1609344);
                    }
                    if (cbfrom.SelectedItem == "Miles" && cbto.SelectedItem == "Centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 160934.4);
                    }
                    if (cbfrom.SelectedItem == "Miles" && cbto.SelectedItem == "Metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1609.344);
                    }
                    if (cbfrom.SelectedItem == "Miles" && cbto.SelectedItem == "Kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.609344);
                    }
                    if (cbfrom.SelectedItem == "Miles" && cbto.SelectedItem == "Inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 63360);
                    }
                    if (cbfrom.SelectedItem == "Miles" && cbto.SelectedItem == "Feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 5280);
                    }
                    if (cbfrom.SelectedItem == "Miles" && cbto.SelectedItem == "Yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1760);
                    }
                    if (cbfrom.SelectedItem == "Miles" && cbto.SelectedItem == "Miles")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Miles" && cbto.SelectedItem == "Nautical Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.150779);
                    }

                    if (cbfrom.SelectedItem == "Nautical Miles" && cbto.SelectedItem == "Nanometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1852000000000);
                    }
                    if (cbfrom.SelectedItem == "Nautical Miles" && cbto.SelectedItem == "Microns")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1852000000);
                    }
                    if (cbfrom.SelectedItem == "Nautical Miles" && cbto.SelectedItem == "Millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1852000);
                    }
                    if (cbfrom.SelectedItem == "Nautical Miles" && cbto.SelectedItem == "Centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 185200);
                    }
                    if (cbfrom.SelectedItem == "Nautical Miles" && cbto.SelectedItem == "Metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1852);
                    }
                    if (cbfrom.SelectedItem == "Nautical Miles" && cbto.SelectedItem == "Kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.852);
                    }
                    if (cbfrom.SelectedItem == "Nautical Miles" && cbto.SelectedItem == "Inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 72913.39);
                    }
                    if (cbfrom.SelectedItem == "Nautical Miles" && cbto.SelectedItem == "Feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6076.115);
                    }
                    if (cbfrom.SelectedItem == "Nautical Miles" && cbto.SelectedItem == "Yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2025.372);
                    }
                    if (cbfrom.SelectedItem == "Nautical Miles" && cbto.SelectedItem == "Miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.150779);
                    }
                    if (cbfrom.SelectedItem == "Nautical Miles" && cbto.SelectedItem == "Nautical Miles")
                    {
                        tbto.Text = tbfrom.Text;
                    }

                    


                }
                if (cbtype.SelectedItem == "Weight")
                {
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 200);
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 20);
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2);
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 5);
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 50);
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 500);
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 5000);
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 5000000);
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 141.7476);
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2267.962);
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 31751.47);
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4535924);
                    }
                    if (cbfrom.SelectedItem == "Carats" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 5080235);
                    }

                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 200);
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10);
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100);
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10000);
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100000);
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000);
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000000);
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 28349.52);
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 453592.4);
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 6350293);
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 907184740);
                    }
                    if (cbfrom.SelectedItem == "Milligrams" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1016046909);
                    }

                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 20);
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10);
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10);
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100);
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10000);
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100000);
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100000000);
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2834.952);
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 45359.24);
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 635029.3);
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 90715474);
                    }
                    if (cbfrom.SelectedItem == "Centigrams" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 101604691);
                    }

                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Carats ")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2);
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100);
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10);
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10);
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100);
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10000);
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10000000);
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 283.4952);
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4535.924);
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 63502.93);
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 9071847);
                    }
                    if (cbfrom.SelectedItem == "Decigrams" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10160469);
                    }

                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 5);
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100);
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10);
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10);
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100);
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000);
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 28.34952);
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 453.5924);
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 6350.293);
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 907184.7);
                    }
                    if (cbfrom.SelectedItem == "Grams" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1016047);
                    }

                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 50);
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10000);
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100);
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10);
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10);
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100);
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100000);
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2.834952 );
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 45.35924);
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 635.0293);
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 90718.47);
                    }
                    if (cbfrom.SelectedItem == "Decagrams" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 101604.7);
                    }

                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 500);
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100000);
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10000);
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100);
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10);
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10);
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10000);
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3.527396);
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4.535924);
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 63.50293);
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 9071.847);
                    }
                    if (cbfrom.SelectedItem == "Hectograms" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10160.47);
                    }

                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 5000);
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000);
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100000);
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10000);
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100);
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10);
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 35.27396);
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.204623);
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 6.350293);
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 907.1847);
                    }
                    if (cbfrom.SelectedItem == "Kilograms" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1016.047);
                    }

                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 5000000);
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000000);
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100000000);
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10000000);
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000);
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100000);
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10000);
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 35273.96);
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2204.623);
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 157.473);
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.102311);
                    }
                    if (cbfrom.SelectedItem == "Metric tonnes" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.016047);
                    }

                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 141.7476);
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 28349.52);
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2834.952);
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 283.4952);
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 28.34952);
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.834952);
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3.527396);
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 35.27396);
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 35273.96);
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 16);
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 224);
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 32000);
                    }
                    if (cbfrom.SelectedItem == "Ounces" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 35840);
                    }

                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2267.962);
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 453592.4);
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 45359.24);
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4535.924);
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 453.5924);
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 45.35924);
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4.535924);
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2.204623);
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2204.623);
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 16);
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 14);
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2000);
                    }
                    if (cbfrom.SelectedItem == "Pounds" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2240);
                    }

                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 31751.47);
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6350293);
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 635029.3);
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 63502.93);
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6350.293);
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 635.0293);
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 63.50293);
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6.350293);
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 157.473);
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 224);
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 14);
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 142.8571);
                    }
                    if (cbfrom.SelectedItem == "Stone" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 160);
                    }

                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4535924);
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 907184740);
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 90718474);
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 9071847);
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 907184.7);
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 90718.47);
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 9071.847);
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 907.1847);
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.102311);
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 32000);
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2000);
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 142.8571);
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Short tons (US)" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.12);
                    }

                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Carats")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 5080235);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Milligrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1016046909);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Centigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 101604691);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Decigrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10160469);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Grams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1016047);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Decagrams")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 101604.7);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Hectograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10160.47);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Kilograms")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1016.047);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Metric tonnes")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.016047);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Ounces")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 35840);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2240);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Stone")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 160);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Short tons (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.12);
                    }
                    if (cbfrom.SelectedItem == "Long tons (UK)" && cbto.SelectedItem == "Long tons (UK)")
                    {
                        tbto.Text = tbfrom.Text;
                    }



                }
                if (cbtype.SelectedItem == "Temperature")
                {
                    if (cbfrom.SelectedItem == "Celsius" && cbto.SelectedItem == "Fahrenheit")
                    {
                        Double C = Convert.ToDouble(tbfrom.Text);
                        tbto.Text = Convert.ToString((1.8 * C) + 32);
                    }
                    if (cbfrom.SelectedItem == "Fahrenheit" && cbto.SelectedItem == "Celsius")
                    {
                        Double F = Convert.ToDouble(tbfrom.Text);
                        Double C = (F - 32) * (5.0 / 9.0);
                        tbto.Text = Convert.ToString(C);
                    }
                    if (cbfrom.SelectedItem == "Fahrenheit" && cbto.SelectedItem == "Kelvin")
                    {
                        Double F = Convert.ToDouble(tbfrom.Text);
                        Double K = (F - 32) * (5.0 / 9.0) + 273.15;
                        tbto.Text = Convert.ToString(K);
                    }
                    if (cbfrom.SelectedItem == "Kelvin" && cbto.SelectedItem == "Fahrenheit")
                    {
                        Double K = Convert.ToDouble(tbfrom.Text);
                        Double F = (K - 273.15) * (9.0 / 5.0) + 32;
                        tbto.Text = Convert.ToString(F);
                    }
                    if (cbfrom.SelectedItem == "Celsius" && cbto.SelectedItem == "Kelvin")
                    {
                        Double C = Convert.ToDouble(tbfrom.Text);
                        Double K = C + 273.15;
                        tbto.Text = Convert.ToString(K);
                    }
                    if (cbfrom.SelectedItem == "Kelvin" && cbto.SelectedItem == "Celsius")
                    {
                        Double K = Convert.ToDouble(tbfrom.Text);
                        Double C = K - 273.15;
                        tbto.Text = Convert.ToString(C);
                    }
                    if (cbfrom.SelectedItem == "Celsius" && cbto.SelectedItem == "Celsius")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Fahrenheit" && cbto.SelectedItem == "Fahrenheit")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Kelvin" && cbto.SelectedItem == "Kelvin")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                }
                if (cbtype.SelectedItem == "Energy")
                {
                    if (cbfrom.SelectedItem == "Electron volts" && cbto.SelectedItem == "Electron volts")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Electron volts" && cbto.SelectedItem == "Joules")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.602177e-19);
                    }
                    if (cbfrom.SelectedItem == "Electron volts" && cbto.SelectedItem == "Kilojoules")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.602177e-22);
                    }
                    if (cbfrom.SelectedItem == "Electron volts" && cbto.SelectedItem == "Thermal calories")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3.829294e-20);
                    }
                    if (cbfrom.SelectedItem == "Electron volts" && cbto.SelectedItem == "Food calories")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3.829294e-23);
                    }
                    if (cbfrom.SelectedItem == "Electron volts" && cbto.SelectedItem == "Foot-pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.181705e-19);
                    }
                    if (cbfrom.SelectedItem == "Electron volts" && cbto.SelectedItem == "British thermal units")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.518570e-22);
                    }

                    if (cbfrom.SelectedItem == "Joules" && cbto.SelectedItem == "Electron volts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6.241509e+18);
                    }
                    if (cbfrom.SelectedItem == "Joules" && cbto.SelectedItem == "Joules")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Joules" && cbto.SelectedItem == "Kilojoules")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Joules" && cbto.SelectedItem == "Thermal calories")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4.184);
                    }
                    if (cbfrom.SelectedItem == "Joules" && cbto.SelectedItem == "Food calories")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4184);
                    }
                    if (cbfrom.SelectedItem == "Joules" && cbto.SelectedItem == "Foot-pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.355818);
                    }
                    if (cbfrom.SelectedItem == "Joules" && cbto.SelectedItem == "British thermal units")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1055.056);
                    }

                    if (cbfrom.SelectedItem == "Kilojoules" && cbto.SelectedItem == "Electron volts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6.241509e+21);
                    }
                    if (cbfrom.SelectedItem == "Kilojoules" && cbto.SelectedItem == "Joules")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Kilojoules" && cbto.SelectedItem == "Kilojoules")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Kilojoules" && cbto.SelectedItem == "Thermal calories")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 239.0057);
                    }
                    if (cbfrom.SelectedItem == "Kilojoules" && cbto.SelectedItem == "Food calories")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4.184);
                    }
                    if (cbfrom.SelectedItem == "Kilojoules" && cbto.SelectedItem == "Foot-pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 737.5621);
                    }
                    if (cbfrom.SelectedItem == "Kilojoules" && cbto.SelectedItem == "British thermal units")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.055056);
                    }

                    if (cbfrom.SelectedItem == "Thermal calories" && cbto.SelectedItem == "Electron volts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.611448e+19);
                    }
                    if (cbfrom.SelectedItem == "Thermal calories" && cbto.SelectedItem == "Joules")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) *4.184 );
                    }
                    if (cbfrom.SelectedItem == "Thermal calories" && cbto.SelectedItem == "Kilojoules")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 239.0057);
                    }
                    if (cbfrom.SelectedItem == "Thermal calories" && cbto.SelectedItem == "Thermal calories")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Thermal calories" && cbto.SelectedItem == "Food calories")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Thermal calories" && cbto.SelectedItem == "Foot-pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 308596);
                    }
                    if (cbfrom.SelectedItem == "Thermal calories" && cbto.SelectedItem == "British thermal units")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 252.1644);
                    }

                    if (cbfrom.SelectedItem == "Food calories" && cbto.SelectedItem == "Electron volts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.611448e+22);
                    }
                    if (cbfrom.SelectedItem == "Food calories" && cbto.SelectedItem == "Joules")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4184);
                    }
                    if (cbfrom.SelectedItem == "Food calories" && cbto.SelectedItem == "Kilojoules")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4.184);
                    }
                    if (cbfrom.SelectedItem == "Food calories" && cbto.SelectedItem == "Thermal calories")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Food calories" && cbto.SelectedItem == "Food calories")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Food calories" && cbto.SelectedItem == "Foot-pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3085.96);
                    }
                    if (cbfrom.SelectedItem == "Food calories" && cbto.SelectedItem == "British thermal units")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3.965666);
                    }

                    if (cbfrom.SelectedItem == "Foot-pounds" && cbto.SelectedItem == "Electron volts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 8.462350e+18);
                    }
                    if (cbfrom.SelectedItem == "Foot-pounds" && cbto.SelectedItem == "Joules")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.355818);
                    }
                    if (cbfrom.SelectedItem == "Foot-pounds" && cbto.SelectedItem == "Kilojoules")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 737.5621);
                    }
                    if (cbfrom.SelectedItem == "Foot-pounds" && cbto.SelectedItem == "Thermal calories")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3.08596);
                    }
                    if (cbfrom.SelectedItem == "Foot-pounds" && cbto.SelectedItem == "Food calories")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3085.96);
                    }
                    if (cbfrom.SelectedItem == "Foot-pounds" && cbto.SelectedItem == "Foot-pounds")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Foot-pounds" && cbto.SelectedItem == "British thermal units")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 778.1694);
                    }

                    if (cbfrom.SelectedItem == "British thermal units" && cbto.SelectedItem == "Electron volts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6.585142e+21);
                    }
                    if (cbfrom.SelectedItem == "British thermal units" && cbto.SelectedItem == "Joules")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1055.056);
                    }
                    if (cbfrom.SelectedItem == "British thermal units" && cbto.SelectedItem == "Kilojoules")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.055056);
                    }
                    if (cbfrom.SelectedItem == "British thermal units" && cbto.SelectedItem == "Thermal calories")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 252.1644);
                    }
                    if (cbfrom.SelectedItem == "British thermal units" && cbto.SelectedItem == "Food calories")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3.965666);
                    }
                    if (cbfrom.SelectedItem == "British thermal units" && cbto.SelectedItem == "Foot-pounds")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 778.1694);
                    }
                    if (cbfrom.SelectedItem == "British thermal units" && cbto.SelectedItem == "British thermal units")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                }
                if (cbtype.SelectedItem == "Area")
                {
                    if (cbfrom.SelectedItem == "Square millimetres" && cbto.SelectedItem == "Square millimetres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Square millimetres" && cbto.SelectedItem == "Square centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100);
                    }
                    if (cbfrom.SelectedItem == "Square millimetres" && cbto.SelectedItem == "Square metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000);
                    }
                    if (cbfrom.SelectedItem == "Square millimetres" && cbto.SelectedItem == "Hectares")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10000000000);
                    }
                    if (cbfrom.SelectedItem == "Square millimetres" && cbto.SelectedItem == "Square kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000000000);
                    }
                    if (cbfrom.SelectedItem == "Square millimetres" && cbto.SelectedItem == "Square inche3s")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 645.16);
                    }
                    if (cbfrom.SelectedItem == "Square millimetres" && cbto.SelectedItem == "Square feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 92903.04);
                    }
                    if (cbfrom.SelectedItem == "Square millimetres" && cbto.SelectedItem == "Square yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 836127.4);
                    }
                    if (cbfrom.SelectedItem == "Square millimetres" && cbto.SelectedItem == "Acres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4046856422);
                    }
                    if (cbfrom.SelectedItem == "Square millietres" && cbto.SelectedItem == "Square miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2589988110336);
                    }

                    if (cbfrom.SelectedItem == "Square centimetres" && cbto.SelectedItem == "Square millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100);
                    }
                    if (cbfrom.SelectedItem == "Square centimetres" && cbto.SelectedItem == "Square centimetres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Square centimetres" && cbto.SelectedItem == "Square metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10000);
                    }
                    if (cbfrom.SelectedItem == "Square centimetres" && cbto.SelectedItem == "Hectares")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100000000);
                    }
                    if (cbfrom.SelectedItem == "Square centimetres" && cbto.SelectedItem == "Square kilometrews")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10000000000);
                    }
                    if (cbfrom.SelectedItem == "Square centimetres" && cbto.SelectedItem == "Square inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 6.4516);
                    }
                    if (cbfrom.SelectedItem == "Square centimetres" && cbto.SelectedItem == "Square feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 929.0304);
                    }
                    if (cbfrom.SelectedItem == "Square centimetres" && cbto.SelectedItem == "Suquare yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 8361.274);
                    }
                    if (cbfrom.SelectedItem == "Square centimetres" && cbto.SelectedItem == "Acres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 40468564);
                    }
                    if (cbfrom.SelectedItem == "Square centimetres" && cbto.SelectedItem == "Square miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 25899881103);
                    }

                    if (cbfrom.SelectedItem == "Square metres" && cbto.SelectedItem == "Square millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000);
                    }
                    if (cbfrom.SelectedItem == "Square metres" && cbto.SelectedItem == "Square centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10000);
                    }
                    if (cbfrom.SelectedItem == "Square metres" && cbto.SelectedItem == "Square metres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Square metres" && cbto.SelectedItem == "Hectares")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10000);
                    }
                    if (cbfrom.SelectedItem == "Square metres" && cbto.SelectedItem == "Square kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000000);
                    }
                    if (cbfrom.SelectedItem == "Square metres" && cbto.SelectedItem == "Square inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1550.003);
                    }
                    if (cbfrom.SelectedItem == "Square metres" && cbto.SelectedItem == "Square feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10.76391);
                    }
                    if (cbfrom.SelectedItem == "Square metres" && cbto.SelectedItem == "Square yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.19599);
                    }
                    if (cbfrom.SelectedItem == "Square metres" && cbto.SelectedItem == "Acres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4046.856);
                    }
                    if (cbfrom.SelectedItem == "Square metres" && cbto.SelectedItem == "Square miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2589988);
                    }

                    if (cbfrom.SelectedItem == "Hectares" && cbto.SelectedItem == "Square millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10000000000);
                    }
                    if (cbfrom.SelectedItem == "Hectares" && cbto.SelectedItem == "Square centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100000000);
                    }
                    if (cbfrom.SelectedItem == "Hectares" && cbto.SelectedItem == "Square metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10000);
                    }
                    if (cbfrom.SelectedItem == "Hectares" && cbto.SelectedItem == "Hectares")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Hectares" && cbto.SelectedItem == "Square kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100);
                    }
                    if (cbfrom.SelectedItem == "Hectares" && cbto.SelectedItem == "Square inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 15500031);
                    }
                    if (cbfrom.SelectedItem == "Hectares" && cbto.SelectedItem == "Square feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 107639.1);
                    }
                    if (cbfrom.SelectedItem == "Hectares" && cbto.SelectedItem == "Square yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 11959.9);
                    }
                    if (cbfrom.SelectedItem == "Hectares" && cbto.SelectedItem == "Acres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.471054);
                    }
                    if (cbfrom.SelectedItem == "Hectares" && cbto.SelectedItem == "Square miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 258.9988);
                    }

                    if (cbfrom.SelectedItem == "Square kilometres" && cbto.SelectedItem == "Square millijmetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000000000);
                    }
                    if (cbfrom.SelectedItem == "Square kilometres" && cbto.SelectedItem == "Square centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10000000000);
                    }
                    if (cbfrom.SelectedItem == "Square kilometres" && cbto.SelectedItem == "Square mnetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000000);
                    }
                    if (cbfrom.SelectedItem == "Square kilometres" && cbto.SelectedItem == "Hectares")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100);
                    }
                    if (cbfrom.SelectedItem == "Square kilometres" && cbto.SelectedItem == "Square kilometres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Square kilometres" && cbto.SelectedItem == "Square inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1550003100);
                    }
                    if (cbfrom.SelectedItem == "Square kilometres" && cbto.SelectedItem == "Square feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10763910);
                    }
                    if (cbfrom.SelectedItem == "Square kilometres" && cbto.SelectedItem == "Squarem yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1195990);
                    }
                    if (cbfrom.SelectedItem == "Square kilometres" && cbto.SelectedItem == "Acres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 247.1054);
                    }
                    if (cbfrom.SelectedItem == "Square Metres" && cbto.SelectedItem == "Square miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2.589988);
                    }

                    if (cbfrom.SelectedItem == "Square inches" && cbto.SelectedItem == "Square millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 645.16);
                    }
                    if (cbfrom.SelectedItem == "Square inches" && cbto.SelectedItem == "Square centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6.4516);
                    }
                    if (cbfrom.SelectedItem == "Square inches" && cbto.SelectedItem == "Square metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1550.003);
                    }
                    if (cbfrom.SelectedItem == "Square inches" && cbto.SelectedItem == "Hectares")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 15500031);
                    }
                    if (cbfrom.SelectedItem == "Square inches" && cbto.SelectedItem == "Square kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 155000100);
                    }
                    if (cbfrom.SelectedItem == "Square inches" && cbto.SelectedItem == "Square inches")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Square inches" && cbto.SelectedItem == "Square feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 144);
                    }
                    if (cbfrom.SelectedItem == "Square inches" && cbto.SelectedItem == "Square yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1296);
                    }
                    if (cbfrom.SelectedItem == "Square inches" && cbto.SelectedItem == "Acres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 6272640);
                    }
                    if (cbfrom.SelectedItem == "Square inches" && cbto.SelectedItem == "Square miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4014489600);
                    }

                    if (cbfrom.SelectedItem == "Square feet" && cbto.SelectedItem == "Square millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 92903.04);
                    }
                    if (cbfrom.SelectedItem == "Square feet" && cbto.SelectedItem == "Square centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 929.0304);
                    }
                    if (cbfrom.SelectedItem == "Square feet" && cbto.SelectedItem == "Square metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10.76391);
                    }
                    if (cbfrom.SelectedItem == "Square feet" && cbto.SelectedItem == "Hectares")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 107639.1);
                    }
                    if (cbfrom.SelectedItem == "Square feet" && cbto.SelectedItem == "Square kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 10763910);
                    }
                    if (cbfrom.SelectedItem == "Square feet" && cbto.SelectedItem == "Square inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 144);
                    }
                    if (cbfrom.SelectedItem == "Square feet" && cbto.SelectedItem == "Square feet")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Square feet" && cbto.SelectedItem == "Square yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 9);
                    }
                    if (cbfrom.SelectedItem == "Square feet" && cbto.SelectedItem == "Acres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 43560);
                    }
                    if (cbfrom.SelectedItem == "Square feet" && cbto.SelectedItem == "Square miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 27878400);
                    }

                    if (cbfrom.SelectedItem == "Square yards" && cbto.SelectedItem == "Square millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 836127.4);
                    }
                    if (cbfrom.SelectedItem == "Square yards" && cbto.SelectedItem == "Square centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 8361.274);
                    }
                    if (cbfrom.SelectedItem == "Square yards" && cbto.SelectedItem == "Square metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.19599);
                    }
                    if (cbfrom.SelectedItem == "Square yards" && cbto.SelectedItem == "Hectares")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 11959.9);
                    }
                    if (cbfrom.SelectedItem == "Square yards" && cbto.SelectedItem == "Square kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1195990);
                    }
                    if (cbfrom.SelectedItem == "Square yards" && cbto.SelectedItem == "Square inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1296);
                    }
                    if (cbfrom.SelectedItem == "Square yards" && cbto.SelectedItem == "Square feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 9);
                    }
                    if (cbfrom.SelectedItem == "Square yards" && cbto.SelectedItem == "Square yards")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Square yards" && cbto.SelectedItem == "Acres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 4840);
                    }
                    if (cbfrom.SelectedItem == "Square yards" && cbto.SelectedItem == "Square miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3097600);
                    }

                    if (cbfrom.SelectedItem == "Acres" && cbto.SelectedItem == "Square millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4046856422);
                    }
                    if (cbfrom.SelectedItem == "Acres" && cbto.SelectedItem == "Square centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 40468564);
                    }
                    if (cbfrom.SelectedItem == "Acres" && cbto.SelectedItem == "Square metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4046.856);
                    }
                    if (cbfrom.SelectedItem == "Acres" && cbto.SelectedItem == "Hectares")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2.471054);
                    }
                    if (cbfrom.SelectedItem == "Acres" && cbto.SelectedItem == "Square kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 247.1054);
                    }
                    if (cbfrom.SelectedItem == "Acres" && cbto.SelectedItem == "Square inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6272640);
                    }
                    if (cbfrom.SelectedItem == "Acres" && cbto.SelectedItem == "Square feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 43560);
                    }
                    if (cbfrom.SelectedItem == "Acres" && cbto.SelectedItem == "Square yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4840);
                    }
                    if (cbfrom.SelectedItem == "Acres" && cbto.SelectedItem == "Acres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Acres" && cbto.SelectedItem == "Square miles")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 640);
                    }

                    if (cbfrom.SelectedItem == "Square miles" && cbto.SelectedItem == "Square millimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2589988110336);
                    }
                    if (cbfrom.SelectedItem == "Square miles" && cbto.SelectedItem == "Square centimetres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 25899881103);
                    }
                    if (cbfrom.SelectedItem == "Square miles" && cbto.SelectedItem == "Square metres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2589988);
                    }
                    if (cbfrom.SelectedItem == "Square miles" && cbto.SelectedItem == "Hectares")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 258.9988);
                    }
                    if (cbfrom.SelectedItem == "Square miles" && cbto.SelectedItem == "Square kilometres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.589988);
                    }
                    if (cbfrom.SelectedItem == "Square miles" && cbto.SelectedItem == "Square inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 4014489600);
                    }
                    if (cbfrom.SelectedItem == "Square miles" && cbto.SelectedItem == "Square feet")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 27878400);
                    }
                    if (cbfrom.SelectedItem == "Square miles" && cbto.SelectedItem == "Square yards")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3097600);
                    }
                    if (cbfrom.SelectedItem == "Square miles" && cbto.SelectedItem == "Acres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 640);
                    }
                    if (cbfrom.SelectedItem == "Square miles" && cbto.SelectedItem == "Square miles")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                }
                if (cbtype.SelectedItem == "Speed")
                {
                    if (cbfrom.SelectedItem == "Centimetres per second" && cbto.SelectedItem == "Centimetres per second")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Centimetres per second" && cbto.SelectedItem == "Metres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100);
                    }
                    if (cbfrom.SelectedItem == "Centimetres per second" && cbto.SelectedItem == "Kilometres per hour")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 0.036);
                    }
                    if (cbfrom.SelectedItem == "Centimetres per second" && cbto.SelectedItem == "Feet per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 30.48);
                    }
                    if (cbfrom.SelectedItem == "Centimetres per second" && cbto.SelectedItem == "Miles per hour")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 44.7);
                    }
                    if (cbfrom.SelectedItem == "Centimetres per second" && cbto.SelectedItem == "Knots")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 51.44);
                    }
                    if (cbfrom.SelectedItem == "Centimetres per second" && cbto.SelectedItem == "Mach")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 34030);
                    }

                    if (cbfrom.SelectedItem == "Metres per second" && cbto.SelectedItem == "Centimetres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100);
                    }
                    if (cbfrom.SelectedItem == "Metres per second" && cbto.SelectedItem == "Metres per second")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Metres per second" && cbto.SelectedItem == "Kilometres per hour")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3.6);
                    }
                    if (cbfrom.SelectedItem == "Metres per second" && cbto.SelectedItem == "Feet per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 3.28084);
                    }
                    if (cbfrom.SelectedItem == "Metres per second" && cbto.SelectedItem == "Miles per hour")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 2.237136);
                    }
                    if (cbfrom.SelectedItem == "Metres per second" && cbto.SelectedItem == "Knots")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.944012);
                    }
                    if (cbfrom.SelectedItem == "Metres per second" && cbto.SelectedItem == "Mach")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 340.3);
                    }

                    if (cbfrom.SelectedItem == "Kilometres per hour" && cbto.SelectedItem == "Centimetres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 0.036);
                    }
                    if (cbfrom.SelectedItem == "Kilometres per hour" && cbto.SelectedItem == "Metres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3.6);
                    }
                    if (cbfrom.SelectedItem == "Kilometres per hour" && cbto.SelectedItem == "Kilometres per hour")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Kilometres per hour" && cbto.SelectedItem == "Feet per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.09728);
                    }
                    if (cbfrom.SelectedItem == "Kilometres per hour" && cbto.SelectedItem == "Miles per hour")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.6092);
                    }
                    if (cbfrom.SelectedItem == "Kilometres per hour" && cbto.SelectedItem == "Knots")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.85184);
                    }
                    if (cbfrom.SelectedItem == "Kilometres per hour" && cbto.SelectedItem == "Mach")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1225.08);
                    }

                    if (cbfrom.SelectedItem == "Feet per second" && cbto.SelectedItem == "Centimetres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 30.48);
                    }
                    if (cbfrom.SelectedItem == "Feet per second" && cbto.SelectedItem == "Metres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3.28084);
                    }
                    if (cbfrom.SelectedItem == "Feet per second" && cbto.SelectedItem == "Kilometres per hour")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.09728);
                    }
                    if (cbfrom.SelectedItem == "Feet per second" && cbto.SelectedItem == "Feet per second")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Feet per second" && cbto.SelectedItem == "Miles per hour")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.466535);
                    }
                    if (cbfrom.SelectedItem == "Feet per second" && cbto.SelectedItem == "Knots")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.687664);
                    }
                    if (cbfrom.SelectedItem == "Feet per second" && cbto.SelectedItem == "Mach")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1116.47);
                    }

                    if (cbfrom.SelectedItem == "Miles per hour" && cbto.SelectedItem == "Centimetres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 44.7);
                    }
                    if (cbfrom.SelectedItem == "Miles per hour" && cbto.SelectedItem == "Metres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 2.237136);
                    }
                    if (cbfrom.SelectedItem == "Miles per hour" && cbto.SelectedItem == "Kilometres per hour")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.6092);
                    }
                    if (cbfrom.SelectedItem == "Miles per hour" && cbto.SelectedItem == "Feet per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.466535);
                    }
                    if (cbfrom.SelectedItem == "Miles per hour" && cbto.SelectedItem == "Miles per hhour")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Miles per hour" && cbto.SelectedItem == "Knots")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.150783);
                    }
                    if (cbfrom.SelectedItem == "Miles per hour" && cbto.SelectedItem == "Mach")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 761.2975);
                    }

                    if (cbfrom.SelectedItem == "Knots" && cbto.SelectedItem == "Centimetres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 51.44);
                    }
                    if (cbfrom.SelectedItem == "Knots" && cbto.SelectedItem == "Metres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1944012);
                    }
                    if (cbfrom.SelectedItem == "Knots" && cbto.SelectedItem == "Kilometres per hour")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.85184);
                    }
                    if (cbfrom.SelectedItem == "Knots" && cbto.SelectedItem == "Feet per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.687664);
                    }
                    if (cbfrom.SelectedItem == "Knots" && cbto.SelectedItem == "Miles per hour")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.150783);
                    }
                    if (cbfrom.SelectedItem == "Knots" && cbto.SelectedItem == "Knots")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Knots" && cbto.SelectedItem == "Mach")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 661.5474);
                    }

                    if (cbfrom.SelectedItem == "Mach" && cbto.SelectedItem == "Centimetres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 34030);
                    }
                    if (cbfrom.SelectedItem == "Mach" && cbto.SelectedItem == "Metres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 340.3);
                    }
                    if (cbfrom.SelectedItem == "Mach" && cbto.SelectedItem == "Kilometres per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1225.08);
                    }
                    if (cbfrom.SelectedItem == "Mach" && cbto.SelectedItem == "Feet per second")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1116.47);
                    }
                    if (cbfrom.SelectedItem == "Mach" && cbto.SelectedItem == "Miles per hour")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 761.2975);
                    }
                    if (cbfrom.SelectedItem == "Mach" && cbto.SelectedItem == "Knots")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 661.5474);
                    }
                    if (cbfrom.SelectedItem == "Mach" && cbto.SelectedItem == "Mach")
                    {
                        tbto.Text = tbfrom.Text;
                    }

                }
                if (cbtype.SelectedItem == "Time")
                {
                    if (cbfrom.SelectedItem == "Microseconds" && cbto.SelectedItem == "Microseconds")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Microseconds" && cbto.SelectedItem == "Milliseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Microseconds" && cbto.SelectedItem == "Seconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 1000000);
                    }
                    if (cbfrom.SelectedItem == "Microseconds" && cbto.SelectedItem == "Minutes")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 60000000);
                    }
                    if (cbfrom.SelectedItem == "Microseconds" && cbto.SelectedItem == "Hours")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 3600000000);
                    }
                    if (cbfrom.SelectedItem == "Microseconds" && cbto.SelectedItem == "Days")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 86400000000);
                    }
                    if (cbfrom.SelectedItem == "Microseconds" && cbto.SelectedItem == "Weeks")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 604800000000);
                    }
                    if (cbfrom.SelectedItem == "Microseconds" && cbto.SelectedItem == "Years")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 31557600000000);
                    }

                    if (cbfrom.SelectedItem == "Milliseconds" && cbto.SelectedItem == "Microseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Milliseconds" && cbto.SelectedItem == "Milliseconds")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Milliseconds" && cbto.SelectedItem == "Seconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Milliseconds" && cbto.SelectedItem == "Minutes")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 60000);
                    }
                    if (cbfrom.SelectedItem == "Milliseconds" && cbto.SelectedItem == "Hours")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 3600000);
                    }
                    if (cbfrom.SelectedItem == "Milliseconds" && cbto.SelectedItem == "Days")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 86400000);
                    }
                    if (cbfrom.SelectedItem == "Milliseconds" && cbto.SelectedItem == "Weeks")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 604800000);
                    }
                    if (cbfrom.SelectedItem == "Milliseconds" && cbto.SelectedItem == "Years")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 31557600000);
                    }
                    if (cbfrom.SelectedItem == "Seconds" && cbto.SelectedItem == "Microseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 1000000);
                    }
                    if (cbfrom.SelectedItem == "Seconds" && cbto.SelectedItem == "Milliseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Seconds" && cbto.SelectedItem == "Seconds")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Seconds" && cbto.SelectedItem == "Minutes")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 60);
                    }
                    if (cbfrom.SelectedItem == "Seconds" && cbto.SelectedItem == "Hours")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 3600);
                    }
                    if (cbfrom.SelectedItem == "Seconds" && cbto.SelectedItem == "Days")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 86400);
                    }
                    if (cbfrom.SelectedItem == "Seconds" && cbto.SelectedItem == "Weeks")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 604800);
                    }
                    if (cbfrom.SelectedItem == "Seconds" && cbto.SelectedItem == "Years")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 31557600);
                    }

                    if (cbfrom.SelectedItem == "Minutes" && cbto.SelectedItem == "Microseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 60000000);
                    }
                    if (cbfrom.SelectedItem == "Minutes" && cbto.SelectedItem == "Milliseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 60000);
                    }
                    if (cbfrom.SelectedItem == "Minutes" && cbto.SelectedItem == "Seconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 60);
                    }
                    if (cbfrom.SelectedItem == "Minutes" && cbto.SelectedItem == "Minutes")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Minutes" && cbto.SelectedItem == "Hours")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 60);
                    }
                    if (cbfrom.SelectedItem == "Minutes" && cbto.SelectedItem == "Days")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 1440);
                    }
                    if (cbfrom.SelectedItem == "Minutes" && cbto.SelectedItem == "Weeks")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 10080);
                    }
                    if (cbfrom.SelectedItem == "Minutes" && cbto.SelectedItem == "Years")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 525960);
                    }

                    if (cbfrom.SelectedItem == "Hours" && cbto.SelectedItem == "Microseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 3600000000);
                    }
                    if (cbfrom.SelectedItem == "Hours" && cbto.SelectedItem == "Milliseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 3600000);
                    }
                    if (cbfrom.SelectedItem == "Hours" && cbto.SelectedItem == "Seconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 3600);
                    }
                    if (cbfrom.SelectedItem == "Hours" && cbto.SelectedItem == "Minutes")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 60);
                    }
                    if (cbfrom.SelectedItem == "Hours" && cbto.SelectedItem == "Hours")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Hours" && cbto.SelectedItem == "Days")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 24);
                    }
                    if (cbfrom.SelectedItem == "Hours" && cbto.SelectedItem == "Weeks")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 168);
                    }
                    if (cbfrom.SelectedItem == "Hours" && cbto.SelectedItem == "Years")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 8766);
                    }

                    if (cbfrom.SelectedItem == "Days" && cbto.SelectedItem == "Microseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 86400000000);
                    }
                    if (cbfrom.SelectedItem == "Days" && cbto.SelectedItem == "Milliseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 86400000);
                    }
                    if (cbfrom.SelectedItem == "Days" && cbto.SelectedItem == "Seconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 86400);
                    }
                    if (cbfrom.SelectedItem == "Days" && cbto.SelectedItem == "Minutes")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 1440);
                    }
                    if (cbfrom.SelectedItem == "Days" && cbto.SelectedItem == "Hours")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 24);
                    }
                    if (cbfrom.SelectedItem == "Days" && cbto.SelectedItem == "Days")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Days" && cbto.SelectedItem == "Weeks")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 7);
                    }
                    if (cbfrom.SelectedItem == "Days" && cbto.SelectedItem == "Years")
                    {
                        tbto.Text = Convert.ToString(Double.Parse(tbfrom.Text) / 365.25);
                    }
                    if (cbfrom.SelectedItem == "Weeks" && cbto.SelectedItem == "Microseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 604800000000);
                    }
                    if (cbfrom.SelectedItem == "Weeks" && cbto.SelectedItem == "Milliseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 604800000);
                    }
                    if (cbfrom.SelectedItem == "Weeks" && cbto.SelectedItem == "Seconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 604800);
                    }
                    if (cbfrom.SelectedItem == "Weeks" && cbto.SelectedItem == "Minutes")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 10080);
                    }
                    if (cbfrom.SelectedItem == "Weeks" && cbto.SelectedItem == "Hours")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 168);
                    }
                    if (cbfrom.SelectedItem == "Weeks" && cbto.SelectedItem == "Days")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 7);
                    }
                    if (cbfrom.SelectedItem == "Weeks" && cbto.SelectedItem == "Weeks")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Weeks" && cbto.SelectedItem == "Years")
                    {
                        tbto.Text = Convert.ToString(Double.Parse(tbfrom.Text) / 52.17857);
                    }

                    if (cbfrom.SelectedItem == "Years" && cbto.SelectedItem == "Microseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 31557600000000);
                    }
                    if (cbfrom.SelectedItem == "Years" && cbto.SelectedItem == "Milliseconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 31557600000);
                    }
                    if (cbfrom.SelectedItem == "Years" && cbto.SelectedItem == "Seconds")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 31557600);
                    }
                    if (cbfrom.SelectedItem == "Years" && cbto.SelectedItem == "Minutes")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 525960);
                    }
                    if (cbfrom.SelectedItem == "Years" && cbto.SelectedItem == "Hours")
                    {
                        tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 8766);
                    }
                    if (cbfrom.SelectedItem == "Years" && cbto.SelectedItem == "Days")
                    {
                        tbto.Text = Convert.ToString(Double.Parse(tbfrom.Text) * 365.25);
                    }
                    if (cbfrom.SelectedItem == "Years" && cbto.SelectedItem == "Weeks")
                    {
                        tbto.Text = Convert.ToString(Double.Parse(tbfrom.Text) * 52.17857);
                    }
                    if (cbfrom.SelectedItem == "Years" && cbto.SelectedItem == "Years")
                    {
                        tbto.Text = tbfrom.Text;
                    }

                }
                if (cbtype.SelectedItem == "Power")
                {
                    if (cbfrom.SelectedItem == "Watts" && cbto.SelectedItem == "Watts")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Watts" && cbto.SelectedItem == "Kilowatts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Watts" && cbto.SelectedItem == "Horsepower (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 745.6999);
                    }
                    if (cbfrom.SelectedItem == "Watts" && cbto.SelectedItem == "Foot-pounds/minute")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 44.25373);
                    }
                    if (cbfrom.SelectedItem == "Watts" && cbto.SelectedItem == "BTUs/minute")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 17.58427);
                    }
                    if (cbfrom.SelectedItem == "Kilowatts" && cbto.SelectedItem == "Watts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Kilowatts" && cbto.SelectedItem == "Kilowatts")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Kilowatts" && cbto.SelectedItem == "Horsepower (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.341022);
                    }
                    if (cbfrom.SelectedItem == "Kilowatts" && cbto.SelectedItem == "Foot-pounds/minute")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 44253.73);
                    }
                    if (cbfrom.SelectedItem == "Kilowatts" && cbto.SelectedItem == "BTs/minute")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 56.86902);
                    }
                    if (cbfrom.SelectedItem == "Horsepower" && cbto.SelectedItem == "Watts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 745.6999);
                    }
                    if (cbfrom.SelectedItem == "Horsepower" && cbto.SelectedItem == "Kilowatts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 0.7457);
                    }
                    if (cbfrom.SelectedItem == "Horsepower" && cbto.SelectedItem == "Horsepower")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Horsepower" && cbto.SelectedItem == "Foot-pounds/minute")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 33000);
                    }
                    if (cbfrom.SelectedItem == "Horsepower" && cbto.SelectedItem == "BTUs/minute")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 42.40722);
                    }
                    if (cbfrom.SelectedItem == "Foot-pounds/minute" && cbto.SelectedItem == "Watts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 44.25373);
                    }
                    if (cbfrom.SelectedItem == "Foot-pounds/minute" && cbto.SelectedItem == "Kilowatts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 44253.73);
                    }
                    if (cbfrom.SelectedItem == "Foot-pounds/minute" && cbto.SelectedItem == "Horsepower (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 33000);
                    }
                    if (cbfrom.SelectedItem == "Foot-pounds/minute" && cbto.SelectedItem == "Foot-pounds/minute")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Foot-pounds/minute" && cbto.SelectedItem == "BTUs/minute")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 778.1694);
                    }
                    if (cbfrom.SelectedItem == "BTUs/minute" && cbto.SelectedItem == "Watts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 17.58427);
                    }
                    if (cbfrom.SelectedItem == "BTUs/minute" && cbto.SelectedItem == "Kilowatts")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 56.86902);
                    }
                    if (cbfrom.SelectedItem == "BTUs/minute" && cbto.SelectedItem == "Horsepower (US)")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 42.40722);
                    }
                    if (cbfrom.SelectedItem == "BTUs/minute" && cbto.SelectedItem == "Foot-pounds/minute")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 778.1694);
                    }
                    if (cbfrom.SelectedItem == "BTUs/minute" && cbto.SelectedItem == "BTUs/minute")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                }
                
                if (cbtype.SelectedItem == "Pressure")
                {
                    if (cbfrom.SelectedItem == "Atmospheres" && cbto.SelectedItem == "Atmospheres")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Atmospheres" && cbto.SelectedItem == "Bars")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1.01325);
                    }
                    if (cbfrom.SelectedItem == "Atmospheres" && cbto.SelectedItem == "Kilopascals")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 101.325);
                    }
                    if (cbfrom.SelectedItem == "Atmospheres" && cbto.SelectedItem == "Millimetres of mercury")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 760.1275);
                    }
                    if (cbfrom.SelectedItem == "Atmospheres" && cbto.SelectedItem == "Pascals")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 101325);
                    }
                    if (cbfrom.SelectedItem == "Atmospheres" && cbto.SelectedItem == "Pounds per square inch")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 14.69595);
                    }
                    if (cbfrom.SelectedItem == "Bars" && cbto.SelectedItem == "Atmospheres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1.01325);
                    }
                    if (cbfrom.SelectedItem == "Bars" && cbto.SelectedItem == "Bars")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Bars" && cbto.SelectedItem == "Kilopascals")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100);
                    }
                    if (cbfrom.SelectedItem == "Bars" && cbto.SelectedItem == "Millimetres of mercury")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 750.1875);
                    }
                    if (cbfrom.SelectedItem == "Bars" && cbto.SelectedItem == "Pascals")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100000);
                    }
                    if (cbfrom.SelectedItem == "Bars" && cbto.SelectedItem == "Pounds per square inch")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 14.50377);
                    }
                    if (cbfrom.SelectedItem == "Kilopascals" && cbto.SelectedItem == "Atmospheres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 101.325);
                    }
                    if (cbfrom.SelectedItem == "Kilopascals" && cbto.SelectedItem == "Bars")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100);
                    }
                    if (cbfrom.SelectedItem == "Kilopascals" && cbto.SelectedItem == "Kilopascals")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Kilopascals" && cbto.SelectedItem == "Millimetres of mercury")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 7.501875);
                    }
                    if (cbfrom.SelectedItem == "Kilopascals" && cbto.SelectedItem == "Pascals")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
                    }
                    if (cbfrom.SelectedItem == "Kilopascals" && cbto.SelectedItem == "Pounds per square inch")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 6.895);
                    }
                    if (cbfrom.SelectedItem == "Millimetres of mercury" && cbto.SelectedItem == "Atmospheres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 760.1275);
                    }
                    if (cbfrom.SelectedItem == "Millimetres of mercury" && cbto.SelectedItem == "Bars")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 750.1875);
                    }
                    if (cbfrom.SelectedItem == "Millimetres of mercury" && cbto.SelectedItem == "Kilopascals")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 7.501875);
                    }
                    if (cbfrom.SelectedItem == "Millimetres of mercury" && cbto.SelectedItem == "Millimetres of mercury")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Millimetres of mercury" && cbto.SelectedItem == "Pascals")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 133.3);
                    }
                    if (cbfrom.SelectedItem == "Millimetres of mercury" && cbto.SelectedItem == "Pounds per square inch")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 51.723);
                    }
                    if (cbfrom.SelectedItem == "Pascals" && cbto.SelectedItem == "Atmospheres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 101325);
                    }
                    if (cbfrom.SelectedItem == "Pascals" && cbto.SelectedItem == "Bars")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100000);
                    }
                    if (cbfrom.SelectedItem == "Pascals" && cbto.SelectedItem == "Kilopascalss")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                    }
                    if (cbfrom.SelectedItem == "Pascals" && cbto.SelectedItem == "Millimetres of mercury")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 133.3);
                    }
                    if (cbfrom.SelectedItem == "Pascals" && cbto.SelectedItem == "Pascals")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Pascals" && cbto.SelectedItem == "Pounds per square inch")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 6894.757);
                    }
                    if (cbfrom.SelectedItem == "Pounds per square inch" && cbto.SelectedItem == "Atmospheres")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 14.69595);
                    }
                    if (cbfrom.SelectedItem == "Pounds per square inch" && cbto.SelectedItem == "Bars")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 14.50377);
                    }
                    if (cbfrom.SelectedItem == "Pounds per square inch" && cbto.SelectedItem == "Kilopascals")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6.895);
                    }
                    if (cbfrom.SelectedItem == "Pounds per square inch" && cbto.SelectedItem == "Millimetres of mercury")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 51.723);
                    }
                    if (cbfrom.SelectedItem == "Pounds per square inch" && cbto.SelectedItem == "Pascals")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 6894.757);
                    }
                    if (cbfrom.SelectedItem == "Pounds per square inch" && cbto.SelectedItem == "Pounds per square inch")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                }
                if (cbtype.SelectedItem == "Angle")
                {
                    if (cbfrom.SelectedItem == "Degrees" && cbto.SelectedItem == "Radians")
                    {
                        Double D = Convert.ToDouble(tbfrom.Text);
                        Double R = (D * (pi / 180.0));
                        tbto.Text = Convert.ToString(R);
                    }
                    if (cbfrom.SelectedItem == "Degrees" && cbto.SelectedItem == "Gradians")
                    {
                        Double D = Convert.ToDouble(tbfrom.Text);
                        Double G = (D * (200.0 / 180.0));
                        tbto.Text = Convert.ToString(G);
                    }
                    if (cbfrom.SelectedItem == "Degrees" && cbto.SelectedItem == "Degrees")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Radians" && cbto.SelectedItem == "Degrees")
                    {
                        Double R = Convert.ToDouble(tbfrom.Text);
                        Double D = (R * (180.0 / pi));
                        tbto.Text = Convert.ToString(D);
                    }
                    if (cbfrom.SelectedItem == "Radians" && cbto.SelectedItem == "Gradians")
                    {
                        Double R = Convert.ToDouble(tbfrom.Text);
                        Double G = (R * (200.0 / pi));
                        tbto.Text = Convert.ToString(G);
                    }
                    if (cbfrom.SelectedItem == "Radians" && cbto.SelectedItem == "Radians")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                    if (cbfrom.SelectedItem == "Gradians" && cbto.SelectedItem == "Degrees")
                    {
                        Double G = Convert.ToDouble(tbfrom.Text);
                        Double D = (G * (180.0 / 200.0));
                        tbto.Text = Convert.ToString(D);
                    }
                    if (cbfrom.SelectedItem == "Gradians" && cbto.SelectedItem == "Radians")
                    {
                        Double G = Convert.ToDouble(tbfrom.Text);
                        Double R = (G * (pi / 200.0));
                        tbto.Text = Convert.ToString(R);
                    }
                    if (cbfrom.SelectedItem == "Gradians" && cbto.SelectedItem == "Gradians")
                    {
                        tbto.Text = tbfrom.Text;
                    }
                }
            }
            else
            {
                tbto.Text = "";
            }
        }
    }
}