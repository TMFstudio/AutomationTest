# Automation Test Project

This repository serves as a base project for structuring automation tests. It is designed to simplify the process of creating and managing automated tests for web applications and APIs, while offering flexibility and scalability.

## Features

### Web API Projects

Test ESshop API: A web API project created for testing purposes.

Product API: Provides fake data for testing automation workflows.

### Test Folder The Test folder contains two main projects:

UI Test:

Developed with SpecFlow.

Implements the Page Object Model (POM) design pattern.

Utilizes Selenium for behavior-driven testing scenarios (WebBddSut).

Integration Test:

Uses InMemory libraries for testing.

Incorporates Autofac for Dependency Injection (DI).

### Web Framework Project

A tool specifically designed for Selenium.

Allows users to choose their preferred browser web driver.

Enables users to configure the Selenium environment easily.

## Getting Started

Follow these steps to set up and start using the project:

Set Up the webframework.dll:

The webframework.dll library provides helpers and the Url class.

Make sure to configure the Url class based on your setup (local or server environment).

Update the browser driver configuration in the web framework to ensure compatibility with your browser version.

Keep Browser Driver Updated:

If you encounter errors while running the tests, ensure your browser driver is updated to the latest version.

Update your Selenium WebDriver via NuGet package manager if necessary.

Run the APIs:

Start the Data API Project and Web API Project simultaneously before running the tests.

Continuous Integration/Continuous Deployment:

A pipeline YAML file (azure-pipelines.yml) is included for CI/CD in Azure Pipelines.

You can customize the pipeline file to suit your requirements.
