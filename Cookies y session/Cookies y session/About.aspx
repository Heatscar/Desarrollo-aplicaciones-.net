<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Cookies_y_session.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cookies y sesión</h2>

    <div>
        <h2 style="color:Red">Cookies y Session en asp</h2>
        <asp:Label 
            ID="label1" 
            runat="server" 
            Font-Size="Large" 
            ForeColor="Red"
            Font-Italic="true"
            >
        </asp:Label>
        <br /><br />

        <h3>Variables de sesión:</h3>
        <asp:Label 
            ID="label2" 
            runat="server" 
            Font-Size="Large" 
            ForeColor="Red"
            Font-Italic="true"
            >
        </asp:Label>
        <asp:Label 
            ID="label3" 
            runat="server" 
            Font-Size="Large" 
            ForeColor="Red"
            Font-Italic="true"
            >
        </asp:Label>
        <br />
        <br />
        <br />
        <asp:Button 
            ID="Button2" 
            runat="server" 
            Text="Leer los valores" 
            OnClick="Button2_Click"
            Font-Bold="true"
            ForeColor="DarkGreen"
            />
    </div>
</asp:Content>
