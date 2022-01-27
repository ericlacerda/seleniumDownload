# seleniumDownload


Um amigo pediu ajuda para um codigo em VBA que fazia download de um arquivo que ele pegava na rede, Após diversos stackoverflow e sem entrar num consenso, resolvi criar um programa escrito em C# que faz essa integração simples e rapida, sem a necessidade de instalar nada.



No CMD você executa o programa "App.exe" e passa como parametro o link do download e o caminho que deve ser salvo.

Ficando assim:

c:\> App.exe "Link origem" "Caminho destino" 


Caso esteja numa sessão logada, baste pegar o Cookie da sessão 


VBA:

'Pega o cookie da pagina funciona 95% das vezes
Cookie = driver.ExecuteScript("var x = document.cookie; return x;")

'Local aonde o executável está
 exec = "C:\Eric\App.exe "
 exec = exec + """" + href + """ " + """C:\Eric\" + Cells(Selection.Row, 5) + ".pdf"" "
 exec = exec + Cookie
 
 'Note que a saida exec tem que está assim C:\Eric\App.exe "http:\\www.w2.com\arquivo.pdf" "c:\eric\teste.pdf" cookieSession 
 'Então é só utilizar o Shell
 texto = Shell(exec, vbNormalNoFocus)
