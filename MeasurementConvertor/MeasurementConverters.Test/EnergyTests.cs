using System;
using MeasurementConverters.Energy;
using Xunit;

namespace MeasurementConverters.Test;

public class EnergyTests
{
	[Theory]
	[InlineData(1, EnergyUnit.J, EnergyUnit.J, 1)]
	[InlineData(1, EnergyUnit.kJ, EnergyUnit.kJ, 1)]
	[InlineData(1, EnergyUnit.cal, EnergyUnit.cal, 1)]
	[InlineData(1, EnergyUnit.kcal, EnergyUnit.kcal, 1)]
	[InlineData(1, EnergyUnit.kW, EnergyUnit.kW, 1)]
	[InlineData(1, EnergyUnit.BTU, EnergyUnit.BTU, 1)]
	[InlineData(1, EnergyUnit.eV, EnergyUnit.eV, 1)]


	public void Convert_ToBaseUnit_Success(double amount, EnergyUnit initialUnit, EnergyUnit requiredUnit, double expected)
	{
		var result = EnergyConverter.Convert(amount, initialUnit, requiredUnit);
		Assert.IsAssignableFrom<double>(result);
		Assert.Equal(expected, Math.Round(result));
	}


}
