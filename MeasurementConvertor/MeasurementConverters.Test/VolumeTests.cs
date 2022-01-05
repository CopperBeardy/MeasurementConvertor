using System;
using MeasurementConverters.Volume;
using Xunit;

namespace MeasurementConverters.Test;

public class VolumeTests
{
	[Theory]
	[InlineData(1, VolumeUnit.floz, VolumeUnit.floz, 1)]
	[InlineData(1, VolumeUnit.L, VolumeUnit.L, 1)]
	[InlineData(1, VolumeUnit.mL, VolumeUnit.mL, 1)]
	[InlineData(1, VolumeUnit.pt_i, VolumeUnit.pt_i, 1)]
	[InlineData(1, VolumeUnit.μL, VolumeUnit.μL, 1)]
	[InlineData(1, VolumeUnit.cL, VolumeUnit.cL, 1)]
	[InlineData(1, VolumeUnit.daL, VolumeUnit.daL, 1)]
	[InlineData(1, VolumeUnit.dL, VolumeUnit.dL, 1)]
	[InlineData(1, VolumeUnit.hL, VolumeUnit.hL, 1)]
	[InlineData(1, VolumeUnit.kL, VolumeUnit.kL, 1)]
	[InlineData(1, VolumeUnit.ML, VolumeUnit.ML, 1)]
	[InlineData(1, VolumeUnit.gal_i, VolumeUnit.gal_i, 1)]
	public void Convert_Success(double amount, VolumeUnit initialUnit, VolumeUnit requiredUnit, double expected)
	{
		var result = VolumeConverter.Convert(amount, initialUnit, requiredUnit);
		Assert.IsAssignableFrom<double>(result);
		Assert.Equal(expected, Math.Round(result));
	}
}
