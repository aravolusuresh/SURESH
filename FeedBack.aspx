<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="FeedBack.aspx.cs" Inherits="FeedBack" Title="Feedback  :: Script Writer" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form id="form1" runat="server">
        <table class="style3" style="background-color: #C0C0C0">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtname" runat="server" Height="19px" Width="220px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Comments</td>
                <td>
                    <asp:TextBox ID="txtfeedback" runat="server" Height="103px" TextMode="MultiLine"
                        Width="328px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnfeedback" runat="server" Text="Feedback"
                        OnClick="btnfeedback_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>

<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="head">

    <style type="text/css">
        .style3 {
            width: 101%;
            height: 168px;
        }
    </style>

</asp:Content>


