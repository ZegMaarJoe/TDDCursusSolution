using System.Linq;

namespace Palindroom
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
            // var omgekeerd = new string(Text.ToCharArray().Reverse().ToArray());
            // return Text == omgekeerd;
            var woordArray = Text.ToArray();
            for (var teller = 0; teller < Text.Length / 2; teller++)
            {
                if (Text[teller] != Text[Text.Length - 1 - teller])
                    return false;
            }
            return true;
        }

    }
}
