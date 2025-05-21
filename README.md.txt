# Nerdbank.GitVersioning Demo

This is a simple .NET 6 Console App that demonstrates how [Nerdbank.GitVersioning](https://github.com/dotnet/Nerdbank.GitVersioning) can be used to manage version numbers automatically using Git history.

## 🛠 Requirements

- .NET 6 SDK or later
- Git

## 🚀 What It Does

Nerdbank.GitVersioning uses Git history (commits, tags, branches) to compute semantic version numbers. You no longer need to update version numbers manually in your `.csproj`.

## 📦 Setup Instructions

```bash
dotnet new console -n NerdbankVersionDemo
cd NerdbankVersionDemo
git init
dotnet add package Nerdbank.GitVersioning


##  ⚙️ Using Instructions
- versions.json should be set like this

{
  "version": "1.2.3",
  "assemblyVersion": "1.2.3.0",
  "fileVersion": "1.2.3.0",
  "semanticVersionFormat": "Prerelease",
  "publicReleaseRefSpec": [
    "^refs/heads/main$",
    "^refs/tags/v\\d+\\.\\d+\\.\\d+$"
  ],
  "versionHeightOffset": 0
}


- Right click the file explorer
- Click on terminal

- type in terminal "dotnet run" it will show the current version
- to change the version you going to need to use Git tags and "versions.json" file that i dont reccomend to change a lot, its recommended to use the git tags
-to change the version use "git tag v1.2" in terminal (the version number is up to your version)
-type dotnet run to see current version

🧼 Maintence of versions
	
To see all tags - git tag

delete tag - git tag -d "v5.2"

Overwrite tag - git tag -d v5.2 && git tag v5.2

Create new tag - git tag v5.4

Push tag to GitHub - git push origin v5.4




