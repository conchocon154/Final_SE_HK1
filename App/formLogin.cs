using MaterialSkin;
using MaterialSkin.Controls;
using MySqlConnector;
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
    public partial class formLogin : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        static string conn = ConfigurationManager.ConnectionStrings["App.Properties.Settings.CosmesticDBConnectionString"].ConnectionString;
        MySqlConnection connection = new MySqlConnection(conn);


        public formLogin()
        {
          
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
       

            // Configure color schema
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                Primary.Grey50, Primary.Grey50,
                Primary.Grey50, Accent.Blue100,
                TextShade.BLACK
            );
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();

            String username = txtUsername.Text;
            String password = txtPassword.Text;
            Boolean checkLogin = false;

            using ( var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "select username, password from `Users` where username ='" + username + "' and password ='" + password +"'";
                using(var reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        checkLogin = true;
                       
                        if(username == "admin")
                        {
                            var frm = new Admin();
                            frm.Location = this.Location;
                            frm.StartPosition = FormStartPosition.Manual;
                            frm.FormClosing += delegate { this.Show(); };
                            frm.Show();
                            this.Hide();
                        } else
                        {
                            var frm = new formUserInterface(username);
                            frm.Location = this.Location;
                            frm.StartPosition = FormStartPosition.Manual;
                            frm.FormClosing += delegate { this.Show(); };
                            frm.Show();
                            this.Hide();
                        }
                                              
                        return;
                    }
                    if (checkLogin == false)
                    {
                        MessageBox.Show("Login failed");
                    }
                }
            }
            connection.Close();
            
            
        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
