using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormAdmin : Form
    {
        private Form activeForm;
        private string id, balance, login, password, access;
        private Database db = new Database();

        public FormAdmin()
        {
            InitializeComponent();
            db.UpdateTable(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            FormCreateNew fcn = new FormCreateNew();
            fcn.ShowDialog();
            fcn.Dispose();
            db.UpdateTable(dataGridView1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAuthorization());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.UpdateTable(dataGridView1);
        }

        private void textBorSearch_TextChanged(object sender, EventArgs e)
        {
            db.Search("SELECT * FROM users WHERE login LIKE '%" + textBorSearch.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            login = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            password = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            access = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            balance = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            User user = new User(Int32.Parse(id), login, password, Int32.Parse(access), Int32.Parse(balance));
            if (e.ColumnIndex == 0)
            {
                FormEditUser feu = new FormEditUser(user);
                feu.ShowDialog();
                feu.Dispose();
                db.UpdateTable(dataGridView1);
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if (user.GetAccess() == 5)
                {
                    MessageBox.Show("You can't delete the main admin");
                    return;
                }else if (MessageBox.Show("Are you want to delete user record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    db.DeleteUser(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    db.UpdateTable(dataGridView1);
                }
                return;
            }
        }

        public string GetId()
        {
            return id;
        }
        public string GetPassword()
        {
            return password;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnDropDatabase_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to drop database?", "Drop database", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                db.DropDataBase();
                db.UpdateTable(dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
