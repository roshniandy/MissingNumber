

namespace FindMissingNumber.FindMissing
{
    public class FindMissingNumberSum : IFindMissingNumber
    {
        public int GetMissingNumber(int[] arr)
        {
            try
            {
                int n = arr.Length;
                if (n == 0)
                    throw new ArgumentException("Input array cannot be empty.");
                if (arr.Any(x => x < 0) || arr.Any(x => x > n))
                {
                    throw new ArgumentOutOfRangeException($"Number in the array is outside the range 0 to {n}");
                }
                int sum = arr.Sum();
                long expSum = (long)n * (n + 1) / 2;
                return (int)(expSum - sum);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
