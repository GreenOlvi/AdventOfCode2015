﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC2020
{
    public static class Utils
    {
        public static IEnumerable<int> ParseInts(this IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                yield return int.Parse(line);
            }
        }

        public static IEnumerable<string[]> SplitGroups(this IEnumerable<string> input)
        {
            var current = new List<string>();
            foreach (var line in input)
            {
                if (line == string.Empty && current.Any())
                {
                    yield return current.ToArray();
                    current.Clear();
                }
                else
                {
                    current.Add(line);
                }
            }

            if (current.Any())
            {
                yield return current.ToArray();
            }
        }

        public static IEnumerable<T[]> SplitGroups<T>(this IEnumerable<string> input, Func<string, T> converter)
        {
            var current = new List<T>();
            foreach (var line in input)
            {
                if (line == string.Empty && current.Any())
                {
                    yield return current.ToArray();
                    current.Clear();
                }
                else
                {
                    current.Add(converter(line));
                }
            }

            if (current.Any())
            {
                yield return current.ToArray();
            }
        }

        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this IEnumerable<(TKey, TValue)> pairs)
            where TKey : notnull
            where TValue : notnull
                => pairs.ToDictionary(p => p.Item1, p => p.Item2);
    }
}
