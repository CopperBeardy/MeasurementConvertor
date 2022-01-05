using System;
using MeasurementConverters.Length;
using Xunit;

namespace MeasurementConverters.Test;

public class LengthTests
{
	[Theory]
	[InlineData(1, LengthUnit.cm, LengthUnit.cm, 1)]
	[InlineData(1, LengthUnit.m, LengthUnit.m, 1)]
	[InlineData(1, LengthUnit.inch, LengthUnit.inch, 1)]
	[InlineData(1, LengthUnit.yard, LengthUnit.yard, 1)]
	[InlineData(1, LengthUnit.ft, LengthUnit.ft, 1)]
	[InlineData(1, LengthUnit.km, LengthUnit.km, 1)]
	[InlineData(1, LengthUnit.dm, LengthUnit.dm, 1)]
	[InlineData(1, LengthUnit.mm, LengthUnit.mm, 1)]
	[InlineData(1, LengthUnit.μ, LengthUnit.μ, 1)]
	[InlineData(1, LengthUnit.mi, LengthUnit.mi, 1)]
	[InlineData(1, LengthUnit.NM, LengthUnit.NM, 1)]

	public void Convert_ToBaseUnit_Success(double amount, LengthUnit initialUnit, LengthUnit requiredUnit, double expected)
	{
		var result = LengthConverter.Convert(amount, initialUnit, requiredUnit);
		Assert.IsAssignableFrom<double>(result);
		Assert.Equal(expected, Math.Round(result));
	}


}
