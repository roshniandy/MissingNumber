
namespace FindMissingNumber.FindMissing
{
    public class FindMissingNumberXor : IFindMissingNumber
    {
        public int GetMissingNumber(int[] arr)
        {
            try
            {
                int n = arr.Length;
                int xor = 0;

                if (n == 0)
                    throw new ArgumentException("Input array cannot be empty.");
                if (arr.Any(x => x < 0) || arr.Any(x => x > n))
                {
                    throw new ArgumentOutOfRangeException($"Number in the array is outside the range 0 to {n}");
                }

                for (int i = 0; i <= n; i++)
                {
                    xor ^= i;
                }

                foreach (var num in arr)
                {
                    xor ^= num;
                }

                return xor;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
