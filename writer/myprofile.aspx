<%@ Page Title="Writer Profile  :: Script Writer" Language="C#" MasterPageFile="~/writer/writer.master" AutoEventWireup="true" CodeFile="myprofile.aspx.cs" Inherits="writer_myprofile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        BackColor="#E3B917" BorderColor="#E3B917" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4" ForeColor="#E0C256" Height="237px" Width="375px">
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <Fields>
            <asp:BoundField DataField="firstname" HeaderText="Firstname" />
            <asp:BoundField DataField="lastname" HeaderText="lastname" />
          
            <asp:BoundField DataField="emailid" HeaderText="emailid" />
            <asp:BoundField DataField="phonenumber" HeaderText="phonenumber" />
            <asp:BoundField DataField="dateofbirth" HeaderText="dateofbirth" />
            <asp:BoundField DataField="qualification" HeaderText="qualification" />
            <asp:BoundField DataField="experience" HeaderText="experience" />
            <asp:BoundField DataField="country" HeaderText="country" />
            <asp:BoundField DataField="state" HeaderText="state" />
            <asp:BoundField DataField="city" HeaderText="city" />
        </Fields>
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <EditRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
    </asp:DetailsView>
</asp:Content>

