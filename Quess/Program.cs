
int number_to_quess = 99;

Console.WriteLine("Quess a number: ");
int player_number = Convert.ToInt32(Console.ReadLine());

while(player_number != number_to_quess)
{   
    if(player_number > number_to_quess)
    {
        Console.WriteLine("too high");
    }
    else if (player_number < number_to_quess)
    {
        Console.WriteLine("too low");
    }
    Console.WriteLine("Quess another: ");
    player_number = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("You win");
