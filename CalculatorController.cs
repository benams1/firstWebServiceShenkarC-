using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace online_calculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        // GET api/calculator/GetFiveRandomNumbers
        [HttpGet("GetFiveRandomNumbers")]
        public List<int> GetFiveRandomNumbers()
        {
            var numbers = new List<int>();
            var rnd = new Random();
            int count = 0;

            while (count < 5)
            {
                int newNum = rnd.Next(1, 21); // generate a random number between 1- 20

                if (!numbers.Contains(newNum))
                {
                    numbers.Add(newNum);
                    count++;
                }
            }

            return numbers;
        }

        // GET api/calculator/ex14
        [HttpGet("ex14")]
        public int[] ex14(int number)
        {
            if(number > 9999 || number < 1000)
            {
                //handle error
                var rnd = new Random();
                number = rnd.Next(1000, 10000);
            }
            var digits = number.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            return digits;
        }

        // GET api/calculator/ex15
        [HttpGet("ex15")]
        public int ex15(int num1, int num2, int num3)
        {
            return Math.Max(num1, Math.Max(num2, num3));
        }


        // GET api/calculator/ex16
        [HttpGet("ex16")]
        public int ex16(int num1, int num2, int num3)
        {
            return Math.Min(num1, Math.Min(num2, num3));
        }


        // GET api/calculator/ex17
        [HttpGet("ex17")]
        public String ex17(int pos,String str)
        {
            if(pos < 0 || pos > str.Length)
            {
                var rnd = new Random();
                pos = rnd.Next(1, str.Length);
            }
            return str.Insert(pos, pos.ToString());
        }
        // GET api/calculator/ex12
        [HttpGet("ex20")]
        public String ex20(int numOfAsterisk)
        {
            String asterisks = "";
            for (int i = 0 ;i < numOfAsterisk ; ++i)
            {
                asterisks += "*";
            }
            return asterisks;
        }

    }
}
