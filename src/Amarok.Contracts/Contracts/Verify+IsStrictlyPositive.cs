﻿/* MIT License
 * 
 * Copyright (c) 2020, Olaf Kober
 * https://github.com/Amarok79/Amarok.Contracts
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Amarok.Contracts
{
    internal partial class Verify
    {
        /// <summary>
        ///     Verifies that the given value is greater than zero, hence, that it is a positive number.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Zero or negative values are invalid.
        /// </exception>
        [DebuggerStepThrough]
        public static void IsStrictlyPositive(Int32 value, String paramName)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsStrictlyPositive);
        }

        /// <summary>
        ///     Verifies that the given value is greater than zero, hence, that it is a positive number.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Zero or negative values are invalid.
        /// </exception>
        [DebuggerStepThrough]
        public static void IsStrictlyPositive(Int64 value, String paramName)
        {
            if (value <= 0L)
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsStrictlyPositive);
        }

        /// <summary>
        ///     Verifies that the given value is greater than zero, hence, that it is a positive number.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Zero or negative values are invalid.
        /// </exception>
        [DebuggerStepThrough]
        public static void IsStrictlyPositive(Double value, String paramName)
        {
            if (value <= 0.0d)
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsStrictlyPositive);
        }

        /// <summary>
        ///     Verifies that the given value is greater than zero, hence, that it is a positive number.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Zero or negative values are invalid.
        /// </exception>
        [DebuggerStepThrough]
        public static void IsStrictlyPositive(TimeSpan value, String paramName)
        {
            if (value.Ticks <= 0L)
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsStrictlyPositive);
        }


        [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
        internal static partial class Debug
        {
            /// <summary>
            ///     Verifies that the given value is greater than zero, hence, that it is a positive number.
            /// </summary>
            /// 
            /// <param name="value">
            ///     The value to verify.
            /// </param>
            /// <param name="paramName">
            ///     The name of the method parameter that is verified.
            /// </param>
            /// 
            /// <exception cref="ArgumentOutOfRangeException">
            ///     Zero or negative values are invalid.
            /// </exception>
            [Conditional("DEBUG"), DebuggerStepThrough]
            public static void IsStrictlyPositive(Int32 value, String paramName)
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        paramName,
                        value,
                        ExceptionResources.ArgumentIsStrictlyPositive
                    );
                }
            }

            /// <summary>
            ///     Verifies that the given value is greater than zero, hence, that it is a positive number.
            /// </summary>
            /// 
            /// <param name="value">
            ///     The value to verify.
            /// </param>
            /// <param name="paramName">
            ///     The name of the method parameter that is verified.
            /// </param>
            /// 
            /// <exception cref="ArgumentOutOfRangeException">
            ///     Zero or negative values are invalid.
            /// </exception>
            [Conditional("DEBUG"), DebuggerStepThrough]
            public static void IsStrictlyPositive(Int64 value, String paramName)
            {
                if (value <= 0L)
                {
                    throw new ArgumentOutOfRangeException(
                        paramName,
                        value,
                        ExceptionResources.ArgumentIsStrictlyPositive
                    );
                }
            }

            /// <summary>
            ///     Verifies that the given value is greater than zero, hence, that it is a positive number.
            /// </summary>
            /// 
            /// <param name="value">
            ///     The value to verify.
            /// </param>
            /// <param name="paramName">
            ///     The name of the method parameter that is verified.
            /// </param>
            /// 
            /// <exception cref="ArgumentOutOfRangeException">
            ///     Zero or negative values are invalid.
            /// </exception>
            [Conditional("DEBUG"), DebuggerStepThrough]
            public static void IsStrictlyPositive(Double value, String paramName)
            {
                if (value <= 0.0d)
                {
                    throw new ArgumentOutOfRangeException(
                        paramName,
                        value,
                        ExceptionResources.ArgumentIsStrictlyPositive
                    );
                }
            }

            /// <summary>
            ///     Verifies that the given value is greater than zero, hence, that it is a positive number.
            /// </summary>
            /// 
            /// <param name="value">
            ///     The value to verify.
            /// </param>
            /// <param name="paramName">
            ///     The name of the method parameter that is verified.
            /// </param>
            /// 
            /// <exception cref="ArgumentOutOfRangeException">
            ///     Zero or negative values are invalid.
            /// </exception>
            [Conditional("DEBUG"), DebuggerStepThrough]
            public static void IsStrictlyPositive(TimeSpan value, String paramName)
            {
                if (value.Ticks <= 0L)
                {
                    throw new ArgumentOutOfRangeException(
                        paramName,
                        value,
                        ExceptionResources.ArgumentIsStrictlyPositive
                    );
                }
            }
        }
    }
}
