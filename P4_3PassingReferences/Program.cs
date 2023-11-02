class Program
{
    public void Sell(House house)
    {
        house.owner = "Alex";
    }

    public static void Main()
    {
        House myHouse = new House();

        myHouse.owner = "John";
        
        myHouse.PrintOwner();

        Program program = new Program();
        
        program.Sell(myHouse);
        
        myHouse.PrintOwner();
    }
}



