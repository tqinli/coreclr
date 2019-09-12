// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using TestLibrary;

namespace SafeHandleTests
{
    public class ReliableUnmarshalTest
    {
        public static void RunTest()
        {
            // Test that our SafeHandle-derived object has its underlying handle set after a P/Invoke
            // even if there's an exception during the unmarshal phase.
            IntPtr value = (IntPtr)123;
            TestSafeHandle h = new TestSafeHandle();

            Assert.Throws<InvalidOperationException>(() => SafeHandleNative.GetHandleAndCookie(value, out h, out var cookie));

            Assert.AreEqual(value, h.DangerousGetHandle());
        }
    }
}