<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calvary.aspx.cs" Inherits="HealthRecordSystem.Calvary" %>

<%@ Register assembly="obout_Calendar2_Net" namespace="OboutInc.Calendar2" tagprefix="obout" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>Expert System for Heart Related Disease Diagnosis</title>
<link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <table width="881" border="0" align="center" cellpadding="0" cellspacing="0" class="white">
	<tr>
		<td ><img src="images/logo.png" alt=""/></td>
	</tr>
	<tr>
		<td colspan="2"><table width="100%" border="0" cellspacing="0" cellpadding="0">
			<tr>
				<td class="tab"><a href="Default.aspx" class="top">Home</a></td>
				
				<td>&nbsp;</td>
			</tr>
		</table></td>
	</tr>
	<tr>
		<td colspan="2" style="border-top:2px solid #10ADBE;" ><a href="#" ><img src="images/banner.jpg" width="881" height="329" border="0" alt=""/></a></td>
	</tr>
	<tr>
		<td colspan="2" style="padding-top:8px; padding-left:4px;"><table width="100%" border="0" cellspacing="0" cellpadding="0">
			<tr><div class="inner_copy"></div>
				
				<td valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
							<tr>
								<td width="50%" class="heafing3">Administer Site</td>
								</tr>
							<tr>
								<td class="text"><strong></strong><br />
                                <p align = "right">
                            
<a href="ChangePassword.aspx">Change Password</a> | <asp:LoginStatus ID="LoginStatus1" runat="server" /> 
                      
<asp:LoginName ID="LoginName1" runat="server" /></p>
<asp:Button runat="server" ID="btnTabDiet" Text="Diet" CssClass ="tabView" onclick="btnTabDiet_Click"/>
<asp:Button runat="server" ID="btnTabPatients" Text = "Patients Log" CssClass ="tabView" 
                                        onclick="btnTabPatients_Click"/>
                   <br /><br />
                   <asp:MultiView runat="server" ID= "MainView">
        <asp:View runat="server" ID= "viewDiet">
        <table style="width: 100%;">
