using static System.Console;
Clear();

WriteLine ("Первая задача. Дан массив из него нужно получить другой массив [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]");
string [] array= {"Hello", "2", "world", ":-)"};
WriteLine();
WriteLine();
WriteLine($"[ “{array[1]}”, “{array[3]}” ]");
WriteLine();
WriteLine();






WriteLine();
WriteLine ("Вторая задача. Дан массив из него нужно получить другой массив [“1234”, “1567”, “-2”, “computer science”] → [“-2”] ");
string [] array1= {"1234", "1567", "-2", "computer science"};
WriteLine();
WriteLine();
WriteLine($"[ “{array1[2]}” ]");
WriteLine();
WriteLine();





WriteLine();
WriteLine ("Третья задача. Дан массив из него нужно получить другой массив [“Russia”, “Denmark”, “Kazan”] → []");
WriteLine();
string [] array3={"Russia", "Denimark", "Kazan"};
string [] b={""};
if (array3.Length>b.Length)
{
    
    WriteLine($"[{b[0]}]");
}
