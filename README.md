Program pro export dat z databaze MSSQL do Embedded FirebirdSQL 4.0

1.	Pro spuštění je nutné správně nastavit konfiguraci pro MSSQL v souboru appsettings.json
	1. 1.	"ConnectionStrings" - nastavit připojení k MSSQL databázi
	1. 2.	"CsvFile" - nastavit aktualni název pro soubor s produktovým stromem
2.	Nahrát dodaný aktuální soubor do adresáře "..\Csv" - (soubor bude před konverzí na vyžádání dodán aktuální)
3.	Spouštěcí soubor je runapp.bat

Poslední revize: 2023-08-08
Radek Švub
