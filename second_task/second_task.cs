int lines = 4;
int columns = 4;
int[,] two_dim_array = new int [ lines,columns ];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= two_dim_array.GetLength(0)* two_dim_array.GetLength(1))
{
    two_dim_array[i,j] = temp;
    temp++;
    if (i <= j + 1 && i + j < two_dim_array.GetLength(1) - 1)
    j++;
    else if (i < j && i + j >= two_dim_array.GetLength(0) - 1)
    i++;
    else if (i >= j && i + j > two_dim_array.GetLength(1) - 1)
    j--;
    else
    i--;
}
void PrintTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if(array[i,j] / 10 <= 0)
            Console.Write($"0{array[i,j]} ");
            else
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}
PrintTwoDimArray(two_dim_array);

