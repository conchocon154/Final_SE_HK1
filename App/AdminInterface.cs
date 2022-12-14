using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Admin : MaterialForm


    {
        readonly MaterialSkinManager materialSkinManager;
        static string conn = ConfigurationManager.ConnectionStrings["App.Properties.Settings.CosmesticDBConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(conn);

        public Admin()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            this.dataUser.DefaultCellStyle.ForeColor = Color.Black;

            // Configure color schema
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                Primary.Grey50, Primary.Grey50,
                Primary.Grey50, Accent.Blue100,
                TextShade.BLACK
            );
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var frm = new formLogin();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cosmesticDBDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.cosmesticDBDataSet.User);

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            connection.Open();

            String name = txtUsernameAdmin.Text;
            String pass = txtPassAdmin.Text;

            SqlCommand cmdAdd = new SqlCommand("insert into [User] values('" + name + "', '" + pass + "', '','','','','')", connection);
            try
            {
                int isAdd = cmdAdd.ExecuteNonQuery();

                if (isAdd > 0)
                {
                    MessageBox.Show("User Added");

                    this.userTableAdapter.Fill(this.cosmesticDBDataSet.User);
                    dataUser.Update();
                    dataUser.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }catch(Exception er)
            {
                MessageBox.Show("Failed");
            }

    connection.Close();
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            connection.Open();

            foreach (DataGridViewRow item in this.dataUser.SelectedRows)
            {
                String user = item.Cells[0].Value.ToString();
                SqlCommand cmdDel = new SqlCommand("delete from [User] where username = '"+user+"'", connection);

                try { 
                int isDel = cmdDel.ExecuteNonQuery();

                if (isDel > 0)
                {
                    MessageBox.Show("User Deleted");
                    this.userTableAdapter.Fill(this.cosmesticDBDataSet.User);
                    dataUser.Update();
                    dataUser.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Failed");
                }
            }

            connection.Close();
        }

        private void dataUser_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataUser.SelectedRows.Count > 0)
            {
                btnDelUser.Enabled = true;
                btnUpdateUser.Enabled = true;
            }
            else
            {
                btnDelUser.Enabled = false;
                btnUpdateUser.Enabled = false;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            connection.Open();

            foreach (DataGridViewRow item in this.dataUser.SelectedRows)
            {
                String user = item.Cells[0].Value.ToString();
                String newname = txtUsernameAdmin.Text;
                String newpass = txtPassAdmin.Text;

                SqlCommand cmdUpd = new SqlCommand("update [User] set username = '"+newname+"', password = '"+newpass+"' where username = '" + user + "'", connection);
                try
                {

                
                int isUpd = cmdUpd.ExecuteNonQuery();

                if (isUpd > 0)
                {
                    MessageBox.Show("User Updated");
                    this.userTableAdapter.Fill(this.cosmesticDBDataSet.User);
                   
                    dataUser.Refresh();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Failed");
                }
            }

            connection.Close();
        }
    }
}
