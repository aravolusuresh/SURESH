<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="NewScriptWriter.aspx.cs" Inherits="NewScriptWriter" Title="Register/Sign Up  :: Script Writer" %>

<%@ Register Assembly="GMDatePicker" Namespace="GrayMatterSoft" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script language="javascript" type="text/javascript">
        function check() {

            var txtFirstName = document.getElementById("<%=txtFirstName.ClientID %>").value;
            if (txtFirstName == "") {
                alert('First Name Required');
                document.getElementById("<%=txtFirstName.ClientID%>").focus();
                return false;
            }


            var txtEmailId = document.getElementById("<%=txtEmailId.ClientID %>").value;
            if (txtEmailId == "") {
                alert('SurName Required');
                document.getElementById("<%=txtEmailId.ClientID%>").focus();
                return false;
            }
            else if (txtEmailId != "") {
                var Exp = /^(\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)+$/;
                if (!txtEmailId.match(Exp)) {
                    alert('Invalid EmailId');
                    document.getElementById("<%=txtEmailId.ClientID%>").focus();
                    return false;
                }
            }
        var txtPhoneNumber = document.getElementById("<%=txtPhoneNumber.ClientID%>").value;
            if (txtPhoneNumber == "") {

                document.getElementById("<%=txtPhoneNumber.ClientID%>").focus();
                alert('PhoneNo Required');
                return false;
            }
            else if (txtPhoneNumber != "") {
                var Exp = /^[0-9 ()+-]+$/;
                if (!txtPhoneNumber.match(Exp)) {
                    alert('PhoneNo Digits Only');
                    document.getElementById("<%=txtPhoneNumber.ClientID%>").focus();
                    return false;
                }
            }
        var GMDatePicker1 = document.getElementById("<%=GMDatePicker1.ClientID%>").value;
            if (GMDatePicker1 == "") {
                alert('Enter DateOfBirth');
                return false;
            }
            var txtQualification = document.getElementById("<%=txtQualification.ClientID%>").value;
            if (txtQualification == "") {
                alert('Enter Qualification');
                return false;
            }
            var txtExperience = document.getElementById("<%=txtExperience.ClientID%>").value;
            if (txtExperience == "") {

                document.getElementById("<%=txtPhoneNumber.ClientID%>").focus();
                alert('Experience Required');
                return false;
            }
            else if (txtExperience != "") {
                var Exp = /^[0-9 ()+-]+$/;
                if (!txtExperience.match(Exp)) {
                    alert('Experience Digits Only');
                    document.getElementById("<%=txtExperience.ClientID%>").focus();
                    return false;
                }
            }
        var ddlCountry = document.getElementById("<%=ddlCountry.ClientID%>").selectedIndex;
            if (ddlCountry == 0) {
                alert('select Country');
                return false;
            }
            var ddlState = document.getElementById("<%=ddlState.ClientID%>").selectedIndex;
            if (ddlState == 0) {
                alert('select State');
                return false;
            }
          <%--  var ddlState=document.getElementById("<%=ddlCity.ClientID%>").selectedIndex;
            if(ddlState==0)
            {
                     alert('select City');      
                     return false; 
            }--%>
            var txtUserName = document.getElementById("<%=txtUserName.ClientID %>").value;
            if (txtUserName == "") {
                alert('UserName Required');
                document.getElementById("<%=txtUserName.ClientID%>").focus();
                return false;
            }
            var txtPassword = document.getElementById("<%=txtPassword.ClientID %>").value;
            if (txtPassword == "") {
                alert('Password Required');
                document.getElementById("<%=txtPassword.ClientID%>").focus();
                return false;
            }

            var fuImage = document.getElementById("<%=fuImage.ClientID %>").value;
            if (fuImage == "") {
                alert('Select Image');
                document.getElementById("<%=fuImage.ClientID%>").focus();
                return false;
            }
        }
    </script>
    <form id="Form1" runat="server">
        <center>
            <fieldset>
                <%--<legend>New ScriptWritor</legend>--%>
                <center>
                    <table cellpadding="10" cellspacing="10">
                        <tr>
                            <td align="center" colspan="3">
                                <br />
                                <%--<asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Red" BackColor="Blue"></asp:Label>
&nbsp;</td>--%>
                        </tr>
                        <tr>
                            <td align="center" colspan="3">
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server"
                                    RepeatDirection="Horizontal" CellPadding="0" CellSpacing="0">
                                    <asp:ListItem>Writer</asp:ListItem>
                                    <asp:ListItem Value="Editor">Editor</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">FirstName :
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">LastName :
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr id="trsurname" runat="server" visible="false">
                            <td align="right">SurName :
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtSurName" runat="server"></asp:TextBox>
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">Email Id :
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">PhoneNumber :
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">Gender
                            </td>
                            <td align="left">
                                <asp:DropDownList ID="drpgender" runat="server">
                                    <asp:ListItem>Select</asp:ListItem>
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Femle</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">DateOfBirth :
                            </td>
                            <td align="left">
                                <cc1:GMDatePicker ID="GMDatePicker1" runat="server" CalendarOffsetX="-127px" CalendarTheme="Blue"
                                    InitialValueMode="Null" ForeColor="#6699FF" YearDropDownRange="150" MaxDate="2016-03-16" MinDate="1900-01-01">
                                </cc1:GMDatePicker>
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">Qualification :
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtQualification" runat="server"></asp:TextBox>
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">Experience :
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtExperience" runat="server"></asp:TextBox>
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">Country :
                            </td>
                            <td align="left">
                                <asp:DropDownList ID="ddlCountry" runat="server" Height="16px" Width="114px">
                                    <asp:ListItem>Select Country</asp:ListItem>
                                    <asp:ListItem>U.S.A</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">State :
                            </td>
                            <td align="left">
                                <asp:DropDownList ID="ddlState" runat="server" Height="18px" Width="114px">
                                    <asp:ListItem>Select State</asp:ListItem>
                                    <asp:ListItem>California</asp:ListItem>
                                    <asp:ListItem>Nevada</asp:ListItem>
                                    <asp:ListItem>Florida</asp:ListItem>
                                    <asp:ListItem>Texas</asp:ListItem>
                                    <asp:ListItem>Alaska</asp:ListItem>
                                </asp:DropDownList>

                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">City :                         </td>
                            <td align="left">
                                <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>

                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">UserName :                         </td>
                            <td align="left">
                                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">Password :
                            </td>
                            <td align="left">
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="right">Image :
                            </td>
                            <td align="left">
                                <asp:FileUpload ID="fuImage" runat="server" />
                            </td>
                            <td align="left"></td>
                        </tr>
                        <tr>
                            <td align="center" colspan="3"></td>
                        </tr>
                        <tr>
                            <td align="center" colspan="3">
                                <asp:Button runat="server" ID="btnRegister" Text="Register"
                                    OnClientClick="return check(this);" OnClick="btnRegister_Click" />
                                &nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
                            </td>
                        </tr>
                    </table>

                </center>
            </fieldset>
        </center>
    </form>
</asp:Content>

