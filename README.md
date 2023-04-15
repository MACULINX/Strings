# Strings

Strings, un programma che data una stringa ti permette di avere delle informazioni riguardanti quella stringa.

## Descrizione del progretto

Realizzazione di un'app MAUI per lo studio delle stringhe in ASCII 7bit.

Senza utilizzare le classi/metodi per la manipolazione delle stringhe.

Es:
StringBuilder, ToUpper(), ToLower(), Count(), Lenght(), IsLetter(), IsNumber()

## Cosa da in output?
  
<details>
<summary>Versione maiuscola</summary>

```c#
public string txtUpper(string TextIn)
{
    char[] txtCharArray = TextIn.ToCharArray();

    for (int i = 0; i < lenght; i++)
        if ((txtCharArray[i] >= 'a') && (txtCharArray<= 'z'))
        {
            int charInt = (int)txtCharArray[i] & 0x5f;
            txtCharArray[i] = (char)charInt;
        }

    return new string(txtCharArray);
}
```

Questo metodo riceve una stringa di input, la converte in un array di caratteri e poi scorre il vettore per controllare se ci sono caratteri minuscoli. Se trova un carattere minuscolo, lo converte in maiuscolo e lo sostituisce nell'array di caratteri. Infine, restituisce la stringa con tutti i caratteri maiuscoli.

</details>

<details>
<summary>Versione minuscola</summary>

```c#
public string txtLower(string TextIn)
{
    char[] txtCharArray = TextIn.ToCharArray();

    for (int i = 0; i < lenght; i++)
        if ((txtCharArray[i] >= 'A') && (txtCharArray[i] <= 'Z'))
        {
            int cInt = (int)txtCharArray[i] | 0x20;
            txtCharArray[i] = (char)cInt;
        }

    return new string(txtCharArray);
}
```

Questo metodo riceve una stringa di input, la converte in un array di caratteri e poi scorre il vettore per controllare se ci sono caratteri maiuscoli. Se trova un carattere maiuscolo, lo converte in minuscolo e lo sostituisce nell'array di caratteri. Infine, restituisce la stringa con tutti i caratteri minuscoli.

</details>

<details>
<summary> La versione capitalized</summary>

```c#
public string txtCapitalized(string TextIn)
{
    char[] txtCharArray = txtLower(TextIn).ToCharArray();

    if ((lenght != 0) && (txtCharArray[0] >= 'a') && (txtCharArray[0] <= 'z'))
    {
        int charInt = (int)txtCharArray[0] & 0x5f;
        txtCharArray[0] = (char)charInt;
    }

    for (int i = 0; i < lenght - 1; i++)
        if (((txtCharArray[i + 1] >= 'a') && (txtCharArray[i + 1] <= 'z'))txtCharArray[i] == ' ')
        {
            int charInt = (int)txtCharArray[i + 1] & 0x5f;
            txtCharArray[i + 1] = (char)charInt;
        }

    return new string(txtCharArray);
}
```

Questo metodo riceve una stringa di input, la converte in un array di caratteri, rende tutti i caratteri minuscoli, poi modifica solo la prima lettera di ogni parola per renderla maiuscola, infine restituisce la stringa capitalizzata.

</details>

<details>
<summary> La versione crittografata</summary>

```c#
public string encryptedWord(string TextIn) 
{
    char[] txtCharArray = TextIn.ToCharArray();
  
    for (int i = 0; i < lenght; i++)
    {   
        int charInt = (int)txtCharArray[i] ^ 0xAA;
        txtCharArray[i] = (char)charInt;
    }

    return new string(txtCharArray);
}
```

Questo metodo riceve una stringa di input, la converte in un array di caratteri e poi crittografa ogni carattere usando un'operazione bitwise XOR con il valore esadecimale 0xAA (170 in decimale).

</details>

<details>
<summary> Se è palindroma</summary>

```c#
public bool txtPalindrome(string TextIn)
{
  if (lenght == 0)
    return false;

  return (splittedWord(txtLower(TextIn)) == splittedWord(txtLower(txtReverse(TextIn))) && !havePuntaction(TextIn));
}
```

