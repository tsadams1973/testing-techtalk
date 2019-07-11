# testing-techtalk

This is effectively an out-of-the box dotnet core web app and web api that I used for a tech talk on automated testing that covered API testing with Postman and UI testing with Selenium.

## Postman
We used Postman to test the simple API in the solution. The Postman folder includes the Postman collection and environment files.

With these trivial examples we demonstrated:
- How to set up a Postman collection.
- How to set up a Postman environment.
- How to write simple tests in Postman.
- How to run the collection in Postman.
- How to run the collection from the command line with newman.
- How to incorporate Postman collections in an azure devops pipeline.
- How to transform the environment files in the pipeline.
- How to run the tests with newman as part of the pipeline.
- How to report the results of those tests.

We followed that up with some non-trivial examples of how we are using these concepts in our production pipelines.

## Selenium
We created the unit test project to demonstrate how to use Selenium to test the simple web app in the solution.

In this example we showed:
- How to install Selenium nuget packages
- How to write a simple test using the Seleniumn drivers.
- How to see the results of the test.
- How to debug a test.

We followed this up with some non-trivial examples of using Selenium to automate UI test in our production pipelines.

