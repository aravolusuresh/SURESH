<%@ Page Title="Write A New Scripting  :: Script Writer" Language="C#" MasterPageFile="~/writer/writer.master" AutoEventWireup="true" CodeFile="writescripting.aspx.cs" Inherits="writer_writescripting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style3 {
            width: 100%;
        }

        .style4 {
            font-size: larger;
            font-weight: bold;
            width: 172px;
        }

        .style5 {
            width: 172px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="style3" align="center">
        <tr>
            <td class="style4" align="center" style="font-size: x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; writescript<br />
            </td>
        </tr>
        <tr>
            <td class="style5">Title&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txttitle" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click"
                    Text="check Availability" />
            </td>
        </tr>
        <tr>
            <td>type of script<asp:TextBox ID="txttype" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            Description&nbsp;&nbsp;&nbsp;
        </tr>
        <tr>
            <td class="style5">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtscript" runat="server" Height="273px" TextMode="MultiLine"
                    Width="557px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Button ID="btnsubmit" runat="server" Height="18px"
                    OnClick="btnsubmit_Click" Text="Submit" Width="110px" />
            </td>
        </tr>
    </table>
</asp:Content>

