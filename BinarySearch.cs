namespace Algorithms
{
    public static class BinarySearch
    {

        public static int Binary_SearchRecursive(string[] AccNumbers, int left, int right, string inputAccNumber)
        {
           if(left <= right) {

                var middleIndex = (left + right) / 2;
                var result = inputAccNumber.CompareTo(AccNumbers[middleIndex]);

                if (result == 0)
                    return middleIndex;

                if (result > 0)
                    return Binary_SearchRecursive(AccNumbers, middleIndex + 1, right, inputAccNumber);//right search

                else
                    return Binary_SearchRecursive(AccNumbers, left, middleIndex - 1, inputAccNumber);//left search

            }
            return -1;
               
        }
    }
}
