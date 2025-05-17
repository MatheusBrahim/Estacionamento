double vlEst, vlValet, vlLavagem, tempPerm, total;
int tempo, horas, hrsAdd;
string tamVeiculo, servValet, servLavagem;

Console.Clear();

titulo();

valiVeiculo();

valiValet();

valiLavagem();


string valiVeiculo ()
{
    Console.Write("Tamanho do veículo (P/G).....: ");
    tamVeiculo = Console.ReadLine().ToUpper();

    if (tamVeiculo != "P" && tamVeiculo != "G")
    {
        Console.WriteLine("--- Dados Invalidos ---");
    }

    return tamVeiculo;
}

string valiValet ()
{
    Console.Write("Serviço de valet (S/N).......: ");
    servValet = Console.ReadLine().ToUpper();

    if (servValet != "S" && tamVeiculo != "N")
    {
        Console.WriteLine("--- Dados Invalidos ---");
    }

    return servValet;
}

string valiLavagem ()
{
    Console.Write("Serviço de lavagem (S/N).....: ");
    servLavagem = Console.ReadLine().ToUpper();

    if (servLavagem != "S" && tamVeiculo != "N")
    {
        Console.WriteLine("--- Dados Invalidos ---");
    }

    return servLavagem;
}

void titulo()
{
    Console.WriteLine("--- Estacionamento ---");
}