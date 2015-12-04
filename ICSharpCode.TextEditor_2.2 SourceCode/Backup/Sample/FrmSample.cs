using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Gui.CompletionWindow;
using ICSharpCode.TextEditor.Document;
using ICSharpCode.TextEditor.Actions;

namespace Sample
{
    public partial class FrmSample : Form
    {
        string[] modes = new string[]{"ASP3/XHTML","BAT","Boo","Coco","C++.NET","C#","HTML",
            "Java","JavaScript","PHP","TeX","VBNET","XML","TSQL"};

        public FrmSample()
        {
            InitializeComponent();

            this.cmbModes.Items.AddRange(modes);

            txtContent.Encoding = System.Text.Encoding.Default;

            this.cmbModes.SelectedIndexChanged += delegate
            {
                txtContent.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy(this.cmbModes.Text);
            };

            this.cmbModes.SelectedItem = "C#";
        }
    }
}