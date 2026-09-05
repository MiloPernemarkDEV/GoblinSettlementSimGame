public static class Containers
{
   public static int GetIndexOfLowestValue(float[] arr)
   {
      float value = float.PositiveInfinity;
      int index = -1;
      for(int i = 0; i < arr.Length; i++)
      {
         if(arr[i] < value)
         {
            index = i;
            value = arr[i];
         }
      }
      return index;
   }
}
