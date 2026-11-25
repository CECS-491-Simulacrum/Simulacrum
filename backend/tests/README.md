## Testing Convention
Use xUnit to write the tests and follow Arrange, Act, and Assert steps when writing the tests. Refer to material on testing within clean architecture for convention, which are linked below. One of the benefits of clean/onion architecture is easier testing, which should be taken advantage of.

### Integration tests
Confirm that multiple app components work together, including infrastructure. If testing database, refer to ASP.NET Core testing strategy recommendations. The specifics for how aren't figured out yet.

### Unit Tests
Unit tests verify isolated software components, specficially stuff like business logic and specific entity methods. Best practice indicates to use fabricated components like fakes/mock objects for dependencies.

### Running Tests


Use the testing feature in VS Code, or use test runner to execute the tests and report the test results. This can also be done in dotnet CLI by typing the following within a specific test project directory:
```powershell
dotnet test
```

Note that running the tests automatically makes a new build. Stop the backend API before running the tests because the build will fail and cause a dll-lock error.

### References
Note: we are using a general dbcontext interface instead of a repository pattern like what the references show, I'm not sure how this will affect testing.
- [testing in clean architecture](https://vahid-faraji-dev.medium.com/testing-in-clean-architecture-from-unit-tests-to-full-system-integration-in-c-66b6679129ca)
- [onion architecture unit/integration testing example](https://medium.com/lets-code-future/onion-architecture-example-in-net-c-977bdb9607b5)
- [integration testing in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-10.0&pivots=xunit)
- [unit testing best practices](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices#lets-speak-the-same-language)
