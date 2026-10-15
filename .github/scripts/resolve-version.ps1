# Resolves the library version from a release tag: "v1.0.87" and "1.0.87" both become "1.0.87".
param([Parameter(Mandatory = $true)][string]$Tag)
"VERSION=$($Tag -replace '^v', '')" >> $env:GITHUB_ENV
