namespace Storyteller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Story story = new Story();
            story.WriteHeading("Šuma Striborova");
            story.WriteParagraph("Zašao neki momak u šumu Striborovu...");
        }
    }
}
