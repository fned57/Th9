using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace BaiTH8.Cau2
{
    
    public partial class TrangChu : System.Web.UI.Page
    {
        private string conStr = "Data Source=SKY-20200706ULN;Initial Catalog=ADO;Integrated Security=True";
        private SqlConnection mySqlConnection;
        private SqlCommand mySqlCommand;
        private static string sMaKhoa;
        private static bool modelNew;
        protected void SetControl(bool edit)
        {
            txt_makhoa.Enabled = edit;
            txt_tenkhoa.Enabled = edit;
            txt_dienthoai.Enabled = edit;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();
            //string sSql = "EXECUTE LayKhoaDaoTao";
            string sSql = "SELECT * FROM KhoaDaoTao";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(mySqlDataReader);
            GridView1.DataSource = myDataTable;
            GridView1.DataBind();
            SetControl(false);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "btnSua")
            {
                modelNew = false;
                SetControl(true);
                txt_makhoa.Text = GridView1.Rows[row].Cells[0].Text;
                txt_tenkhoa.Text = GridView1.Rows[row].Cells[1].Text;
                txt_dienthoai.Text = GridView1.Rows[row].Cells[2].Text;
                sMaKhoa = txt_makhoa.Text;
            }
            else if (e.CommandName == "btnXoa"){
                string sXoaMaKhoa = GridView1.Rows[row].Cells[0].Text;
                string sSql = "EXECUTE XoaKhoa @MaKhoa";
                mySqlCommand = new SqlCommand(sSql, mySqlConnection);
                mySqlCommand.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 2);
                mySqlCommand.Parameters["@MaKhoa"].Value = sXoaMaKhoa;
                mySqlCommand.ExecuteNonQuery();
                //Response.Redirect("KhoaDaoTao_SqlCommand_Store.aspx");
                //string s = GridView1.Rows[row].Cells[0].Text;
                //string sSQL = "DELETE FROM KhoaDaoTao WHERE MaKhoa = N'" + s + "'";
                //mySqlCommand = new SqlCommand(sSQL, mySqlConnection);
                //mySqlCommand.ExecuteNonQuery();

            }
        }

        protected void btn_them_Click(object sender, EventArgs e)
        {
            modelNew = true;
            txt_makhoa.Text = "";
            txt_tenkhoa.Text = "";
            txt_dienthoai.Text = "";
            SetControl(modelNew);
            //string sSql = "INSERT INTO KhoaDaoTao(MaKhoa,TenKhoa,Phone)" +
            //    "VALUES(@MaKhoa,@TenKhoa,@Phone)";
            //mySqlCommand = new(sSql, mySqlConnection);
            //mySqlCommand.Parameters.AddWithValue("@MaKhoa", txt_makhoa.Text);
            //mySqlCommand.Parameters.AddWithValue("@TenKhoa", txt_tenkhoa.Text);
            //mySqlCommand.Parameters.AddWithValue("@Phone", txt_dienthoai.Text);
            //mySqlCommand.ExecuteNonQuery();
        }

        protected void btn_ghi_Click(object sender, EventArgs e)
        {
            if (txt_makhoa.Text == "")
            {
                Response.Write("<script>alert('Bạn chưa nhập mã khoa');</script>");
                return;
            }
            if (modelNew)
            {
                string sSql = "EXECUTE NhapKhoa @Makhoa, @Tenkhoa, @Phone";
                mySqlCommand = new SqlCommand(sSql, mySqlConnection);
                mySqlCommand.Parameters.Add("@Makhoa", SqlDbType.NVarChar, 2);
                mySqlCommand.Parameters.Add("@Tenkhoa", SqlDbType.NVarChar, 50);
                mySqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 20);
                mySqlCommand.Parameters["@Makhoa"].Value = txt_makhoa.Text;
                mySqlCommand.Parameters["@Tenkhoa"].Value = txt_tenkhoa.Text;
                mySqlCommand.Parameters["@Phone"].Value = txt_dienthoai.Text;
                mySqlCommand.ExecuteNonQuery();
            }
            else
            {
                string sSql = "EXECUTE SuaKhoa @Makhoa, @Tenkhoa,@Phone";
                mySqlCommand = new SqlCommand(sSql, mySqlConnection);
                mySqlCommand.Parameters.Add("@Makhoa", SqlDbType.NVarChar, 2);
                mySqlCommand.Parameters.Add("@Tenkhoa", SqlDbType.NVarChar, 50);
                mySqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 20);
                mySqlCommand.Parameters["@Makhoa"].Value = txt_makhoa.Text;
                mySqlCommand.Parameters["@Tenkhoa"].Value = txt_tenkhoa.Text;
                mySqlCommand.Parameters["@Phone"].Value = txt_dienthoai.Text;
                mySqlCommand.ExecuteNonQuery();
            }
            //Response.Redirect("KhoaDaoTao_SqlCommand_Store.aspx");
            SetControl(false);
        }
    }
}