using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Entities;
using System.Globalization;
using System.Security.Cryptography;


List<Funcionario> listaFuncionarios =  new List<Funcionario>();

Console.WriteLine("Digite o caminho do arquivo csv: ");
var path = Console.ReadLine();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] vetor = sr.ReadLine().Split(',');
        string nome = vetor[0];
        string email = vetor[1];
        double salario = double.Parse(vetor[2], CultureInfo.InvariantCulture);

        var func = new Funcionario(nome, email, salario);

        listaFuncionarios.Add(func);
    }

    Console.WriteLine("FUNCIONÁRIOS");
    foreach (var func in listaFuncionarios)
    {
        Console.WriteLine(func);
    }

    Console.WriteLine("======================================================");

    Console.WriteLine("Digite o salário mínimo que para retornar os emails: ");
    double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    var lista = listaFuncionarios.Where(f => f.Salario > sal).Select(f => f.Email).ToList();


    foreach(var func in lista)
    {
        Console.WriteLine(func);

    }

    var somaSalario = listaFuncionarios.Where(f => f.Nome[0] == 'M').Select(f => f.Salario).Sum();

    Console.WriteLine("========================================================");

    Console.WriteLine("Soma dos salarios dos funcionarios que começam com M: "+ somaSalario);
}

