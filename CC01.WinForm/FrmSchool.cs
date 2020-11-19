using CC01.BLL;
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

namespace CC01.WinForm
{
    public partial class FrmSchool : Form
    {
        private Action callBack;
        private School oldSchool;
        public FrmSchool()
        {
            InitializeComponent();
        }

    public FrmSchool(Action callBack):this()
        {
            this.callBack = callBack;
        }
        public FrmSchool(School school, Action callBack) : this()
        {
            this.oldSchool = school;
            tbAcronym.Text = school.Acronym;
            tbLocation.Text = school.Location;
            tbSchool.Text = school.Schoolname;
            if (!string.IsNullOrEmpty(school.Logo))
                pictureBox1.ImageLocation = Path.Combine(ConfigurationManager.AppSettings["DbFolder"], "logo", school.Logo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSchool_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();
                string filename = null;
                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                {

                    string ext = Path.GetExtension(pictureBox1.ImageLocation);
                    filename = Guid.NewGuid().ToString() + ext;
                    FileInfo fileSource = new FileInfo(pictureBox1.ImageLocation);
                    string filePath = Path.Combine(ConfigurationManager.AppSettings["DbFolder"], "logo", filename);
                    FileInfo fileDest = new FileInfo(filePath);
                    if (!fileDest.Directory.Exists)
                        fileDest.Directory.Create();
                    fileSource.CopyTo(fileDest.FullName);
                }

                School newSchool = new School
                (
                    tbAcronym.Text.ToUpper(),
                    tbLocation.Text,
                    tbSchool.Text,
                    !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldSchool?.Picture,
                    filename
                );
                SchoolBLO schoolBLO = new SchoolBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldSchool == null)
                    schoolBLO.CreateSchool(newSchool);
                else
                    schoolBLO.EditSchool(oldSchool, newSchool);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldSchool != null)
                    Close();

                tbAcronym.Clear();
                tbLocation.Clear();
                tbSchool.Clear();
                tbAcronym.Focus();

            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Duplicate error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Not found error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }
        private void checkForm()
        {
            string text = string.Empty;
            tbAcronym.BackColor = Color.White;
            tbSchool.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(tbAcronym.Text))
            {
                text += "- Please enter the acronym ! \n";
                tbAcronym.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(tbSchool.Text))
            {
                text += "- Please enter the name ! \n";
                tbSchool.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }
    }
}
