﻿using System;
using System.IO;

namespace Puzzle02
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines(args[0]);
            var solver = new Solver(input);

            var solution1 = solver.Solve1();
            Console.WriteLine(solution1);

            var solution2 = solver.Solve2();
            Console.WriteLine(solution2);

            Console.ReadLine();
        }
    }
}
