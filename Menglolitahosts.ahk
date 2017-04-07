#NoEnv  ; Recommended for performance and compatibility with future AutoHotkey releases.
; #Warn  ; Enable warnings to assist with detecting common errors.
SendMode Input  ; Recommended for new scripts due to its superior speed and reliability.
SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.

whr := ComObjCreate("WinHttp.WinHttpRequest.5.1")
whr.Open("GET", "https://raw.githubusercontent.com/sy618/hosts/master/FQ")
whr.Send()
FileDelete, C:\WINDOWS\system32\drivers\etc\hosts
FileAppend, % whr.ResponseText, C:\WINDOWS\system32\drivers\etc\hosts
run, ipconfig /flushdns, , Hide
msgbox, hosts更新完成，你可以继续其他操作或者关闭主程序
run, http://www.menglolita.com