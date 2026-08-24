# Timeout Fix for "When I switch to leads user" Step

## Problem
The step `When I switch to leads user "All"` was timing out after 5 seconds with error:
```
Timed out after 5 seconds (5.3s)
```

## Root Cause Analysis
The issue was in the `SelectOption` method in `CreateNewLeadStepDefinitions.cs`:

1. **Insufficient Wait Time**: The method was waiting only 8 seconds for dropdown options to appear
2. **Poor Selector Strategy**: XPath selectors were too generic and might not match the dropdown structure
3. **No Fallback Logic**: If the primary XPath failed, there was no alternative approach
4. **Race Condition**: Dropdown might not be fully rendered when trying to click options
5. **Missing Validation**: No check that the dropdown was actually open before searching for options

## Solution Implemented

### 1. Improved `SelectOption` Method
- Reordered XPath locators to check for specific dropdown-menu classes first
- Added 300ms sleep after clicking dropdown to allow it to fully render
- Increased wait time from 8 to 10 seconds for finding options
- Added fallback logic to find and click options even if primary selectors fail
- Implemented direct element click with JavaScript fallback via `ClickElement` method

### 2. Enhanced `WhenISwitchToLeadsUser` Step
- Added explicit loading overlay wait (10 seconds max)
- Implemented pre-validation of dropdown existence
- Added alternative XPath selector strategy if primary ID locator fails
- Improved error messaging with context about what failed
- Added 500ms delay after selection to ensure page state updates

### 3. Key Changes
```csharp
// Before: Simple direct call with minimal error handling
SelectOption(By.Id("dropdownLeadListUser"), user);

// After: Robust approach with validation and fallbacks
CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
var dropdown = FindVisibleWithRetry(10, dropdownLocator);
Assert.That(dropdown, Is.Not.Null, $"Unable to find leads user dropdown");
SelectOption(dropdownLocator, user);
System.Threading.Thread.Sleep(500);
```

## Testing Recommendations

1. **Test with Different User Values**
   - Test with "All" (the failing case)
   - Test with "User_1", "User_2"
   - Test with usernames with special characters

2. **Network Conditions**
   - Test on slow network (add delays)
   - Test with loading indicators
   - Test after page transitions

3. **Timeout Scenarios**
   - Monitor actual execution time for the step
   - If still timing out, consider increasing wait times further
   - Add logging to identify exactly where the delay occurs

## Further Optimization Options

If timeout issues persist, consider:

1. **Increase Default Timeouts**
   ```csharp
   private const int DEFAULT_DROPDOWN_WAIT = 15; // Increase from 10
   ```

2. **Add Explicit Waits for Dropdown Visibility**
   ```csharp
   var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
   wait.Until(d => dropdown.Displayed);
   ```

3. **Implement Retry Logic at Step Level**
   ```csharp
   int maxRetries = 3;
   for (int i = 0; i < maxRetries; i++)
   {
       try { SelectOption(...); break; }
       catch { if (i == maxRetries - 1) throw; }
   }
   ```

4. **Add JavaScript-Based Selection**
   ```csharp
   ((IJavaScriptExecutor)Driver).ExecuteScript(
       "document.getElementById('dropdownLeadListUser').value = '" + value + "';"
   );
   ```

## Files Modified
- `ReqnrollProject_FraudCapture/StepDefinitions/CreateNewLeadStepDefinitions.cs`
  - `SelectOption(By locator, string value)` method
  - `WhenISwitchToLeadsUser(string user)` step definition

## Status
✅ Build: Successful
✅ Changes: Applied
⏳ Testing: Requires validation in test environment
