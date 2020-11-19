using CC01.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForm
{
    public partial class FrmSchoolList : Form
    {
        private SchoolBLO schoolBLO;
        public FrmSchoolList()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            schoolBLO = new SchoolBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        private void loadData()
        {
            string value = tbSearch.Text.ToLower();
            var schools = schoolBLO.GetBy
            (
                x =>
                x.Acronym.ToLower().Contains(value) ||
                x.Schoolname.ToLower().Contains(value)
            ).OrderBy(x => x.Reference).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = schools;
            lblCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridView1.ClearSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new FrmSchool
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as School,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form f = new FrmSchool(loadData);
            f.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this product(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        schoolBLO.DeleteSchool(dataGridView1.SelectedRows[i].DataBoundItem as School);
                    }
                    loadData();
                }
            }
        }

        private void FrmSchoolList_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }
    }
}
