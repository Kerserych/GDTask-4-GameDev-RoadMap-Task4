string outt = Magic("Hello world",2);
Console.WriteLine(outt);


string Magic(string inpt_str, int rule)
{
    string magic_string = string.Empty;
    if (rule > 255) { rule -= 255; }
    for (int i = 0; i < inpt_str.Length; i++)
    {
        magic_string += (char)((int)inpt_str[i] + rule);
    }
    return magic_string;
}