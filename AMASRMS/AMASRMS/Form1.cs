using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMASRMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    dataGridView.DataSource = aMASTUDENTSBindingSource;
                else
                {
                    var query = from o in this.MyDB.AMA_STUDENTS
                                where o.StudentID.Contains(txtSearch.Text) || o.LastName == txtSearch.Text || o.MiddleName == txtSearch.Text || o.FirstName == txtSearch.Text || o.Gender == txtSearch.Text || o.Nationality == txtSearch.Text || o.DOB == txtSearch.Text || o.HomeAddress == txtSearch.Text || o.MobileNo == txtSearch.Text || o.Guardian == txtSearch.Text || o.ContactNo == txtSearch.Text || o.DateOfAdmission == txtSearch.Text || o.SchoolYear == txtSearch.Text || o.YearLevel == txtSearch.Text || o.Department == txtSearch.Text || o.Section == txtSearch.Text || o.Remarks.Contains(txtSearch.Text)
                                select o;
                    dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    aMASTUDENTSBindingSource.RemoveCurrent();
            }
        }

        private void BBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        PhotoBox.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtID.Focus();
                this.MyDB.AMA_STUDENTS.AddAMA_STUDENTSRow(this.MyDB.AMA_STUDENTS.NewAMA_STUDENTSRow());
                aMASTUDENTSBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                aMASTUDENTSBindingSource.ResetBindings(false);
            }
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtID.Focus();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            aMASTUDENTSBindingSource.ResetBindings(false);
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            try
            {
                aMASTUDENTSBindingSource.EndEdit();
                aMA_STUDENTSTableAdapter.Update(this.MyDB.AMA_STUDENTS);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                aMASTUDENTSBindingSource.ResetBindings(false);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDB.AMA_STUDENTS' table. You can move, or remove it, as needed.
            this.aMA_STUDENTSTableAdapter.Fill(this.MyDB.AMA_STUDENTS);
            aMASTUDENTSBindingSource.DataSource = this.MyDB.AMA_STUDENTS;
        }
    }
}
