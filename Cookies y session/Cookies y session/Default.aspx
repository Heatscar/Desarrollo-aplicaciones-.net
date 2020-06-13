<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cookies_y_session._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div>
        <h2 style="color:Red">Cookies y Session en asp</h2>
        <asp:Label 
            ID="label1" 
            runat="server" 
            Font-Size="Large" 
            ForeColor="SeaGreen"
            Font-Italic="true"
            >
        </asp:Label>
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Edad:">
        </asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" BackColor="LightGreen" required="required">
        </asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email:">
        </asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" BackColor="LightGreen" required="required">
        </asp:TextBox>
        <br />
        <br />
         <asp:Label ID="Label4" runat="server" Text="Usuario:">
        </asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" BackColor="LightGreen" required="required">
        </asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Clave:">
        </asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" BackColor="LightGreen" required="required">
        </asp:TextBox>
        <br />
        <asp:Button 
            ID="Button1" 
            runat="server" 
            Text="Setear los valores" 
            OnClick="Button1_Click"
            Font-Bold="true"
            ForeColor="Crimson"
            />
    </div>

</asp:Content>
