<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TimKiemSV.aspx.cs" Inherits="BaiTH8.Cau2.TimKiemSV" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 157px;
        }
        .auto-style5 {
            margin-right: 0px;
        }
        .auto-style6 {
            height: 201px;
        }
        .auto-style7 {
            width: 87px;
        }
        .auto-style8 {
            width: 150px;
        }
        .auto-style9 {
            width: 101px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td colspan="5">TÌM KIẾM THEO MÃ SINH VIÊN HOẶC TÊN</td>
                </tr>
                <tr>
                    <td class="auto-style8">Tìm theo mã sinh viên:</td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="ddlMaSV" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMaSV_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style9">Nội dung tìm:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtTen" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnTim" runat="server" Text="Tìm" Width="77px" OnClick="btnTim_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="5" class="auto-style6">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style5" ForeColor="#333333" GridLines="None" Width="513px">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="MaSV" HeaderText="Mã SV" />
                                <asp:BoundField DataField="HoTen" HeaderText="Họ và tên" />
                                <asp:BoundField DataField="TenKhoa" HeaderText="Tên khoa" />
                                <asp:ButtonField ButtonType="Button" CommandName="btnChiTiet" HeaderText="Chi tiết" Text="Chi tiết" />
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
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="283px" OnRowCommand="GridView2_RowCommand">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="TenMon" HeaderText="Tên môn">
                                <ItemStyle Width="150px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="NamHK" HeaderText="Năm đăng ký" />
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
