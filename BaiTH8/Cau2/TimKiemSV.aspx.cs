using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTH8.Cau2
{
    public partial class TimKiemSV : System.Web.UI.Page
    {
        private string conStr = "Data Source=SKY-20200706ULN;Initial Catalog=ADO;Integrated Security=True";
        private SqlConnection mySqlConnection;
        private SqlCommand mySqlCommand;
        protected void Page_Load(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();

            //Hiển thị khoa đào tạo trong DropDownList
            if (!IsPostBack)
            {
                string sSQL = "SELECT MaSV FROM SinhVien";
                mySqlCommand = new SqlCommand(sSQL, mySqlConnection);
                SqlDataReader myDataReader = mySqlCommand.ExecuteReader();
                DataTable mySinhViens = new DataTable();
                mySinhViens.Load(myDataReader);
                ddlMaSV.DataSource = mySinhViens;
                ddlMaSV.DataTextField = "MaSV";
                ddlMaSV.DataBind();
                ddlMaSV_SelectedIndexChanged(sender, e);
            }
        }

        protected void ddlMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSQL = "SELECT MaSV, HoTen, TenKhoa FROM SinhVien SV INNER JOIN KhoaDaoTao K ON SV.MaKhoa = K.MaKhoa WHERE MaSV = N'" + ddlMaSV.SelectedValue.ToString() + "'";
            mySqlCommand = new SqlCommand(sSQL, mySqlConnection);
            SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(mySqlDataReader);
            GridView1.DataSource = myDataTable;
            GridView1.DataBind();
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            string sSQL = "SELECT MaSV, HoTen, TenKhoa FROM SinhVien SV INNER JOIN KhoaDaoTao K ON SV.MaKhoa = K.MaKhoa WHERE HoTen LIKE N'%" + txtTen.Text + "%'";
            mySqlCommand = new SqlCommand(sSQL, mySqlConnection);
            SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(mySqlDataReader);
            GridView1.DataSource = myDataTable;
            GridView1.DataBind();
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            string sMaSV = GridView1.Rows[row].Cells[0].Text;
            if (e.CommandName == "btnChiTiet")
            {
                string ssSQL = "SELECT TenMon,NamHK FROM MonHoc MH INNER JOIN DangKyHoc DK ON MH.MaMon = DK.MaMon WHERE MaSV = N'" + sMaSV + "'";
                mySqlCommand = new SqlCommand(ssSQL, mySqlConnection);
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable myDataTable = new DataTable();
                myDataTable.Load(mySqlDataReader);
                GridView2.DataSource = myDataTable;
                GridView2.DataBind();
            }
        }
    }
}