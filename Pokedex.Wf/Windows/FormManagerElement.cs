using Pokedex.Wf.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex.Wf.Windows
{
    public partial class FormManagerElement : Form
    {
        public DataContext Context { get; set; }

        public FormManagerElement()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
            listBoxElements.DataSource = null;
            listBoxElements.DataSource = Context.Elements;
            listBoxElements.DisplayMember = nameof(Element.FullName);
        }

        private void buttonAddElement_Click(object sender, EventArgs e)
        {
            Element element = new Element("Nouvel élément");
            Context.Elements.Add(element);
            RefreshList();
        }

        private void listBoxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxElements.SelectedItem != null)
                textBoxElementName.Text = ((Element)listBoxElements.SelectedItem).Name;
        }

        private void buttonUpdateElement_Click(object sender, EventArgs e)
        {
            if (listBoxElements.SelectedItem != null)
                ((Element)listBoxElements.SelectedItem).Name = textBoxElementName.Text;
                RefreshList();
        }

        private void buttonDeleteElement_Click(object sender, EventArgs e)
        {
            if (listBoxElements.SelectedItem != null)
                Context.Elements.Remove((Element)listBoxElements.SelectedItem);
                RefreshList();
        }
    }
}
