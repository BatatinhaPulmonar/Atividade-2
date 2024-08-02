using MinhaEmpresa.Cliente;
using MinhaEmpresa.Produto;
using System;

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("Pedro", "pedro.hype@exemple.com");
        Produto produto = new Produto("Chocolate");

        Console.WriteLine($"Cliente: {cliente.Nome} \nEmail: {cliente.Email} \nProduto: {produto.Produtos}");
    }
}
