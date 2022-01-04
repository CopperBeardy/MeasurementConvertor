using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeasurementConvertor.Mass;
using Xunit;

namespace MeasurementConverters.Test;

public class MassTests
{
	[Theory]
	[InlineData(1, MassUnit.kg, MassUnit.kg, 1)]
	[InlineData(1, MassUnit.lb, MassUnit.lb, 1)]
	[InlineData(1, MassUnit.oz, MassUnit.oz, 1)]
	[InlineData(1, MassUnit.st, MassUnit.st, 1)]
	[InlineData(1, MassUnit.mg,  MassUnit.mg,1)]
	public void Convert_ToBaseUnit_Success(double amount, MassUnit initialUnit,MassUnit requiredUnit,double expected)
	{
		var result = MassConverter.Convert(amount, initialUnit,requiredUnit);
		Assert.IsAssignableFrom<double>(result);
		Assert.Equal(expected, Math.Round(result));
	}

	
}
