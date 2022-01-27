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
 
 'Note que a saida exec tem que estar assim C:\Eric\App.exe "http:\\www.w2.com\arquivo.pdf" "c:\eric\teste.pdf" cookieSession 
 'Então é só utilizar o Shell
 texto = Shell(exec, vbNormalNoFocus)
 
 Exemplo:
 
 ![image](https://user-images.githubusercontent.com/16361144/151417295-f610ea70-f178-4d82-a306-f6f9e2bad9ff.png)



![image](https://user-images.githubusercontent.com/16361144/151417467-d53f5668-7e34-41e2-b6a7-1bde43ad2254.png)

