# Data Quality Management Application
Developed to assist in the data preparation process, of hard copy crime statement data into a digital format, that is ready to be transformed into useful information for analysis and reporting. 

# How to Run
## Ensure to Install DotNet CLI Tools:
- dotnet tool install --global dotnet-ef
- dotnet add package Microsoft.EntityFrameworkCore
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
- dotnet add package Microsoft.EntityFrameworkCore.Tools
- dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore 

## Run Migrations
- dotnet-ef update database

## Refresh Microsoft Azure Api Key 

## Run Application
- dotnet run
