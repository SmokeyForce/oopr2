
namespace WpfTilt
{
    internal interface IPrintable
    {
        public string PrintContent { get; }
        void Print(MessageSender sender);
        string this[int index] { get; }
    }
    internal interface IDrawable : IPrintable
    {
        void Draw(string something, MessageSender sender);
    }
}
