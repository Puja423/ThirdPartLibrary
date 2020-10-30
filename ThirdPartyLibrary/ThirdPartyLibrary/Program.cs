using System;

namespace ThirdPartyLibraryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            CSVHandler.ImplimentatonDataHandling();
            //JSONcsvManipulation.ImplimentCSVtoJSON();
            JSONcsvManipulation.ImplimentJSONtoCSV();
        }
    }
    
}
