namespace Bucci.Marco._3i.MAUIString

{
    public class CustomLib
    {

        public int Lenght(string TextIn)
        {
            char[] caratteri = TextIn.ToCharArray();
            int retVal = 0;

            foreach (char c in caratteri)
                retVal++;

            return retVal;
        }


        public int qtbLetter(string TextIn)
        {
            char[] txtCharArray = TextIn.ToCharArray();
            int retVal = 0;

            for (int i = 0; i < Lenght(TextIn); i++)
                if (isLetter(txtCharArray[i]))
                    retVal++;

            return retVal;
        }

        public int qtbWord(string TextIn)
        {
            char[] txtCharArray = TextIn.ToCharArray();
            int retVal = 0;

            for (int i = 0; i < Lenght(TextIn) - 1; i++)
                if ((isLetter(txtCharArray[i + 1])) && txtCharArray[i] == ' ')
                    retVal++;

            if (Lenght(TextIn) != 0)
                retVal++;

            return retVal;
        }

        public string txtUpper(string TextIn)
        {
            char[] txtCharArray = TextIn.ToCharArray();

            for (int i = 0; i < Lenght(TextIn); i++)
                if ((txtCharArray[i] >= 'a') && (txtCharArray[i] <= 'z'))
                {
                    int charInt = (int)txtCharArray[i] & 0x5f;
                    txtCharArray[i] = (char)charInt;
                }

            return new string(txtCharArray);
        }

        public string txtLower(string TextIn)
        {
            char[] txtCharArray = TextIn.ToCharArray();

            for (int i = 0; i < Lenght(TextIn); i++)
                if ((txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z'))
                {
                    int cInt = (int)txtCharArray[i] | 0x20;
                    txtCharArray[i] = (char)cInt;

                }

            return new string(txtCharArray);
        }

        public string txtReverse(string TextIn)
        {
            char[] txtCharArray = TextIn.ToCharArray();
            char[] txtCharArrayReverse = new char[Lenght(TextIn)];


            for (int i = 0; i < Lenght(TextIn); i++)
            {
                txtCharArrayReverse[i] = (char)txtCharArray[Lenght(TextIn) - i - 1];
            }

            return new string(txtCharArrayReverse);
        }

        public bool onlyAlphabet(string TextIn)
        {
            if (Lenght(TextIn) == 0)
                return false;

            char[] txtCharArray = TextIn.ToCharArray();

            for (int i = 0; i < Lenght(TextIn); i++)
                if (!(isLetter(txtCharArray[i])))
                    return false;

            return true;
        }

        public bool isLetter(char CharIn)
        {
            if (!((CharIn >= 'a') && (CharIn <= 'z') || (CharIn >= 'A') && (CharIn <= 'Z')))
                return false;

            return true;
        }

        public bool isNumber(char CharIn)
        {
            if (!((CharIn >= '1') && (CharIn <= '9')))
                return false;

            return true;
        }

        public bool onlyAlphanumeric(string TextIn)
        {
            if (Lenght(TextIn) == 0)
                return false;

            char[] txtCharArray = TextIn.ToCharArray();

            for (int i = 0; i < Lenght(TextIn); i++)
                if (!(isLetter(txtCharArray[i]) || (txtCharArray[i] >= '1') && (txtCharArray[i] <= '9')))
                    return false;

            return true;
        }

        public bool IsPunctuation(string TextIn)
        {
            char[] txtCharArray = TextIn.ToCharArray();

            for (int i = 0; i < Lenght(TextIn); i++)
                if (!(isLetter(txtCharArray[i]) || (txtCharArray[i] == ' ') || isNumber(txtCharArray[i])))
                    return true;

            return false;
        }

        public bool txtPalindrome(string TextIn)
        {
            if (Lenght(TextIn) == 0)
                return false;

            if (splittedWord(txtLower(TextIn)) == splittedWord(txtLower(txtReverse(TextIn))))
                return true;

            return false;
        }

        public string txtCapitalized(string TextIn)
        {
            char[] txtCharArray = txtLower(TextIn).ToCharArray();

            if ((Lenght(TextIn) != 0) && (txtCharArray[0] >= 'a') && (txtCharArray[0] <= 'z'))
            {
                int charInt = (int)txtCharArray[0] & 0x5f;
                txtCharArray[0] = (char)charInt;
            }

            for (int i = 0; i < Lenght(TextIn) - 1; i++)
                if (((txtCharArray[i + 1] >= 'a') && (txtCharArray[i + 1] <= 'z')) && txtCharArray[i] == ' ')
                {
                    int charInt = (int)txtCharArray[i + 1] & 0x5f;
                    txtCharArray[i + 1] = (char)charInt;
                }
            return new string(txtCharArray);
        }

        public string splittedWord(string TextIn)
        {
            int j = 0;
            int count = 0;
            char[] txtCharArray = TextIn.ToCharArray();

            for (int i = 0; i < Lenght(TextIn); i++)
                if (txtCharArray[i] != ' ')
                    count++;

            char[] SplittedArray = new char[count];

            for (int i = 0; i < Lenght(TextIn); i++)

                if (txtCharArray[i] != ' ')
                {
                    SplittedArray[j] = txtCharArray[i];
                    j++;
                }
            return new string(SplittedArray);
        }

    }
}