// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User!");

// Q1

// int[] cowData = {1, 2, 3, 4, 5, 6, 7,8, 9, 10,};
// for (int i = 0; i < cowData.Length; i++)
// {
//     Console.WriteLine("Cow in index " + i + ": " + cowData[i]);
// }

// Q2
// Console.Write("Pls input the length of the cows: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] cowData = new int [n];

// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine("Enter cow at index " + i + ": ");
//     cowData[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < cowData.Length; i++)
// {
//     Console.WriteLine("Cow in index " + i + ": " + cowData[i]);
// }

// n----> Length of Array

// Q3
// Console.Write("Input the length chicks : "); //Input Arry L
// int n = Convert.ToInt32(Console.ReadLine()); // conversion of L

// int[] chicks = new int [n];
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine("Enter chicks index " + i + ": ");
//     chicks[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < chicks.Length; i++)
// {
//     Console.WriteLine("chick in index " + i + ": " + chicks[i]);
// }
// foreach (var chick in chicks) 
// {
//     Console.Write($"\t {chick}");
// 

// Q4
// Console.WriteLine("input the lenght of Rabit Cage");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// int[] rabbits = new int[n];
// for (int k = 0; k < n; k++) 
// {
//     Console.WriteLine("Enter Rabbit no respect with  index " + k + ": ");
//     rabbits[k] =Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < rabbits.Length; i++)
// {
//     // sum += rabbits[k];
//     Console.WriteLine("rabbits no in index " + i + ": " + rabbits[i]);
//     sum += rabbits[i];
// }
// Console.WriteLine("Sum of Rabbits stored in the rabbit cage is : " + sum);

// Q5
// Console.WriteLine("Input length of Sockets");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] socket = new int [n];
// for (int s = 0; s < n; s++) {
//     Console.WriteLine("Enter no of socket with index " + s + ": ");
//     socket[s] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i <socket.Length; i++) {
//     Console.WriteLine("sockets no in index " + i + " " + socket[i]);
// }

// foreach(var socketbox in socket) {
//     Console.WriteLine(socketbox);
// }

// Q6
// Console.WriteLine("input the length of basket in car");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] baskets = new int[n];
// for (int b = 0; b < n; b++) {
//     Console.WriteLine("Enter baskets no with index " + b + ": ");
//     baskets[b] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < baskets.Length; i++) {
//     Console.WriteLine("basket no in index " + i + " " + baskets[i]);
// }

// Console.WriteLine("The unique element found inthe array are : " + baskets[1]);

// MATRICES
Console.Write("Enter the no of the rows");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the no of the columns");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [rows, cols];

Console.WriteLine("Enter the cells of the matrix: ");
for (int row = 0; row < rows; row++) 
{
    for (int col = 0; col < cols; col++) 
    {
        Console.Write("matrix[{0},{1}] = ", row, col);
        matrix[row, col] = Convert.ToInt32(Console.ReadLine());
    }
}
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(" " + matrix[row, col]);
    }
    Console.WriteLine();
}