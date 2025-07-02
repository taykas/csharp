//Codigo meu e da Lasnine

// var verificador = new Verificador();
// var Pessoa = new Pessoa();
// Pessoa.Nome = "Thayna";
// Pessoa.Senha = "Thayna123";
// Pessoa.Email = "thayna.lasnine@gmail.com";
// public interface IVerificador
// {
//     bool Nome(Pessoa pessoa);
//     bool Email(Pessoa pessoa);
//     bool Senha(Pessoa pessoa);
// }
// public class Verificador : IVerificador
// { 

//     public bool Nome(Pessoa pessoa)
//     {
//         List<char> simbolos = new List<char>()
//         { '@', '#', '$', '%', '&', '*', '(', ')', '+', '=', '[', ']', '{', '}', '|', ';', ':', ',', '.', '<', '>', '/', '?', '`', '~' , '!'};
//         for (int i = 0; i <= pessoa.Nome; i++)
//         {
//             char atual = pessoa.Nome[i];
//             if (simbolos.Contains(atual))
//             {
//                 Console.WriteLine("Usuario invalido!");
//                 return false;
//             }
//             else
//             {
//                 Console.WriteLine("Usuario cadastrado com sucesso!");
//                 return true;
//             }
//         }
//     }
//     public bool Email(Pessoa pessoa)
//     {
//         List<char> simbolos = new List<char>()
//         { '#', '$', '%', '&', '*', '(', ')', '+', '=', '[', ']', '{', '}', '|', ';', ':', ',','<', '>', '/', '?', '`', '~' , '!'};
//         for (int i = 0; i <= pessoa.Email; i++)
//         {
//             char atual = pessoa.Email[i];
//             if (simbolos.Contains(atual))
//             {
//                 Console.WriteLine("Email invalido!");
//                 return false;
//             }
//             else
//             {
//                 Console.WriteLine("Email cadastrado com sucesso!");
//                 return true;
//             }
//         }
//     }
//     public bool Senha(Pessoa pessoa)
//     {
//         List<char> simbolos = new List<char>()
//         { '@', '#', '$', '%', '&', '*', '(', ')', '+', '=', '[', ']', '{', '}', '|', ';', ':', ',', '.', '<', '>', '/', '?', '`', '~' , '!'};
//         for (int i = 0; i <= pessoa.Senha; i++)
//         {
//             char atual = pessoa.Senha[i];
//             if (!simbolos.Contains(atual))
//             {
//                 Console.WriteLine("Senha invalida");
//                 return false;
//             }
//             else
//             {
//                 Console.WriteLine("Senha cadastrado com sucesso!");
//                 return true;
//             }
//         }
//     }
// }
// public class Pessoa
// {
//     string Nome { get;  set; }
//     private string Senha { get;  set; }
//     string Email { get;  set; }

// }