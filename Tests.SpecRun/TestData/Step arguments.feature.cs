﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.SpecRun.TestData
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Step arguments", new string[] {
            "data"}, SourceFile="TestData\\Step arguments.feature", SourceLine=1)]
    public partial class StepArgumentsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Step arguments.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Step arguments", null, ProgrammingLanguage.CSharp, new string[] {
                        "data"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Table arguments", SourceLine=3)]
        public virtual void TableArguments()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Table arguments", ((string[])(null)));
#line 4
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2"});
#line 7
 testRunner.Given("Step with table", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3"});
#line 11
 testRunner.Given("Step with table", ((string)(null)), table2, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "surname",
                        "gender",
                        "age"});
            table3.AddRow(new string[] {
                        "John",
                        "Smith",
                        "male",
                        ""});
#line 15
 testRunner.Given("Step with table", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "attribute",
                        "value"});
            table4.AddRow(new string[] {
                        "width",
                        "10"});
            table4.AddRow(new string[] {
                        "length",
                        "20"});
            table4.AddRow(new string[] {
                        "height",
                        "5"});
#line 20
 testRunner.Given("Step with table", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "param",
                        "value"});
            table5.AddRow(new string[] {
                        "width",
                        "10"});
            table5.AddRow(new string[] {
                        "length",
                        "20"});
            table5.AddRow(new string[] {
                        "height",
                        "5"});
#line 27
 testRunner.Given("Step with table", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "surname",
                        "gender",
                        "age"});
            table6.AddRow(new string[] {
                        "John",
                        "Smith",
                        "male",
                        "30"});
            table6.AddRow(new string[] {
                        "\"Mary\",\"Ann\"",
                        "Jane;",
                        "female",
                        "25"});
            table6.AddRow(new string[] {
                        "",
                        "",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "Eric",
                        "Cartman",
                        ",",
                        ",,"});
#line 34
 testRunner.Given("Step with table", ((string)(null)), table6, "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
