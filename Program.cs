//Aplicação Simples para demostrar como funciona a lista no C#
//Aut. Luiz Ricardo de Campos

//Criando a variavel
List<string> listarString = new List<string>();

//Adicionando elementos na lista
listarString.Add("SP");
listarString.Add("BA");
listarString.Add("MG");

//Percorrendo os índices e imprimindo na tela
for(int i = 0; i < listarString.Count;i++)
{
    Console.WriteLine($"Posição Nº {i} - Valor = {listarString[i]}");
}

//Percorrendo os índices e imprimindo na tela com o FOREACH
int contador = 0;
foreach(string i in listarString)
{
    Console.WriteLine($"Posição Nº {} - Valor {i}");
    contador++;
}