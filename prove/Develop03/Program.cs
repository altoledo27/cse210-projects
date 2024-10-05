using System;

class Program
{
    static void Main(string[] args)
    {
        //Exceeding Requirements: Creation of a new class "scriptureLibrary" where the user can add the scripture they want to learn to a library and the program randomly choose one.
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        int n = scriptureLibrary.GetRandomNumber();
        Reference scriptureReference = new Reference(scriptureLibrary.GetBook(n), scriptureLibrary.GetChapter(n), scriptureLibrary.GetStartVerse(n), scriptureLibrary.GetEndVerse(n));
        
        string scriptureText = scriptureLibrary.GetScripture(n);
        
        Scripture scripture = new Scripture(scriptureReference, scriptureText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress enter to hide words, or type 'quit' to exit.");
            string userResponse = Console.ReadLine();
            
            if (userResponse.ToLower() == "quit")
                break;
            scripture.HideRandomWords(3); // How many words would you like to hide?
        }
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll the words are hidden. See you next time!");
        }
        else{
            Console.WriteLine("Ok, see you next time!");
        }

        
    }
}