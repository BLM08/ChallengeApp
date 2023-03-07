//Zadanie domowe dzień 4

string name = "Michał";
string sex = "Mężczyzna";           
int age = 23;

Console.WriteLine("Imię :" + name);
Console.WriteLine("Płeć :" + sex);
Console.WriteLine("Wiek :" + age + " lata");

if (age < 50)
{
    if (name == "Michał" && age < 30)
    {
        Console.WriteLine("Mężczyzna poniżej 30 roku życia");
    }
    else if(sex == "Mężczyzna" || age < 30)
    {
        Console.WriteLine("Michał , lat 23");
    }
}
else if(age < 30 && sex == "Mężczyzna")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}    
