using System;
using MeasurementConverters.Temperature;
using Xunit;

namespace MeasurementConverters.Test;

public class TemperatureTests
{
	[Theory]
	[InlineData(1, TemperatureUnit.C, TemperatureUnit.C, 1)]
	[InlineData(1, TemperatureUnit.K, TemperatureUnit.K, 1)]
	[InlineData(1, TemperatureUnit.F, TemperatureUnit.F, 1)]
	[InlineData(1, TemperatureUnit.R, TemperatureUnit.R, 1)]

	public void Convert_ToBaseUnit_Success(double amount, TemperatureUnit initialUnit, TemperatureUnit requiredUnit, double expected)
	{
		var result = TemperatureConverter.Convert(amount, initialUnit, requiredUnit);
		Assert.IsAssignableFrom<double>(result);
		Assert.Equal(expected, Math.Round(result));
	}


}
