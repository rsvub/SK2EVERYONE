@echo off
echo start ...

copy sk2everyone.empty sk2everyone.fdb

rem *** Parameters description ***
rem n.1 - log <path>\<file>
rem n.2 - typ procesu: import, export, createdb
rem n.3 - config <path>\<ConfigFile>

rem example for import
rem SK2EVERYONE.EXE logs\log.txt import appsetings.json

rem example for export
rem SK2EVERYONE.EXE logs\log.txt export appsetings.json

rem example for createdb
SK2EVERYONE.EXE logs\log.txt createdb appsetings.json


echo ********************************
echo *           end                *
echo ********************************
pause
goto end


:end
