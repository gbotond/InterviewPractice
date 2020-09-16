class Solution
{
    public int Solution(int x, int y, int d) 
    {
        int distance = y - x;
        int result = distance / d;
        
        if(distance % d == 0)
        {
            return result;
        }
        
        return result + 1;
    }
}