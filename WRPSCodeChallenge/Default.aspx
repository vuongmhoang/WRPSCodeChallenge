<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WRPSCodeChallenge._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>WRPS CODING CHALLENGE</h1>
        <asp:Label ID="problem" runat="server" Text="1) Given two dictionaries in two different languages (example: English and Spanish), return all words that are spelled the same in both languages.<br />2) (Optional) Write a web API (Application Programming Interface) that uses the code in part 1 to allow users to submit their own lists of words and return the set of words that are spelled the same. This part is not necessary but we'd love to see you try it!"></asp:Label>
        <hr />          
    </div>
    <div>
        English:<br />
        <asp:TextBox ID="TextBoxEnglish" runat="server" TextMode="MultiLine" Rows="7" Width="500px"></asp:TextBox><br />
        Spanish:<br />
        <asp:TextBox ID="TextBoxSpanish" runat="server" TextMode="MultiLine" Rows="7" Width="500pxd"></asp:TextBox><br /><br />
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit"  OnClick="ButtonSubmit_Click"/>&nbsp;&nbsp;
        <asp:Button ID="ButtonReset" runat="server" Text="Reset"  OnClick="ButtonReset_Click"/><hr />
        Result:<br />
        <asp:Label ID="LabelResult" runat="server" Text="" Font-Size="Medium"></asp:Label>
    </div>   
</asp:Content>
