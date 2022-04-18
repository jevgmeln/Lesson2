// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("===Uzdevums 1========================================");

Console.WriteLine("Ka Tevi Sauc?");
string myName = Console.ReadLine();
Console.WriteLine("Sveiks, " + myName);

Console.WriteLine("===Uzdevums 2========================================");

Console.WriteLine("Kads ir tavs vecums?");
int myAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nakamgad Tev Paliks " + (myAge + 1) + ", Tu esi pilngadigs");

Console.WriteLine("===Uzdevums 3========================================");

Console.WriteLine("Ievadi pirmo skaitli");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Ievadi otro skaitli");
int secondNumber = int.Parse(Console.ReadLine());

int resultMax = Math.Max(firstNumber, secondNumber);
Console.WriteLine("Max rezultats: " + resultMax);

Console.WriteLine("===Uzdevums 4========================================");
int resultMin = Math.Min(firstNumber, secondNumber);
Console.WriteLine("Min rezultats: " + resultMin);

Console.WriteLine("===Uzdevums 5========================================");
double atlikums = (double)firstNumber % secondNumber;

Console.WriteLine("Atlikms: " + atlikums);

Console.WriteLine("===Uzdevums 6========================================");

Console.WriteLine("Ludzu, ievadi skaitli");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;
Console.WriteLine("Skaitlis ir pāra skaitlis: " + isEven);

Console.WriteLine("===Uzdevums 7========================================");

Console.WriteLine("Ievadi pirmo skaitli");
int pirmais = int.Parse(Console.ReadLine());

Console.WriteLine("Ievadi otro skaitli");
int otrais = int.Parse(Console.ReadLine());

int area = pirmais * otrais;
Console.WriteLine(area);

Console.WriteLine("===Uzdevums 8========================================");

Console.WriteLine("Ievadi pirmo skaitli");
double one = double.Parse(Console.ReadLine());

Console.WriteLine("Ievadi otro skaitli");
double two = double.Parse(Console.ReadLine());

double area2 = one * two / 2;
Console.WriteLine(area2);


Console.WriteLine("===Uzdevums 9========================================");

Console.WriteLine("Ka Tevi Sauc?");
string vards = Console.ReadLine();

Console.WriteLine("Kads ir tavs vecums?");
int vecums = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sveiks {vards}, tavs vecums ir {vecums}");