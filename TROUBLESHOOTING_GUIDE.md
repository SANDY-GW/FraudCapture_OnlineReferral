# Quick Troubleshooting Guide

## Common Error Messages & Solutions

### Error: "Sequence contains no elements"

**When it occurs:**
- Accessing `.First()` or `.SelectedOption` on empty collection
- `.FirstOrDefault()` followed by direct property access without null check
- `SelectElement` operations on dropdown with no options

**Quick Fix:**
```csharp
// ❌ Wrong
var option = select.Options.First();

// ✅ Right
if (select.Options.Count > 0)
{
    var option = select.Options.First();
}
```

**Root Cause Checklist:**
- [ ] Is the collection null?
- [ ] Is the collection empty?
- [ ] Are options dynamically loaded?
- [ ] Is there a loading overlay?

**Solution Steps:**
1. Add null check: `if (collection == null || collection.Count == 0)`
2. Wait for elements to load: `CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10)`
3. Use `.FirstOrDefault()` instead of `.First()`
4. Add logging: `Console.WriteLine($"Options count: {select.Options.Count}")`

---

### Error: "ElementNotInteractableException"

**When it occurs:**
- Element is obscured by overlay
- Element is not yet fully rendered
- Element is covered by another element
- Element is disabled or hidden

**Quick Fix:**
```csharp
try
{
    element.Click();
}
catch (ElementNotInteractableException)
{
    // Use JavaScript click instead
    ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", element);
}
```

**Root Cause Checklist:**
- [ ] Is loading overlay visible?
- [ ] Is element hidden in CSS (display:none, visibility:hidden)?
- [ ] Is element covered by modal/popup?
- [ ] Is element disabled?
- [ ] Is element outside viewport?

**Solution Steps:**
1. Wait for overlay: `CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10)`
2. Scroll into view: `((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);`
3. Use JavaScript click: `((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", element);`
4. Try alternative locators
5. Add delay: `Thread.Sleep(500)`

---

### Error: "NoSuchElementException"

**When it occurs:**
- Element not found on page
- Wrong locator strategy
- Element hasn't loaded yet
- Locator is case-sensitive

**Quick Fix:**
```csharp
// ❌ Wrong
var element = Driver.FindElement(By.XPath("//button[text()='Click']"));

// ✅ Right
var element = FindVisibleWithRetry(10, 
    By.XPath("//button[normalize-space()='Click']"),
    By.XPath("//button[contains(normalize-space(),'Click')]"));
```

**Root Cause Checklist:**
- [ ] Is locator correct?
- [ ] Is element visible on page?
- [ ] Is page fully loaded?
- [ ] Is case/whitespace correct in locator?
- [ ] Is element inside frame/iframe?

**Solution Steps:**
1. Verify locator in browser console
2. Use multiple locators: `FindVisible(locator1, locator2, locator3)`
3. Wait for element: `FindVisibleWithRetry(10, locator)`
4. Check for frames: `Driver.SwitchTo().Frame(...)`
5. Use flexible XPath: `normalize-space()` and `contains()`

---

### Error: "NullReferenceException"

**When it occurs:**
- Accessing property on null object
- Collection is null
- Element attribute is null

**Quick Fix:**
```csharp
// ❌ Wrong
var text = element.Text;  // Could be null

// ✅ Right
var text = element?.Text ?? string.Empty;
```

**Root Cause Checklist:**
- [ ] Is object null?
- [ ] Is collection empty?
- [ ] Is property value null?
- [ ] Was FindElement called before Find check?

**Solution Steps:**
1. Add null check: `if (element != null)`
2. Use safe navigation: `element?.Property ?? defaultValue`
3. Validate collection: `if (collection?.Count > 0)`
4. Check method return values

---

### Error: "StaleElementReferenceException"

**When it occurs:**
- DOM was refreshed after element was found
- Page navigated or reloaded
- Element was removed and re-added

**Quick Fix:**
```csharp
try
{
    element.Click();
}
catch (StaleElementReferenceException)
{
    // Re-find element
    element = Driver.FindElement(locator);
    element.Click();
}
```

**Root Cause Checklist:**
- [ ] Did page refresh?
- [ ] Did page navigate?
- [ ] Is JavaScript updating DOM?
- [ ] Is there dynamic content loading?

**Solution Steps:**
1. Add retry in exception handler
2. Re-find element: `Driver.FindElement(locator)`
3. Reduce time between find and use
4. Use wait conditions instead of sleeps

---

## Debugging Checklist

### Before Running Tests:
- [ ] Verify test data exists
- [ ] Check internet connectivity
- [ ] Verify browser version compatibility
- [ ] Clear browser cache
- [ ] Check for browser updates

### When Test Fails:
- [ ] Take screenshot: `((ITakesScreenshot)Driver).GetScreenshot()`
- [ ] Check console logs
- [ ] Review page source: `Driver.PageSource`
- [ ] Print URL: `Console.WriteLine(Driver.Url)`
- [ ] Print page title: `Console.WriteLine(Driver.Title)`

### For Flaky Tests:
- [ ] Increase wait times incrementally
- [ ] Add additional waits between actions
- [ ] Use explicit waits instead of Thread.Sleep
- [ ] Check for timing dependencies
- [ ] Review test data for consistency

---

## Common Timeout Issues

