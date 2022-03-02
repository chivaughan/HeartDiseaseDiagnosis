<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="HealthRecordSystem.ChangePassword" %>

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
								<td width="50%" class="heafing3">Result</td>
								</tr>
							<tr>
								<td class="text"><strong></strong><br />
                                 <asp:ChangePassword ID="ChangePassword1" runat="server"></asp:ChangePassword>
                                
                   
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
