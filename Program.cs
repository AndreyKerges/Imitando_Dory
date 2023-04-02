//cria uma string 'txt' do tipo string
string txt;

//Exibe uma mensagem pedindo ao usuário para digitar um texto...
Console.WriteLine("Digite o seu texto em português para traduzi-lo para o baleiês:");

//Lê a entrada do usuário e atribui o valor à variável txt
txt = Console.ReadLine()!;

//linha em branco, quebra de linha
Console.WriteLine();

//exibe o texto digitado pelo usuário em português mais o valor do txt
Console.WriteLine($"Em português: " + txt);
Console.WriteLine();

//substitui a vogal 'a, e, i, o ,u' do texto pela repetição da letra 3 vezes, utilizando
//o replace e a função concat
txt = txt.Replace("a", string.Concat(Enumerable.Repeat("aaa", 1)));
txt = txt.Replace("e", string.Concat(Enumerable.Repeat("eee", 1)));
txt = txt.Replace("i", string.Concat(Enumerable.Repeat("iii", 1)));
txt = txt.Replace("o", string.Concat(Enumerable.Repeat("ooo", 1)));
txt = txt.Replace("u", string.Concat(Enumerable.Repeat("uuu", 1)));
//*REPLACE:  é um método que substitui todas as ocorrências de um caractere ou sequência de caracteres por outro.*//
//*STRING.CONCAT: é um método que concatena uma sequência de strings em uma única string.*//
//*ENUMERABLE.REPEAT("aaa", 1): é uma função do namespace System.Linq que repete a string "aaa" UMA vez. Ela é 
//*utilizada para criar a sequência de caracteres que será usada na substituição. Neste caso, a letra "a" será substituída por "aaa".*//


//exibe o texto traduzido para baleiês
Console.WriteLine($"Em baleiês: " + txt);