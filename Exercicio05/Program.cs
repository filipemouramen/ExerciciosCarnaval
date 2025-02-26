Console.WriteLine("Seu animal é um mamífero?");
string mamifero = Console.ReadLine().ToUpper();

if (mamifero == "SIM")
{
    Console.WriteLine("Seu animal é quadrúpede?");
    string quadrupede = Console.ReadLine().ToUpper();
    if (quadrupede == "SIM")
    {
        Console.WriteLine("Seu animal é carnívoro?");
        string carnivoro = Console.ReadLine().ToUpper();
        if (carnivoro == "SIM")
        {
            Console.WriteLine("Seu animal é o leão!");
        }
        else
        {
            Console.WriteLine("Seu animal é herbívoro?");
            string herbivoro = Console.ReadLine().ToUpper();
            if (herbivoro == "SIM")
            {
                Console.WriteLine("Seu animal é o cavalo!");
            }
        }
    }
    else
    {
        Console.WriteLine("Seu animal é bípede?");
        string bipede = Console.ReadLine().ToUpper();
        if (bipede == "SIM")
        {
            Console.WriteLine("Seu animal é onívoro?");
            string onivoro = Console.ReadLine().ToUpper();
            if (onivoro == "SIM")
            {
                Console.WriteLine("O seu animal é o homem!");
            }
            else
            {
                Console.WriteLine("O seu animal é frutífero?");
                string frutifero = Console.ReadLine().ToUpper();
                if (frutifero == "SIM")
                {
                    Console.WriteLine("O seu animal é o macaco!");
                }
            }
        }
        else
        {
            Console.WriteLine("O seu animal é voador?");
            string voador = Console.ReadLine().ToUpper();
            if (voador == "SIM")
            {
                Console.WriteLine("O seu animal é o morcego!");
            }
            else
            {
                Console.WriteLine("O seu animal é aquático?");
                string aquatico = Console.ReadLine().ToUpper();
                if (aquatico == "SIM")
                {
                    Console.WriteLine("O seu animal é a baleia!");
                }
            }
        }
    }
}
else
{
    Console.WriteLine("Seu animaç é uma ave?");
    string ave = Console.ReadLine().ToUpper();
    if (ave == "SIM")
    {
        Console.WriteLine("Sua ave é não-voadora?");
        string naovoadora = Console.ReadLine().ToUpper();
        if (naovoadora == "SIM")
        {
            Console.WriteLine("Sua ave é uma ave tropical?");
            string avetropical = Console.ReadLine().ToUpper();
            if (avetropical == "SIM")
            {
                Console.WriteLine("A sua ave é o avestruz!");
            }
            else
            {
                Console.WriteLine("A sua ave é polar?");
                string polar = Console.ReadLine().ToUpper();
                if (polar == "SIM"){
                    Console.WriteLine("A sua ave é o pinguim!");
                }
            }
        }
        else
        {
            Console.WriteLine("A sua ave é nadadora?");
            string nadadora = Console.ReadLine().ToUpper();
            if (nadadora == "SIM")
            {
                Console.WriteLine("A sua ave é o pato!");
            }
            else
            {
                Console.WriteLine("A sua ave é de rapina?");
                string rapina = Console.ReadLine().ToUpper();
                if (rapina == "SIM")
                {
                    Console.WriteLine("A sua ave é uma águia!");
                }
            }
        }
    }
}
