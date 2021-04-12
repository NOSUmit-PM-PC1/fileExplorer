using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fileExplorer
{
    public partial class FormExplorer : Form
    {
        public FormExplorer()
        {
            InitializeComponent();
        }

        private void FormExplorer_Load(object sender, EventArgs e)
        {
            listViewFolder.Columns.Add("имя папки", 300);
            listViewFolder.Columns.Add("дата создания", 300);

            DirectoryInfo di = new DirectoryInfo(@"d:\ПМ 2020");
            DirectoryInfo[] dir = di.GetDirectories(); 
            

            //MessageBox.Show(dir[2]);
            foreach (var d in dir)
            {
                ListViewItem element = new ListViewItem(d.FullName, 0);
                //element.SubItems.Add(d.Name);
                element.SubItems.Add(d.LastWriteTime.ToString());
                listViewFolder.Items.Add(element);
            }
        }

        private void listViewFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFolder.SelectedItems.Count > 0)
            {
                string s = listViewFolder.SelectedItems[0].Text;
                listBoxFiles.Items.Clear();
                foreach (var f in Directory.GetFiles(s))
                    listBoxFiles.Items.Add(f);
                //MessageBox.Show(s);
            }
        }
    }
}
