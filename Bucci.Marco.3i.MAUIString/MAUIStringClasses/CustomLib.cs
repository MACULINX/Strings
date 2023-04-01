using System;

namespace Bucci.Marco._3i.MAUIString
{
    public class CustomLib
    {
        /*Dichiarazione della lunghezza del vettore
        (Cambia il valore di lenght cambia ogni volta che si preme
        il bottone e non ogni volta che viene chiamata)*/
        public int lenght = 0;
        public void Lenght(string TextIn)
        {
            //Converto la stringa in un char[]
            char[] txtCharArray = TextIn.ToCharArray();

            //Ciclo FOREACH per scorrere il vettore
            foreach (var c in txtCharArray)
                //Ogni volta che incontra qualcosa incrementa di 1 la lunghezza
                lenght++;

        }
        public int qtbLetter(string TextIn)
        {
            //Converto la stringa in un char[]
            char[] txtCharArray = TextIn.ToCharArray();
            //Dichiarazione variabile di ritorno
            int retVal = 0;

            //Ciclo FOR per scorrere il vettore
            for (int i = 0; i < lenght; i++)
                //Controllo che l'indice punti su una lettera
                if (isLetter(txtCharArray[i]))
                    //In caso positivo incremento retVal
                    retVal++;

            //Ritorno la quantita' di lettere presenti
            return retVal;
        }

        public int qtbWord(string TextIn)
        {
            //Converto la stringa in un char[]
            char[] txtCharArray = TextIn.ToCharArray();
            //Dichiarazione variabile di ritorno
            int retVal = 0;

            //Ciclo FOR per scorrere il vettore
            for (int i = 0; i < lenght - 1; i++)
                //Controllo che il l'indice punta su uno spazio e che il char dopo e' una lettera
                if ((isLetter(txtCharArray[i + 1])) && txtCharArray[i] == ' ')
                    //In caso positivo incremento retVal
                    retVal++;
            
            //Controllo che il primo char e' una lettera
            if (isLetter(txtCharArray[0]))
                //In caso positivo incremento retVal di 1
                retVal++;

            //Ritorno la quantita' di parole presenti
            return retVal;
        }

        public string txtUpper(string TextIn)
        {
            //Converto la stringa in un char[]
            char[] txtCharArray = TextIn.ToCharArray();

            //Ciclo FOR per scorrere il vettore
            for (int i = 0; i < lenght; i++)
                //Controllo che l'indice punti su una lettera minuscola
                if ((txtCharArray[i] >= 'a') && (txtCharArray[i] <= 'z'))
                {
                    //In caso positivo la rendo maiuscola con un AND
                    int charInt = (int)txtCharArray[i] & 0x5f;
                    txtCharArray[i] = (char)charInt;
                }

            //Ritorno la stringa maiuscola
            return new string(txtCharArray);
        }

