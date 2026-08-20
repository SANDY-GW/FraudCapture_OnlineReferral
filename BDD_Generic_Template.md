Act as a Selenium C# Automation Engineer working on a SpecFlow BDD framework.

Objective:
Implement a new automation test scenario while preserving the existing framework design and logic.

Instructions:

1. Add a new test scenario to the following feature file:
   - Refer to file: "CaseEdit.feature"
   - Feature file location: "C:\Users\jd\source_Onlinereferral\repos\FraudCapture_OnlineReferral\ReqnrollProject_FraudCapture\Features\FraudCapture_CaseEditTests.feature"
   - Refer to "promptfile" before adding the scenario.

2. Review the existing scenarios in the feature file before making any changes to ensure consistency with the current implementation.

3. Do NOT rewrite, refactor, remove, or modify any existing business logic, framework logic, methods, locators, utilities, or test flow without my explicit approval.

4. Add the required Step Definitions for all newly added feature file steps.
   - Refer to file: "FraudCapture_CaseTestStepDefination.cs"
   - located at "StepDefinitions/OrderManagement/FraudCapture_CaseTestStepDefination.cs".
   - Reuse existing step definitions whenever possible.
   - Only create new step definition methods if no suitable implementation already exists.

5. Add any required XPath locators that are missing.
   - Locator file name: "AddSubject.cs"
   - If the location of file "AddSubject.cs" is unknown, search the solution and identify where it is located before making changes.
   - Refer to file: "CommonXpaths.cs" for existing locator naming conventions and patterns.
   - Do not add duplicate locators.
   - Follow the existing locator structure and standards.

6. Resolve any timeout exception issues related to the newly added scenario.
   - Use existing framework wait utilities, explicit waits, or reusable synchronization methods.
   - Avoid using Thread.Sleep unless absolutely necessary and no alternative exists.

7. Implement logic to switch to the newly opened browser window or tab when required.
   - Reuse existing window-handling utilities if available.
   - Ensure control returns to the parent window when appropriate.

8. Validate that:
   - The scenario compiles successfully.
   - All new step definitions are correctly mapped.
   - All required locators exist.
   - Window switching works correctly.
   - Timeout issues are resolved.

9. Build the solution after making the changes.
   - Fix only build issues caused by the new implementation.
   - Do not modify unrelated files.

10. At completion, provide:
    - List of modified files
    - Feature scenario added
    - Step Definitions added or updated
    - XPaths added
    - Timeout resolution details
    - Window switching implementation details
    - Build result summary

Expected Behavior:
- Follow the existing framework architecture.
- Follow Page Object Model conventions.
- Avoid duplicate code.
- Make minimal, safe, and maintainable changes.
- Request approval before altering any existing logic.