<tr>
<td>
<asp:GridView runat="server" ID = "grvDiet" Width="98%" GridLines="None" ForeColor="#333333" AllowPaging = "true" PageSize ="50"
DataSourceID="DietDataSource" AutoGenerateColumns="false" DataKeyNames="FoodGroup" 
        EnableModelValidation ="true" ShowFooter = "true" ShowHeader = "true" 
        EmptyDataText="No diet has been added">
                                <RowStyle ForeColor="#333333" BackColor="#F7F6F3" />
                            <PagerStyle BackColor="#089FAF" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#089FAF" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
        <asp:CommandField ShowEditButton = "true" />
        <asp:CommandField ShowDeleteButton = "true" />
                                    
                                   <asp:TemplateField>
                                    <FooterTemplate >
                                        <asp:LinkButton runat="server" ID="lnkAddDiet" Text="Add" CommandName = "Insert" OnClick ="lnkAddDiet_Click" ValidationGroup ="NewDiet"></asp:LinkButton>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    
                                    
                                    <asp:TemplateField HeaderText="Food Group" SortExpression="FoodGroup">
                                        <ItemTemplate>
                                            <asp:Label ID="lblFoodGroup" runat="server" Text ='<%# Bind("FoodGroup") %>'></asp:Label>
                                        </ItemTemplate>
                                        
                                        <FooterTemplate >
                                        <asp:TextBox runat="server" ID="txtNewFoodGroup" CssClass ="txt"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvFoodGroup" runat="server" 
                                   ControlToValidate="txtNewFoodGroup" ErrorMessage="RequiredFieldValidator" 
                                   ForeColor="Red" ValidationGroup ="NewDiet">*</asp:RequiredFieldValidator>
                                        </FooterTemplate>
                                    </asp:TemplateField>                             
                                        <asp:TemplateField HeaderText="Daily Servings (Except as Noted)" SortExpression="DailyServings">
                                        <ItemTemplate>
                                            <asp:Label ID="lblDailyServings" runat="server" Text ='<%# Bind("DailyServings") %>'></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                        <asp:TextBox ID="txtDailyServings" runat="server" CssClass ="txt" Text = '<%# Bind("DailyServings") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <FooterTemplate >
                                        <asp:TextBox runat="server" ID="txtNewDailyServings" CssClass ="txt"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvDailyServings" runat="server" 
                                   ControlToValidate="txtNewDailyServings" ErrorMessage="RequiredFieldValidator" 
                                   ForeColor="Red" ValidationGroup ="NewDiet">*</asp:RequiredFieldValidator>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Serving Sizes" SortExpression="ServingSizes">
                                        <ItemTemplate>
                                            <asp:Label ID="lblServingSizes" runat="server" Text ='<%# Bind("ServingSizes") %>'></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                        <asp:TextBox ID="txtServingSizes" runat="server" CssClass ="txt" Text = '<%# Bind("ServingSizes") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <FooterTemplate >
                                        <asp:TextBox runat="server" ID="txtNewServingSizes" CssClass ="txt"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvServingSizes" runat="server" 
                                   ControlToValidate="txtNewServingSizes" ErrorMessage="RequiredFieldValidator" 
                                   ForeColor="Red" ValidationGroup ="NewDiet">*</asp:RequiredFieldValidator>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                                <asp:SqlDataSource ID="DietDataSource" runat="server" ConnectionString ="<%$Connectionstrings:connStr%>"
     SelectCommand ="SELECT * FROM Diet"
    DeleteCommand="DELETE FROM [Diet] WHERE [FoodGroup] = @FoodGroup" 
                                InsertCommand="INSERT INTO [Diet] ([FoodGroup],[DailyServings],[ServingSizes]) VALUES (@FoodGroup,@DailyServings,@ServingSizes)" 
                                UpdateCommand="UPDATE [Diet] SET [FoodGroup] = @FoodGroup, [DailyServings] = @DailyServings, [ServingSizes] = @ServingSizes WHERE [FoodGroup] = @FoodGroup">
                                <DeleteParameters>
                                    <asp:Parameter Name="FoodGroup" Type="String" />
                                    <asp:Parameter Name="DailyServings" Type="String" />
                                    <asp:Parameter Name="ServingSizes" Type="String" />
                                </DeleteParameters>
                                <InsertParameters>
                                    <asp:Parameter Name="FoodGroup" Type="String" />
                                    <asp:Parameter Name="DailyServings" Type="String" />
                                    <asp:Parameter Name="ServingSizes" Type="String" />
                                    </InsertParameters>
                                <UpdateParameters>
                                    <asp:Parameter Name="FoodGroup" Type="String" />
                                    <asp:Parameter Name="DailyServings" Type="String" />
                                    <asp:Parameter Name="ServingSizes" Type="String" />
                                    </UpdateParameters>
    </asp:SqlDataSource>
</td>
</tr>
</table>
</asp:View>
<asp:View runat="server" ID= "viewPatients">
        <table style="width: 100%;">
<tr>
<td>
<asp:GridView runat="server" ID = "grvPatients" Width="98%" GridLines="None" ForeColor="#333333" AllowPaging = "true" PageSize ="50"
DataSourceID="PatientDataSource" AutoGenerateColumns="true" DataKeyNames="ID" 
        EnableModelValidation ="true" ShowFooter = "true" ShowHeader = "true" 
        EmptyDataText="No patient has used the system">
                                <RowStyle ForeColor="#333333" BackColor="#F7F6F3" />
                            <PagerStyle BackColor="#089FAF" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#089FAF" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
            <asp:CommandField ShowDeleteButton = "true" />
                                    
                                   
                                    </Columns>
                                </asp:GridView>
                                <asp:SqlDataSource ID="PatientDataSource" runat="server" ConnectionString ="<%$Connectionstrings:connStr%>"
     SelectCommand ="SELECT * FROM Patients"
    DeleteCommand="DELETE FROM [Patients] WHERE [ID] = @ID">
                                <DeleteParameters>
                                    <asp:Parameter Name="FoodGroup" Type="String" />
                                    <asp:Parameter Name="DailyServings" Type="String" />
                                    <asp:Parameter Name="ServingSizes" Type="String" />
                                </DeleteParameters>
                                
    </asp:SqlDataSource>
</td>
</tr>
</table>
</asp:View>
</asp:MultiView>
                    </tr>
						</table></td>
			</tr>
		</table></td>
	</tr>
	
	<tr>
		<td colspan="2" class="copy_bg" style="padding:11px">
			<center>				
				Designed by - NETO
				
			</center>
		</td>
	</tr>
</table>
    </form>
</body>
</html>
