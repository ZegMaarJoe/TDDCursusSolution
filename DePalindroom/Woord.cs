using System.Linq;

namespace Taken
{
    public class Woord
    {
        public string Text { get; set; }
        public Woord(string woord)
        {
            Text = woord;
        }
        public bool IsPalindroom()
        {
            var omgekeerd = new string(Text.ToArray().Reverse().ToArray());
            return Text == omgekeerd;
        }
        public bool IsPalindroom01()
        {
            for (var teller = 0; teller < Text.Length / 2; teller++)
            {
                if (Text[teller] != Text[Text.Length - 1 - teller]) return false;
            }
            return true;
        }
        public bool IsPalindroom02()
        {
            return Text == new string(Text.ToCharArray().Reverse().ToArray());
        }
    }
}
