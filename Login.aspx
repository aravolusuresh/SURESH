<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Login" Title="Login :: Admin,Writer,Editor  :: Script Writer" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <form runat="server" id="form1">

        <center>
            <fieldset style="width: 546px; height: 140px">
                <legend style="color: Blue; font-size: large; font-family: Calibri; text-decoration: blink;">Login </legend>
                <center>
                    <table style="width: 241px">
                        <tr>
                            <td colspan="3"></td>

                        </tr>
                        <tr>
                            <td align="right" class="style3">UserName :
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td align="right" class="style3">Password :
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td align="right" class="style3">&nbsp;</td>
                            <td align="left">&nbsp;</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td colspan="3"></td>
                        </tr>
                        <tr>
                            <td colspan="3" align="center">
                                <asp:Button ID="btnLogin" runat="server"
                                    Text="Login" OnClick="btnLogin_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style3"></td>
                            <td align="center">
                                <%--<a href="NewScriptWriter.aspx">NewUser</a>--%>
                                <%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>--%>
                                <asp:LinkButton
                                    ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">New User</asp:LinkButton>
                            </td>
                            <td align="center">
                                <%--<a href="ForgotPassword.aspx">ForgotPassword</a>--%>&nbsp;<%--<asp:LinkButton ID="lnbNewUser" runat="server" Text="NewUser"></asp:LinkButton>--%><%--<asp:RadioButtonList 
                                ID="RadioButtonList1" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
                                <asp:ListItem>Writer</asp:ListItem>
                                <asp:ListItem>Editor</asp:ListItem>
                            </asp:RadioButtonList>--%>
&nbsp;


                            <br />


                            </td>
                        </tr>
                    </table>
                </center>
            </fieldset>
        </center>
    </form>
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="head">

    <style type="text/css">
        .style3 {
            width: 80px;
        }
    </style>

</asp:Content>

