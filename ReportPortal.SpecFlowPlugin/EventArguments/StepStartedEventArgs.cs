﻿using System;
using ReportPortal.Client;
using ReportPortal.Client.Requests;
using ReportPortal.Shared;
using TechTalk.SpecFlow;

namespace ReportPortal.SpecFlowPlugin.EventArguments
{
    public class StepStartedEventArgs : EventArgs
    {
        public StepStartedEventArgs(Service service, AddLogItemRequest request)
        {
            Service = service;
            TestItem = request;
        }

        public StepStartedEventArgs(Service service, AddLogItemRequest request, TestReporter testReporter)
            : this(service, request)
        {
            TestReporter = testReporter;
        }

        public StepStartedEventArgs(Service service, AddLogItemRequest request, TestReporter testReporter, FeatureContext featureContext, ScenarioContext scenarioContext, ScenarioStepContext stepContext)
            : this(service, request, testReporter)
        {
            FeatureContext = featureContext;
            ScenarioContext = scenarioContext;
            StepContext = stepContext;
        }

        public Service Service { get; }

        public AddLogItemRequest TestItem { get; }

        public TestReporter TestReporter { get; }

        public FeatureContext FeatureContext { get; }

        public ScenarioContext ScenarioContext { get; }

        public ScenarioStepContext StepContext { get; }

        public bool Canceled { get; set;}
    }
}
