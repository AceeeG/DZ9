namespace Lab
{
    internal interface ICipher
    {
        string Encode(string text);
        string Decode(string text);
    }
}
