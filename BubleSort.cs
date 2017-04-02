//Buble sort
private static void Sort(List<int> list)
 {
    int size = list.Capacity;
    for (int i = 1; i < size; i++)
    {
         for (int j = 0; j < (size - i); j++)
         {
           if (list[j] > list[j+1])
           {
              int temp = list[j];
              list[j] = list[j+1];
              list[j+1] = temp;
            }
         }
    }
}