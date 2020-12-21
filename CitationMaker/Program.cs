using System;

namespace CitationMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Created by Weston McNamara \n");
                Console.WriteLine("To use, pass the format you would like as a command line argument.");
                Console.WriteLine("Supported formats: APA");
                Console.WriteLine("Example: \"cite apa\" for apa citation.");

                return;
            }

            switch (args[0].ToLower())
            {                    
                //Author’s Last name, First initial. Middle initial. (Year published). Title of source. URL. < APA format
                case "apa":
                    Citation citation = new Citation();

                    string apaCitation = string.Empty;
                    apaCitation = $"{citation.lastName}, {citation.firstIntial}. {citation.middleInitial}. ({citation.year}, {citation.month}, {citation.day}). {citation.title}. \n{citation.URL}.";

                    Console.WriteLine(apaCitation);             
                    break;
                
                case "mla":

                    break;
            }
        }

        
    }

    class Citation
    {
        //Creates a citation with userinput
        public Citation()
        {
            Console.WriteLine("Please enter the title of the document you're citing");
            title = GetSanitizedUserInput();

            Console.WriteLine("Please enter the last name of the author of the document you're citing");
            lastName = GetSanitizedUserInput();

            Console.WriteLine("Please enter the middle initial of the author of the document you're citing");
            middleInitial = GetSanitizedUserInput();

            Console.WriteLine("Please enter the first initial of the author of the document you're citing");
            firstIntial = GetSanitizedUserInput();

            Console.WriteLine("Please enter the URL of the document you're citing");
            URL = GetSanitizedUserInput();
            
            Console.WriteLine("Please enter the year of publication of the document you're citing");
            year = GetSanitizedUserInput();

            Console.WriteLine("Please enter the month of publication of the document you're citing");
            month = GetSanitizedUserInput();

            Console.WriteLine("Please enter the day of publication of the document you're citing");
            day = GetSanitizedUserInput();
        }

        static string GetSanitizedUserInput()
        {
            string input = null;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter text: ");
                    input = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter in the corrent format.");
                    continue;
                }

                return input;
            }
        }

        public string title;
        public string lastName;
        public string middleInitial;
        public string firstIntial;
        public string URL;
        public string year;
        public string month;
        public string day;
    }
}
