using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTH8
{
    public partial class Cau1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string strCon = "Data Source=SKY-20200706ULN;Initial Catalog=ADO;Integrated Security=True";
                SqlConnection conn = new SqlConnection(strCon);
                conn.Open();
                string taiKhoan = txt_ten.Text;
                string matKhau = txt_pass.Text;
                string sql = "SELECT * FROM [User] WHERE UserName= '" + taiKhoan + "'and PassWord= '"+matKhau+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    Application["TaiKhoan"] = txt_ten.Text;
                    Response.Redirect("GetTK.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Bạn nhập sai tài khoản')</script>");
                }
            }
            catch(SqlException conn)
            {
                Response.Write("<script>alert('Lỗi kết nối')</script>");
            }
        }
    }
}