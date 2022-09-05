void MatreshkaMaster(int size)
{
    if(size == 1)
    {
        System.Console.WriteLine("Last matreshka " + size);
        return;
    }
    System.Console.WriteLine("Start Matreshka " + size);
    MatreshkaMaster(size -1);
    System.Console.WriteLine("End Matreshka " + size);
    return;
}

MatreshkaMaster(4);