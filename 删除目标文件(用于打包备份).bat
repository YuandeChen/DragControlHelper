dir /ad /b > sdk.txt

del /f /s /q .\*.sdf

for /r %%a in (obj bin x64 x86 ipch Debug) do  rd /s /q "%%a"

@PAUSE
del sdk.txt
