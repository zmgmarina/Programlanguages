//поменять в тексте маленькую букву к на большую К
string Replace(string text, char oldValue, char newValue)  //char - 1 символ  string - множество символов  
// используем char для экономии памяти 
{
    string result = String.Empty;  // String.Empty  - так записывается пустая строчка

    int length = text.length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
    
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(next, 'k', 'K');
Console.WriteLine(newText);

