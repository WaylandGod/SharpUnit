﻿/**
 * @file Assert.cs
 * 
 * Static assertion methods for verifying test expectations.
 * Each test throws a TestException if it fails.
 */

using System;

namespace SharpUnit
{
    public class Assert
    {
        // Members
        private static Exception ms_expectedEx = null;  // The expected exception.

        /**
         * Property to get/set the exception we are expecting.
         */
        public static Exception ExpectedException
        {
            get { return ms_expectedEx; }
            set { ms_expectedEx = value; }
        }

        /**
         * Set the exception that is expected to be triggered by a unit test case.
         *
         * @param Exception ex, the expection to expect.
         */
        public static void ExpectException(Exception ex)
        {
            ms_expectedEx = ex;
        }

        /**
         * Throw an exception if the boolean expression is not true.
         * 
         * @param bool boolean, the expression to test.
         */
        public static void True(bool boolean)
        {
            True(boolean, "Expected True, got False.");
        }

        /**
         * Throw an exception if the boolean expression is not true.
         * 
         * @param bool boolean, boolean expression to evaluate.
         * @param string msg, error message to display if test fails.
         */
        public static void True(bool boolean, string msg)
        {
            // If not true
            if (true != boolean)
            {
                // Test failed
                throw new TestException(msg);
            }
        }

        /**
         * Throw an exception if the boolean expression is not false.
         * 
         * @param bool boolean, the expression to test.
         */
        public static void False(bool boolean)
        {
            False(boolean, "Expected False, got True.");
        }

        /**
         * Throw an exception if the boolean expression is not false.
         * 
         * @param bool boolean, boolean expression to evaluate.
         * @param string msg, error message to display if test fails.
         */
        public static void False(bool boolean, string msg)
        {
            // If not false
            if (false != boolean)
            {
                // Test failed
                throw new TestException(msg);
            }
        }

        /**
         * Throw an exception if the object is not null.
         * 
         * @param Object obj, the object to test.
         */
        public static void Null(Object obj)
        {
            Null(obj, "Expected Null object, got " + obj);
        }

        /**
         * Throw an exception if the object is not null.
         * 
         * @param Object obj, the object to test.
         * @param string msg, error message to display if test fails.
         */
        public static void Null(Object obj, string msg)
        {
            // If not null
            if (null != obj)
            {
                // Test failed
                throw new TestException(msg);
            }
        }

        /**
         * Throw an exception if the object is null.
         * 
         * @param Object obj, the object to test.
         */
        public static void NotNull(Object obj)
        {
            NotNull(obj, "The object is null.");
        }

        /**
         * Throw an exception if the object is null.
         * 
         * @param Object obj, the object to test.
         * @param string msg, error message to display if test fails.
         */
        public static void NotNull(Object obj, string msg)
        {
            // If null
            if (null == obj)
            {
                // Test failed
                throw new TestException(msg);
            }
        }

        /**
         * Throw an exception if the two integers are not not equal.
         * 
         * @param int wanted, the value we expected.
         * @param int got, the value we actually received.
         */
        public static void Equal(int wanted, int got)
        {
            // If values not equal
            if (wanted != got)
            {
                // Test failed
                throw new TestException("Expected " + wanted + ", Got " + got);
            }
        }

        /**
         * Throw an exception if the two integers are not not equal.
         * 
         * @param int wanted, the value we expected.
         * @param int got, the value we actually received.
         * @param string msg, error message to display if test fails.
         */
        public static void Equal(int wanted, int got, string msg)
        {
            // If values not equal
            if (wanted != got)
            {
                // Test failed
                throw new TestException(msg);
            }
        }

        /**
         * Throw an exception if the two floats are not not equal.
         * NOTE: Comparing two floats for exact equality is never accurate unless
         *       you take into account error tolerances. It may be wiser to test
         *       the expected ranges of floats using the greater-than / less-than operators.
         *       See:
         *              http://www.cygnus-software.com/papers/comparingfloats/comparingfloats.htm
         *              http://realtimecollisiondetection.net/blog/?p=89
         * 
         * @param float wanted, the value we expected.
         * @param float got, the value we actually received.
         */
        public static void Equal(float wanted, float got)
        {
            // If values not equal
            if (wanted != got)
            {
                // Test failed
                throw new TestException("Expected " + wanted + ", Got " + got);
            }
        }

