using System.Collections;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using kakakak;

decimal preçoIniciais = 0;
decimal preçoPorHoras = 0;

Console.WriteLine("Seja bem vindo ao sistema do estacionamento\nDigite o preço.");
preçoIniciais = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora.");
preçoPorHoras = Convert.ToDecimal(Console.ReadLine());

bool exibirMenu = true;

Cadastro cadastro = new Cadastro(preçoIniciais, preçoPorHoras);

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções abaixo.");
    Console.WriteLine("1.Cadastre seu carro\n2.Remover carro\n3.Lista de carros\n4.Encerrar.");



    switch (Console.ReadLine())
    {
        case "1":
            cadastro.AdicionarCarro();
            break;
        case "2":
            cadastro.RemoverVeiculo();
            break;
        case "3":
            cadastro.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Numero válido.");
            break;

    }
}
