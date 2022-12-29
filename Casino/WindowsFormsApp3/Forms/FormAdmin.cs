using Org.BouncyCastle.Utilities.Collections;
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
        private User user;
        private int curUserId = 0;

        public FormAdmin(User user)
        {
            InitializeComponent();
            db.UpdateTable(dataGridView1);
            this.user = user;
            curUserId = user.GetId();
            label1.Text = user.GetLogin();
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
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.UpdateTable(dataGridView1);
        }

        private void textBorSearch_TextChanged(object sender, EventArgs e)
        {
            db.SearchInDataBase("SELECT * FROM users WHERE login LIKE '%" + textBorSearch.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                login = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                password = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                access = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                balance = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                User user = new User(Int32.Parse(id), login, password, Int32.Parse(access), Int32.Parse(balance));
                if (e.ColumnIndex == 0)
                {
                    if (access == "5")
                    {
                        MessageBox.Show("You can't edit main administrator");
                        return;
                    }
                    FormEditUser feu = new FormEditUser(user);
                    feu.ShowDialog();
                    //feu.Dispose();
                    db.UpdateTable(dataGridView1);
                    return;
                }
                if (e.ColumnIndex == 1)
                {
                    if (user.GetAccess() == 5)
                    {
                        MessageBox.Show("You can't delete the main admin");
                        return;
                    }
                    if (id == curUserId.ToString())
                    {
                        MessageBox.Show("You can't delete yourselt");
                        return;
                    }
                    else if (MessageBox.Show("Are you want to delete user record?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        db.DeleteUser(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                        db.UpdateTable(dataGridView1);
                    }
                    return;
                }
                if (e.ColumnIndex == 2)
                {
                    if (user.GetAccess() == 5)
                    {
                        MessageBox.Show("You can't block the main admin");
                        return;
                    }
                    if (id == curUserId.ToString())
                    {
                        MessageBox.Show("You can't block yourselt");
                        return;
                    }
                    if (access == "0")
                    {
                        if (MessageBox.Show("Are you want to unblock user?", "Block", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            user.SetAccess(1);
                            db.EditUser(login, password, id, balance, "1");
                            db.UpdateTable(dataGridView1);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Are you want to block user?", "Block", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            user.SetAccess(0);
                            db.EditUser(login, password, id, balance, "0");
                            db.UpdateTable(dataGridView1);
                        }
                    }
                    return;
                }
            }
            catch
            {

            }
        }

        public string GetId()
        {
            return id;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            db.SearchInDataBase("SELECT * FROM users WHERE login LIKE '%" + textBox1.Text + "%'", dataGridView1);
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
