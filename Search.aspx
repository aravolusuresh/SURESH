<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" Title="Search :: Script Writer" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form id="form1" runat="server">
        <table class="style3">
            <tr>
                <td style="background-color:#C0C0C0; color: #000000;">
                    <br />
                    Enter Title to search<br />
                    <br />
                    <asp:TextBox ID="txtsearch" runat="server" Height="36px" Width="353px"></asp:TextBox>
                    <asp:Button ID="btnsearch" runat="server" Height="26px"
                        OnClick="btnsearch_Click" Text="Search" Width="126px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="SearchGrid" runat="server" AutoGenerateColumns="False"
                        CellPadding="5" CellSpacing="5" ForeColor="#333333" GridLines="None" Height="159px" Width="497px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="title" HeaderText="title" />
                            <asp:BoundField DataField="writer" HeaderText="writer" />
                            <asp:BoundField DataField="typeofscript" HeaderText="typeofscript" />
                            <asp:BoundField DataField="script" HeaderText="script" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</asp:Content>

<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .style3 {
            width: 100%;
            height: 145px;
        }
    </style>


</asp:Content>


