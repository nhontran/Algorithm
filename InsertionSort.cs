public void InsertionSort(int[] intArray)
{
	int temp, j;
	for (int i = 1; i < intArray.Length; i++)
	{
		temp = intArray[i];
		j = i - 1;

		while (j >= 0 && intArray[j] > temp)
		{
			intArray[j + 1] = intArray[j];
			j--;
		}

		intArray[j + 1] = temp;
	}
}