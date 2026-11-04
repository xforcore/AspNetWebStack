// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Web.Mvc;
using Microsoft.TestCommon;

namespace Microsoft.Web.Test
{
    public class VersionTest
    {
        [Fact]
        public void VerifyMVCVersionChangesAreIntentional()
        {
            Version mvcVersion = VersionTestHelper.GetVersionFromAssembly("System.Web.Mvc", typeof(Controller));
            // webForCore: the released MVC 5.3.0's version, which webForCore's System.Web.Mvc has, as Microsoft's builds stamped
            // it in place of this source's development version (5.3.1.0), so libraries built against Microsoft's bind (#141).
            Assert.Equal(new Version(5, 3, 0, 0), mvcVersion);
        }
    }
}
