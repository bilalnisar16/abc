<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style12
    {
        width: 145px;
    }
    .style14
    {
        width: 232px;
    }
    .style17
    {
        height: 21px;
    }
        .auto-style1 {
            color: #FF0000;
            text-align: center;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" style="height: 256px; width: 100%">
    <tr>
        <td colspan="2" class="tblhead">
            Add Category</td>
    </tr>
    <tr>
        <td class="style12">
            &nbsp;</td>
        <td class="style14">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="lbl">
            Catagory Id:</td>
        <td style="text-align: left">
            <asp:TextBox ID="TextBox1" runat="server" Width="139px" Height="20px"></asp:TextBox>
            <span class="auto-style1">*</span></td>
    </tr>
    <tr>
        <td class="lbl">
            Category Name:</td>
        <td style="text-align: left">
            <asp:TextBox ID="txtName1" runat="server" placeholder="Enter Category Name!!!" 
                CssClass="txt" Width="141px"  ></asp:TextBox>
            <span class="auto-style1">*</span></td>
    </tr>
    <tr>
        <td class="lbl">
            Catagory Image: </td>
        <td style="text-align: left">
            <asp:FileUpload ID="FileUpload1" runat="server" Width="228px" />
        </td>
    </tr>
    <tr>
        <td class="style17">
            </td>
        <td style="text-align: left" class="style17">
            <asp:Button ID="btnadd" runat="server" BorderColor="#FFFF99" CssClass="btn" 
                style="margin-left: 0px" Text="ADD" Width="70px" onclick="btnadd_Click" 
                Height="30px" />
        </td>
    </tr>
    <tr>
        <td class="style17">
            &nbsp;</td>
        <td style="text-align: left" class="style17">
            <asp:Label ID="lb1Result" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style12">
            &nbsp;</td>
        <td class="style14">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CategoryID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" ReadOnly="True" SortExpression="CategoryID" />
                    <asp:BoundField DataField="cat_Name" HeaderText="Categories" SortExpression="cat_Name" />
                    <asp:ImageField DataImageUrlField="CAT_image" HeaderText="category Image">
                    </asp:ImageField>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMSC1ConnectionString %>" DeleteCommand="DELETE FROM [CATEGORY] WHERE [CategoryID] = @original_CategoryID" InsertCommand="INSERT INTO [CATEGORY] ([cat_Name], [CategoryID], [CAT_image]) VALUES (@cat_Name, @CategoryID, @CAT_image)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [cat_Name], [CategoryID], [CAT_image] FROM [CATEGORY]" UpdateCommand="UPDATE [CATEGORY] SET [cat_Name] = @cat_Name, [CAT_image] = @CAT_image WHERE [CategoryID] = @original_CategoryID">
                <DeleteParameters>
                    <asp:Parameter Name="original_CategoryID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="cat_Name" Type="String" />
                    <asp:Parameter Name="CategoryID" Type="Int32" />
                    <asp:Parameter Name="CAT_image" Type="Object" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="cat_Name" Type="String" />
                    <asp:Parameter Name="CAT_image" Type="Object" />
                    <asp:Parameter Name="original_CategoryID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </td>
    </tr>
</table>

</asp:Content>

