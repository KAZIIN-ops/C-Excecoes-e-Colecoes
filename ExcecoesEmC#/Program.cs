using System.Linq.Expressions;
using System.Text.Json.Serialization;
using ExcecoesEmC_.Models;
using Newtonsoft.Json;

//Desserializacao com a classe Vendas_2
// string lerarquivo = File.ReadAllText("Arquivos/vendas.json");
// List<vendas_2> listavendas = JsonConvert.DeserializeObject<List<vendas_2>>(lerarquivo);

// foreach(vendas_2 vendas_2 in  listavendas){
//     Console.WriteLine(vendas_2);

// }












//Serializacao em json com a classe venda
// List<Venda> listavendas = new List<Venda>();
// DateTime dataatual = DateTime.Now;
// Venda venda1= new Venda(1,"MAterial vendido",2.00M,dataatual);
// Venda venda2= new Venda(2,"MAterial vendido",2.00M,dataatual);

// listavendas.Add(venda1);
// listavendas.Add(venda2);

// string serializado = JsonConvert.SerializeObject(listavendas,Formatting.Indented);
// File.WriteAllText("Arquivos/vendas.json",serializado);
// Console.WriteLine(serializado);














// int numero = 10;
// bool par = false;

//IF ternario
// par= numero %2 ==0;
// Console.WriteLine($" O numero {numero}"+ (par ?"par":"impar"));



//Tuplas
// lerarquivos arquivo = new lerarquivos();

// var (Sucesso,linhas,QuantidadeLinhas)= arquivo.lerarquivo("Arquivos/Arquivo.txt");
// if (Sucesso)
// {
//     Console.WriteLine("Quantidade de linhas arquivo " + QuantidadeLinhas);
//     foreach(string linha in linhas){
//         Console.WriteLine(linha);

//     }


// }
// else{
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }



// (int,string,string) Tupla = (1,"Kaio","Felipe");
// Console.WriteLine(Tupla.Item1);



//Dicionario

// Dictionary <string, string> Estados = new Dictionary<string, string>();

// Estados.Add("PE","Pernambuco");
// Estados.Add("SC" , "Santa Catarina");
// Estados.Add("RJ", "Rio de Janeiro");

//Console.WriteLine(Estados["Sc"]);



// foreach(var item in Estados){
//     Console.WriteLine(item);
// }

// Estados.Remove("PE");
// Estados["SC"]= "Santa Catarina - Valor foi Alterado ";
// Console.WriteLine("PErnambuco Removido");
// foreach(var item in Estados){
//     Console.WriteLine(item);
// }
// string chave = "RJ";
// if (Estados.ContainsKey(chave)){
//     Console.WriteLine($" Valor {chave} Existente!");

// }else{
//     Console.WriteLine($"O valor {chave} Não existe!");

// }



//Pilhas

// Stack<int> Pilha = new Stack<int>();
// Pilha.Push(4);
// Pilha.Push(6);
// Pilha.Push(8);
// Pilha.Push(10);

// foreach(int item in Pilha)
// {
//     Console.WriteLine(item);

// }
// Pilha.Pop();
// Console.WriteLine("Removido o Ultimo Elemento  ");

// foreach(int item in Pilha)
// {
//     Console.WriteLine(item);
// }



//Filas
// Queue<int> fila =  new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
// foreach(int item in fila){
//     Console.WriteLine(item);
// }
// fila.Dequeue();

// foreach(int item in fila){
//     Console.WriteLine(item);

// }







//Testando o metodo Excessão
//new Exemplo_Excessão().Metodo1();



// try{
// string[] linhas= File.ReadAllLines("Arquivos/Arquivo.txt");

// foreach(string linha in linhas){
//     Console.WriteLine(linha);

// }

// }

// catch(FileNotFoundException ex){
//     Console.WriteLine($"erro{ex.Message}");
// }
// catch(Exception ex){
//     Console.WriteLine($"Erro generico{ex.Message}");
// }
// finally{
//     //algo para ser Representado até mesmo sem alguma excessão
// }