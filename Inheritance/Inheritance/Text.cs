using System;
namespace Inheritance
{
    // CHILD class
    public class Text : PresentationObject // this allows props on the PresentationObject class to be use-able here.
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url) {
            Console.WriteLine("Link added: " + url);
        }
    }
}
