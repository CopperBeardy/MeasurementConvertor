using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeasurementConvertor.Mass;
using MeasurementConvertor.Volume;
using Xunit;

namespace MeasurementConverters.Test;

public  class VolumeTests
{
	[Theory]
	[InlineData(1, VolumeUnit.floz,VolumeUnit.floz,1)]
	[InlineData(1, VolumeUnit.l, VolumeUnit.l, 1)]
	[InlineData(1, VolumeUnit.ml, VolumeUnit.ml, 1)]
	[InlineData(1, VolumeUnit.pt_i, VolumeUnit.pt_i, 1)]
	public void Convert_Success(double amount, VolumeUnit initialUnit, VolumeUnit requiredUnit, double expected)
	{
		var result = VolumeConverter.Convert(amount, initialUnit, requiredUnit);
		Assert.IsAssignableFrom<double>(result);
		Assert.Equal(expected, Math.Round(result));
	}
}
