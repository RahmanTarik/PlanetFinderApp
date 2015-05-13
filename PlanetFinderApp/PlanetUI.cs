using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetFinderApp
{
    public partial class PlanetUI : Form
    {
        public PlanetUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string planetName = planetComboBox.SelectedItem.ToString();

            if (planetName == "Mercury")
            {
                MessageBox.Show("It is in no " + planetComboBox.SelectedIndex + " position");
            }
            else if (planetName == "Venus")
            {
                MessageBox.Show(planetName + " is in no " + planetComboBox.SelectedIndex + " position");
            }
            else if (planetName == "Earth")
            {
                MessageBox.Show(planetName + " is in no " + planetComboBox.SelectedIndex + " position");
            }
            else if (planetName == "Mars")
            {
                MessageBox.Show(planetName + " is in no " + planetComboBox.SelectedIndex + " position");
            }
            else if (planetName == "Jupiter")
            {
                MessageBox.Show(planetName + " is in no " + planetComboBox.SelectedIndex + " position");
            }
            else if (planetName == "Saturn")
            {
                MessageBox.Show(planetName + " is in no " + planetComboBox.SelectedIndex + " position");
            }
            else if (planetName == "Uranus")
            {
                MessageBox.Show(planetName + " is in no " + planetComboBox.SelectedIndex + " position");
            }
            else if (planetName == "Neptune")
            {
                MessageBox.Show(planetName + " is in no " + planetComboBox.SelectedIndex + " position");
            }
            else
            {
                MessageBox.Show("I don’t know");
            }
        }
    }
}
