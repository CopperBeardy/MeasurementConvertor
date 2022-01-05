using System;
using MeasurementConverters.Speed;
using Xunit;

namespace MeasurementConverters.Test;

public class SpeedTests
{
	[Theory]
	[InlineData(1, SpeedUnit.mph, SpeedUnit.mph, 1)]
	[InlineData(1, SpeedUnit.kph, SpeedUnit.kph, 1)]
	[InlineData(1, SpeedUnit.fps, SpeedUnit.fps, 1)]
	[InlineData(1, SpeedUnit.mps, SpeedUnit.mps, 1)]
	[InlineData(1, SpeedUnit.knot, SpeedUnit.knot, 1)]
	[InlineData(1, SpeedUnit.mach, SpeedUnit.mach, 1)]

	public void Convert_ToBaseUnit_Success(double amount, SpeedUnit initialUnit, SpeedUnit requiredUnit, double expected)
	{
		var result = SpeedConverter.Convert(amount, initialUnit, requiredUnit);
		Assert.IsAssignableFrom<double>(result);
		Assert.Equal(expected, Math.Round(result));
	}


}
