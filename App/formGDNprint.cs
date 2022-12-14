using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class formGDNprint : MaterialForm

         
    {
        readonly MaterialSkinManager materialSkinManager;
        static string conn = ConfigurationManager.ConnectionStrings["App.Properties.Settings.CosmesticDBConnectionString"].ConnectionString;
        SqlConnection connection = new SqlConnection(conn);

        String _id = "";
        public formGDNprint(String id)
        {
            InitializeComponent();
            _id = id;

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

        private void formGDNprint_Load(object sender, EventArgs e)
        {
            connection.Open();

            DataSet dtb = new DataSet();

            //SqlDataAdapter da = new SqlDataAdapter("select Orderprod.prodid, Product.prodname, Orderprod.quantity, Product.price from Product join Orderprod on Product.prodid = Orderprod.prodid where Orderprod.oid = '" + _id + "'", connection);
            //da.Fill(dtb);

            SqlDataAdapter da = new SqlDataAdapter("select * from Product", connection);
            SqlDataAdapter db = new SqlDataAdapter("select * from Orderprod where Orderprod.oid = '" + _id + "'", connection);

            DataTable taba = new DataTable("Product");
            DataTable tabb = new DataTable("Orderprod");
         
            da.Fill(taba);
            db.Fill(tabb);

            dtb.Tables.Add(taba);
            dtb.Tables.Add(tabb);

            gdn1.SetDataSource(dtb);

            crystalReportViewer1.ReportSource = gdn1;
            SqlCommand cmd = new SqlCommand("select * from [Order] where oid = '" + _id + "'", connection);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                gdn1.SetParameterValue("agName", sdr["agentname"].ToString());
                gdn1.SetParameterValue("agNumber", sdr["agentphone"].ToString());
                gdn1.SetParameterValue("agAddress", sdr["agentaddress"].ToString());
                gdn1.SetParameterValue("orderID", _id);
                gdn1.SetParameterValue("date", sdr["delidate"].ToString());
                gdn1.SetParameterValue("total", sdr["total"].ToString());
                gdn1.SetParameterValue("method", sdr["paidmethod"].ToString());

            }
            sdr.Close();

            crystalReportViewer1.ReportSource = gdn1;
            //crystalReportViewer1.Refresh();

            connection.Close();
        }
    }
}
