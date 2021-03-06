using System;
using System.Globalization;
/// <summary>
///IsNeutralCulture
/// </summary>
public class CultureInfoIsNeutralCulture
{
    public static int Main()
    {
        CultureInfoIsNeutralCulture CultureInfoIsNeutralCulture = new CultureInfoIsNeutralCulture();

        TestLibrary.TestFramework.BeginTestCase("CultureInfoIsNeutralCulture");
        if (CultureInfoIsNeutralCulture.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: CultureInfo.InvariantCulture.");
        try
        {
            CultureInfo myCultureInfo = CultureInfo.InvariantCulture;
            if (myCultureInfo.IsNeutralCulture)
             {
                 TestLibrary.TestFramework.LogError("001", "CultureInfo.InvariantCulture is not a neutral culture.");
                 retVal = false;
                
             }
         

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest2()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest2: fr is a neutral culture .");
        try
        {
            if (!TestLibrary.Utilities.IsWindows)
            {
                CultureInfo myCultureInfo = new CultureInfo("fr");
                if (!myCultureInfo.IsNeutralCulture)
                {
                    TestLibrary.TestFramework.LogError("003", "fr is  a neutral culture.");
                    retVal = false;
                }
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest3()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest3: 'fr-FR' is a specific culture .");
        try
        {
            CultureInfo myCultureInfo = new CultureInfo("fr-FR");
            if (myCultureInfo.IsNeutralCulture)
            {
                TestLibrary.TestFramework.LogError("005", "'fr-FR' is not  a neutral culture.");
                retVal = false;

            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("006", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }

}

