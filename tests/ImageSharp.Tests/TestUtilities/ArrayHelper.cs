﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System.Linq;

namespace SixLabors.ImageSharp.Tests
{
    public static class ArrayHelper
    {
        /// <summary>
        /// Concatenates multiple arrays of the same type into one
        /// </summary>
        /// <typeparam name="T">The array type</typeparam>
        /// <param name="arrs">The arrays to concatenate. The order is kept</param>
        /// <returns>The concatenated array</returns>
        public static T[] Concat<T>(params T[][] arrs)
        {
            T[] result = new T[arrs.Sum(t => t.Length)];
            int offset = 0;
            for (int i = 0; i < arrs.Length; i++)
            {
                arrs[i].CopyTo(result, offset);
                offset += arrs[i].Length;
            }
            return result;
        }

        /// <summary>
        /// Creates an array filled with the given value
        /// </summary>
        /// <typeparam name="T">The array type</typeparam>
        /// <param name="value">The value to fill the array with</param>
        /// <param name="length">The wanted length of the array</param>
        /// <returns>The created array filled with the given value</returns>
        public static T[] Fill<T>(T value, int length)
        {
            T[] result = new T[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = value;
            }
            return result;
        }

        /// <summary>
        /// Creates a string from a character with a given length
        /// </summary>
        /// <param name="value">The character to fill the string with</param>
        /// <param name="length">The wanted length of the string</param>
        /// <returns>The filled string</returns>
        public static string Fill(char value, int length)
        {
            return "".PadRight(length, value);
        }
    }
}
