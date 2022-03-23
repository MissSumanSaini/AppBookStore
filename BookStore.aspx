<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookStore.aspx.cs" Inherits="AppBookStore.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Book Name: </td>
                    <td><asp:TextBox  ID="txtName" runat ="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Book Price: </td>
                    <td><asp:TextBox  ID="txtPrice" runat ="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Author Name: </td>
                    <td><asp:TextBox  ID="txtAuthorName" runat ="server"></asp:TextBox></td>
                </tr>
                
                 <tr>
                    <td> </td>
                    <td><asp:Button id="BtnSave" runat="server" Text="SAVE" OnClick="BtnSave_Click"
                        /> </td>
                </tr>

                  <tr>
                    <td> </td>
                    <td><asp:GridView id="grd" runat="server" ></asp:GridView> </td>
                </tr>




            </table>

        </div>
    </form>
</body>
</html>
