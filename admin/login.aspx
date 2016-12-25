<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #00FFFF;
        }
        .auto-style2 {
            width: 337px;
        }
        .auto-style3 {
            width: 377px;
        }
        .auto-style4 {
            width: 377px;
            height: 30px;
        }
        .auto-style5 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <table class="auto-style1">
        <tr>
            <td class="lblas">User Name:</td>
            <td class="auto-style4">
                <asp:TextBox ID="Textbox1" placeholder="Enter user id" runat="server" CssClass="txt"></asp:TextBox>
            </td>
             
        </tr>
        <tr>
            <td class="lblas">Password:</td>
            <td class="auto-style4">
                <asp:TextBox ID="Textbox2" placeholder="Enter Password" runat="server" CssClass="txt" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td>
                        &nbsp;</td>
            <td class="auto-style3">
                        <asp:Button ID="btnadditem" runat="server" CssClass="btnadd" Text="Login" 
                            onclick="btnadditem_Click" Height="32px" Width="142px" />
                    &nbsp;
                        <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>
                    </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

