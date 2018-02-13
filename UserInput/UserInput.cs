using System;
using System.Text.RegularExpressions;

namespace UserInput
{
    public class TextInput
    {
        string input;

        public TextInput ()
        {
            input = string.Empty;
        }

        public virtual void Add(char c)
        {
            input += c;
        }

        public string GetValue()
        {
            return input;
        }
    }

    public class NumericInput : TextInput
    {
        string input; 

        public NumericInput ()
        {
            input = string.Empty;
        }

        public override void Add(char c)
        {
            Regex regex = new Regex(@"^\d$");
            if (regex.IsMatch(c.ToString()))
            {
                base.Add(c);
            }
        }
    }

    public class UserInput
    {
        public static void Main(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
        }
    }
}