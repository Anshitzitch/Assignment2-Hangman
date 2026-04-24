using System;

public class Player
{
    private string playerName;

    public string PlayerName(string name)
    {
        get
        {
            return playerName;
        }

        set
        {
            if(name != null)
            {
                playerName = name;
            }
            else
            {
                Console.WriteLine("Please enter the name");
            }
        }
    }
}
