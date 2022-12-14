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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class formUserInterface : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        static string conn = ConfigurationManager.ConnectionStrings["App.Properties.Settings.CosmesticDBConnectionString"].ConnectionString;
        MySqlConnection connection = new MySqlConnection(conn);

        String _username;

        public formUserInterface(String username)
        {

            _username = username;
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
            DrawerBackgroundWithAccent = true;

            dateMonthSelect.CustomFormat = "yyyy-MM";

        }

        private void formUserInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            Application.Exit();
        }


        // LOGOUT TAB
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var frm = new formLogin();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }


        // CHANGE PASSWORD TAB
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPass.Controls)
            {
                    if(control is MaterialTextBox)
                    {
                    MaterialTextBox textBox = (MaterialTextBox)control;
                    textBox.Text = null;
                    }         
            }
        }

        // PROFILE TAB
        private void btnResetProfile_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabProfile.Controls)
            {
                if (control is MaterialTextBox)
                {
                    MaterialTextBox textBox = (MaterialTextBox)control;
                    textBox.Text = null;
                }
                else if ( control is DateTimePicker)
                {
                    DateTimePicker datePicker = (DateTimePicker)control;
                    datePicker.Value = DateTime.Now;
                }
                else if ( control is MaterialMultiLineTextBox2)
                {
                    MaterialMultiLineTextBox2 textBox2 = (MaterialMultiLineTextBox2)control;
                    textBox2.Text = null;
                }
            }
        }

        // GRN TAB
        private void btnGRNReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabGRN.Controls)
            {
                if (control is MaterialTextBox)
                {
                    MaterialTextBox textBox = (MaterialTextBox)control;
                    textBox.Text = null;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker datePicker = (DateTimePicker)control;
                    datePicker.Value = DateTime.Now;
                }
                
            }
        }

        private void btnGRNSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            String insupplier = txtSupplier.Text;
            String inreceiver = txtReceiver.Text;
            String inchecker = txtChecker.Text;
            String inid = txtGRNID.Text;
            
            String dayIn = dateGRN.Value.Day.ToString();
            String monthIn = dateGRN.Value.Month.ToString();
            String yearIn = dateGRN.Value.Year.ToString();
            String inDate = yearIn + "-" + monthIn + "-" + dayIn;

            // add data to GRN table

            MySqlCommand cmdGRN = new MySqlCommand("insert into `GRN` values(@grnid, @supplier, @receiver, @checker, @grndate)", connection);

            cmdGRN.Parameters.AddWithValue("@grnid", inid);
            cmdGRN.Parameters.AddWithValue("@supplier", insupplier);
            cmdGRN.Parameters.AddWithValue("@receiver", inreceiver);
            cmdGRN.Parameters.AddWithValue("@checker", inchecker);
            cmdGRN.Parameters.AddWithValue("@grndate", inDate);
            try
            {

            
            int ifAddGRN = cmdGRN.ExecuteNonQuery();
            int ifAddGRNprod = 0;
            int ifAddProduct = 0;

            // add data to GRNprod and Product table

            for (int i = 0; i < dataGRNProd.Rows.Count -1; i++)
            {

                String inProdID = (string)dataGRNProd.Rows[i].Cells[0].Value;
                String inProdName = (string)dataGRNProd.Rows[i].Cells[1].Value;           
                int inProdQuantity = Convert.ToInt32(dataGRNProd.Rows[i].Cells[2].Value);
                int inProdPrice = Convert.ToInt32(dataGRNProd.Rows[i].Cells[3].Value);


                MySqlCommand checkProd = new MySqlCommand("SELECT count(*) FROM `Product` WHERE (`prodid` = '"+inProdID+ "')", connection);
            

                int prodReader = Convert.ToInt32(checkProd.ExecuteScalar());

                //SqlDataReader prodReader = checkProd.ExecuteReader();
                int checkProdExist = 0;

                if (prodReader != 0)
                {
                    //Product exist
                    checkProdExist = 1;
                }

                    //prodReader.Close();
                    //prodReader.Dispose();

                MySqlCommand cmdProduct;
           
                if (checkProdExist == 1)
                {

                     cmdProduct = new MySqlCommand("update `Product` set prodname = '" + inProdName + "', quantity = quantity + '" + inProdQuantity + "', price =  '" + inProdPrice + "' where prodid = '" + inProdID + "'", connection);
                     Console.WriteLine("alovailoz");

                }
                else
                {
                     cmdProduct = new MySqlCommand("insert into `Product` values('"+ inProdID+"', '"+ inProdName + "', '" + inProdQuantity + "', '" + inProdPrice + "')", connection);
                    
                }
                ifAddProduct = cmdProduct.ExecuteNonQuery();

                MySqlCommand cmdGRNprod = new MySqlCommand("insert into `GRNprod` values('" + inid + "', '" + inProdID + "', '" + inProdQuantity + "')", connection);

                ifAddGRNprod = cmdGRNprod.ExecuteNonQuery();
            }


            
            if (ifAddGRN > 0 && ifAddGRNprod > 0  && ifAddProduct > 0)
            {
                MessageBox.Show("GRN Saved");
            } else
            {
                MessageBox.Show("Failed");
            }
            }catch(Exception er)
            {
                var st = new StackTrace(er, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();

                Console.WriteLine(er.Message + " - " + er.Source + " - L: " + line);
                MessageBox.Show("Failed er");
            }

            connection.Close();
        }

        private void btnProdAdd_Click(object sender, EventArgs e)
        {
            String inProdID = txtProdID.Text;
            String inProdName = txtProdName.Text;
            String inProdQuantity = txtProdQty.Text;
            String inProdPrice = txtProdPrice.Text;
         
            
            this.dataGRNProd.Rows.Add(inProdID, inProdName, inProdQuantity, inProdPrice);

        }

        private void btnProdDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGRNProd.SelectedRows)
            {
                
                dataGRNProd.Rows.RemoveAt(item.Index);
            }
        }

        private void dataGRNProd_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGRNProd.SelectedRows.Count > 0)
            {
                btnProdDel.Enabled = true;
            }
            else
            {
                btnProdDel.Enabled = false;
            }
        }

        // ORDER TAB
        private void btnLoadOrder_Click(object sender, EventArgs e)
        {
            connection.Open();
            String dayFrom = dateListStart.Value.Day.ToString();
            String monthFrom = dateListStart.Value.Month.ToString();
            String yearFrom = dateListStart.Value.Year.ToString();
            String dateFrom = yearFrom + "-" + monthFrom + "-" + dayFrom;

            String dayTo = dateListEnd.Value.Day.ToString();
            String monthTo = dateListEnd.Value.Month.ToString();
            String yearTo = dateListEnd.Value.Year.ToString();
            String dateTo = yearTo + "-" + monthTo + "-" + dayTo;
          

            DataTable dtb = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("select oid from `Orders` where odate BETWEEN '" + dateFrom + "' and '" + dateTo + "'", connection);
            da.Fill(dtb);
            //cmdDate.ExecuteNonQuery();
            comboOrderList.ValueMember = "oid";
            comboOrderList.DisplayMember = "oid";           
            comboOrderList.DataSource = dtb;

            connection.Close();
        }

        private void comboOrderList_SelectedValueChanged(object sender, EventArgs e)
        {
          
            
        }

        private void comboOrderList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            connection.Open();
            
            listViewProdOL.Items.Clear();

            String inoid = comboOrderList.SelectedValue.ToString();
            MySqlCommand cmdOrder = new MySqlCommand("select agentname, agentaddress, agentphone, paymentstt, orderstt from `Orders` where oid = '" + inoid + "'", connection);
            MySqlDataReader sdr = cmdOrder.ExecuteReader();
            while (sdr.Read())
            {
                txtAgentNameOL.Text = sdr["agentname"].ToString();
                txtAgentAddressOL.Text = sdr["agentaddress"].ToString();
                txtAgentPhoneOL.Text = sdr["agentphone"].ToString();
                comboOrderStatusOL.SelectedIndex = comboOrderStatusOL.FindStringExact(sdr["orderstt"].ToString());
                //.Item.IndexOf
                int isPaid = int.Parse(sdr["paymentstt"].ToString());
                if (isPaid == 1)
                {
                    cbxIfPayment.Checked = true;
                }
                else
                {
                    cbxIfPayment.Checked = false;
                }
            }
            sdr.Close();

            //SqlCommand cmdProdOrder = new SqlCommand("select prodid, prodname, quantity, price from Product join Orderprod on Product.prodid = Orderprod.prodid  join `Orders` on `Orders`.oid = Orderprod.oid where`Orders`.oid = '"+ inoid + "'", connection);
            //SqlDataReader tmp = cmdOrder.ExecuteReader();

            DataSet prodDS = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select Product.prodid, Product.prodname, Product.price, Orderprod.quantity from Product join Orderprod on Product.prodid = Orderprod.prodid  join `Orders` on `Orders`.oid = Orderprod.oid where `Orders`.oid = '" + inoid + "'", connection);
            adapter.Fill(prodDS);
            foreach (DataRow row in prodDS.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(row["prodid"].ToString());
                item.SubItems.Add(row["prodname"].ToString());
                item.SubItems.Add(row["quantity"].ToString());
                item.SubItems.Add(row["price"].ToString());
                listViewProdOL.Items.Add(item);
            }

            //tmp.Close();
            connection.Close();
        }

        private void btnSaveOL_Click(object sender, EventArgs e)
        {
            connection.Open();
            String inoid = comboOrderList.SelectedValue.ToString();
            int inPaymentstt = 0;
            String inOrderstt = comboOrderStatusOL.SelectedItem.ToString();

            if(cbxIfPayment.Checked)
            {
                inPaymentstt = 1;
            }
            MySqlCommand cmdProdOrder = new MySqlCommand("update `Orders` set paymentstt = '"+ inPaymentstt+"', orderstt = '"+ inOrderstt+"' where oid = '"+ inoid+"'", connection);
            cmdProdOrder.ExecuteNonQuery();
            MessageBox.Show("Saved");
            connection.Close();
        }

        // GDN TAB

        private void btnLoadGDN_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dtbGDN = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("select oid from `Orders` where orderstt = 'Pending'", connection);
            da.Fill(dtbGDN);
            //cmdDate.ExecuteNonQuery();
            comboOrderGDN.ValueMember = "oid";
            comboOrderGDN.DisplayMember = "oid";
            comboOrderGDN.DataSource = dtbGDN;

            connection.Close();
        }

        private void comboOrderGDN_SelectionChangeCommitted(object sender, EventArgs e)
        {
            connection.Open();

            listViewProdGDN.Items.Clear();

            String inoid = comboOrderGDN.SelectedValue.ToString();
            MySqlCommand cmdOrder = new MySqlCommand("select agentname, agentaddress, agentphone, paymentstt, orderstt from `Orders` where oid = '" + inoid + "'", connection);
            MySqlDataReader sdrGDN = cmdOrder.ExecuteReader();
            while (sdrGDN.Read())
            {
                txtAgentName.Text = sdrGDN["agentname"].ToString();
                txtAgentAddress.Text = sdrGDN["agentaddress"].ToString();
                txtAgentPhone.Text = sdrGDN["agentphone"].ToString();
               
               
            }
            sdrGDN.Close();

            //SqlCommand cmdProdOrder = new SqlCommand("select prodid, prodname, quantity, price from Product join Orderprod on Product.prodid = Orderprod.prodid  join `Orders` on `Orders`.oid = Orderprod.oid where`Orders`.oid = '"+ inoid + "'", connection);
            //SqlDataReader tmp = cmdOrder.ExecuteReader();

            DataSet prodGDN = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select Product.prodid, Product.prodname, Product.price, Orderprod.quantity from Product join Orderprod on Product.prodid = Orderprod.prodid  join `Orders` on `Orders`.oid = Orderprod.oid where `Orders`.oid = '" + inoid + "'", connection);
            adapter.Fill(prodGDN);
            foreach (DataRow row in prodGDN.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(row["prodid"].ToString());
                item.SubItems.Add(row["prodname"].ToString());
                item.SubItems.Add(row["quantity"].ToString());
                item.SubItems.Add(row["price"].ToString());
                listViewProdGDN.Items.Add(item);
            }

            MySqlCommand cmdTotal = new MySqlCommand("select sum(Product.price*Orderprod.quantity) from Product join Orderprod on Product.prodid = Orderprod.prodid  join `Orders` on `Orders`.oid = Orderprod.oid where `Orders`.oid = '" + inoid + "'", connection);
            MySqlDataReader dtTotal = cmdTotal.ExecuteReader();
            if (dtTotal.Read())
            {
                txtTotal.Text = dtTotal.GetValue(0).ToString();
            }
            dtTotal.Close();

            MySqlCommand cmdMed = new MySqlCommand("select paidmethod from `Orders` where oid = '" + inoid + "'", connection);
            MySqlDataReader dtMed = cmdMed.ExecuteReader();
            if (dtMed.Read())
            {
                txtMethod.Text = dtMed.GetValue(0).ToString();
            }
            dtMed.Close();

            //MySqlCommand cmdAddTotal = new MySqlCommand("update `Orders` set total = (select sum(Product.price * Orderprod.quantity) from Product join Orderprod on Product.prodid = Orderprod.prodid  join `Orders` on `Orders`.oid = Orderprod.oid where `Orders`.oid = '" + inoid + "') where oid = '" + inoid + "'", connection);
            //cmdAddTotal.ExecuteNonQuery();

            //DateTime deliDate = dateDelivery.Value.Date;
            //MySqlCommand cmdaddDelDate = new MySqlCommand("update `Orders` set delidate = '" + deliDate + "' where oid = '" + inoid + "'", connection);
            //cmdaddDelDate.ExecuteNonQuery();
            connection.Close();
        }

        private void btnGDNPrint_Click(object sender, EventArgs e)
        {
            String inoid = comboOrderGDN.SelectedValue.ToString();

            String dayFrom = dateDelivery.Value.Day.ToString();
            String monthFrom = dateDelivery.Value.Month.ToString();
            String yearFrom = dateDelivery.Value.Year.ToString();
            String deli = yearFrom + "-" + monthFrom + "-" + dayFrom;

            using(formGDNprint frm = new formGDNprint(inoid, deli))
            {
                frm.ShowDialog();
            }
        }

        // STATISTICS TAB

        private void btnLoadMonth_Click(object sender, EventArgs e)
        {
            connection.Open();
            int month = dateMonthSelect.Value.Month;
            int year = dateMonthSelect.Value.Year;

            dataGDNrv.Rows.Clear();
            dataGRNrv.Rows.Clear();

            MySqlCommand cmdRevenue = new MySqlCommand("select sum(total) as Revenue from `Orders` where month(odate) = " + month + "  and year(odate) = "+ year + "", connection);
            MySqlDataReader dtRe = cmdRevenue.ExecuteReader();
            while (dtRe.Read())
            {
                txtRevenue.Text = dtRe.GetValue(0).ToString();
            }
            dtRe.Close();

            MySqlCommand cmdOut = new MySqlCommand("select sum(quantity) from `Orderprod` join `Orders` on `Orders`.oid = Orderprod.oid where month(odate) = " + month + "  and year(odate) = " + year + " ", connection);
            MySqlDataReader dtOut = cmdOut.ExecuteReader();
            while (dtOut.Read())
            {
                txtOut.Text = dtOut.GetValue(0).ToString();
            }
            dtOut.Close();

            MySqlCommand cmdIn = new MySqlCommand("select sum(GRNprod.quantity) from `GRNprod` join `GRN` on `GRN`.grnid = GRNprod.grnid where month(grndate) = " + month + "  and year(grndate) = " + year + " ", connection);
            MySqlDataReader dtIn = cmdIn.ExecuteReader();
            while (dtIn.Read())
            {
                txtIn.Text = dtIn.GetValue(0).ToString();
            }
            dtIn.Close();


            DataSet drnrv = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select GRNprod.grnid, sum(GRNprod.quantity) as qty, GRN.grndate from GRN join GRNprod on GRN.grnid = GRNprod.grnid  where month(grndate) = " + month + "  and year(grndate) = " + year + " group by GRNprod.grnid, GRN.grndate", connection);
            adapter.Fill(drnrv);
            foreach (DataRow row in drnrv.Tables[0].Rows)
            {
                this.dataGRNrv.Rows.Add(row["grnid"].ToString(), row["qty"].ToString(), row["grndate"].ToString());
            }

            DataSet gdnrv = new DataSet();
            MySqlDataAdapter gadapter = new MySqlDataAdapter("select `Orderprod`.oid, sum(Orderprod.quantity) as oqty, `Orders`.odate from `Orders` join `Orderprod` on `Orders`.oid = Orderprod.oid  where month(odate) = " + month + "  and year(odate) = " + year + " group by Orderprod.oid, `Orders`.odate ", connection);
            gadapter.Fill(gdnrv);
            foreach (DataRow row in gdnrv.Tables[0].Rows)
            {
                this.dataGDNrv.Rows.Add(row["oid"].ToString(), row["oqty"].ToString(), row["odate"].ToString());
            }



            connection.Close();
        }

        // PROFILE TAB

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            connection.Open();
            String fname = txtFullname.Text;
            DateTime Birth = dateBirth.Value.Date;
            int day = Birth.Day;
            int month = Birth.Month;
            int year = Birth.Year;
            String bdate = year.ToString() + "-" + month.ToString() + "-" + day.ToString();
            String phone = txtPhone.Text;
            String address = txtAddress.Text;
            String gender = "M";
            if(radFemale.Checked)
            {
                gender = "F";
            }

            MySqlCommand cmdUpd = new MySqlCommand("update `Users` set fullName = '"+fname+ "', BDate ='" + bdate + "', Address = '" + address + "', phone = '"+ phone +"', Gender = '" + gender + "' where username = '"+_username+"' ", connection);
            int update = cmdUpd.ExecuteNonQuery();
            if(update > 0)
            {
                MessageBox.Show("Profile Saved");
            }
            else
            {
                MessageBox.Show("Failed");
            }


            connection.Close();
        }

        // CHANGE PASSWORD TAB
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            connection.Open();
            String currp = txtCurrPass.Text;
            String newp = txtNewPass.Text;
            String confp = txtConfPass.Text;
            int updatep = 0;

            MySqlCommand cmdp = new MySqlCommand("select password from `Users` where username = '"+ _username+"' ", connection);
            MySqlDataReader dtp = cmdp.ExecuteReader();
            while (dtp.Read())
            {
               if(currp.Equals(dtp.GetValue(0).ToString()) && newp.Equals(confp))
                {
                    updatep = 1;
                }
               
            }
            dtp.Close();

            if (updatep > 0)
            {
                MySqlCommand cmdupp = new MySqlCommand("update `Users` set password = '" + newp + "'where username = '" + _username + "' ", connection);
                updatep = cmdupp.ExecuteNonQuery();
                MessageBox.Show("Password Saved");
            }
            else
            {
                MessageBox.Show("Failed");
            }
            

            connection.Close();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void updateDeliBtn_Click(object sender, EventArgs e)
        {
            connection.Open();

            String inoid = comboOrderGDN.SelectedValue.ToString();

            String dayFrom = dateDelivery.Value.Day.ToString();
            String monthFrom = dateDelivery.Value.Month.ToString();
            String yearFrom = dateDelivery.Value.Year.ToString();
            String deli = yearFrom + "-" + monthFrom + "-" + dayFrom;

            MySqlCommand cmd = new MySqlCommand("update `Orders` set delidate = '" + deli + "' where oid = '" + inoid + "'", connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
