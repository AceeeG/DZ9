namespace Lab
{
    internal class ACipher : ICipher
    {
        private string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
        private string result;
        public string Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }

        public ACipher(string text)
        {
            this.text = text;
        }

        public string Encode(string text)
        {
            char[] text_array = text.ToCharArray();

            for (int i = 0; i < text_array.Length; i++)
            {
                if (char.IsLetter(text_array[i]) && text_array[i] != 'z' && text_array[i] != 'z')
                {
                    char baseChar = text_array[i];
                    text_array[i] = (char)((text_array[i] - baseChar + 1) % 26 + baseChar);
                }
                else if (text_array[i] == 'z')
                {
                    text_array[i] = 'a';
                }
                else if (text_array[i] == 'я')
                {
                    text_array[i] = 'а';
                }
            }
            result = new string(text_array);
            return new string(text_array);
        }
        public string Decode(string text)
        {
            char[] text_array = text.ToCharArray();

            for (int i = 0; i < text_array.Length; i++)
            {
                if (char.IsLetter(text_array[i]) && text_array[i] != 'а' && text_array[i] != 'a')
                {
                    char baseChar = text_array[i];
                    text_array[i] = (char)((text_array[i] - baseChar - 1) % 26 + baseChar);
                }
                else if (text_array[i] == 'a')
                {
                    text_array[i] = 'z';
                }
                else if (text_array[i] == 'а')
                {
                    text_array[i] = 'я';
                }
            }

            return new string(text_array);
        }

    }
}
