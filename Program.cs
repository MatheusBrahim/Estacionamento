decimal vlEst, vlValet, vlLavagem, total, horas, tempo;
string tamVeiculo, servValet, servLavagem;

Console.Clear();

titulo();
valiVeiculo();
tempoHrs();
valiValet();
valiLavagem();
valorEstacionamento();
valorValet();
valorLavagem();
valorTotal();

void titulo()
{
    Console.WriteLine("--- Estacionamento ---");
}

string valiVeiculo ()
{
    Console.Write("Tamanho do veículo (P/G).....: ");
    tamVeiculo = Console.ReadLine().ToUpper();

    if (tamVeiculo != "P" && tamVeiculo != "G")
    {
        Console.WriteLine("--- Dados Invalidos ---");
        return valiVeiculo();
    }

    return tamVeiculo;
}

int tempoHrs()
{
    Console.Write("Tempo de permanência (min)...: ");
    tempo = Convert.ToInt32(Console.ReadLine());

    if (tempo >= 720)
    {
        Console.WriteLine("--- Dados Invalidos ---");
        return tempoHrs();
    }
    else
    {
        horas = (int)(tempo / 60);
    }

    return (int)horas;
}

string valiValet ()
{
    Console.Write("Serviço de valet (S/N).......: ");
    servValet = Console.ReadLine().ToUpper();

    if (servValet != "S" && servValet != "N")
    {
        Console.WriteLine("--- Dados Invalidos ---");
        return valiValet();

    }

    return servValet;
}

string valiLavagem ()
{
    Console.Write("Serviço de lavagem (S/N).....: ");
    servLavagem = Console.ReadLine().ToUpper();

    if (servLavagem != "S" && servLavagem != "N")
    {
        Console.WriteLine("--- Dados Invalidos ---");
        return valiLavagem();
    }

    Console.WriteLine();

    return servLavagem;
}

Decimal valorEstacionamento()
{
    if (horas >= 5 && tamVeiculo == "G")
    {
        vlEst = 80;
    }
    else if (horas >= 5 && tamVeiculo == "P")
    {
        vlEst = 50;
    }
    else
    {
        vlEst = tamVeiculo == "G" ? 20 + (20 * (horas - 1)) : 20 + (10 * (horas - 1));
    }
    Console.WriteLine($"Estacionamento..:       R$ {vlEst:N2}");
    return vlEst;
}

Decimal valorValet()
{
    vlValet = servValet == "S" ? vlEst * 0.2m : 0;
    Console.WriteLine($"Valet...........:       R$ {vlValet:N2}");
    return vlValet;
}

Decimal valorLavagem()
{
    if (tamVeiculo == "G")
    {
        vlLavagem = 100;
    }
    else
    {
        vlLavagem = 50;
    }

    if (servLavagem != "S")
    {
        Console.WriteLine("Lavagem.........:       R$ 0,00");
    }
    else
    {
        Console.WriteLine($"Lavagem.........:       R$ {vlLavagem:N2}");
    }

    return vlLavagem;
}

decimal valorTotal()
{
    Console.WriteLine("--------------------------------");

    total = servLavagem == "S" ? vlEst + vlValet + vlLavagem : vlEst + vlValet;
    Console.WriteLine($"Total...........:       R$ {total:N2}");

    return total;
}
