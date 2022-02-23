using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }
        private void BindGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ADConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT UserID,EmailID FROM cc"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }











        //protected void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    string connection = ConfigurationManager.ConnectionStrings["ADConnection"].ToString();
        //    DirectorySearcher dssearch = new DirectorySearcher(connection);
        //   dssearch.Filter = "(sAMAccountName=" + txtusername.Text + ")";
        //    SearchResult sresult = dssearch.FindOne();
        //    DirectoryEntry dsresult = sresult.GetDirectoryEntry();
        //    lblfname.Text = dsresult.Properties["Name"][0].ToString();
        //    lbllname.Text = dsresult.Properties["LName"][1].ToString();
        //    lblemail.Text = dsresult.Properties["Email"][2].ToString();
        //}
    }
}