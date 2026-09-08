$path = "Reqnroll_OnlineReferral\FraudCapture_Pages\CaseTrackingModule\AdministrativeCases\AdministrativeCases.cs"
$names = Get-Content "byfieldnames.txt" | Where-Object { $_.Trim() -ne "" }
$content = Get-Content $path -Raw

foreach ($name in $names) {
	$pattern1 = "(?<![\w.])" + [regex]::Escape($name) + "\.(Click|SendKeys|Clear|GetAttribute|Selected|TagName|Enabled)\("
	$content = [regex]::Replace($content, $pattern1, "driver.FindElement($name).`$1(")

	$pattern2 = "(?<![\w.])" + [regex]::Escape($name) + "\.(Text|Displayed)\b"
	$content = [regex]::Replace($content, $pattern2, "driver.FindElement($name).`$1")

	$pattern3 = "new SelectElement\(" + [regex]::Escape($name) + "\)"
	$content = [regex]::Replace($content, $pattern3, "new SelectElement(driver.FindElement($name))")

	$pattern4 = "ScrollAndCenterElement\(driver,\s*" + [regex]::Escape($name) + "\)"
	$content = [regex]::Replace($content, $pattern4, "ScrollAndCenterElement(driver, driver.FindElement($name))")
}

Set-Content -Path $path -Value $content -NoNewline
Write-Output "Done"
