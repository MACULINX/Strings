namespace Bucci.Marco._3i.MAUIString;

public partial class MainPage : ContentPage
{
    

    public MainPage()
    {
        InitializeComponent();
    }


    public void StringBtn(object sender, EventArgs e)
    {
        CustomLib StringLib = new CustomLib();

        StringLib.Lenght(StringIn.Text);

        StringOut.Text =
            $"Maiuscolo: {StringLib.txtUpper(StringIn.Text)} \n" +
            $"Minuscolo {StringLib.txtLower(StringIn.Text)} \n" +
            $"Capitalized: {StringLib.txtCapitalized(StringIn.Text)} \n" +
            $"Stringa crittografata: {StringLib.encryptedWord(StringIn.Text)} \n" +
            $"E' palidroma? {StringLib.txtPalindrome(StringIn.Text)} \n" +
            $"Reverse: {StringLib.txtReverse(StringIn.Text)} \n" +
            $"Contiene solo lettere? {StringLib.onlyAlphabet(StringIn.Text)} \n" +
            $"Contiene solo lettere e numeri? {StringLib.onlyAlphanumeric(StringIn.Text)} \n" +
            $"Quante lettere: {StringLib.qtbLetter(StringIn.Text)} \n" +
            $"Quante parole: {StringLib.qtbWord(StringIn.Text)} \n";

    }
}
