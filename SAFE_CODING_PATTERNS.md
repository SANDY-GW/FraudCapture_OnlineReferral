# Code Examples - Safe Null Handling Patterns

## Pattern 1: Safe SelectElement Option Handling

### ❌ INCORRECT (Causes "Sequence contains no elements")
```csharp
var select = new SelectElement(element);
var anonymousOption = select.Options.FirstOrDefault(o => 
    o.Text.Equals("Anonymous", StringComparison.OrdinalIgnoreCase));

if (anonymousOption != null)
{
    anonymousOption.Click();
}
```

**Issues:**
- No check if `Options` collection is empty
- `.FirstOrDefault()` could return null without clear error
- No exception handling for invalid select state

---

### ✅ CORRECT (Safe Implementation)
```csharp
try
{
    var select = new SelectElement(element);
    var availableOptions = select.Options;

    // Check 1: Collection not null and has items
    if (availableOptions == null || availableOptions.Count == 0)
    {
        Console.WriteLine("WARNING: No options available");
        return;
    }

    // Check 2: Find matching option with safe property access
    var anonymousOption = availableOptions.FirstOrDefault(o => 
    {
        try
        {
            var text = o.Text;
            var value = o.GetAttribute("value");

            return text?.Equals("Anonymous", StringComparison.OrdinalIgnoreCase) == true ||
                   value?.Equals("Anonymous", StringComparison.OrdinalIgnoreCase) == true ||
                   text?.Contains("Anonymous", StringComparison.OrdinalIgnoreCase) == true;
        }
        catch
        {
            return false;
        }
    });

    // Check 3: Selection result
    if (anonymousOption != null)
    {
        anonymousOption.Click();
        Console.WriteLine($"Selected: {anonymousOption.Text}");
    }
    else
    {
        Console.WriteLine("Anonymous option not found, using first option");
        if (availableOptions.Count > 0)
        {
            select.SelectByIndex(0);
        }
    }
}
catch (NoSuchElementException ex)
{
    Console.WriteLine($"Dropdown not found: {ex.Message}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Invalid operation: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}
```

**Improvements:**
- ✅ Null checks before collection access
- ✅ Count validation before iteration
- ✅ Safe property access with null coalescing
- ✅ Comprehensive exception handling
- ✅ Detailed logging for debugging
- ✅ Fallback strategy when primary fails

---

## Pattern 2: Safe Element Click with Fallbacks

### ❌ INCORRECT (Causes ElementNotInteractableException)
```csharp
var button = Driver.FindElement(By.Id("leadViewEditEndButton"));
button.Click();
```

**Issues:**
- No wait for element to be ready
- No handling for overlay or interception
- No fallback if click fails
- Single locator strategy

---

### ✅ CORRECT (Safe Implementation)
```csharp
try
{
    // Step 1: Wait for loading overlay
    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
    System.Threading.Thread.Sleep(500);

    // Step 2: Define multiple locators (ordered by reliability)
    var locators = new[]
    {
        By.Id("leadViewEditEndButton"),
        By.XPath("//button[@title='Begin Editing']"),
        By.XPath("//button[normalize-space()='Begin Editing']"),
        By.XPath("//div[@id='CaseDetailContentId']//button[contains(@class,'btn')]"),
    };

    // Step 3: Find element with retry
    IWebElement? button = null;
    foreach (var locator in locators)
    {
        button = FindVisibleWithRetry(5, locator);
        if (button != null)
        {
            Console.WriteLine($"Found element: {locator}");
            break;
        }
    }

    // Step 4: Assert element found
    Assert.That(button, Is.Not.Null, "Button could not be found");

    // Step 5: Attempt click with exception handling
    try
    {
        button.Click();
    }
    catch (ElementClickInterceptedException)
    {
        Console.WriteLine("Click intercepted, using JavaScript");
        ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", button);
    }
    catch (ElementNotInteractableException)
    {
        Console.WriteLine("Element not interactable, using JavaScript");
        ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", button);
    }

    // Step 6: Wait for result
    System.Threading.Thread.Sleep(1000);
    CommonHelpers.WaitForLoadingOverlayToDisappear(Driver, 10);
}
catch (Exception ex)
{
    throw new Exception($"Failed to click button: {ex.Message}", ex);
}
```

**Improvements:**
- ✅ Pre-click overlay wait
- ✅ Multiple locator strategies
- ✅ Retry mechanism for element finding
- ✅ Null assertion before click
- ✅ Specific exception handling
- ✅ JavaScript fallback
- ✅ Post-click wait for page transition
- ✅ Detailed error messages

---

## Pattern 3: Safe Property Access

### ❌ INCORRECT (Causes NullReferenceException)
```csharp
var elements = Driver.FindElements(By.XPath("//*[@id]"));
foreach (var element in elements)
{
    var id = element.GetAttribute("id");
    if (id.Contains("lead"))  // Could be null!
    {
        Process(element);
    }
}
```

