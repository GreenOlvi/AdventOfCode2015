﻿using NUnit.Framework;
using FluentAssertions;
using Puzzle07;

namespace Puzzle07Tests
{
    [TestFixture]
    public class SolverTests
    {
        [Test]
        public void Solve1Example1Test()
        {
            new Solver("abba[mnop]qrst").Solve1().Should().Be(1);
        }

        [Test]
        public void Solve1Example2Test()
        {
            new Solver("abcd[bddb]xyyx").Solve1().Should().Be(0);
        }

        [Test]
        public void Solve1Example3Test()
        {
            new Solver("aaaa[qwer]tyui").Solve1().Should().Be(0);
        }

        [Test]
        public void Solve1Example4Test()
        {
            new Solver("ioxxoj[asdfgh]zxcvbn").Solve1().Should().Be(1);
        }

        [Test]
        public void Solve1ExampleSumTest()
        {
            new Solver(
                "abba[mnop]qrst",
                "abcd[bddb]xyyx",
                "aaaa[qwer]tyui",
                "ioxxoj[asdfgh]zxcvbn"
            ).Solve1().Should().Be(2);
        }

        [Test]
        public void Solve2Example1Test()
        {
            new Solver("aba[bab]xyz").Solve2().Should().Be(1);
        }

        [Test]
        public void Solve2Example2Test()
        {
            new Solver("xyx[xyx]xyx").Solve2().Should().Be(0);
        }

        [Test]
        public void Solve2Example3Test()
        {
            new Solver("aaa[kek]eke").Solve2().Should().Be(1);
        }

        [Test]
        public void Solve2Example4Test()
        {
            new Solver("zazbz[bzb]cdb").Solve2().Should().Be(1);
        }

        [Test]
        public void Solve2ExampleSumTest()
        {
            new Solver(
                "aba[bab]xyz",
                "xyx[xyx]xyx",
                "aaa[kek]eke",
                "zazbz[bzb]cdb"
            ).Solve2().Should().Be(3);
        }
    }
}
