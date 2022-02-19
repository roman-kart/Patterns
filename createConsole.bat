if "%1" EQU "" goto error

mkdir %1
cd %1
dotnet new console
dotnet new sln
dotnet sln add .\%1.csproj
cd | clip

:error
echo Enter project name