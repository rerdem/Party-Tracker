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
    public partial class NoteEditor : Form
    {
        public NoteEditor()
        {
            InitializeComponent();

            okButton.Click += (sender, e) => { Close(); };
        }

        public string ShowDialog(string title, string content)
        {
            Text = title;
            markdownBox.Text = content;

            return ShowDialog() == DialogResult.OK ? markdownBox.Text : "";
        }

        private void markdownBox_TextChanged(object sender, EventArgs e)
        {
            string md = markdownBox.Text;
            string html = Markdig.Markdown.ToHtml(md);
            htmlPreview.DocumentText = html;
        }
    }
}
