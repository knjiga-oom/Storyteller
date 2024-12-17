using System;

namespace Storyteller
{
    class Story
    {
        public void WriteHeading(string title)
        {
            ++section_number;

            title = $"{section_number} {title}";
            Console.WriteLine(title);
            Console.WriteLine(new string('=', title.Length));
        }

        public void WriteParagraph(string text)
        {
            Console.WriteLine(text);
        }

        private int section_number = 0;
    }
}
