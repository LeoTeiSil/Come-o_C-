// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld;

internal class Customer
{
    string _name;
    public string Name
    {
        get { return "Senhor: " + _name; }
        set { _name = value; }
    }

    public string Address { get; set; }
    
    public DateTime Birthday { get; set; }

    //Construtor
    //public Customer(string name, string address, DateTime birthday)
    //{
    //    Name = name;
    //    Address = address;
    //    Birthday = birthday;
    //}

    //Método de objetos
    public void SendWelcomeKit()
    {
        Console.WriteLine("Bem vindo " + Name + "!  Você está em uma atividade do Projeto Conectados.");
    }
}