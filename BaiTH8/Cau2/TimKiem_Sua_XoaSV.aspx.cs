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
    public partial class TimKiem_Sua_XoaSV : System.Web.UI.Page
    {
        private string conStr = "Data Source=SKY-20200706ULN;Initial Catalog=ADO;Integrated Security=True";
        private SqlConnection mySqlConnection;
        private SqlCommand mySqlCommand;
        protected void Page_Load(object sender, EventArgs e)
        {
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();
            string sSql = "SELECT * FROM SinhVien";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(mySqlDataReader);
            GridView1.DataSource = myDataTable;
            GridView1.DataBind();

            //Hiển thị khoa đào tạo trong DropDownList
            if (!IsPostBack)
            {
                string sSQL = "SELECT * FROM KhoaDaoTao";
                mySqlCommand = new SqlCommand(sSQL, mySqlConnection);
                SqlDataReader myDataReader = mySqlCommand.ExecuteReader();
                DataTable myKhoaDaoTao = new DataTable();
                myKhoaDaoTao.Load(myDataReader);
                ddlKhoa.DataSource = myKhoaDaoTao;
                ddlKhoa.DataTextField = "TenKhoa";
                ddlKhoa.DataValueField = "MaKhoa"; 
                ddlKhoa.DataBind();
                ddlKhoa_SelectedIndexChanged(sender, e);
            }
        }

        protected void ddlKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSQL = "SELECT * FROM SinhVien WHERE MaKhoa = N'"+ddlKhoa.SelectedValue.ToString()+"'";
            mySqlCommand = new SqlCommand(sSQL, mySqlConnection);
            SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            DataTable myDataTable = new DataTable();
            myDataTable.Load(mySqlDataReader);
            GridView1.DataSource = myDataTable;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "btnSua")
            {
                txtLop.Text = GridView1.Rows[row].Cells[1].Text;
                txtMSSV.Text = GridView1.Rows[row].Cells[2].Text;
                txtTen.Text = GridView1.Rows[row].Cells[3].Text;
                txtNgaySinh.Text = GridView1.Rows[row].Cells[4].Text;
                txtDiaChi.Text = GridView1.Rows[row].Cells[5].Text;

            }
            else if(e.CommandName == "btnXoa")
            {
                string s = GridView1.Rows[row].Cells[2].Text;
                string sSQL = "DELETE FROM SinhVien WHERE MaSV = N'" + s + "'";
                mySqlCommand = new SqlCommand(sSQL, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();
                ddlKhoa_SelectedIndexChanged(sender, e);
            }
        }

        protected void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text.Trim() == "")
            {
                return;
            }
            string sMaKhoa = ddlKhoa.SelectedValue;
            string sSQL = "UPDATE SinhVien SET MaKhoa = N'" + sMaKhoa + "',LopBC = N'"+txtLop.Text+"',HoTen  = N'"+txtTen.Text+
                "',NgaySinh = N'"+txtNgaySinh.Text+"',DiaChi=N'"+txtDiaChi.Text +"'WHERE MaSV = N'"+txtMSSV.Text.Trim()+"'";
            mySqlCommand = new SqlCommand(sSQL, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            ddlKhoa_SelectedIndexChanged(sender, e);

        }
    }
}