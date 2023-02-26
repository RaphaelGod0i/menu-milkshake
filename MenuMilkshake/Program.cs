// See https://aka.ms/new-console-template for more information


Console.WriteLine("------------------");
Console.WriteLine(" M I L K   B O M");
Console.WriteLine("------------------");

string[] sabor =
{
    "[1]",
    "[2]",
    "[3]",
    "[4]",
    "[5]",
    "[6]",
    "[7]",
    "[8]",
    "[9]",
    "[10]",
    "[11]",
    "[12]",
    "[13]",
    "[14]",
    "[15]",
    "[16]"
};

string resp = "";
string tamanho = "";

double[] valor = { 5.22, 7.44, 9.53};
double totItem = 0;

 void menu(string[] sabor,double []valor)
{
    Console.WriteLine("Selecione o seu sabor");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine(sabor[0] + "Morango         " + sabor[8] + " Uva");
    Console.WriteLine(sabor[1] + "Melão           " + sabor[9] + " Banana");
    Console.WriteLine(sabor[2] + "Menta           " + sabor[10] + " Manga");
    Console.WriteLine(sabor[3] + "Chocolate       " + sabor[11] + " Flocos");
    Console.WriteLine(sabor[4] + "Chocolate B     " + sabor[12] + " Sonho de Valsa");
    Console.WriteLine(sabor[5] + "Nutella         " + sabor[13] + " Chiclete");
    Console.WriteLine(sabor[6] + "Prestígio       " + sabor[14] + " Cereja");
    Console.WriteLine(sabor[7] + "Ovomaltine      " + sabor[15] + " Sensação");
    Console.WriteLine("-----------------------------------");
    Console.Write("Insira o sabor desejado: ");
    string escolha = Console.ReadLine();

    Console.WriteLine("Pequeno R$" + valor[0]);
    Console.WriteLine("Médio   R$" + valor[1]);
    Console.WriteLine("Grande  R$" + valor[2]);
    tamanho = Console.ReadLine();
    Console.Clear();
}


do
{
  menu(sabor, valor);


    switch (tamanho)
    {
        case "pequeno":
            Console.WriteLine("Item adicionado!");
            totItem = totItem + valor[0];

       break;

        case "médio":
            Console.WriteLine("Item adicionado!");
            totItem = totItem + valor[1];

        break;

      
        case "grande":
            Console.WriteLine("Item adicionado!");
            totItem = totItem + valor[2];

        break;

        default:
            Console.WriteLine("Opção inválida"); 
        break;
    }

    Console.Write("Deseja adicionar mais itens? ");
    resp = Console.ReadLine();

    if (resp != "sim" && resp != "não")
    {
        Console.WriteLine("Opção inválida");
        Console.Clear();
        menu(sabor, valor);

    }

} while (resp == "sim");

Console.WriteLine("O valor total foi de R$" + totItem);


