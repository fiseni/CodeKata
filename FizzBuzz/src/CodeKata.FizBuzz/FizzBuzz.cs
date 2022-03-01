namespace CodeKata.FizzBuzz
{
    public class FizzBuzz
    {
        public string FormatNumber(int candidate)
        {
            string output = string.Empty;

            if (candidate % 3 == 0)
            {
                output += "Fizz";
            }

            if (candidate % 5 == 0)
            {
                output += "Buzz";
            }

            if (string.IsNullOrEmpty(output))
            {
                output = candidate.ToString();
            }

            return output;
        }

        public string FormatNumber_Original(int candidate)
        {
            if (candidate % 3 == 0 && candidate % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (candidate % 3 == 0)
            {
                return "Fizz";
            }

            if (candidate % 5 == 0)
            {
                return "Buzz";
            }

            return candidate.ToString();
        }
    }
}
