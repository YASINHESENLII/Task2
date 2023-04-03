using System.ComponentModel.Design;

int[] arr = { 1, 24 ,5,12,6,72,46,2,4};
int numbers = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] <= 9 && arr[i] >= 0)
    {
        numbers++;
    }
}
Console.WriteLine( numbers + "  reqem var");
