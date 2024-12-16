string Number1 = Console.ReadLine();
double a = Convert.ToDouble(Number1);
string Number2 = Console.ReadLine();
double b = Convert.ToDouble(Number2);
string Number3 = Console.ReadLine();
double c = Convert.ToDouble(Number3);
double determine = b * b - 4 * a * c;
if (determine >0) 
{
    double X1 = (-b + Math.Sqrt(determine)) / (2 * a);
    double X2 = (-b - Math.Sqrt(determine)) / (2 * a);
    Console.WriteLine($" javabe aval shoma: {X1} , javabe dovome shoma: {X2}");
}
else if (determine == 0) { 
    double X = -b / (2 * a);
    Console.WriteLine($"javabe X shoma barabare: {X}");
}
else
{
    Console.WriteLine("rahe hali vojod nadarad");
}