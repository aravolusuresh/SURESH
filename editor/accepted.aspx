<%@ Page Title="Accepted Scripts  :: Script Writer" Language="C#" MasterPageFile="~/editor/editor.master" AutoEventWireup="true" CodeFile="accepted.aspx.cs" Inherits="editor_accepted" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style3 {
            width: 100%;
        }

        .style4 {
            font-size: xx-large;
            color: #00000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="style3">
        <tr>
            <td class="style4">Accepted Scripts<br />
                <asp:Label ID="lbltitle" runat="server" Visible="false"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <asp:GridView ID="viewgrid" runat="server" Height="54px" Width="665px"
                    CellPadding="4" AutoGenerateSelectButton="True"
                    OnSelectedIndexChanged="viewgrid_SelectedIndexChanged1"
                    ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" Height="30px" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                <br />
                <br />
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                <br />
                <asp:TextBox ID="txtdesc" runat="server" Height="297px" TextMode="MultiLine"
                    Width="493px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" Visible="false"/>
            </td>
        </tr>
    </table>
</asp:Content>

