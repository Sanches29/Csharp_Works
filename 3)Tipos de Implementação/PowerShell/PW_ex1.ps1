Measure-Command {
$soma = 0
for ($i = 0; $i -le 1000001; $i ++){
$soma += $i
}
Write-Host "$soma"
}