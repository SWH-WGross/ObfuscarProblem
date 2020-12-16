# build
dotnet clean
dotnet build

# obfuscate the example 
.\Obfuscar.2.2.29\tools\Obfuscar.Console.exe .\Obfuscar.xml

# run the example
.\bin\debug\net48\obfuscated\ObfuscationProblem.exe