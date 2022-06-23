// See https://aka.ms/new-console-template for more information

var array = new[]{1,2,3,4,5,6,7,8,9,10,11};
var searchDigit = 2;

Console.WriteLine($"Digit index is {BinarySearch(searchDigit,array)}");
Console.ReadKey();


static int BinarySearch(int searchDigit, int[] array)
{
    int down = 0;
    int up = array.Length - 1;
    int numberOftry = 0;
    while (down <= up)
    {
        int mid = (down + up) / 2;

        if (searchDigit == array[mid])
        {
            Console.WriteLine($"Number of try:{++numberOftry}");
            return mid;
        }

        if (searchDigit < array[mid])
        {
            up = mid - 1;
        }
        else
        {
            down = mid + 1;
        }
        numberOftry++;
    }
    return -1;
}
