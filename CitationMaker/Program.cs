using System;

namespace CitationMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Help
            if (args.Length == 0 || args[0].ToLower() == "help")
            {
                Console.WriteLine("Created by Weston McNamara \n");
                Console.WriteLine("To use, pass the format you would like as a command line argument.");
                Console.WriteLine("Supported formats: APA & MLA");
                Console.WriteLine("Example: \"cite apa\" for apa citation.");
                Console.WriteLine("Example: \"cite mla\" for mla citation.");

                return;
            }

            //Respond to the arguments
            switch (args[0].ToLower())
            {                    
                //Author’s Last name, First initial. (Year published). Title of source. URL. < APA format
                case "apa":
                    Citation apaCiteData = new Citation();

                    //Create the citation text
                    string apaCitation = string.Empty;
                    apaCitation = $"{apaCiteData.lastName}, {apaCiteData.firstIntial}. ({apaCiteData.year}, {apaCiteData.month}, {apaCiteData.day}). {apaCiteData.title}. \n{apaCiteData.URL}.";

                    Console.WriteLine(apaCitation);             
                    break;

                //Author's Last name, First name. "Title of Source." publication date, location.
                case "mla":
                    Citation mlaCiteData = new Citation();

                    //Create the citation text
                    string mlaCitation = string.Empty;
                    mlaCitation = $"{mlaCiteData.lastName}, {mlaCiteData.firstIntial}. \"{mlaCiteData.title}.\" {mlaCiteData.year}, {mlaCiteData.month}, {mlaCiteData.day}. \n{mlaCiteData.URL}.";

                    Console.WriteLine(mlaCitation);
                    break;

                //Incorrect arguments
                default:
                    Console.WriteLine("Please use the correct format for command line arguments. Example:");
                    Console.WriteLine("\"cite apa\" for an APA citation");
                    Console.WriteLine("\"cite mla\" for an MLA citation");
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

        //Gets an input string, and will requery the user if an exception is thrown to prevent crashing.
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
        public string firstIntial;
        public string URL;
        public string year;
        public string month;
        public string day;
    }
}
