$path = "Reqnroll_OnlineReferral\FraudCapture_Pages\CaseTrackingModule\AdministrativeCases\AdministrativeCases.cs"
$names = Get-Content "byfieldnames2.txt" | Where-Object { $_.Trim() -ne "" }
$lines = Get-Content $path

for ($i = 0; $i -lt $lines.Count; $i++) {
	$line = $lines[$i]
	if ($line -match 'private (readonly )?By \w+' -or $line -match 'private IWebElement') { continue }
	foreach ($name in $names) {
		$escName = [regex]::Escape($name)

		$pattern1 = "(?<![\w.])$escName\.(Click|SendKeys|Clear|GetAttribute|Selected|TagName|Enabled)\("
		$line = [regex]::Replace($line, $pattern1, { param($m) "driver.FindElement($name)." + $m.Groups[1].Value + "(" })

		$pattern2 = "(?<![\w.])$escName\.(Text|Displayed)\b"
		$line = [regex]::Replace($line, $pattern2, { param($m) "driver.FindElement($name)." + $m.Groups[1].Value })

		$pattern3 = "new SelectElement\($escName\)"
		$line = [regex]::Replace($line, $pattern3, "new SelectElement(driver.FindElement($name))")

		$pattern4 = "ScrollAndCenterElement\(((driver,\s*)?)$escName\)"
		$line = [regex]::Replace($line, $pattern4, { param($m) "ScrollAndCenterElement(" + $m.Groups[1].Value + "driver.FindElement($name))" })
	}
	$lines[$i] = $line
}
[System.IO.File]::WriteAllLines($path, $lines)
Write-Output "Done"
