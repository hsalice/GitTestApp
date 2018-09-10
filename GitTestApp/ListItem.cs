using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestApp
{
    class ListItem
    {
        private string part1;
        private string part2;
        private string part3;

        public string Part1 { get => part1; set => part1 = value; }
        public string Part2 { get => part2; set => part2 = value; }
        public string Part3 { get => part3; set => part3 = value; }

        public ListItem()
        {
            Part1 = "AAA";
            Part2 = "BBB";
            Part3 = "CCC";
        }

        public ListItem(string a, string b, string c)
        {
            Part1 = a;
            Part2 = b;
            Part3 = c;
        }

        public override string ToString()
        {
            return Part1 + "," + Part2 + "," + Part3;
        }
    }
}
