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
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();

            okButton.Click += (sender, e) => { Close(); };
        }
        
        public string ShowDialog(string title, string content)
        {
            Text = title;
            partyNameBox.Text = content;

            return ShowDialog() == DialogResult.OK ? partyNameBox.Text : "";
        }

        private void partyNameBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(partyNameBox.Text))
            {
                okButton.Enabled = true;
            }
            else
            {
                okButton.Enabled = false;
            }
        }
    }
}
