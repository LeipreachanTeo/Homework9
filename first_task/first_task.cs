int rdm_lines = new Random().Next(2,6);
int rdm_columns = new Random().Next(2,6);
int[,] two_dim_array = new int [ rdm_lines,rdm_columns ];

void FillTwoDimArrayRDM(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }   
}
void PrintTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
    Console.WriteLine();
    }
}
void SorterDescendingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for ( int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i,k] < array[i,k+1])
                {
                    int temp = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1]= temp;
                }
            }
        }
    }
}

FillTwoDimArrayRDM(two_dim_array);
PrintTwoDimArray(two_dim_array);
Console.WriteLine();
SorterDescendingArray(two_dim_array);
PrintTwoDimArray(two_dim_array);

