int[] array = {4, 45, 78, 65, 80, 99, 49, 0, 80, 1, 3};

int n = array.Length;
int find = 80;

int index = 0;

while(index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index+1;
}