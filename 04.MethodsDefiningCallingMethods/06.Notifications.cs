using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            string operation = string.Empty;
            string message = string.Empty;
            int code = 0;

            for (int i = 0; i < N; i++)
            {
                string result = Console.ReadLine();
                
                if (result == "success")
                {
                    Console.WriteLine(ShowSuccess(operation, message));
                }
                else if (result == "error")
                {
                    Console.WriteLine(ShowError(operation, code));
                }
            }
        }

        private static string ShowError(string operation, int code)
        {
            operation = Console.ReadLine();
            code = int.Parse(Console.ReadLine());
            string reason = string.Empty;
            string result = string.Empty;

            if (code > 0)
            {
                reason = "Invalid Client Data.";
            }
            else if (code < 0)
            {
                reason = "Internal System Failure.";
            }

            result = $@"Error: Failed to execute {operation}.
==============================
Error Code: {code}.
Reason: {reason}";
            return result;
        }

        private static string ShowSuccess(string operation, string message)
        {
            operation = Console.ReadLine();
            message = Console.ReadLine();

            string result = $@"Successfully executed {operation}.
==============================
Message: { message}.";

            return result;
        }
    }
}