**Issues:**
- `.GetAttribute()` can return null
- No null check before `.Contains()`
- No exception handling for stale elements

---

### ✅ CORRECT (Safe Implementation)
```csharp
try
{
    var elements = Driver.FindElements(By.XPath("//*[@id]"));

    if (elements == null || elements.Count == 0)
    {
        Console.WriteLine("No elements found");
        return;
    }

    foreach (var element in elements)
    {
        try
        {
            // Safe property access
            var id = element.GetAttribute("id");

            if (!string.IsNullOrWhiteSpace(id) && 
                id.Contains("lead", StringComparison.OrdinalIgnoreCase))
            {
                Process(element);
            }
        }
        catch (StaleElementReferenceException)
        {
            // Element no longer in DOM, skip
            Console.WriteLine("Stale element encountered, skipping");
        }
        catch (Exception ex)
        {
            // Log and continue
            Console.WriteLine($"Error processing element: {ex.Message}");
            continue;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error iterating elements: {ex.Message}");
}
```

**Improvements:**
- ✅ Null check for collection
- ✅ Count validation
- ✅ Whitespace validation for property values
- ✅ Stale element handling
- ✅ Per-element exception handling
- ✅ Continue on error instead of throw
- ✅ Detailed logging at each level

---

## Pattern 4: Safe Text Reading

### ❌ INCORRECT (Causes Various Exceptions)
```csharp
public string ReadFieldText(By locator)
{
    var element = Driver.FindElement(locator);

    if (element.TagName == "select")
    {
        return new SelectElement(element).SelectedOption.Text;
    }

    return element.Text ?? "";
}
```

**Issues:**
- No check if element found
- `SelectedOption` could throw exception
- No handling for empty selects
- No exception handling

---

### ✅ CORRECT (Safe Implementation)
```csharp
public string ReadFieldText(params By[] locators)
{
    try
    {
        // Step 1: Find visible element
        var element = FindVisible(locators);
        if (element == null)
        {
            Console.WriteLine($"No visible element found for locators");
            return string.Empty;
        }

        // Step 2: Handle select elements
        if (element.TagName.Equals("select", StringComparison.OrdinalIgnoreCase))
        {
            try
            {
                var selectElement = new SelectElement(element);
                var selectedOption = selectElement.SelectedOption;

                if (selectedOption != null)
                {
                    var text = selectedOption.Text;
                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        return text.Trim();
                    }
                }
            }
            catch (NoSuchElementException)
            {
                // No option selected
                Console.WriteLine("No option selected in select element");
            }
            catch (InvalidOperationException)
            {
                // Element is not a valid select
                Console.WriteLine("Element is not a valid select");
            }
        }

        // Step 3: Try to get value attribute
        var value = element.GetAttribute("value");
        if (!string.IsNullOrWhiteSpace(value))
        {
            return value.Trim();
        }

        // Step 4: Fall back to text content
        var text2 = element.Text;
        return text2?.Trim() ?? string.Empty;
    }
    catch (StaleElementReferenceException)
    {
        Console.WriteLine("Stale element reference");
        return string.Empty;
    }
    catch (NoSuchElementException)
    {
        Console.WriteLine("Element not found");
        return string.Empty;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error reading field text: {ex.Message}");
        return string.Empty;
    }
}
```

**Improvements:**
- ✅ Element existence check
- ✅ Select element specific handling
- ✅ Exception handling for each operation
- ✅ Multiple fallback strategies
- ✅ Whitespace validation
- ✅ Stale element handling
- ✅ Graceful degradation
- ✅ Comprehensive logging

---

## General Guidelines

### DO's ✅
- Always check for null before accessing properties
- Use try-catch blocks around element interactions
- Implement multiple fallback strategies
- Add detailed console logging
- Validate collection counts before iteration
- Use `.FirstOrDefault()` instead of `.First()` when appropriate
- Check string results for whitespace

### DON'Ts ❌
- Don't access properties directly without null checks
- Don't assume element will be interactable immediately
- Don't rely on single locator strategy
- Don't swallow exceptions silently
- Don't access collections without null/count validation
- Don't use `.First()` on collections that might be empty
- Don't return null for string methods (use empty string instead)

---

## Best Practices

### 1. Always Validate Before Use
```csharp
if (collection != null && collection.Count > 0)
{
    // Safe to use collection
}
```

### 2. Use Null Coalescing for Strings
```csharp
var result = element?.GetAttribute("value") ?? string.Empty;
```

### 3. Chain Exception Handlers Specifically
```csharp
catch (NoSuchElementException) { }  // Specific
catch (InvalidOperationException) { }  // Specific
catch (Exception) { }  // Generic last
```

### 4. Log Before Returning Errors
```csharp
catch (Exception ex)
{
    Console.WriteLine($"Detailed context: {ex.Message}");
    throw; // or return default value
}
```

### 5. Use Defensive Loops
```csharp
foreach (var item in collection ?? Enumerable.Empty<Item>())
{
    // Safe iteration
}
```
