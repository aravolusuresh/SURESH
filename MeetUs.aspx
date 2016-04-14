<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="MeetUs.aspx.cs" Inherits="MeetUs" Title="Meet Us :: Script Writer" %>

<%--
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form id="form1" runat="server">

        <table class="style3">
            <tr>
                <td style="font-size: large; font-weight: bold" align="center">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    MEET US</td>
            </tr>
            <tr align="center">
                <td style="font-size: medium; font-weight: bold;">
                    <br />
                    SCRIPT WRITERS<br />
                    <br />
                    FREMONT<br />
                    <br />
                    CALIFORNIA<br />
                    <br />
                    PIN:94538<br />
                    <br />

                </td>
            </tr>
        </table>

        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</asp:Content>

<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .style3 {
            width: 100%;
        }
    </style>















</asp:Content>


