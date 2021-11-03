// int [] array = {1, 42, 31, 14, 18, 35, 26, 71, 18};

// int n = array.Length;
// int find = 18;

// int index = 0;

// while (index<n)
// {
//     if (array [index]==find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];

FillArray(array);
array[4]=4;
array[7]=4;

PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 44);
Console.WriteLine(pos);


