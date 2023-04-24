@echo off
echo start ...

rem *** Parameters description ***
rem n.1 - log <path>\<file>
rem n.2 - typ procesu: import, export, createdb
rem n.3 - config <path>\<ConfigFile>

rem example for import
SK2EVERYONE.EXE logs\log.txt import appsettings.json

rem example for export
rem SK2EVERYONE.EXE logs\log.txt export appsettings.json

rem example for createdb
rem SK2EVERYONE.EXE logs\log.txt createdb appsettings.json


echo ********************************
echo *           end                *
echo ********************************
pause
goto end


:end
