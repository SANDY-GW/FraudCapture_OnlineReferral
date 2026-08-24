# Debugging Guide for Lead Edit Navigation Issues

## Console Output Reading Guide

### Success Patterns
```
Found Begin Editing button using locator: By.XPath: //button[@id='leadViewEditEndButton']
Successfully clicked Begin Editing button
Lead Edit page indicator found: button#leadSaveButton
✓ Lead Edit page detected via title: Lead Edit
```

### Issues to Watch For
```
Normal click intercepted, using JavaScript click: element click intercepted
Stale element encountered, retrying
Already in edit mode - Save button is visible (this is OK - means already editable)
No new window to switch to (this is OK - depends on configuration)
```

### Error Patterns
```
Unable to click element using the provided locators. Tried: ... Last error: ...
Begin Editing button not found or not clickable
Sequence contains no elements (THIS WAS THE BUG - should be fixed)
```

---

## Debugging Steps

### Step 1: Check Console Output
Look for these messages:
1. "Found Begin Editing button using locator: ..."
2. "Successfully clicked Begin Editing button"
3. "Lead Edit page indicator found: ..."

### Step 2: If Click Fails
Check if you see:
- "Normal click intercepted, using JavaScript click" ✓ (acceptable)
- "Stale element encountered, retrying" ✓ (acceptable)
- "Already in edit mode" ✓ (means page is already editable)

### Step 3: If Navigation Fails
Check for:
- "Lead Edit page detected via title" or "URL"
- "Lead ID found on page"
- "Lead-related elements" list
- Page content verification messages

### Step 4: Browser Inspection
If test still fails:
1. Take screenshot right after failure
2. Inspect page source for "lead" elements
3. Check browser console for JavaScript errors
4. Verify page loaded completely (check Network tab)

---

## Common Issues & Solutions

### Issue: "Element not clickable at point (X, Y)"
**Symptoms:** ElementClickInterceptedException
**Checks:**
1. Is element at edge of viewport?
2. Is there a modal overlay covering it?
3. Is page still loading?
**Solutions:**
- Scroll element to center (already implemented)
- Wait for overlays to disappear (already implemented)
- Add more wait time before clicking

### Issue: "Sequence contains no elements"
**Symptoms:** InvalidOperationException
**Root Cause:** Calling .First() on empty collection
**Solution:** NOW FIXED - Using .FirstOrDefault() throughout
**Prevention:** Never use .First() - always use .FirstOrDefault()

### Issue: "Begin Editing button not found"
**Symptoms:** InvalidOperationException after checking all locators
**Checks:**
1. Is page on Lead Edit screen?
2. Is button ID "leadViewEditEndButton"?
3. Is button text exactly "Begin Editing"?
**Solutions:**
- Check page URL contains "lead"
- Inspect actual button element in browser
- Verify button ID hasn't changed
- Check if already in edit mode

### Issue: "Already in edit mode but test fails later"
**Symptoms:** Begin Editing succeeds but then save fails
**Checks:**
1. Is Lead form visible?
2. Can you click Save button?
3. Are form fields accessible?
**Solutions:**
- Add explicit wait after Begin Editing
- Verify form is fully loaded
- Check for validation errors on form

---

## JavaScript Debugging in Browser Console

### Check if Begin Editing button exists
```javascript
document.getElementById('leadViewEditEndButton')
document.querySelector('button[class*="Begin"]')
```

### Check if in edit mode
```javascript
document.getElementById('leadSaveButton')
document.getElementById('leadForm')
```

### Check for overlays
```javascript
document.querySelectorAll('[role="dialog"], [role="presentation"], .modal-backdrop')
```

### Clear content from editor
```javascript
var editor = document.querySelector('[contenteditable="true"]');
editor.textContent = '';
editor.innerText = '';
```

---

## Screenshot Analysis

When taking screenshots for debugging:

1. **Before clicking Begin Editing:**
   - Verify Begin Editing button is visible
   - Check for any overlays
   - Note page state (view vs edit)

2. **After clicking Begin Editing:**
   - Check if page reloaded
   - Verify Save button appeared
   - Check form fields are enabled

3. **After lead creation:**
   - Verify Lead ID is displayed
   - Check Lead Type matches input
   - Verify form fields have correct values

---

## Test Execution Tips

### Running Single Scenario
```powershell
# Run specific scenario by name
dotnet test --filter "Create a new lead" --verbosity detailed
```

### Capturing Detailed Logs
```powershell
# Run with maximum verbosity
dotnet test --verbosity detailed 2>&1 | Tee-Object -FilePath test-output.log
```

### Retrying Failed Test
```powershell
# Run last failed scenario with extended timeouts
# Set env variable first
$env:SELENIUM_TIMEOUT = "60"
dotnet test --filter "Create a new lead"
```

---

## Performance Monitoring

### Timers Added
- Window switch: 1500ms
- Page stabilization: 500ms
- Scroll operations: 300ms
- JavaScript operations: 200ms

### If Tests Run Too Slowly
- Check if Thread.Sleep() calls can be reduced
- Verify page actually takes that long to load
- Consider implementing WebDriverWait conditions
- Profile with browser developer tools

### If Tests Are Flaky
- Increase Thread.Sleep() values by 500ms increments
- Add more explicit waits for loading overlays
- Verify network requests complete before proceeding
- Check server response times

---

## Quick Troubleshooting Flowchart

```
Test Fails
    ↓
Is ElementClickInterceptedException?
    ↓ YES → Check browser console, verify overlay detection working
    ↓ NO
Is InvalidOperationException?
    ↓ YES → Check collection operations, use FirstOrDefault()
    ↓ NO
Is ElementNotInteractableException?
    ↓ YES → Check all locators, verify element state
    ↓ NO
Is TimeoutException?
    ↓ YES → Increase wait times, check page load speed
    ↓ NO
Check console output for custom logging messages
    ↓
Find message "Lead Edit page indicator found: ..."?
    ↓ YES → Navigation succeeded, issue is elsewhere
    ↓ NO → Check page title, URL, element IDs
```

---

## Support Information

All methods include:
- ✓ Console.WriteLine() logging
- ✓ Exception messages with context
- ✓ Fallback locators
- ✓ State verification
- ✓ Stale element recovery
- ✓ Modal overlay removal
- ✓ Strategic wait times

If issues persist:
1. Check console output for detailed messages
2. Take browser screenshots at failure point
3. Inspect page source for element changes
4. Run individual scenario multiple times
5. Test on different browsers if possible
