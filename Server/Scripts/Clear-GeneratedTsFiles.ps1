$mainProjectPath = Split-Path $PSScriptRoot -Parent | Split-Path -Parent;

$generatedModelsDirectory = Join-Path -Path $mainProjectPath "Client/src/app/models"
$generatedEnumsDirectory = Join-Path -Path $mainProjectPath "Client/src/app/enums"

Write-Host "Attempting to clear model directory..."
if (Test-Path -LiteralPath $generatedModelsDirectory -PathType Container) {
    Remove-Item $generatedModelsDirectory -Recurse
    Write-Host "Model directory '$generatedModelsDirectory' successfully cleared."
} else {
   Write-Error "Model directory '$generatedModelsDirectory' not found."
}

Write-Host "Attempting to clear enum directory..."
if (Test-Path -LiteralPath $generatedEnumsDirectory -PathType Container) {
    Remove-Item $generatedEnumsDirectory -Recurse
    Write-Host "Enum directory '$generatedEnumsDirectory' successfully cleared."
} else {
    Write-Error "Enum directory '$generatedEnumsDirectory' not found."
}

Write-Host "All generated files successfully cleared."

Write-Host "Recreating folder structure..."

New-Item $generatedModelsDirectory -ItemType Directory
New-Item $generatedEnumsDirectory -ItemType Directory

Write-Host "Process complete."