// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System.Configuration
{

    public class SettingsPropertyWrongTypeExceptionTests
    {
        [Fact]
        public void SingleParameterExceptionReturnsExpected()
        {
            var exception = new SettingsPropertyIsReadOnlyException("ThisIsATest");
            Assert.Equal("ThisIsATest", exception.Message);
        }

        [Fact]
        public void ExceptionWithInnerExceptionExceptionReturnsExpected()
        {
            var exception = new SettingsPropertyIsReadOnlyException("ThisIsATest", new AggregateException("AlsoATest"));
            Assert.Equal("ThisIsATest", exception.Message);
            Assert.Equal("AlsoATest", exception.InnerException.Message);
            Assert.IsType<AggregateException>(exception.InnerException);
        }

        [Fact]
        public void ExceptionEmptyConstructorReturnsExpected()
        {
            var exception = new SettingsPropertyIsReadOnlyException();
            Assert.IsType<SettingsPropertyIsReadOnlyException>(exception);
        }
    }
}
