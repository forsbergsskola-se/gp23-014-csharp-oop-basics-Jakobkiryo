
public class Plant
{
    public bool isGrown;

    public void PlantStatus()
    {
        if (isGrown)
        {
            Console.WriteLine("Plant is a tree");
        }
        else
        {
            Console.WriteLine("Plant is a seed");
        }
    }

    public void Grow()
    {
        if (isGrown)
        {
            Console.WriteLine("Plant is already grown");
            return;
        }
        
        Console.WriteLine("Plant is Growing");
        isGrown = true;
    }
}