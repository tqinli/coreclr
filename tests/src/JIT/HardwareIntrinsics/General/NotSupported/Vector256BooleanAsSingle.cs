// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/******************************************************************************
 * This file is auto-generated from a template file by the GenerateTests.csx  *
 * script in tests\src\JIT\HardwareIntrinsics\General\Shared. In order to make    *
 * changes, please update the corresponding template and run according to the *
 * directions listed in the file.                                             *
 ******************************************************************************/

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace JIT.HardwareIntrinsics.General
{
    public static partial class Program
    {
        private static void Vector256BooleanAsSingle()
        {
            bool succeeded = false;

            try
            {
                Vector256<float> result = default(Vector256<bool>).AsSingle();
            }
            catch (NotSupportedException)
            {
                succeeded = true;
            }

            if (!succeeded)
            {
                TestLibrary.TestFramework.LogInformation($"Vector256BooleanAsSingle: RunNotSupportedScenario failed to throw NotSupportedException.");
                TestLibrary.TestFramework.LogInformation(string.Empty);
            }
        }
    }
}