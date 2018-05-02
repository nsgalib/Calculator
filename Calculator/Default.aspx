<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculator.Calculator_App" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Calculator</title>
       <link rel="stylesheet" href="style.css" type="text/css" />
    <meta http-equiv="Page-Exit" content="BlendTrans(Duration=0)" />
   <meta http-equiv="Page-Enter" content="BlendTrans(Duration=0)" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="top_header">
            <p id="Label1">Online Calculator</p>
        </div>
       
        <div id="tbl_calc">
            
            <table id="tbl">
               
                <tr>
                    <td colspan="8">
                        <div id="label_text">
                            <asp:Label ID="lbl_result" runat="server"></asp:Label>
                            <br /><br />
                            <asp:TextBox ID="Result_box" runat="server" Height="31px" Width="572px" Font-Size="Large" ReadOnly="True">0</asp:TextBox>
                            <br />
                            <br />
                        </div>
                        
                    </td>
                    
                   
                    
                </tr>
                <tr>
                    <td>
                        <asp:Button class="btn_style" ID="Button_CE" runat="server" Text="CE" width="70px" Height="50px" OnClick="Button_CE_Click" Font-Bold="True" Font-Size="Small"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_BACKSPACE" runat="server" Text="&larr;" width="70px" Height="50px" Font-Bold="True" Font-Size="X-Large" OnClick="Button_BACKSPACE_Click"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_ADD" runat="server" Text="+" width="70px" Height="50px" OnClick="Operator_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td >
                        <asp:Button class="btn_style" ID="Button_SUBTRACT" runat="server" Text="-" width="70px" Height="50px" OnClick="Operator_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td >
                        &nbsp;&nbsp;</td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_Pi" runat="server" Text="π" width="70px" Height="50px" Font-Bold="True" Font-Size="Large" OnClick="btn_Pi_Click" />
                    </td>
                    <td> 
                        <asp:Button class="btn_style" ID="btn_log" runat="server" Text="Log" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_log_Click" />
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_Sqrt" runat="server" Text="Sqrt" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_Sqrt_Click" />
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
                    <td>
                        &nbsp;&nbsp;</td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_sinh" runat="server" Text="Sinh" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_sinh_Click" />
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_sin" runat="server" Text="Sin" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_sin_Click" />
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_mod" runat="server" Text="Mod" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_mod_Click"/>
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
                    <td>
                        &nbsp;&nbsp;</td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_cosh" runat="server" Text="Cosh" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_cosh_Click" />
                     </td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_cos" runat="server" Text="Cos" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_cos_Click" />
                     </td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_bin" runat="server" Text="Bin" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_bin_Click" />
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
                        <asp:Button class="btn_style" ID="plusMinus" runat="server" Text="±" width="70px" Height="50px" OnClick="plusMinus_Click" Font-Bold="True" Font-Size="Large" />
                    </td>
                    <td>
                        &nbsp;&nbsp;</td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_tanh" runat="server" Text="Tanh" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_tanh_Click" />
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_tan" runat="server" Text="Tan" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_tan_Click" />
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_hex" runat="server" Text="Hex" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_hex_Click" />
                    </td>
                </tr>
                <tr>
                     <td colspan="2">
                        <asp:Button class="btn_style" ID="Button_0" runat="server" Text="0" width="144px" Height="50px" OnClick="Button_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                   
                    <td>
                        <asp:Button class="btn_style" ID="Button_DOT" runat="server" Text="." width="70px" Height="50px" Font-Bold="True" Font-Size="Large" OnClick="Button_DOT_Click"/>
                    </td>
                    <td>
                        <asp:Button class="btn_style" ID="Button_EQUAL" runat="server" Text="=" width="70px" Height="50px" OnClick="Button_EQUAL_Click" Font-Bold="True" Font-Size="Large"/>
                    </td>
                    <td>
                        &nbsp;&nbsp;</td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_x2" runat="server" Text="x^2" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_x2_Click"  />
                     </td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_x3" runat="server" Text="x^3" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_x3_Click" />
                     </td>
                    <td>
                        <asp:Button class="btn_style" ID="btn_1x" runat="server" Text="1/x" width="70px" Height="50px" Font-Bold="True" Font-Size="Small" OnClick="btn_1x_Click" />
                     </td>
                </tr>
            </table>
            
        </div>
       
   </form>
    
</body>
</html>
