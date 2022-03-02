using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace HealthRecordSystem
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDiagnose_Click(object sender, EventArgs e)
        {
            // Collect the patients personal information
            string fullName = txtFullName.Value;
            int age = int.Parse(txtAge.Value);
            string gender = ddlGender.Value;
            string address = txtAddress.Value;
            string phoneNumber = txtPhoneNumber.Value;

            // Collect the Physical Test Result
            string familyHistoryOfHeartDisease = ddlFamilyHistoryOfHeartDisease.Value;
            string smoke = ddlSmoke.Value;
            string obesity = ddlObesity.Value;
            string chestPain = ddlChestPain.Value;
            string chestPainSeverity = ddlChestPainSeverity.Value;
            string locationOfChestPain = ddlLocationOfChestPain.Value;
            string localizeChestpain = ddlLocalizeChestPain.Value;
            string dizzy = ddlDizzy.Value;
            string radiate = ddlRadiate.Value;
            string shortnessOfBreath = ddlShortnessOfBreath.Value;
            string stress = ddlStress.Value;
            string natureOfWork = ddlNatureOfWork.Value;

            //Collect the Laboratory Test Result
            string diabetes = ddlDiabetes.Value;
            string highBloodPressure = ddlHighBloodPressure.Value;
            string highCholesterol = ddlHighCholesterol.Value;
            string Palpitation = ddlPalpitation.Value;

            #region Inference Engine
            int fact1, fact2, fact3, fact4, fact5, fact6, fact7;

            #region Facts
            fact1 = 0; //Initialize fact1
            //Fact1
            if (gender == "Male" && age > 40)
            {
                fact1 = 1;
            }
            if (gender == "Male" && age < 40)
            {
                fact1 = 0;
            }
            if (gender == "Female" && age > 40)
            {
                fact1 = 1;
            }
            if (gender == "Female" && age < 40)
            {
                fact1 = 0;
            }

            //Fact2
            if (smoke == "Yes")
            {
                fact2 = 1;
            }
            else 
            {
                fact2 = 0;
            }

            //Fact3
            if (highBloodPressure == "Yes")
            {
                fact3 = 1;
            }
            else 
            {
                fact3 = 0;
            }

            //fact4
            if (familyHistoryOfHeartDisease == "Yes")
            {
                fact4 = 1;
            }
            else 
            {
                fact4 = 0;
            }

            //fact5
            if (diabetes == "Yes")
            {
                fact5 = 1;
            }
            else
            {
                fact5 = 0;
            }

            //fact6
            if (highCholesterol == "Yes")
            {
                fact6 = 1;
            }
            else
            {
                fact6 = 0;
            }

            //fact7
            if (chestPain == "Yes")
            {
                fact7 = 1;
            }
            else
            {
                fact7 = 0;
            }

            #endregion

            #region Rules
            //Rules
            int palpitationSymptom, dizzySymptom, rSymptom1,calcFact, rule01, combine1, radiationSymptom, combine2, severitySymptom, finalCombine, ruless;
            string finalResult;

            #region Palpitation Symptom
            //Palpitation Symptom
            palpitationSymptom = 0; //Initialize palpitation symptom
            if (Palpitation == "Yes" && shortnessOfBreath == "Yes")
            {
                palpitationSymptom = 0;
            }
            if (Palpitation == "No" && shortnessOfBreath == "Yes")
            {
                palpitationSymptom = 1;
            }
            if (Palpitation == "Yes" && shortnessOfBreath == "No")
            {
                palpitationSymptom = 2;
            }
            if (Palpitation == "No" && shortnessOfBreath == "No")
            {
                palpitationSymptom = 3;
            }
            #endregion

            #region Dizzy Symptom
            // Dizzy Symptom
            if (dizzy == "Yes")
            {
                dizzySymptom = 0;
            }
            else
            {
                dizzySymptom = 1;
            }
            #endregion

            #region rSymptom1
            // rSymptom1
            rSymptom1 = 0; //Initialize rSymptom1
            if (localizeChestpain == "Yes" && locationOfChestPain == "Anterior Chest")
            {
                rSymptom1 = 1;
            }
            if (localizeChestpain == "Yes" && locationOfChestPain == "Other Parts")
            {
                rSymptom1 = 2;
            }
            if (localizeChestpain == "No" && locationOfChestPain == "Anterior Chest")
            {
                rSymptom1 = 3;
            }
            if (localizeChestpain == "No" && locationOfChestPain == "Other Parts")
            {
                rSymptom1 = 4;
            }
            #endregion

            // Calculate the facts
            calcFact = fact1 + fact2 + fact3 + fact4 + fact5 + fact6;

            #region Rule01
            //Rule01
            rule01 = 0; //Initialize Rule01
            if (fact7 == 1 && calcFact == 1)
            {
                rule01 = 1;
            }
            if (fact7 == 1 && calcFact == 2)
            {
                rule01 = 2;
            }
            if (fact7 == 1 && calcFact == 3)
            {
                rule01 = 3;
            }
            if (fact7 == 1 && calcFact == 4)
            {
                rule01 = 4;
            }
            if (fact7 == 1 && calcFact == 5)
            {
                rule01 = 5;
            }
            if (fact7 == 1 && calcFact == 6)
            {
                rule01 = 6;
            }
            if (fact7 == 1 && calcFact == 0)
            {
                rule01 = 0;
            }
            if (fact7 == 0 && calcFact == 0)
            {
                rule01 = 7;
            }
            if (fact7 == 0 && calcFact == 1)
            {
                rule01 = 8;
            }
            if (fact7 == 0 && calcFact == 2)
            {
                rule01 = 9;
            }
            if (fact7 == 0 && calcFact == 3)
            {
                rule01 = 10;
            }
            if (fact7 == 0 && calcFact == 4)
            {
                rule01 = 11;
            }
            if (fact7 == 0 && calcFact == 5)
            {
                rule01 = 12;
            }
            if (fact7 == 0 && calcFact == 6)
            {
                rule01 = 13;
            }
            #endregion

            #region Radiation Symptom
            //Radiation Symptom
            if (radiate == "Neck and Shoulder")
            {
                radiationSymptom = 0;
            }
            else
            {
                radiationSymptom = 1;
            }
            #endregion

            #region Severity Symptom
            //Severity Symptom
            if (chestPainSeverity == "Mild to Moderate")
            {
                severitySymptom = 0;
            }
            else
            {
                severitySymptom = 1;
            }
            #endregion

            #region Combine1
            //Combine1
            combine1 = 0; //Initialize combine1
            if (radiationSymptom == 0 && severitySymptom == 0)
            {
                combine1 = 0;
            }
            if (radiationSymptom == 0 && severitySymptom == 1)
            {
                combine1 = 1;
            }
            if (radiationSymptom == 1 && severitySymptom == 0)
            {
                combine1 = 2;
            }
            if (radiationSymptom == 1 && severitySymptom == 1)
            {
                combine1 = 3;
            }
            #endregion

            #region Combine2
            //Combine2
            combine2 = 0; //Initialize combine2
            if (palpitationSymptom == 0 && dizzySymptom == 0)
            {
                combine2 = 0;
            }
            if (palpitationSymptom == 1 && dizzySymptom == 0)
            {
                combine2 = 1;
            }
            if (palpitationSymptom == 2 && dizzySymptom == 0)
            {
                combine2 = 2;
            }
            if (palpitationSymptom == 3 && dizzySymptom == 0)
            {
                combine2 = 3;
            }
            if (palpitationSymptom == 0 && dizzySymptom == 1)
            {
                combine2 = 4;
            }
            if (palpitationSymptom == 1 && dizzySymptom == 1)
            {
                combine2 = 5;
            }
            if (palpitationSymptom == 2 && dizzySymptom == 1)
            {
                combine2 = 6;
            }
            if (palpitationSymptom == 3 && dizzySymptom == 1)
            {
                combine2 = 7;
            }
            #endregion

            #region Final Combine
            //Final Combine
            finalCombine = 0; //Initialize finalCombine
            if (combine1 == 0 && combine2 == 0)
            {
                finalCombine = 0;
            }
            if (combine1 == 1 && combine2 == 0)
            {
                finalCombine = 1;
            }
            if (combine1 == 2 && combine2 == 0)
            {
                finalCombine = 2;
            }
            if (combine1 == 3 && combine2 == 0)
            {
                finalCombine = 3;
            }
            if (combine1 == 0 && combine2 == 1)
            {
                finalCombine = 4;
            }
            if (combine1 == 1 && combine2 == 1)
            {
                finalCombine = 5;
            }
            if (combine1 == 2 && combine2 == 1)
            {
                finalCombine = 6;
            }
            if (combine1 == 3 && combine2 == 1)
            {
                finalCombine = 7;
            }
            if (combine1 == 0 && combine2 == 2)
            {
                finalCombine = 8;
            }
            if (combine1 == 1 && combine2 == 2)
            {
                finalCombine = 9;
            }
            if (combine1 == 2 && combine2 == 2)
            {
                finalCombine = 10;
            }
            if (combine1 == 3 && combine2 == 2)
            {
                finalCombine = 11;
            }
            if (combine1 == 0 && combine2 == 3)
            {
                finalCombine = 12;
            }
            if (combine1 == 1 && combine2 == 3)
            {
                finalCombine = 13;
            }
            if (combine1 == 2 && combine2 == 3)
            {
                finalCombine = 14;
            }
            if (combine1 == 3 && combine2 == 3)
            {
                finalCombine = 15;
            }
            if (combine1 == 0 && combine2 == 4)
            {
                finalCombine = 16;
            }
            if (combine1 == 1 && combine2 == 4)
            {
                finalCombine = 17;
            }
            if (combine1 == 2 && combine2 == 4)
            {
                finalCombine = 18;
            }
            if (combine1 == 3 && combine2 == 4)
            {
                finalCombine = 19;
            }
            if (combine1 == 0 && combine2 == 5)
            {
                finalCombine = 20;
            }
            if (combine1 == 1 && combine2 == 5)
            {
                finalCombine = 21;
            }
            if (combine1 == 2 && combine2 == 5)
            {
                finalCombine = 22;
            }
            if (combine1 == 3 && combine2 == 5)
            {
                finalCombine = 23;
            }
            if (combine1 == 0 && combine2 == 6)
            {
                finalCombine = 24;
            }
            if (combine1 == 1 && combine2 == 6)
            {
                finalCombine = 25;
            }
            if (combine1 == 2 && combine2 == 6)
            {
                finalCombine = 26;
            }
            if (combine1 == 3 && combine2 == 6)
            {
                finalCombine = 27;
            }
            if (combine1 == 0 && combine2 == 7)
            {
                finalCombine = 28;
            }
            if (combine1 == 1 && combine2 == 7)
            {
                finalCombine = 29;
            }
            if (combine1 == 2 && combine2 == 7)
            {
                finalCombine = 30;
            }
            if (combine1 == 3 && combine2 == 7)
            {
                finalCombine = 31;
            }
            #endregion

            #region Ruless
            //ruless
            ruless = 0; //Initialize ruless
            if (rule01 == 0 && rSymptom1 == 1)
            {
                ruless = 0;
            }
            if (rule01 == 1 && rSymptom1 == 1)
            {
                ruless = 1;
            }
            if (rule01 == 2 && rSymptom1 == 1)
            {
                ruless = 2;
            }
            if (rule01 == 3 && rSymptom1 == 1)
            {
                ruless = 3;
            }
            if (rule01 == 4 && rSymptom1 == 1)
            {
                ruless = 4;
            }
            if (rule01 == 5 && rSymptom1 == 1)
            {
                ruless = 5;
            }
            if (rule01 == 6 && rSymptom1 == 1)
            {
                ruless = 6;
            }
            if (rule01 == 0 && rSymptom1 == 2)
            {
                ruless = 7;
            }
            if (rule01 == 1 && rSymptom1 == 2)
            {
                ruless = 8;
            }
            if (rule01 == 2 && rSymptom1 == 2)
            {
                ruless = 9;
            }
            if (rule01 == 3 && rSymptom1 == 2)
            {
                ruless = 10;
            }
            if (rule01 == 4 && rSymptom1 == 2)
            {
                ruless = 11;
            }
            if (rule01 == 5 && rSymptom1 == 2)
            {
                ruless = 12;
            }
            if (rule01 == 6 && rSymptom1 == 2)
            {
                ruless = 13;
            }
            if (rule01 == 0 && rSymptom1 == 3)
            {
                ruless = 14;
            }
            if (rule01 == 1 && rSymptom1 == 3)
            {
                ruless = 15;
            }
            if (rule01 == 2 && rSymptom1 == 3)
            {
                ruless = 16;
            }
            if (rule01 == 3 && rSymptom1 == 3)
            {
                ruless = 17;
            }
            if (rule01 == 4 && rSymptom1 == 3)
            {
                ruless = 18;
            }
            if (rule01 == 5 && rSymptom1 == 3)
            {
                ruless = 19;
            }
            if (rule01 == 6 && rSymptom1 == 3)
            {
                ruless = 20;
            }
            if (rule01 == 0 && rSymptom1 == 4)
            {
                ruless = 21;
            }
            if (rule01 == 1 && rSymptom1 == 4)
            {
                ruless = 22;
            }
            if (rule01 == 2 && rSymptom1 == 4)
            {
                ruless = 23;
            }
            if (rule01 == 3 && rSymptom1 == 4)
            {
                ruless = 24;
            }
            if (rule01 == 4 && rSymptom1 == 4)
            {
                ruless = 25;
            }
            if (rule01 == 5 && rSymptom1 == 4)
            {
                ruless = 26;
            }
            if (rule01 == 6 && rSymptom1 == 4)
            {
                ruless = 27;
            }
            #endregion

            #region FinalResult
            finalResult = ""; //Initialize finalResult
            if (ruless >= 0 && ruless <= 7 && finalCombine == 0)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 0)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 0)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 21 && finalCombine == 0)
            {
                finalResult = "OnlyHighRate";
            }
            if (ruless >= 0 && ruless <= 7 && finalCombine == 1)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 1)
            {
                finalResult = "OnlyHighRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 1)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 21 && finalCombine == 1)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless <= 7 && finalCombine == 2)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 2)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 2)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 21 && finalCombine == 2)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 3)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 3)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 3)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 21 && finalCombine == 3)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 4)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 5)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 6)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 7)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 8)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 9)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 10)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 11)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 12)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 13)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 14)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 15)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 16)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 17)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 18)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 19)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 20)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 21)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 22)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 23)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 24)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 25)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 26)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 27)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 28)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 29)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 30)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 0 && ruless < 7 && finalCombine == 31)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 4)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 5)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 6)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 7)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 8)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 9)
            {
                finalResult = "HighRateAngina";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 10)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 11)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 12)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 13)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 14)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 15)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 16)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 17)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 18)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 19)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 20)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 21)
            {
                finalResult = "HighRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 22)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 23)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 24)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 25)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 26)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 27)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 28)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 29)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 30)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 7 && ruless <= 14 && finalCombine == 31)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 4)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 5)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 6)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 7)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 8)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 9)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 10)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 11)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 12)
            {
                finalResult = "OnlyHighRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 13)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 14)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 15)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 16)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 17)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 18)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 19)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 20)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 21)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 22)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 23)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 24)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 25)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 26)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 27)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 28)
            {
                finalResult = "LowRateAngina";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 29)
            {
                finalResult = "OnlyHighRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 30)
            {
                finalResult = "OnlyHighRate";
            }
            if (ruless >= 14 && ruless <= 21 && finalCombine == 31)
            {
                finalResult = "OnlyHighRate";
            }
            if (ruless >= 21 && finalCombine == 4)
            {
                finalResult = "OnlyHighRate";
            }
            if (ruless >= 21 && finalCombine == 5)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 21 && finalCombine == 6)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 21 && finalCombine == 7)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 21 && finalCombine == 8)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 21 && finalCombine == 9)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 21 && finalCombine == 10)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 21 && finalCombine == 11)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 21 && finalCombine == 12)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 21 && finalCombine == 13)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 21 && finalCombine == 14)
            {
                finalResult = "OnlyLowRate";
            }
            if (ruless >= 21 && finalCombine == 15)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 16)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 17)
            {
                finalResult = "LowRateAorticAneurism";
            }
            if (ruless >= 21 && finalCombine == 18)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 19)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 20)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 21)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 22)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 23)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 24)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 25)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 26)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 27)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 28)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 29)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 30)
            {
                finalResult = "NotAtAll";
            }
            if (ruless >= 21 && finalCombine == 31)
            {
                finalResult = "NotAtAll";
            }
            #endregion

            DisplayDiagnosis(finalResult); // Display the diagnosis

            #endregion

            #endregion

        }

        private void DisplayDiagnosis(string illness)
        {
            string illnessInfo = ""; //Info on the herat disease
            string dietInfo = ""; //Info on the diet
            switch (illness)
            {
                case "NotAtAll":
                    illnessInfo = "<strong>" +txtFullName.Value +"</strong>" + ", You are not suffering from any heart disease. This system has been designed for heart diseases only. Please consult your physician for any doubts.";
                    break;
                case "OnlyLowRate":
                    illnessInfo = "<strong>" + txtFullName.Value + "</strong>" + ", You are not suffering from any heart disease but from your symptoms it has been diagnosed that you have a <strong>low risk</strong> of suffering from a heart disease. Please consult your physician. For further enquiries please do not hesitate to contact our center. ";
                    break;
                case "OnlyHighRate":
                    illnessInfo = "<strong>" + txtFullName.Value + "</strong>" + ", You are not suffering from any heart disease but from your symptoms it has been diagnosed that you have a <strong>high risk</strong> of suffering from a heart disease. Please consult your physician. For further enquiries please do not hesitate to contact our center.";
                    break;
                case "LowRateAngina":
                    illnessInfo = "<strong>" + txtFullName.Value + "</strong>" + ", You are suffering from <strong>Angina</strong> and your stage is a <strong>early stage</strong>.<br/>Angina Pectoris is a severe chest pain resulting from a reduced supply of blood and oxygen to the heart. Please follow a strict and selected diet to prevent the increase of the risk level. Your risk level increases with every wrong step you take. Below is some information on a proposed diet:";
                    dietInfo = "*Serving sizes vary between 1/2-1 1/4 cups. Check the product's nutrition label.<br/>" +
                        "*Fat content changes serving counts for fats and oils:<br/>" +
                        "For example, 1 Tbsp of regular salad dressing = 1 serving;<br/>" +
                        "1 Tbsp of a lowfat dressing = 1/2 serving;<br/>" +
                        "1 Tbsp of a fat free dressing = 0 servings.";
                    break;
                case "HighRateAngina":
                    illnessInfo = "<strong>" + txtFullName.Value + "</strong>" + ", You are suffering from <strong>Angina</strong> and your stage is a <strong>late stage<strong>.<br/>Angina Pectoris is a severe chest pain resulting from a reduced supply of blood and oxygen to the heart. Please consult your physician <strong>immediately</strong>. As for now please follow a strict and selected diet. Below is some information on a proposed diet:";
                    dietInfo = "*Serving sizes vary between 1/2-1 1/4 cups. Check the product's nutrition label.<br/>" +
                        "*Fat content changes serving counts for fats and oils:<br/>" +
                        "For example, 1 Tbsp of regular salad dressing = 1 serving;<br/>" +
                        "1 Tbsp of a lowfat dressing = 1/2 serving;<br/>" +
                        "1 Tbsp of a fat free dressing = 0 servings.";
                    break;
                case "LowRateAorticAneurism":
                    illnessInfo = "<strong>" + txtFullName.Value + "</strong>" + ", You are suffering from <strong>Aortic Aneurysm</strong> and your stage is a <strong>early stage</strong>.<br/>Aortic Aneurism is a swelling of the vessel wall of the aorta. Please follow a strict and selected diet to prevent the increase of the risk level. Your risk level increases with every wrong step you take. Below is some information on a proposed diet:";
                    dietInfo = "*Serving sizes vary between 1/2-1 1/4 cups. Check the product's nutrition label.<br/>" +
                        "*Fat content changes serving counts for fats and oils:<br/>" +
                        "For example, 1 Tbsp of regular salad dressing = 1 serving;<br/>" +
                        "1 Tbsp of a lowfat dressing = 1/2 serving;<br/>" +
                        "1 Tbsp of a fat free dressing = 0 servings.";
                    break;
                case "HighRateAorticAneurism":
                    illnessInfo = "<strong>" + txtFullName.Value + "</strong>" + ", You are suffering from <strong>Aortic Aneurysm</strong> and your stage is a <strong>late stage</strong>.<br/>Aortic Aneurism is a swelling of the vessel wall of the aorta. Please follow a strict and selected diet to prevent the increase of the risk level. Your risk level increases with every wrong step you take. Below is some information on a proposed diet:";
                    dietInfo = "*Serving sizes vary between 1/2-1 1/4 cups. Check the product's nutrition label.<br/>" +
                        "*Fat content changes serving counts for fats and oils:<br/>" +
                        "For example, 1 Tbsp of regular salad dressing = 1 serving;<br/>" +
                        "1 Tbsp of a lowfat dressing = 1/2 serving;<br/>" +
                        "1 Tbsp of a fat free dressing = 0 servings.";
                    break;
            }

            //Save the patient's result to the database
            //string connString = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            //SqlConnection conn;
            //conn = new SqlConnection(connString);
            //conn.Open();
            //SqlCommand command;
            //command = new SqlCommand();
            //string sqlString = @"INSERT INTO Patients VALUES (@FullName, @Gender, @Age, @ContactAddress, @Phone, @Email, @Date, @Result)"; //the insert sql string
            ////command.Parameters.AddWithValue("@ID", lblID.Text);
            //command.Parameters.AddWithValue("@FullName", txtFullName.Value);
            //command.Parameters.AddWithValue("@Gender", ddlGender.Value);
            //command.Parameters.AddWithValue("@Age", txtAge.Value);
            //command.Parameters.AddWithValue("@ContactAddress", txtAddress.Value);
            //command.Parameters.AddWithValue("@Phone", txtPhoneNumber.Value);
            //command.Parameters.AddWithValue("@Email", txtEmail.Value);
            //command.Parameters.AddWithValue("@Date", DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
            //command.Parameters.AddWithValue("@Result", illness);
            //command.Connection = conn; //Assign connection of the command
            //command.CommandText = sqlString; //Assign the command text of the command
            //command.ExecuteNonQuery(); //Execute the query
            

            //Assign the seesion variables
            Session["IllnessInfo"] = illnessInfo;
            Session["DietInfo"] = dietInfo;
            Server.Transfer("Diagnosis.aspx"); //Display the Diagnosis page
        }
    }
}