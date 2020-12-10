<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cau1.aspx.cs" Inherits="BaiTH8.Cau1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 71%;
            margin-right: 0px;
            margin-bottom: 0px;
        }
        .auto-style3 {
            height: 23px;
            width: 103px;
        }
        .auto-style4 {
            margin-left: 0px;
            width: 103px;
        }
        .auto-style2 #btn_dangnhap{
            margin-left: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2">
                <tr>
                    <td colspan="2" style="">Đăng nhập</td>
                </tr>
                <tr>
                    <td class="auto-style3">Tài khoản: </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txt_ten" runat="server" Width="295px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Mật khẩu:</td>
                    <td>
                        <asp:TextBox ID="txt_pass" runat="server" Width="295px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btn_dangnhap" runat="server" Text="Đăng nhập" OnClick="btn_dangnhap_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
