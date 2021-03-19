using System;
using Sharprompt;

namespace PPTGenerator.Input
{
    public static class Input
    {
        static string AskSearchTerm(){
            var teste = Prompt.Input<string>("Type a Wikipedia search term: ");
            return teste;
        }

        static string AskPrefix(){
            return Prompt.Select("Choose one option: ", new[] { "Who is", "What is", "The history of" });
        }

        public static void Start(){
            var searchTerm = AskSearchTerm();
            var prefix = AskPrefix();

            Console.WriteLine($"{prefix} {searchTerm}");
        }
    }
}
