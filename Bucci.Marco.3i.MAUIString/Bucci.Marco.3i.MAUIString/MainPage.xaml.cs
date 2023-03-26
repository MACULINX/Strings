using System.Runtime.InteropServices;

namespace Bucci.Marco._3i.MAUIString;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    static int Lenght(string TextIn)
    {
        char[] caratteri = TextIn.ToCharArray();
        int retVal = 0;

        foreach (char c in caratteri)
            retVal++;

        return retVal;
    }


    int qtbLetter(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();
        int retVal = 0;

        for (int i = 0; i < Lenght(TextIn); i++)
            if (isLetter(txtCharArray[i]))
                retVal++;

        return retVal;
    }

    int qtbWord(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();
        int retVal = 0;

        for (int i = 0; i < Lenght(TextIn) - 1; i++)
            if ((isLetter(txtCharArray[i+1])) && txtCharArray[i] == ' ')
                retVal++;

        if (Lenght(TextIn) != 0)
            retVal++;

        return retVal;
    }

    string txtUpper(string TextIn)
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

    string txtLower(string TextIn)
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

    string txtReverse(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();
        char[] txtCharArrayReverse = new char[Lenght(TextIn)];


        for (int i = 0; i < Lenght(TextIn); i++)
        {
            txtCharArrayReverse[i] = (char)txtCharArray[Lenght(TextIn) - i - 1];
        }

        return new string(txtCharArrayReverse);
    }

    bool onlyAlphabet(string TextIn)
    {
        if (Lenght(TextIn) == 0)
            return false;

        char[] txtCharArray = TextIn.ToCharArray();

        for (int i = 0; i < Lenght(TextIn); i++)
            if (!(isLetter(txtCharArray[i])))
                return false;

        return true;
    }

    bool isLetter(char CharIn)
    {
        if (!((CharIn >= 'a') && (CharIn <= 'z') || (CharIn >= 'A') && (CharIn <= 'Z')))
            return false;

        return true;
    }

    bool onlyAlphanumeric(string TextIn)
    {
        if (Lenght(TextIn) == 0)
            return false;

        char[] txtCharArray = TextIn.ToCharArray();

        for (int i = 0; i < Lenght(TextIn); i++)
            if (!(isLetter(txtCharArray[i]) || (txtCharArray[i] >= '1') && (txtCharArray[i] <= '9')))
                return false;

        return true;
    }

    bool txtPalindrome(string TextIn)
    {
        if (Lenght(TextIn) == 0) 
            return false;

        if (splittedWord(txtLower(TextIn)) == splittedWord(txtLower(txtReverse(TextIn))))
            return true;

        return false;
    }

    string txtCapitalized(string TextIn)
    { 
        char[] txtCharArray = txtLower(TextIn).ToCharArray();

        if ((Lenght(TextIn) != 0) && (txtCharArray[0] >= 'a') && (txtCharArray[0] <= 'z')) {
            int charInt = (int)txtCharArray[0] & 0x5f;
            txtCharArray[0] = (char)charInt;
        }

        for (int i = 0; i < Lenght(TextIn) - 1; i++)
            if (((txtCharArray[i + 1] >= 'a') && (txtCharArray[i + 1] <= 'z')) && txtCharArray[i] == ' '){ 
                int charInt = (int)txtCharArray[i+1] & 0x5f;
                txtCharArray[i+1] = (char)charInt;
            }
        return new string(txtCharArray); 
    }

    string splittedWord(string TextIn) 
    {
        int j = 0;
        int count = 0;
        char[] txtCharArray = TextIn.ToCharArray();
        
        for (int i = 0; i < Lenght(TextIn); i++)
            if (txtCharArray[i] != ' ')
                count++;

        char[] SplittedArray = new char[count];

        for (int i = 0; i < Lenght(TextIn); i++)
        
            if (txtCharArray[i] != ' ') { 
                SplittedArray[j] = txtCharArray[i];
                j++;
            }
        return new string(SplittedArray);
    }

    private void StringBnt(object sender, EventArgs e)
    {
        StringOut.Text =
            $"Maiuscolo: {txtUpper(StringIn.Text)} \n" +
            $"Minuscolo {txtLower(StringIn.Text)} \n" +
            $"Capitalized: {txtCapitalized(StringIn.Text)} \n" +
            $"Contiene solo lettere? {onlyAlphabet(StringIn.Text)} \n" +
            $"Contiene solo lettere e numeri? {onlyAlphanumeric(StringIn.Text)} \n" +
            $"E' palidroma? {txtPalindrome(StringIn.Text)} \n" +
            $"Reverse: {txtReverse(StringIn.Text)} \n" +
            $"Quante lettere: {qtbLetter(StringIn.Text)} \n" +
            $"Quante parole: {qtbWord(StringIn.Text)} \n";
    }
}

