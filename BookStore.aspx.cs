using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace AppBookStore
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=SUMAN\\SQLEXPRESS; initial catalog=Bookstore; integrated security=true"); 
        protected void Page_Load(object sender, EventArgs e) 
        {
            Display();
        }

       

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Library(bookname, price, author) values('" +txtName.Text+ "' ,'" +txtPrice.Text + "', '" + txtAuthorName.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Display();
            MessageBox.Show("Record Saved Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        void Display()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Library", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            grd.DataSource = dt;
            grd.DataBind();
        }
    }
}