        /**
         * Throw an exception if the two floats are not not equal.
         * NOTE: Comparing two floats for exact equality is never accurate unless
         *       you take into account error tolerances. It may be wiser to test
         *       the expected ranges of floats using the greater-than / less-than operators.
         *       See:
         *              http://www.cygnus-software.com/papers/comparingfloats/comparingfloats.htm
         *              http://realtimecollisiondetection.net/blog/?p=89
         * 
         * @param float wanted, the value we expected.
         * @param float got, the value we actually received.
         * @param string msg, error message to display if test fails.
         */
        public static void Equal(float wanted, float got, string msg)
        {
            // If values not equal
            if (wanted != got)
            {
                // Test failed
                throw new TestException(msg);
            }
        }

        /**
         * Throw an exception if the two strings are not not equal.
         * 
         * @param string wanted, the value we expected.
         * @param string got, the value we actually received.
         */
        public static void Equal(string wanted, string got)
        {
            // If values not equal
            if (wanted != got)
            {
                // Test failed
                throw new TestException("Expected " + wanted + ", Got " + got);
            }
        }

        /**
         * Throw an exception if the two strings are not not equal.
         * 
         * @param string wanted, the value we expected.
         * @param string got, the value we actually received.
         * @param string msg, error message to display if test fails.
         */
        public static void Equal(string wanted, string got, string msg)
        {
            // If values not equal
            if (wanted != got)
            {
                // Test failed
                throw new TestException(msg);
            }
        }

        /**
         * Throw an exception if the two bools are not not equal.
         * 
         * @param bool wanted, the value we expected.
         * @param bool got, the value we actually received.
         */
        public static void Equal(bool wanted, bool got)
        {
            // If values not equal
            if (wanted != got)
            {
                // Test failed
                throw new TestException("Expected " + wanted + ", Got " + got);
            }
        }

        /**
         * Throw an exception if the two bools are not not equal.
         * 
         * @param bool wanted, the value we expected.
         * @param bool got, the value we actually received.
         * @param string msg, error message to display if test fails.
         */
        public static void Equal(bool wanted, bool got, string msg)
        {
            // If values not equal
            if (wanted != got)
            {
                // Test failed
                throw new TestException(msg);
            }
        }

        /**
         * Throw an exception if the exceptions do not match.
         * NOTE: We only test the type and message of the exceptions.
         * 
         * @param Exception wanted, the exception we expected.
         * @param Exception got, the exception we actually caught.
         */
        public static void Equal(Exception wanted, Exception got)
        {
            Equal(wanted, got, "Exceptions do not match.\n\tExpected " + wanted + ",\n\tGot " + got);
        }

        /**
         * Throw an exception if the exceptions do not match.
         * NOTE: We only test the type and message of the exceptions.
         * 
         * @param Exception wanted, the exception we expected.
         * @param Exception got, the exception we actually caught.
         * @param string msg, error message to display if test fails.
         */
        public static void Equal(Exception wanted, Exception got, string msg)
        {
            // If types not equal
            if (wanted.GetType() != got.GetType())
            {
                // Test failed
                throw new TestException(msg);
            }

            // If the messages do not match
            if (wanted.Message != got.Message)
            {
                // Test failed
                throw new TestException(msg);
            }
        }

        /**
         * Throw an exception if the two objects are not not equal.
         * 
         * @param object wanted, the value we expected.
         * @param object got, the value we actually received.
         */
        public static void Equal(Object wanted, Object got)
        {
            // If values not equal
            if (wanted != got)
            {
                // Test failed
                throw new TestException("Expected " + wanted + ", Got " + got);
            }
        }

        /**
         * Throw an exception if the two objects are not not equal.
         * 
         * @param object wanted, the value we expected.
         * @param object got, the value we actually received.
         * @param string msg, error message to display if test fails.
         */
        public static void Equal(Object wanted, Object got, string msg)
        {
            // If values not equal
            if (wanted != got)
            {
                // Test failed
                throw new TestException(msg);
            }
        }
    }
}
