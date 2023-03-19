namespace Marco.Bucci._3I.MAUIString;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    int Lenght(string TextIn)
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
            if ((txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z') ||
               (txtCharArray[i] >= 'a') && (txtCharArray[i] <= 'z'))
                retVal++;

        return retVal;
    }

    string txtUpper(string TextIn)
    { 
        char[] txtCharArray = TextIn.ToCharArray();

        for(int i = 0; i < Lenght(TextIn) ; i++)
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


        for (int i = 0; i < Lenght(TextIn); i++) {
            txtCharArrayReverse[i] = (char)txtCharArray[Lenght(TextIn)-i-1];
        }

        return new string(txtCharArrayReverse);
    }

    bool onlyAlphabet(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();

        for (int i = 0; i < Lenght(TextIn); i++)
            if (!((txtCharArray[i] >= 'a') && (txtCharArray[i] <= 'z') ||
               (txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z')))
                return false;

        return true;
    }

    bool onlyAlphanumeric(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();

        for (int i = 0; i < Lenght(TextIn); i++)
            if (!((txtCharArray[i] >= 'a') && (txtCharArray[i] <= 'z') ||
               (txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z') ||
               (txtCharArray[i] >= '1') && (txtCharArray[i] <= '9')))

                return false;

        return true;
    }

    bool txtPalindrome(string TextIn) 
    {
        if (txtLower(TextIn) == txtLower(txtReverse(TextIn)))
            return true;

        return false;
    }

    private void StringBnt(object sender, EventArgs e)
    {
        //string txtCapitalized = " ";

        //for (int i = 0; i < SplittedWord.Length; i++)
        //SplittedWord[i] = SplittedWord[i].Substring(0, 1).ToUpper() + SplittedWord[i].Substring(1).ToLower();

        //txtCapitalized = String.Join(" ", SplittedWord);



        StringOut.Text =
            $"Maiuscolo: {txtUpper(StringIn.Text)} \n" +
            $"Minuscolo {txtLower(StringIn.Text)} \n" +
            //$"Capitalized: {txtCapitalized} \n" +
            $"Contiene solo lettere? {onlyAlphabet(StringIn.Text)} \n" +
            $"Contiene solo lettere e numeri? {onlyAlphanumeric(StringIn.Text)} \n" +
            $"E' palidroma? {txtPalindrome(StringIn.Text)} \n" +
            $"Reverse: {txtReverse(StringIn.Text)} \n" +
            $"Quante lettere: {qtbLetter(StringIn.Text)} \n";


    }
}

