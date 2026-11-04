// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using Microsoft.TestCommon;

namespace System.Web.Mvc.Test
{
    [Xunit.Collection("Uses ScopeStorage or ViewEngines.Engines")] // webForCore: reads the static ValueProviderFactories.Factories, which ControllerBaseTest in this collection clears (xforcore/webForCore#114)
    public class ValueProviderFactoriesTest
    {
        [Fact]
        public void CollectionDefaults()
        {
            // Arrange
            Type[] expectedTypes = new[]
            {
                typeof(ChildActionValueProviderFactory),
                typeof(FormValueProviderFactory),
                typeof(JsonValueProviderFactory),
                typeof(RouteDataValueProviderFactory),
                typeof(QueryStringValueProviderFactory),
                typeof(HttpFileCollectionValueProviderFactory),
                typeof(JQueryFormValueProviderFactory),
            };

            // Act
            Type[] actualTypes = ValueProviderFactories.Factories.Select(p => p.GetType()).ToArray();

            // Assert
            Assert.Equal(expectedTypes, actualTypes);
        }
    }
}
