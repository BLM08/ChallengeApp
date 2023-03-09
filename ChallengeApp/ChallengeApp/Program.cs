//Zadanie domowe dzień 4

string name = "Michał";
string gender = "Mężczyzna";           
int age = 23;

Console.WriteLine("Imię :" + name);
Console.WriteLine("Płeć :" + gender);
Console.WriteLine("Wiek :" + age + " lata");

if (age < 50)
{
    if (gender == "Mężczyzna" && age < 30)
    {
        Console.WriteLine("Mężczyzna poniżej 30 roku życia");
    }
    else if(name == "Michał" || age < 30)
    {
        Console.WriteLine("Michał , 23 lata");
    }
}
else if(age < 18 && gender == "Mężczyzna")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}    
