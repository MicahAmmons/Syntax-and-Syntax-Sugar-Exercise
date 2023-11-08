namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Inferred typing
            var answer = 4;
            var response = "";

            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + "greater than or equal to nine";
            }
            Console.WriteLine(response);

            //string interpolation 

            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = $"{answer} is less than nine";
            }
            else
            {
                response = $"{answer} is greater than or equal to nine";
            }
            Console.WriteLine(response);

            //Ternary Operator

            int answer = 4;
            string response = (answer < 9) ? $"{answer} is less than nine." : $"Answer is greater than nine";
            Console.WriteLine(response);

        }
    }
}
