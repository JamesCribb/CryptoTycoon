using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoTycoon
{
    public partial class TravelForm : Form
    {
        public Location Destination { get; set; }

        public TravelForm(List<Location> locations)
        {
            InitializeComponent();
            locations.ForEach(l => travelComboBox.Items.Add(l));
        }

        private void travelOkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void travelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Destination = (Location)travelComboBox.SelectedItem;
        }
    }
}
