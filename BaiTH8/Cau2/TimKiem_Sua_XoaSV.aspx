<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TimKiem_Sua_XoaSV.aspx.cs" Inherits="BaiTH8.Cau2.TimKiem_Sua_XoaSV" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 99px;
        }
        .auto-style3 {
            width: 99px;
        }
        .auto-style4 {
            width: 76%;
        }
        .auto-style5 {
            height: 23px;
            width: 505px;
        }
        .auto-style6 {
            width: 505px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style4">
                <tr>
                    <td colspan="2" class="auto-style1">TÌM KIẾM - SỬA - XÓA SINH VIÊN</td>
                </tr>
                <tr>
                    <td class="auto-style2">Khoa đào tạo:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlKhoa" runat="server" AutoPostBack="True" Height="23px" OnSelectedIndexChanged="ddlKhoa_SelectedIndexChanged" Width="334px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Lớp BC:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtLop" runat="server" Width="325px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Mã sinh viên:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtMSSV" runat="server" Width="325px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Họ và tên:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtTen" runat="server" Width="325px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Ngày sinh:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtNgaySinh" runat="server" Width="325px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Địa chỉ:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtDiaChi" runat="server" Width="325px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="2">
                        <asp:Button ID="btnGhi" runat="server" Text="Ghi" Width="61px" OnClick="btnGhi_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="MaKhoa" HeaderText="Mã Khoa" />
                                <asp:BoundField DataField="LopBC" HeaderText="Lớp BC" />
                                <asp:BoundField DataField="MaSV" HeaderText="Mã sinh viên">
                                <ItemStyle Width="100px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="HoTen" HeaderText="Họ và tên">
                                <ItemStyle Width="150px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NgaySinh" HeaderText="Ngày sinh" />
                                <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
                                <asp:ButtonField ButtonType="Button" CommandName="btnSua" HeaderText="Sửa" Text="Sửa" />
                                <asp:ButtonField ButtonType="Button" CommandName="btnXoa" HeaderText="Xóa" Text="Xóa" />
                            </Columns>
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
