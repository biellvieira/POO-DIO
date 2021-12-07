using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.IO;
using System.Collections.Generic;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
            {
                var caminho = "C:\\TrabalhandoComArquivos";
                var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
                var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
                var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
                var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
                var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
                var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
                var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");


                FileHelper helper = new FileHelper();
                helper.ListarDiretorios(caminho);
                helper.ListarArquivosDiretorios(caminho);
                helper.CriarDiretorio(caminhoPathCombine);
                helper.ApagarDiretorio(caminhoPathCombine, true);
                helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
                helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
                helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
                helper.LerArquivoStream(caminhoArquivo);
                helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
                helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
                helper.DeletarArquivo(caminhoArquivoTesteCopia);


                ICalculadora calc1 = new Calculadora();
                System.Console.WriteLine(calc1.Somar(10, 20));
                
                
                Computador comp = new Computador();
                System.Console.WriteLine(comp.ToString());
                
                
                
                Corrente c = new Corrente();
                c.Creditar(100);

                c.ExibirSaldo();      

                Calculadora calc = new Calculadora();
                System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
                System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));
                
                Aluno p0 = new Aluno();
                p0.Nome = "Bob";
                p0.Idade = 20;
                p0.Documento = "12345";
                p0.Nota = 10;
                p0.Apresentar();

                Professor p2 = new Professor();
                p2.Nome = "Bob";
                p2.Idade = 20;
                p2.Documento = "12345";
                p2.Salario = 20000;
                p2.Apresentar();

                //valores validos
                Retangulo r = new Retangulo();
                r.DefinirMedidas(30, 30);
                System.Console.WriteLine($"Area : {r.ObterArea()}");

                 //valores invalidos
                Retangulo r2 = new Retangulo();
                r2.DefinirMedidas(0, 0);
                System.Console.WriteLine($"Area : {r2.ObterArea()}");
                
            
            
                Pessoa p1 = new Pessoa();
                p1.Nome = "Bob";
                p1.Idade = 20;

                p1.Apresentar();
         
        }


    }
}

