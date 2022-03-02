<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="HealthRecordSystem.Test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>Expert System for Heart Related Disease Diagnosis</title>
<link href="style.css" rel="stylesheet" type="text/css" />
<script src="Scripts/jquery-1.6.4.min.js" type="text/javascript"></script>
<script type="text/javascript">
//This function sets the default view
    function DefaultView() {
        $('#div1').show();
        $('#div2').hide();
        $('#divChestPainInfo').hide();
        $('#div3').hide();
        $('#div4').hide();
    }
</script>
<script type="text/javascript">
//This functions displays the next category of info/test
    function NextViewIndex(index) {
        switch (index) {
            case 2:
                //Check that all fields have been filled
                if (txtFullName.value == '') {
                    alert('All fields are required');
                    break;
                }
                if (txtAge.value == '') {
                    alert('All fields are required');
                    break;
                }
                if (txtAddress.value == '') {
                    alert('All fields are required');
                    break;
                }
                if (txtPhoneNumber.value == '') {
                    alert('All fields are required');
                    break;
                }
                if (txtEmail.value == '') {
                    alert('All fields are required');
                    break;
                }
                $('#div1').hide();
                $('#div2').show();
                $('#div3').hide();
                $('#div4').hide();
                break;
            case 3:
                $('#div1').hide();
                $('#div2').hide();
                $('#div3').show();
                $('#div4').hide();
                break;
            case 4:
                $('#div1').hide();
                $('#div2').hide();
                $('#div3').hide();
                $('#div4').show();
                break;
        }

        }
</script>
<script type="text/javascript">
    //This functions displays the previous category of info/test
    function PreviousViewIndex(index) {
        switch (index) {
            case 1:
                $('#div1').show();
                $('#div2').hide();
                $('#div3').hide();
                $('#div4').hide();
                break;
            case 2:
                $('#div1').hide();
                $('#div2').show();
                $('#div3').hide();
                $('#div4').hide();
                break;
            case 3:
                $('#div1').hide();
                $('#div2').hide();
                $('#div3').show();
                $('#div4').hide();
                break;
        }

    }
</script>
<script type="text/javascript">
//This function displays the chest pain info field if the patient has chest pain
    function ChestPainInfo(field) {

        if (field.value == 'Yes') {
            $('#divChestPainInfo').show();
        }
        else 
        {
            $('#divChestPainInfo').hide();
        }
        
    }
</script>
<script type = "text/javascript">
    // This function ensures that only numbers can be enetered in the text box
    function isNumberKey(evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode > 31 && (charCode < 48 || charCode > 57)) {
            return false;
        }

        return true; // Return true if a number is entered
    }
