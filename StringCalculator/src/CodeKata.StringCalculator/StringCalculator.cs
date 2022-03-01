namespace CodeKata.StringCalculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers)) return 0;

            var delimiters = new List<char>() { ',', '\n' };

            if (numbers.StartsWith("//"))
            {
                var splitedInputByNewLine = numbers.Split('\n');
                var newDelimiter = splitedInputByNewLine.First().Trim('/');
                numbers = string.Join('\n', splitedInputByNewLine.Skip(1));

                delimiters.Add(Convert.ToChar(newDelimiter));
            }

            var numberList = numbers.Split(delimiters.ToArray()).Select(s => int.Parse(s));

            var negatives = numberList.Where(n => n < 0);

            if (negatives.Any())
            {
                string negativeString = string.Join(',', negatives.Select(n => n.ToString()));
                throw new Exception($"Negatives not allowed: {negativeString}");
            }

            var result = numberList.Where(x => x <= 1000).Sum();

            return result;
        }

        public int Add_Original(string numbers)
        {
            List<int> negativeList = new List<int>();
            string exMessage = "";
            int currentNumber = 0, sum = 0;
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            var delimiters = new List<char>() { ',', '\n' };
            if (numbers.StartsWith("//"))
            {
                var splitedInputByNewLine = numbers.Split('\n');
                var newDelimiter = splitedInputByNewLine.First().Trim('/');
                numbers = String.Join('\n', splitedInputByNewLine.Skip(1));
                delimiters.Add(Convert.ToChar(newDelimiter));
            }
            var splitedInput = numbers.Split(delimiters.ToArray());
            foreach (var number in splitedInput)
            {

                if (int.TryParse(number, out currentNumber))
                {
                    if (currentNumber < 0)
                    {
                        if (string.IsNullOrEmpty(exMessage))
                        {
                            exMessage = "Negatives not allowed:";
                            exMessage += " " + currentNumber.ToString();
                        }
                        else
                        {
                            exMessage += "," + currentNumber.ToString();
                        }
                        negativeList.Add(currentNumber);
                    }
                    if (currentNumber < 1000)
                    {
                        sum += currentNumber;
                    }
                }
            }
            if (negativeList.Count > 0)
            {
                throw new Exception(exMessage);
            }
            return sum;
        }
    }
}
