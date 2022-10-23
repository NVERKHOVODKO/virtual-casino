using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormAdmin : Form
    {
        private Form activeForm;


        DataSet ds;
        public FormAdmin()
        {
            InitializeComponent();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            Database databaseObject = new Database();
            DataTable datatable = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM users", databaseObject.myConnection);
            databaseObject.OpenConnection();
            adapter.SelectCommand = cmd;
            adapter.Fill(datatable);

            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns["Id"].ReadOnly = true;
            databaseObject.CloseConnection();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*connection.Open();
            adapter = new SqlDataAdapter(sql, connection);
            commandBuilder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = new SqlCommand("sp_CreateUser", connection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@age", SqlDbType.Int, 0, "Age"));

            SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            adapter.Update(ds);*/
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
    }
    
}
