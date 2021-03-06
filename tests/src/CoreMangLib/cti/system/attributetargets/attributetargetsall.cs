using System;
/// <summary>
///All
/// </summary>

public class AttributeTargetsAll
{
    public static int Main()
    {
        AttributeTargetsAll AttributeTargetsAll = new AttributeTargetsAll();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsAll");
        if (AttributeTargetsAll.RunTests())
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
      
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.All value is include all the enum element. ");
        try
        {
            AttributeTargets expectValue =(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class
                        | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor |
                        AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field |
                        AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter |
                        AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter);
            if (AttributeTargets.All != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.All  should return " + expectValue);
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
       
        return retVal;
    }
   
}