Questo metodo prende in input una stringa TextIn e restituisce un valore booleano che indica se la stringa è palindroma o meno. La funzione utilizza altre funzioni definite all'interno del codice:

- "splittedWord" suddivide la stringa in parole separate da spazi;
- "txtLower" trasforma la stringa in input in minuscolo;
- "txtReverse" restituisce la stringa in input con le sue lettere in ordine inverso;
- "havePuntaction" controlla se la stringa in input contiene segni di punteggiatura

</details>

<details>
<summary>La sua versione reverse</summary>

```c#
public string txtReverse(string TextIn)
{
    char[] txtCharArray = TextIn.ToCharArray();

    for (int i = 0; i < lenght / 2; i++){
        char tmp = txtCharArray[i];
        txtCharArray[i] = txtCharArray[lenght - i - 1];
        txtCharArray[lenght - i - 1] = tmp;
    }
    
    return new string(txtCharArray);
}
```

Questo metodo prende un input una stringa TextIn come input e restituisce la stessa stringa ma con i caratteri invertiti nell'ordine. Ad esempio, la stringa "hello" diventerà "olleh".

</details>

<details>
<summary> Se contiene solo caratteri alfabetici</summary>

```c#
public bool onlyAlphabet(string TextIn)
{
    if (lenght == 0)
        return false;

    char[] txtCharArray = TextIn.ToCharArray();

    for (int i = 0; i < lenght; i++)
        if (!(isLetter(txtCharArray[i])))
            return false;

    return true;
}
```

Questo metodo prende in input una stringa e controlla se la stringa contiene solo lettere dell'alfabeto (sia maiuscole che minuscole). La funzione utilizza un'altra funzione definita all'interno del codice:

- "isLetter" controlla che il carattere è una lettera

</details>

<details>
<summary> Se contiene solo caratteri alfanumerici</summary>

```c#
public bool onlyAlphanumeric(string TextIn)
{
    if (lenght == 0)
        return false;

    char[] txtCharArray = TextIn.ToCharArray();

    for (int i = 0; i < lenght; i++)
        if (!(isLetter(txtCharArray[i]) || isNumber(txtCharArray[i])))
            return false;

    return true;
}
```

Questo metodo prende in input una stringa e controlla se la stringa contiene solo lettere dell'alfabeto (sia maiuscole che minuscole) o numeri. La funzione utilizza altre funzioni definite all'interno del codice:

- "isLetter" controlla che il carattere è una lettera;
- "isNumber" controlla che il carattere è un numero

</details>

<details>
<summary> Se è un isogromma</summary>

```c#
public bool isIsogram(string TextIn) 
{
    char[] txtCharArray = TextIn.ToCharArray();

    for (int i = 0; i < lenght - 1; i++)
        for (int j = i + 1; j < lenght; j++)
            if (txtCharArray[i] == txtCharArray[j])
                return false;

    return true;
}
```

Questo metodo prende in input una stringa e controlla se la stringa è un isogramma, ovvero una parola in cui ogni lettera appare una sola volta.
</details>

<details>
<summary> Quante lettere contiene</summary>

```c#
public int qtbLetter(string TextIn)
{
    char[] txtCharArray = TextIn.ToCharArray();

    int retVal = 0;

    for (int i = 0; i < lenght; i++)
        if (isLetter(txtCharArray[i]))
            retVal++;
            
    return retVal;
}
```

Questo metodo prende in input una stringa TextIn e conta il numero di lettere presenti al suo interno. La funzione utilizza un'altra funzione definita all'interno del codice:

- "isLetter" controlla che il carattere è una lettera

</details>

<details>
<summary> Quante parole contiene</summary>

```c#
public int qtbWord(string TextIn)
{
    char[] txtCharArray = TextIn.ToCharArray();
    int retVal = 0;

    for (int i = 0; i < lenght - 1; i++)
        if ((isLetter(txtCharArray[i + 1])) && txtCharArray[i] == ' ')
            retVal++;

    if (isLetter(txtCharArray[0]))
        retVal++;
        
    return retVal;
}
```

Questo metodo prende una stringa in input e conta il numero di parole all'interno di essa.La funzione utilizza un'altra funzione definita all'interno del codice:

- "isLetter" controlla che il carattere è una lettera

</details>
