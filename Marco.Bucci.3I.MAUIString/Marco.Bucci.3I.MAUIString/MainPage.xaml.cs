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
        int QtbLetter = 0;

        foreach (char c in txtCharArray)
            if (char.IsLetter(c))
                QtbLetter++;

        return QtbLetter;
    }

    string txtUpper(string TextIn)
    { 
        char[] txtCharArray = TextIn.ToCharArray();

        for(int i = 0; i < Lenght(TextIn) ; i++)
            if (char.IsLetter(txtCharArray[i]) && (txtCharArray[i] > 97))
            {
                int cInt = (int)txtCharArray[i] & 0x5f;
                txtCharArray[i] = (char)cInt;
            }

        return new string(txtCharArray);
    }

    string txtLower(string TextIn)
    {
        char[] txtCharArray = TextIn.ToCharArray();

        for (int i = 0; i < Lenght(TextIn); i++)
            if (char.IsLetter(txtCharArray[i]) && (txtCharArray[i] < 90))
            {
                int cInt = (int)txtCharArray[i] | 0x20;
                txtCharArray[i] = (char)cInt;
                
            }

        return new string(txtCharArray);
    }
    private void StringBnt(object sender, EventArgs e)
    {
     
        string[] SplittedWord = StringIn.Text.Split(' ');
        int QtbWords = SplittedWord.Length;
        
        char[] txtCharArray = StringIn.Text.ToCharArray();

        char[] txtCharArrayRev = StringIn.Text.ToCharArray();
        Array.Reverse(txtCharArrayRev); 
        string txtReverse = new string(txtCharArrayRev);

        string txtPalindroma = "✘";
        string txtPunteggiatura = "✘";
        string txtCapitalized = " ";

        for (int i = 0; i < SplittedWord.Length; i++)
            SplittedWord[i] = SplittedWord[i].Substring(0, 1).ToUpper() + SplittedWord[i].Substring(1).ToLower();

        txtCapitalized = String.Join(" ", SplittedWord);

        if ( StringIn.Text.ToLower() == txtReverse.ToLower() )
            txtPalindroma = "✔";

        foreach (char c in txtCharArray)
            if ( char.IsPunctuation(c) || char.IsSymbol(c) )
                txtPunteggiatura = "✔";



        StringOut.Text = 
            $"Maiuscolo: {txtUpper(StringIn.Text)} \n" +
            $"Minuscolo {txtLower(StringIn.Text)} \n" +
            $"Capitalized: {txtCapitalized} \n" +
            $"E' palidroma? {txtPalindroma} \n" +
            $"Reverse: {txtReverse} \n" +
            $"Quante parole: {QtbWords} \n" +
            $"Quante lettere: {qtbLetter(StringIn.Text)} \n" +
            $"Segni di punteggiatura/simboli: {txtPunteggiatura} \n";
            


    }
}

