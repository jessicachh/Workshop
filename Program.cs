// See https://aka.ms/new-console-template for more information
// Declare and initialize variables of various types
byte myByte = 10;
short myShort = 2000;
int myInt = 50000;
long myLong = 10000000000;
float myFloat = 3.14f;
double myDouble = 9.81;
decimal myDecimal = 123.456m;
char myChar = 'A';
bool myBool = true;

// Convert integer 42 to string
int number = 42;
string numberAsString = number.ToString();

// Convert string "3.14" to double
string piString = "3.14";
double piValue = Convert.ToDouble(piString);

// Print all variables with labels
Console.WriteLine($"byte: {myByte}");
Console.WriteLine($"short: {myShort}");
Console.WriteLine($"int: {myInt}");
Console.WriteLine($"long: {myLong}");
Console.WriteLine($"float: {myFloat}");
Console.WriteLine($"double: {myDouble}");
Console.WriteLine($"decimal: {myDecimal}");
Console.WriteLine($"char: {myChar}");
Console.WriteLine($"bool: {myBool}");
Console.WriteLine($"Integer 42 as string: {numberAsString}");
Console.WriteLine($"String \"3.14\" as double: {piValue}");