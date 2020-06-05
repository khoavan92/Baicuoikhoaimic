using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost; User Id=root; Password ='';Database=db_cs1;convert zero datetime=True");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlCommand command = new MySqlCommand();
        public DataSet ds = new DataSet();
        public String currentid = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetRecords();
        }
        public void GetRecords()
        {
            ds = new DataSet();
            adapter = new MySqlDataAdapter("select * from tbl_task", conn);
            adapter.Fill(ds, "tbl_task");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tbl_task";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ds = new DataSet();

            var checkboxValue = 0;
            if (statusCheckbox.Checked == true)
            {
                checkboxValue = 1;
            }

            adapter = new MySqlDataAdapter("insert into tbl_task (task_name,status,created_date,due_date,tags) VALUES ('" + taskBox.Text + "','" + checkboxValue + "','" + CD.Value.ToString("yyyy-MM-dd HH:mm") + "','" + DD.Value.ToString("yyyy-MM-dd HH:mm") + "','" + tagsBox.Text + "')", conn);
            adapter.Fill(ds, "tbl_task");
            GetRecords();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ds = new DataSet();

            var checkboxValue = 0;
            if (statusCheckbox.Checked == true)
            {
                checkboxValue = 1;
            }

            adapter = new MySqlDataAdapter("update tbl_task set task_name = '" + taskBox.Text + "',status = '" + checkboxValue + "',created_date = '" + CD.Value.ToString("yyyy-MM-dd HH:mm") + "',due_date = '" + DD.Value.ToString("yyyy-MM-dd HH:mm") + "',tags = '" + tagsBox.Text + "' where id = " + currentid, conn);
            adapter.Fill(ds, "tbl_task");
            GetRecords();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            currentid = dataGridView1[0, i].Value.ToString();
            taskBox.Text = dataGridView1[1, i].Value.ToString();

            if (dataGridView1[2, i].Value.ToString() == "1")
            {
                statusCheckbox.Checked = true;
            }

            else
            {
                statusCheckbox.Checked = false;
            }

            CD.Value = DateTime.Parse(dataGridView1[3, i].Value.ToString());
            DD.Value = DateTime.Parse(dataGridView1[4, i].Value.ToString());
            tagsBox.Text = dataGridView1[5, i].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            currentid = dataGridView1[0, i].Value.ToString();
            ds = new DataSet();
            adapter = new MySqlDataAdapter("delete from tbl_task where id = " + currentid, conn);
            adapter.Fill(ds, "tbl_task");
            GetRecords();
        }

        private void searchData(string valueToSearch)
        {
            ds = new DataSet();
            adapter = new MySqlDataAdapter("select * from tbl_task where concat(task_name,status,created_date,due_date,tags) like '%" + valueToSearch +"%'" , conn);
            adapter.Fill(ds, "tbl_task");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tbl_task";

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string valueToSearch = seachtextBox.Text.ToString();
            searchData(valueToSearch);
        }
    }
}