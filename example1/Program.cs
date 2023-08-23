// Вид 1

void Method1 ()
    {
    Console.WriteLine("Автор...");
    }

  Method1();  

// Вид2
void Method2 (string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст");

// Вид3
int Method3()
    {
    return DateTime.Now.Year;
    }
 int year = Method3();
 Console.WriteLine(year);


// Вид 4

string Method4 (int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i< count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);