using System;
using System.Text;

namespace DiamondGenerator
{
    public class Diamond
    {
        public string Create(char target)
        {
            try
            {
                if (target < 'A' || target > 'Z')
                    throw new ArgumentException("Invalid input. Please provide an uppercase letter.");

                int size = target - 'A' + 1;
                var sb = new StringBuilder();

                for (int i = 0; i < size; i++)
                {
                    char currentChar = (char)('A' + i);
                    int spacesBefore = size - i - 1;

                    // Add leading spaces
                    sb.Append(' ', spacesBefore);

                    // Add characters in sequence
                    sb.Append(currentChar);

                    // Add repeated characters (except for 'A')
                    if (currentChar != 'A')
                        sb.Append(' ', 2 * i - 1).Append(currentChar);

                    // Add newline
                    sb.AppendLine();
                }

                // Add bottom half (excluding 'A')
                for (int i = size - 2; i >= 0; i--)
                {
                    char currentChar = (char)('A' + i);
                    int spacesBefore = size - i - 1;

                    // Add leading spaces
                    sb.Append(' ', spacesBefore);

                    // Add characters in sequence
                    sb.Append(currentChar);

                    // Add repeated characters (except for 'A')
                    if (currentChar != 'A')
                        sb.Append(' ', 2 * i - 1).Append(currentChar);

                    // Add newline
                    if (i > 0)
                        sb.AppendLine();
                }

                return sb.ToString();
            }
            catch (ArgumentException ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}



