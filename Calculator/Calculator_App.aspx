<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator_App.aspx.cs" Inherits="Calculator.Calculator_App" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="style.css" type="text/css" />
   
</head>
<body>
    <form id="form1" runat="server">
        <div id="top_header">
            <p id="Label1">Online Calculator</p>
        </div>
       
        <div id="tbl_calc">
            
            <table id="tbl">
                <tr>
                    <td colspan="4">
                        <asp:TextBox ID="Result_box" runat="server" Height="35px" Width="263px" Font-Size="Large" ReadOnly="True">0</asp:TextBox>
                        <br />
                        <br />
                    </td>
                    
                </tr>
                <tr>
                    <td>
                        <asp:Button class="btn_style" ID="Button_CE" runat="server" Text="CE" width="70px" Height="50px" OnClick="Button_CE_Click" Font-Bold="True" Font-Size="Small"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_BACKSPACE" runat="server" Text="&larr;" width="70px" Height="50px" Font-Bold="True" Font-Size="Large" OnClick="Button_BACKSPACE_Click"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_ADD" runat="server" Text="+" width="70px" Height="50px" OnClick="Operator_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_SUBTRACT" runat="server" Text="-" width="70px" Height="50px" OnClick="Operator_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button class="btn_style" ID="Button_7" runat="server" Text="7" width="70px" Height="50px" OnClick="Button_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_8" runat="server" Text="8" width="70px" Height="50px" OnClick="Button_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_9" runat="server" Text="9" width="70px" Height="50px" OnClick="Button_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_MULTI" runat="server" Text="x" width="70px" Height="50px" OnClick="Operator_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                </tr>
                <tr>
                     <td>
                        <asp:Button class="btn_style" ID="Button_4" runat="server" Text="4" width="70px" Height="50px" OnClick="Button_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_5" runat="server" Text="5" width="70px" Height="50px" OnClick="Button_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_6" runat="server" Text="6" width="70px" Height="50px" OnClick="Button_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_DIVIDE" runat="server" Text="/" width="70px" Height="50px" OnClick="Operator_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button class="btn_style" ID="Button_1" runat="server" Text="1" width="70px" Height="50px" OnClick="Button_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_2" runat="server" Text="2" width="70px" Height="50px" OnClick="Button_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_3" runat="server" Text="3" width="70px" Height="50px" OnClick="Button_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_MOD" runat="server" Text="%" width="70px" Height="50px" OnClick="Button_MOD_Click" Font-Bold="True" Font-Size="Large" />
                    </td>
                </tr>
                <tr>
                     <td colspan="2">
                        <asp:Button class="btn_style" ID="Button_0" runat="server" Text="0" width="144px" Height="50px" OnClick="Button_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                   
                    <td>
                        <asp:Button class="btn_style" ID="Button_DOT" runat="server" Text="." width="70px" Height="50px" OnClick="Button_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_EQUAL" runat="server" Text="=" width="70px" Height="50px" OnClick="Button_EQUAL_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
    <div id="list">
        <ul>
            <li>Enter first number.</li>
            <li>Select the operator.</li>
            <li>Enter second number.</li>
            <li>Press = to get results.</li>
        </ul>
    </div>
    <footer id="page_footer">
        <p>
            Project by Narinder Gill
        </p>
    </footer>
</body>
</html>
