using System;
using MeasurementConverters.Mass;
using Xunit;

namespace MeasurementConverters.Test;

public class MassTests
{
	[Theory]
	[InlineData(1, MassUnit.kg, MassUnit.kg, 1)]
	[InlineData(1, MassUnit.lb, MassUnit.lb, 1)]
	[InlineData(1, MassUnit.oz, MassUnit.oz, 1)]
	[InlineData(1, MassUnit.st, MassUnit.st, 1)]
	[InlineData(1, MassUnit.mg, MassUnit.mg, 1)]
	[InlineData(1, MassUnit.dg, MassUnit.dg, 1)]
	[InlineData(1, MassUnit.cg, MassUnit.cg, 1)]
	[InlineData(1, MassUnit.μg, MassUnit.μg, 1)]
	[InlineData(1, MassUnit.dag, MassUnit.dag, 1)]
	[InlineData(1, MassUnit.hg, MassUnit.hg, 1)]
	[InlineData(1, MassUnit.Mg, MassUnit.Mg, 1)]
	[InlineData(1, MassUnit.t, MassUnit.t, 1)]
	public void Convert_ToBaseUnit_Success(double amount, MassUnit initialUnit, MassUnit requiredUnit, double expected)
	{
		var result = MassConverter.Convert(amount, initialUnit, requiredUnit);
		Assert.IsAssignableFrom<double>(result);
		Assert.Equal(expected, Math.Round(result));
	}


}
