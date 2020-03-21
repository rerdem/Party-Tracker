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
        private PartyManager pm;

        public SaveForm(PartyManager manager)
        {
            InitializeComponent();

            pm = manager;

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
            //to do: check, if party name already exists
            

            if ((!string.IsNullOrWhiteSpace(partyNameBox.Text)) && (pm.IsPartyNameUnique(partyNameBox.Text)))
            {
                errorLabel.Visible = false;
                okButton.Enabled = true;
            }
            else
            {
                if (!pm.IsPartyNameUnique(partyNameBox.Text))
                {
                    errorLabel.Visible = true;
                }
                else
                {
                    errorLabel.Visible = false;
                }

                okButton.Enabled = false;
            }
        }
    }
}
