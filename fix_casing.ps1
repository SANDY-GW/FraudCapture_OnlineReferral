$path = "Reqnroll_OnlineReferral\FraudCapture_Pages\CaseTrackingModule\CaseTab\CaseEdit.cs"
$fields = Get-Content byfields.txt
$c = Get-Content -Raw $path

$map = @{}
foreach ($f in $fields) { $map[$f.ToLower()] = $f }

$pattern = '\b([A-Za-z_][A-Za-z0-9_]*)\.(Click\(\)|SendKeys\(|Clear\(\)|Text\b|Enabled\b|Selected\b|GetAttribute\(|Displayed\b)'
$c2 = [regex]::Replace($c, $pattern, {
	param($m)
	$ident = $m.Groups[1].Value
	$lower = $ident.ToLower()
	if ([Array]::IndexOf($fields, $ident) -ge 0) {
		return $m.Value
	} elseif ($map.ContainsKey($lower)) {
		$correct = $map[$lower]
		return "driver.FindElement($correct)." + $m.Groups[2].Value
	} else {
		return $m.Value
	}
})
Set-Content -Path $path -Value $c2 -NoNewline
Write-Output "done"