        public string txtLower(string TextIn)
        {
            //Converto la stringa in un char[]
            char[] txtCharArray = TextIn.ToCharArray();

            //Ciclo FOR per scorrere il vettore
            for (int i = 0; i < lenght; i++)
                //Controllo che l'indice punti su una lettera maiuscola
                if ((txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z'))
                {
                    //In caso positivo la rendo minuscola con un OR
                    int cInt = (int)txtCharArray[i] | 0x20;
                    txtCharArray[i] = (char)cInt;

                }

            //Ritorno la stringa minuscola
            return new string(txtCharArray);
        }

        public string txtReverse(string TextIn)
        {
            //Converto la stringa in un char[]
            char[] txtCharArray = TextIn.ToCharArray();
            //Creo un vettore con la stessa lunghezza del primo char[]
            char[] txtCharArrayReverse = new char[lenght];

            //Ciclo FOR per scorrere il vettore
            for (int i = 0; i < lenght; i++)
                //Inserisco alla posizione opposta il carattere del primo char[] nel secondo char[]
                txtCharArrayReverse[i] = (char)txtCharArray[lenght - i - 1];

            //Ritorno la stringa invertita
            return new string(txtCharArrayReverse);
        }

        public bool onlyAlphabet(string TextIn)
        {
            //Controllo che la lunghezza del vettore e' uguale a 0
            if (lenght == 0)
                //In caso positivo torno direttamente false
                return false;

            //Converto la stringa in un char[]
            char[] txtCharArray = TextIn.ToCharArray();

            //Ciclo FOR per scorrere il vettore
            for (int i = 0; i < lenght; i++)
                //Controllo che l'indice non punti su una lettera o su un numero
                if (!(isLetter(txtCharArray[i])))
                    //In caso positivo torno false
                    return false;

            //Torno invece true quando tutte le condizione precedenti non si avverano
            return true;
        }

        public bool isLetter(char CharIn)
        {
           //Controllo che il carattere e' una lettera
            return((CharIn >= 'a') && (CharIn <= 'z') || (CharIn >= 'A') && (CharIn <= 'Z'));
        }

        public bool isNumber(char CharIn)
        {
            //Controllo che il carattere e' un numero
            return ((CharIn >= '0') && (CharIn <= '9'));
        }

        public bool onlyAlphanumeric(string TextIn)
        {
            //Controllo che la lunghezza del vettore e' uguale a 0
            if (lenght == 0)
                //In caso positivo torno direttamente false
                return false;

            //Converto la stringa in un char[]
            char[] txtCharArray = TextIn.ToCharArray();

            //Ciclo FOR per scorrere il vettore
            for (int i = 0; i < lenght; i++)
                //Controllo che l'indice non punti su una lettera o su un numero
                if (!(isLetter(txtCharArray[i]) || isNumber(txtCharArray[i])))
                    //In caso positivo torno false
                    return false;

            //Torno invece true quando tutte le condizione precedenti non si avverano
            return true;
        }

        public bool havePuntaction(string TextIn)
        {
            //Converto la stringa in un char[]
            char[] txtCharArray = TextIn.ToCharArray();

            //Ciclo FOR per scorrere il vettore
            for (int i = 0; i < lenght; i++)
                //Controllo che l'indice non punti su una lettera, su un numero o su uno spazio
                if (!(isLetter(txtCharArray[i]) || isNumber(txtCharArray[i]) || (txtCharArray[i] == ' ')))
                    //In caso positivo torno true
                    return true;

            //Controllo che il carattere non e' ne' un numero, ne' una lettera e ne' uno spazio
            return false;
        }

        public bool txtPalindrome(string TextIn)
        {
            //Controllo che la lunghezza del vettore e' uguale a 0
            if (lenght == 0)
                return false;

            //Ritorno un booleano che mi dice la stringa e' palindroma
            return (splittedWord(txtLower(TextIn)) == splittedWord(txtLower(txtReverse(TextIn))) && !havePuntaction(TextIn));

        }

        public string txtCapitalized(string TextIn)
        {
            //Converto la stringa in un char[] e lo porto minuscolo
            char[] txtCharArray = txtLower(TextIn).ToCharArray();

            //Controllo che il primo char del vettore e' una lettera
            if ((lenght != 0) && (txtCharArray[0] >= 'a') && (txtCharArray[0] <= 'z'))
            {
                //In caso positvo porto maiuscolo SOLO il primo carattere
                int charInt = (int)txtCharArray[0] & 0x5f;
                txtCharArray[0] = (char)charInt;
            }

            //Ciclo FOR per scorrere il vettore
            for (int i = 0; i < lenght - 1; i++)
                //Controllo che il l'indice punta su uno spazio e che il char dopo e' una lettera
                if (((txtCharArray[i + 1] >= 'a') && (txtCharArray[i + 1] <= 'z')) && txtCharArray[i] == ' ')
                {
                    //In caso positivo porto maiuscola la lettera
                    int charInt = (int)txtCharArray[i + 1] & 0x5f;
                    txtCharArray[i + 1] = (char)charInt;
                }

            //Ritorno la stringa capitalizzata
            return new string(txtCharArray);
        }

        public string splittedWord(string TextIn)
        {
            //Converto la stringa in un char[]
            char[] txtCharArray = TextIn.ToCharArray();

            //Dichiaro delle variabili di lavoro
            int j = 0;
            int count = 0;

            //Ciclo FOR per scorrere il vettore
            for (int i = 0; i < lenght; i++)
                //Controllo che il char e' diverso dallo ' '
                if (txtCharArray[i] != ' ')
                    //In caso positivo incremento count
                    count++;

            //Creo un char[] grande quanto count
            char[] SplittedArray = new char[count];

            //Ciclo FOR per scorrere il vettore
            for (int i = 0; i < lenght; i++)
                //Controllo che il char del primo vettore e' diverso dallo ' '
                if (txtCharArray[i] != ' ')
                {
                    /* In caso positivo copio il carattere del primo vettore 
                     * nel secondo e incremento j di 1 */
                    SplittedArray[j] = txtCharArray[i];
                    j++;
                }

            //Ritorno la stringa senza spazi
            return new string(SplittedArray);
        }
        public string encryptedWord(string TextIn) 
        {
            //Converto la stringa in un char[]
            char[] txtCharArray = TextIn.ToCharArray();

            //Ciclo FOR per scorrere il vettore
            for (int i = 0; i < lenght; i++)
            {   
                //Faccio lo XOR per ogni carattere del vettore
                int charInt = (int)txtCharArray[i] ^ 0xAA;
                txtCharArray[i] = (char)charInt;
            }

            //Ritorno la stringa crittografata
            return new string(txtCharArray);
        }
    }

}