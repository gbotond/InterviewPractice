class Solution 
{ 
    public int Solution(int[] inputArray)
    {
        int maxPossibleValue = inputArray.Length + 1;
        int missing = maxPossibleValue;
        
        for (int i = 1; i < maxPossibleValue; i++)
        {
            missing ^= inputArray[i - 1];
            missing ^= i;
        }

        return missing;
    }
}