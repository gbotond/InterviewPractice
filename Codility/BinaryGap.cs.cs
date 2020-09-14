class Solution 
{ 
    public int Solution(int N)
    {
        string binary = Convert.ToString(N, 2);
        int length = binary.Length;
        int currentMax = 0, currentCount = 0;
        for (int i = 0; i < length; i++)
        {
            if (binary[i] == '0')
            {
                currentCount++;
            }
            else
            {
                currentMax = currentCount > currentMax ? currentCount : currentMax;
                currentCount = 0;
            }
        }

        return currentMax;
    }
}