</script>
</head>
<body onload ="DefaultView();">
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
								<td width="50%" class="heafing3"></td>
							</tr>
							<tr>
								<td class="text"><strong></strong><br />
									<div id="div1">
                                <strong class="heafing3">Personal Information</strong>
                                <br /><br />
                                Full Name: <input type="text" class="txt" id="txtFullName" runat="server"/>
                                <br /><br />
                                Age: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type="text" maxlength= "3" class="txt" id="txtAge" runat="server" onkeypress ="return isNumberKey(event);"/>
                                <br /><br />
                                Gender: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlGender" runat="server">
                                <option value="Male" selected>Male</option>
                                <option value="Female" >Female</option>
                                </select>
                                <br /><br />
                                Address: &nbsp;&nbsp;&nbsp;<input type="text" class="txt" id="txtAddress" runat="server"/>
                                <br /><br />
                                Phone No: <input type="text" class="txt" id="txtPhoneNumber"  maxlength= "11" runat="server" onkeypress ="return isNumberKey(event);"/>
                                <br /><br />
                                Email: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input type="text" class="txt" id="txtEmail" runat="server"/>
                                <br /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<input type="button" id="btnNextPhysicalTest" value="Next" class ="btn" 
                   onclick ="return NextViewIndex(2);"/>
                    
                                </div>
                
                    <div id="div2">
                                <strong class="heafing3">Physical Tests</strong>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;1. Do you have family history of heart disease?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlFamilyHistoryOfHeartDisease" runat="server">
                                <option value="No" selected>No</option>
                                <option value="Yes" >Yes</option>
                                </select>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;2. Do you smoke?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlSmoke" runat="server">
                                <option value="No" selected>No</option>
                                <option value="Yes" >Yes</option>
                                </select>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;3. Do you suffer from obesity?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlObesity" runat="server">
                                <option value="No" selected>No</option>
                                <option value="Yes" >Yes</option>
                                </select>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;4. Does your body radiate?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlRadiate" runat="server">
                                <option value="Neck and Shoulder" selected>Neck and Shoulder</option>
                                <option value="Neck, shoulder, lower or upper jaw" >Neck, shoulder, lower or upper jaw</option>
                                </select>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;5. Do you have shortness of breath?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlShortnessOfBreath" runat="server">
                                <option value="No" selected>No</option>
                                <option value="Yes" >Yes</option>
                                </select>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;6. Do you face any kind of stress?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlStress" runat="server">
                                <option value="No" selected>No</option>
                                <option value="Yes" >Yes</option>
                                </select>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;7. What is the nature of your work?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlNatureOfWork" runat="server">
                                <option value="Normal" selected>Normal</option>
                                <option value="Excessive Exercise" >Excessive Exercise</option>
                                </select>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;8. Do you have chest pain?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlChestPain" onchange="return ChestPainInfo(ddlChestPain);" runat="server">
                                <option value="No" selected>No</option>
                                <option value="Yes">Yes</option>
                                </select>
                                <br /><br />
                                <div id="divChestPainInfo">
                                &nbsp;&nbsp;&nbsp;9. How severe is your the pain?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlChestPainSeverity" runat="server">
                                <option value="Mild to Moderate" selected>Mild to Moderate</option>
                                <option value="Very Severe" >Very Severe</option>
                                </select>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;10. Can you localize the pain while pressing with your finger?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlLocalizeChestPain" runat="server">
                                <option value="No" selected>No</option>
                                <option value="Yes" >Yes</option>
                                </select>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;11. What is the location of the pain?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlLocationOfChestPain" runat="server">
                                <option value="Anterior Chest" selected>Anterior Chest</option>
                                <option value="Other Parts" >Other parts</option>
                                </select>
                                <br /><br />                                
                                &nbsp;&nbsp;&nbsp;12. Do you feel dizzy while having the pain?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlDizzy" runat="server">
                                <option value="No" selected>No</option>
                                <option value="Yes" >Yes</option>
                                </select>
                                <br /><br />
                                </div>
                                <input type="button" id="btnPreviousPersonalInfo" class="btn" value="Previous" onclick ="return PreviousViewIndex(1);"/>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<input type="button" id="btnNextLaboratoryTest" value="Next" class ="btn" 
                    onclick = "return NextViewIndex(3);"/>
                    
                                </div>
                                <div id="div3">
                                <strong class="heafing3">Laboratory Tests</strong>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;1. Do you have diabetes?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlDiabetes" runat="server">
                                <option value="No" selected>No</option>
                                <option value="Yes" >Yes</option>
                                </select>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;2. Do you have high blood pressure?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlHighBloodPressure" runat="server">
                                <option value="No" selected>No</option>
                                <option value="Yes" >Yes</option>
                                </select>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;3. Do you have high cholesterol?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlHighCholesterol" runat="server">
                                <option value="No" selected>No</option>
                                <option value="Yes" >Yes</option>
                                </select>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;4. Do you have palpitation(fast or irregular heartbeat)?
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select id="ddlPalpitation" runat="server">
                                <option value="No" selected>No</option>
                                <option value="Yes" >Yes</option>
                                </select>
                                <br /><br />
                                <input type="button" id="btnPreviousPhysicalTest" class="btn" value="Previous" onclick ="return PreviousViewIndex(2);"/>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<input type="button"id="btnNextTestComplete" value="Next" class ="btn" 
                    onclick = "return NextViewIndex(4);"/>
                                </div>
                                <div id="div4">
                                <strong class="heafing3">Test Complete</strong>
                                <br /><br />
                                You have successfully completed the test
                                <br /><br />
                                Click the 'Diagnose' button to view your result or 'Previous' to go back and make corrections
                                <br /><br />
                                <input type="button" id="btnPreviousLaboratoryTest" class="btn" value="Previous" onclick ="return PreviousViewIndex(3);"/>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button runat="server" ID="btnDiagnose" Text="Diagnose" CssClass ="btn" onclick="btnDiagnose_Click" 
                    />
                                </div>
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
