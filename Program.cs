class Program
{
    static void Main()
    {

        Console.WriteLine("How many records do you want to add? ");

        var numberOfRecords = int.Parse(Console.ReadLine()!);
        {
            var recordList = new List<Files>();
            for (int i = 0; i < numberOfRecords; i++)

            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var Files = new Files();

                Console.WriteLine("Enter the value for ");
                Files.Name = Console.ReadLine()!;


                recordList.Add(Files);
            }
        }
    }

}

class Person
{

    private string _name = default!;

    public string Name

    {
        get => _name;
        set => _name = value;
    }

}
 class Files : Person
{ 
    
        private string _name = default!;

        new public string  Name

    {
        get => _name;
        set => _name = value;

    }
    
}



// Print out the list of records using Console.WriteLine()

