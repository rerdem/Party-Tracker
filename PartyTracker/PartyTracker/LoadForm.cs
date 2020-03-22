using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyTracker
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();

            okButton.Click += (sender, e) => { Close(); };
        }
        
        public string ShowDialog(List<string> availableParties)
        {
            partyListComboBox.DataSource = availableParties;

            if (availableParties.Count == 0)
            {
                okButton.Enabled = false;
            }

            return ShowDialog() == DialogResult.OK ? partyListComboBox.SelectedItem.ToString() : "";
        }
    }
}
