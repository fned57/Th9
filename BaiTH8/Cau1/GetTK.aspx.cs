using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTH8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string taiKhoan = Application["TaiKhoan"].ToString();
            Response.Write("Xin chào bạn: " + taiKhoan);
        }
    }
}