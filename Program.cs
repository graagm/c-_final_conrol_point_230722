void NewRandomArray(string [] msStart)
{
    int N = msStart.Length;
    string s = string.Empty;

    for(int i=0; i<N; i++)
    {
        int counts_of_symbols = new Random().Next(2, 9);
        for(int j=0; j<counts_of_symbols; j++)
        {  
            int ch_Ascii = new Random().Next(32, 123);
            char c = Convert.ToChar(ch_Ascii); 
            s += c;
        }
        msStart[i] = s;
        s = string.Empty;
    }

}

void PrintedArray(string [] ms)
{
    int N = ms.Length;

    if (N == 0)
    {
        Console.WriteLine("Массив ну СОВСЕМ пуст");
        return;
    }
    Console.WriteLine("Список подходящих элементов массива");
    for(int i=0; i<N; i++)
    {
        Console.WriteLine($"{i+1}: {ms[i]}");
    }
}

int X = new Random().Next(10, 14);
string [] msGlobal = new string [X];
NewRandomArray(msGlobal);

string [] ms_final = new string[0];
int index = 0;
while(index < msGlobal.Length)
{
    if (msGlobal[index].Length <= 3)
    {
        Array.Resize(ref ms_final, ms_final.Length + 1);
        ms_final[ms_final.Length - 1] = msGlobal[index];

    }

    index++;
}

PrintedArray(ms_final);
