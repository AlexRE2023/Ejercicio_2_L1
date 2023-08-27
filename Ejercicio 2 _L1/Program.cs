Console.WriteLine("Hello, World!");
Console.WriteLine("Ingrese los minutos");
int totalminutos = int.Parse(Console.ReadLine());

int horas = totalminutos / 60;
int minutos = totalminutos % 60;

Console.WriteLine(horas + " horas y " + minutos + " minutos");