### Issue: Test timeout after 5 seconds
**Solutions:**
```csharp
// 1. Increase individual wait
FindVisibleWithRetry(20, locator);  // was 10, now 20

// 2. Add intermediate waits
Thread.Sleep(500);
element.Click();
Thread.Sleep(500);

// 3. Wait for page load
CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 15);
```

### Issue: Test slow on certain steps
**Solutions:**
```csharp
// 1. Reduce polling frequency
Thread.Sleep(100);  // was 200ms

// 2. Optimize locators
// ❌ //div//div//div//button (too deep)
// ✅ //button[@id='submitBtn']  (direct)

// 3. Remove unnecessary waits
// Only wait where needed, not after every action
```

---

## Testing Different Scenarios

### Scenario: Element not visible initially
```csharp
// Solution: Use retry mechanism
var element = FindVisibleWithRetry(15, locator);
Assert.That(element, Is.Not.Null);
```

### Scenario: Element requires scroll
```csharp
// Solution: Scroll into view
((IJavaScriptExecutor)Driver).ExecuteScript(
    "arguments[0].scrollIntoView(true);", element);
Thread.Sleep(500);
element.Click();
```

### Scenario: Dropdown options load dynamically
```csharp
// Solution: Wait for options to load
WaitForCondition(() => select.Options.Count > 0, 10);
var option = select.Options.FirstOrDefault(o => o.Text == "Value");
```

### Scenario: Multiple windows/frames
```csharp
// Solution: Handle window switching
Driver.SwitchTo().Window(Driver.WindowHandles[1]);
// ... perform actions ...
Driver.SwitchTo().Window(Driver.WindowHandles[0]);
```

---

## Performance Tips

### Speed up tests:
1. **Reduce sleeps**: Use explicit waits instead
   ```csharp
   // ❌ Slow
   Thread.Sleep(5000);

   // ✅ Fast
   FindVisibleWithRetry(5, locator);
   ```

2. **Optimize locators**: Use ID when possible
   ```csharp
   // ❌ Slow: Checks every element
   By.XPath("//button[contains(text(), 'Click')]")

   // ✅ Fast: Direct access
   By.Id("clickButton")
   ```

3. **Batch operations**: Do multiple checks at once
   ```csharp
   // Instead of multiple waits, combine:
   var element = FindVisible(locator1, locator2, locator3);
   ```

4. **Skip unnecessary checks**: Only assert when needed
   ```csharp
   // ❌ Slow: Checks every step
   Assert.That(element, Is.Not.Null);
   Assert.That(text, Is.Not.Empty);

   // ✅ Fast: Check only critical path
   Assert.That(finalResult, Is.EqualTo(expected));
   ```

---

## Logging Best Practices

### Always log important steps:
```csharp
Console.WriteLine("Starting test...");
Console.WriteLine($"Current URL: {Driver.Url}");
Console.WriteLine($"Element found: {element.GetAttribute("id")}");
Console.WriteLine($"Element text: {element.Text}");
Console.WriteLine("Test completed");
```

### Log errors with context:
```csharp
Console.WriteLine($"ERROR: {ex.Message}");
Console.WriteLine($"StackTrace: {ex.StackTrace}");
Console.WriteLine($"Current page: {Driver.Title}");
```

### Use consistent log levels:
```csharp
// ✅ Good practice
Console.WriteLine("[INFO] Starting navigation");
Console.WriteLine("[WARN] Element not found, using fallback");
Console.WriteLine("[ERROR] Step failed with exception");
Console.WriteLine("[DEBUG] Found element: button#id");
```

---

## Quick Reference: Method Retry Logic

### Pattern for finding elements:
```csharp
private IWebElement? FindVisibleWithRetry(int timeoutInSeconds, params By[] locators)
{
    var timeoutAt = DateTime.UtcNow.AddSeconds(timeoutInSeconds);

    while (DateTime.UtcNow < timeoutAt)
    {
        CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 5);
        var element = FindVisible(locators);
        if (element != null)
            return element;

        Thread.Sleep(200);
    }

    return null;
}
```

### Pattern for clicking with retries:
```csharp
private void ClickWithRetry(int timeoutInSeconds, params By[] locators)
{
    var timeoutAt = DateTime.UtcNow.AddSeconds(timeoutInSeconds);

    while (DateTime.UtcNow < timeoutAt)
    {
        try
        {
            var element = FindVisible(locators);
            if (element == null)
            {
                Thread.Sleep(200);
                continue;
            }

            element.Click();
            return;
        }
        catch
        {
            Thread.Sleep(200);
        }
    }

    throw new TimeoutException($"Unable to click element within {timeoutInSeconds}s");
}
```

---

## Support Matrix

| Error Type | Likely Cause | Primary Fix | Fallback |
|------------|--------------|-----------|----------|
| Sequence contains no elements | Empty collection | Check count | Use FirstOrDefault |
| ElementNotInteractableException | Element hidden/disabled | Wait for load | JS click |
| NoSuchElementException | Element not found | Use FindVisibleWithRetry | Multiple locators |
| NullReferenceException | Null object access | Add null check | Safe navigation |
| StaleElementReferenceException | DOM refreshed | Retry find | Re-get element |
| TimeoutException | Wait too short | Increase timeout | Check page load |
| InvalidOperationException | Wrong element type | Verify TagName | Check selector |

