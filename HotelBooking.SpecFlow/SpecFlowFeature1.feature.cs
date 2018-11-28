﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HotelBooking.SpecFlow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ManageBookingFeature : Xunit.IClassFixture<ManageBookingFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        public ManageBookingFeature(ManageBookingFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Manage Booking", "\tIn order to make a booking\r\n\tAs a customer\r\n\tI want to be able to see if I can b" +
                    "ook a room", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Find an available room with invalid dates")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Find an available room with invalid dates")]
        [Xunit.TraitAttribute("Category", "mytag")]
        public virtual void FindAnAvailableRoomWithInvalidDates()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find an available room with invalid dates", null, new string[] {
                        "mytag"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("Startdate for the booking is in 0 day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("Enddate for the booking is in 0 days", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I look for a room", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("I should get an error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Find an available room with valid date")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Find an available room with valid date")]
        public virtual void FindAnAvailableRoomWithValidDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find an available room with valid date", null, ((string[])(null)));
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
 testRunner.Given("Startdate for the booking is in 0 day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.And("Enddate for the booking is in 1 days", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.When("I look for a room", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("I should get a room ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Try to find an available room but get -1 as room id as no rooms available")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Try to find an available room but get -1 as room id as no rooms available")]
        public virtual void TryToFindAnAvailableRoomButGet_1AsRoomIdAsNoRoomsAvailable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Try to find an available room but get -1 as room id as no rooms available", null, ((string[])(null)));
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
 testRunner.Given("Startdate for the booking is in 5 day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.And("Enddate for the booking is in 7 days", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.When("I look for a room", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("I should get -1 as a room ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Find available room ID without going through more loop steps. Room ID is not -1")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Find available room ID without going through more loop steps. Room ID is not -1")]
        public virtual void FindAvailableRoomIDWithoutGoingThroughMoreLoopSteps_RoomIDIsNot_1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find available room ID without going through more loop steps. Room ID is not -1", null, ((string[])(null)));
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 26
 testRunner.Given("Startdate for the booking is in 0 day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.And("Enddate for the booking is in 3 days", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.When("I look for a room", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("I should get a room ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Creating a booking with invalid dates")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Creating a booking with invalid dates")]
        public virtual void CreatingABookingWithInvalidDates()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating a booking with invalid dates", null, ((string[])(null)));
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 32
 testRunner.Given("Startdate for the booking is in 2 days", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.And("Enddate for the booking is in 5 days", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.When("I book a room", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("I should get -1 instead of a legit room ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Creating a booking in an occupied or unoccupied timeframe")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Creating a booking in an occupied or unoccupied timeframe")]
        [Xunit.InlineDataAttribute("1", "3", "true", new string[0])]
        [Xunit.InlineDataAttribute("1", "6", "false", new string[0])]
        public virtual void CreatingABookingInAnOccupiedOrUnoccupiedTimeframe(string startdate, string endedate, string valid, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating a booking in an occupied or unoccupied timeframe", null, exampleTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 38
 testRunner.Given(string.Format("{0} is supplied from today as startdate", startdate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.And(string.Format("{0} is also supplied from today as enddate", endedate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.When("I book a room", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then(string.Format("return whether the booking is {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Creating a booking in an unoccupied timeframe and have booking be active")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Creating a booking in an unoccupied timeframe and have booking be active")]
        public virtual void CreatingABookingInAnUnoccupiedTimeframeAndHaveBookingBeActive()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating a booking in an unoccupied timeframe and have booking be active", null, ((string[])(null)));
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 49
 testRunner.Given("Startdate for the booking is in 1 day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
 testRunner.And("Enddate for the booking is in 3 days", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.When("I book a room", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("The booking should be active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Returning fully occupied rooms within a set of 2 dates")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Returning fully occupied rooms within a set of 2 dates")]
        public virtual void ReturningFullyOccupiedRoomsWithinASetOf2Dates()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Returning fully occupied rooms within a set of 2 dates", null, ((string[])(null)));
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 56
 testRunner.Given("Startdate for the booking is in 1 day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
 testRunner.And("Enddate for the booking is in 30 days", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.When("I look for fully booked dates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("a list of fully occupied dates should be given", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Return empty list if no bookings within a set of 2 dates")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Return empty list if no bookings within a set of 2 dates")]
        public virtual void ReturnEmptyListIfNoBookingsWithinASetOf2Dates()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return empty list if no bookings within a set of 2 dates", null, ((string[])(null)));
#line 61
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 62
 testRunner.Given("Startdate for the booking is in 45 day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
 testRunner.And("Enddate for the booking is in 60 days", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.When("I look for fully booked dates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.Then("an empty list of dates should be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Return empty list if no fully occupied dates within a set of 2 dates")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Return empty list if no fully occupied dates within a set of 2 dates")]
        public virtual void ReturnEmptyListIfNoFullyOccupiedDatesWithinASetOf2Dates()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return empty list if no fully occupied dates within a set of 2 dates", null, ((string[])(null)));
#line 67
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 68
 testRunner.Given("Startdate for the booking is in 2 day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
 testRunner.And("Enddate for the booking is in 3 days", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.When("I look for fully booked dates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("an empty list of dates should be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Return not empty list if a mix of occupied and non-occupied rooms within a set of" +
            " 2 dates")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Return not empty list if a mix of occupied and non-occupied rooms within a set of" +
            " 2 dates")]
        public virtual void ReturnNotEmptyListIfAMixOfOccupiedAndNon_OccupiedRoomsWithinASetOf2Dates()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return not empty list if a mix of occupied and non-occupied rooms within a set of" +
                    " 2 dates", null, ((string[])(null)));
#line 73
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 74
 testRunner.Given("Startdate for the booking is in 2 day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
 testRunner.And("Enddate for the booking is in 7 days", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.When("I look for fully booked dates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("an empty list of dates shouldnt be returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Find an available room with valid date using example table")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Find an available room with valid date using example table")]
        [Xunit.InlineDataAttribute("120", "125", "-1", new string[0])]
        [Xunit.InlineDataAttribute("115", "120", "-1", new string[0])]
        [Xunit.InlineDataAttribute("125", "127", "-1", new string[0])]
        public virtual void FindAnAvailableRoomWithValidDateUsingExampleTable(string startdat2, string endedat2, string wrongResult, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find an available room with valid date using example table", null, exampleTags);
#line 79
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 80
 testRunner.Given(string.Format("Startdate for the booking is in {0} day", startdat2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 81
 testRunner.And(string.Format("Enddate for the booking is in {0} days", endedat2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.When("I look for a room", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then(string.Format("I should get a room ID that is not {0}", wrongResult), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Returning fully occupied rooms within a set of 2 dates using example table")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Booking")]
        [Xunit.TraitAttribute("Description", "Returning fully occupied rooms within a set of 2 dates using example table")]
        [Xunit.InlineDataAttribute("235", "245", "false", new string[0])]
        [Xunit.InlineDataAttribute("215", "230", "true", new string[0])]
        [Xunit.InlineDataAttribute("220", "228", "true", new string[0])]
        [Xunit.InlineDataAttribute("220", "230", "true", new string[0])]
        public virtual void ReturningFullyOccupiedRoomsWithinASetOf2DatesUsingExampleTable(string startdat3, string endedat3, string foundAnyFullyOccupiedDates, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Returning fully occupied rooms within a set of 2 dates using example table", null, exampleTags);
#line 91
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 92
 testRunner.Given(string.Format("Startdate for the booking is in {0} day", startdat3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 93
 testRunner.And(string.Format("Enddate for the booking is in {0} days", endedat3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("I look for fully booked dates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then(string.Format("a list of {0} dates should be given", foundAnyFullyOccupiedDates), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ManageBookingFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ManageBookingFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
