using RawExplorer.Classes;
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

namespace RawExplorer
{
    public partial class MainForm : Form
    {
        //public List<RawFile> FilesCollection { get; }
        private OpenFileDialog openFileDialog;
        private DataTable GridData = new DataTable();


        public MainForm()
        {

            InitializeComponent();

            Grid.DataSource = GridData;
            GridData.Columns.Add("File", typeof(RawFile));


            Grid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[0].Width = 2;
            Grid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            Grid.Columns[1].MinimumWidth = 200;
            Grid.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            Grid.Columns[0].Visible = false;
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var image = Image.FromFile((GridData.Rows[e.RowIndex].Field<RawFile>("File")).RawPath);
                pictureBox.Image = image;
            
            }
            catch
            { }

            //pictureBox.Image
        }

        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            //GridData.Rows.Add(new RawFile("1", "24"));
            //GridData.Rows.Add(new RawFile("2", "33"));
            //GridData.Rows.Add(new RawFile("3", "2e"));

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                foreach (var file in files)
                {
                    GridData.Rows.Add(new RawFile(Path.GetFileName(file), file));
                }
            }
        }
    }
}
