﻿namespace Paraminter.Parameters.MethodParameterFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static MethodParameterFactory Target() => new();
}