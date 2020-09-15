class Solution
{
    public int[] solution(int[] a, int k)
    {        
        int n = a.Length;
        int[] result = new int[n];      
        for (int i = 0; i < n; i++)
        {
            result[(i + k) % n] = a[i];
        }
        
        return result;
    }
}