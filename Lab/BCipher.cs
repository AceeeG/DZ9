using System;

namespace Lab
{
    internal class BCipher : ICipher
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

        public BCipher(string text)
        {
            this.text = text;
        }

        public string Encode()
        {
            if (result == "" && text != "")
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char new_char;

                    if (Char.IsLetter(text[i]))
                    {
                        if (text.ToLower()[i] >= 'а' && text.ToLower()[i] <= 'я')
                        {
                            new_char = (char)((int)'я' - ((int)text.ToLower()[i] - (int)'а'));
                        }
                        else
                        {
                            new_char = (char)((int)'z' - ((int)text.ToLower()[i] - (int)'a'));
                        }

                        if (Char.IsUpper(text[i]))
                        {
                            result += new_char.ToString().ToUpper();
                        }
                        else
                        {
                            result += new_char;
                        }
                    }
                    else
                    {
                        result += text[i];
                    }
                }
                text = "";
                return result;
            }

            return result;
        }

        public string Decode()
        {
            if (result != "" && text == "")
            {
                for (int i = 0; i < result.Length; i++)
                {
                    char new_char;

                    if (Char.IsLetter(result[i]))
                    {
                        if (result.ToLower()[i] >= 'а' && result.ToLower()[i] <= 'я')
                        {
                            new_char = (char)((int)'я' - (int)result.ToLower()[i] + (int)'а');
                        }
                        else
                        {
                            new_char = (char)(((int)'z' - (int)result.ToLower()[i]) + (int)'a');
                        }

                        if (Char.IsUpper(result[i]))
                        {
                            text += new_char.ToString().ToUpper();
                        }
                        else
                        {
                            text += new_char;
                        }
                    }
                    else
                    {
                        text += text[i];
                    }
                }

                result = "";
                return text;
            }

            return text;
        }

    }
}
