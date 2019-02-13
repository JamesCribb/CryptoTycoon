using System.Drawing;

namespace CryptoTycoon
{
    public class Message
    {
        public string Text { get; }
        public Color MessageColor { get; }

        public Message(string text)
        {
            Text = text;
            MessageColor = Color.Black;
        }

        public Message(string text, Color mColor)
        {
            Text = text;
            MessageColor = mColor;
        }
    }
}
