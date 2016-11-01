using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrailProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            generateJudgeID();
        }

        private static void generateJudgeID()
        {
            string zeroes;
            string letterseq = generateChar();
            string numberseq = generateNumber();
            string judgeID;
            if (numberseq.Length == 1)
            {
                zeroes = "00";
                numberseq = zeroes + numberseq;
                judgeID = letterseq + "-" + numberseq;

            }
            else if (numberseq.Length == 2)
            {
                zeroes = "0";
                numberseq = zeroes + numberseq;
                judgeID = letterseq + "-" + numberseq;
            }
            else
            {
                judgeID = letterseq + "-" + numberseq;
            }
            Console.WriteLine(judgeID);
            Console.ReadLine();
        }
        private static string generateChar()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, 2)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private static string generateNumber()
        {
            return rand.Next(0,999).ToString();
        }
        private static Random random = new Random();
        private static Random rand = new Random();
    }
}

