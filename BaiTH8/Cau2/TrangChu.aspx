<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="BaiTH8.Cau2.TrangChu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 76px;
        }
        .auto-style2 {
            width: 191px;
        }
        .auto-style3 {
            width: 59%;
            height: 130px;
        }
        #btn_them{
            margin-right: 30px;
            margin-left: 100px;
        }
        #lbl_tieude{
            margin-left: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_tieude" runat="server" Text="NHẬP - SỬA - XÓA KHOA ĐÀO TẠO"></asp:Label>
        </div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style1">Mã khoa:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txt_makhoa" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Tên khoa: </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txt_tenkhoa" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Điện thoại:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txt_dienthoai" runat="server" Width="250px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_them" runat="server" Text="Thêm mới" OnClick="btn_them_Click" />
                    <asp:Button ID="btn_ghi" runat="server" Text="Ghi" Width="89px" OnClick="btn_ghi_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowCommand="GridView1_RowCommand">
                        <Columns>
                            <asp:BoundField HeaderText="Mã khoa" DataField="MaKhoa" />
                            <asp:BoundField HeaderText="Tên khoa" DataField="TenKhoa">
                            <ItemStyle Width="300px" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Điện thoại" DataField="Phone">
                            <ControlStyle Width="200px" />
                            <ItemStyle Width="150px" />
                            </asp:BoundField>
                            <asp:ButtonField ButtonType="Button" HeaderText="Sửa" Text="Sửa" CommandName="btnSua"></asp:ButtonField>
                            <asp:ButtonField ButtonType="Button" HeaderText="Xóa" Text="Xóa" CommandName="btnXoa" />
                        </Columns>
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
