


namespace MeasurementConverters.Length;

/// <summary>
/// Length convertion calculator
/// </summary>
public static class LengthConverter
{
	/// <summary>
	///	Manages the conversion of from the initial LengthUnit to the required LengthUnit
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Input LengthUnit type</param>
	/// <param name="outputUnit">Type of required LengthUnit</param>
	/// <returns type="double">The amount of the required LengthUnit as double</returns>
	public static double Convert(double quantity, LengthUnit inputUnit, LengthUnit outputUnit)
	{
		if (inputUnit == LengthUnit.cm && outputUnit == LengthUnit.cm)
			return quantity;
		var baseUnitAmount = ToBaseMeasure(quantity, inputUnit);
		return outputUnit == LengthUnit.cm ? baseUnitAmount : FromBaseMeasure(baseUnitAmount, outputUnit);
	}

	/// <summary>
	/// Converts passed in value to the convertors base LengthUnit - (cm) Centimetre
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Type of input LengthUnit</param>
	/// <returns type="double">weight in grams</returns>
	/// <exception cref="NotSupportedException"></exception>
	public static double ToBaseMeasure(double quantity, LengthUnit inputUnit) =>
		inputUnit switch
		{
			LengthUnit.m => quantity * 100,
			LengthUnit.inch => quantity * 2.54,
			LengthUnit.ft => quantity * 30.48,
			LengthUnit.yard => quantity * 91.44,
			LengthUnit.km => quantity * 100000,
			LengthUnit.dm => quantity * 10,
			LengthUnit.mm => quantity * 0.1,
			LengthUnit.μ => quantity * 0.0001,
			LengthUnit.mi => quantity * 160934.4,
			LengthUnit.NM => quantity * 185200,
			_ => throw new NotSupportedException()
		};

	/// <summary>
	///  Converts passed in value from the convertors base LengthUnit - (cm) Centimetre
	/// </summary>
	/// <param name="quantity">Amount of grams</param>
	/// <param name="outputUnit">Required LengthUnit type</param>
	/// <returns type="double" >Amount in requested LengthUnit type</returns>
	/// <exception cref="NotSupportedException"></exception>
	public static double FromBaseMeasure(double quantity, LengthUnit outputUnit) =>
	   outputUnit switch
	   {
		   LengthUnit.m => quantity / 100,
		   LengthUnit.inch => quantity / 2.54,
		   LengthUnit.ft => quantity / 30.48,
		   LengthUnit.yard => quantity / 91.44,
		   LengthUnit.km => quantity / 100000,
		   LengthUnit.dm => quantity / 10,
		   LengthUnit.mm => quantity / 0.1,
		   LengthUnit.μ => quantity / 0.0001,
		   LengthUnit.mi => quantity / 160934.4,
		   LengthUnit.NM => quantity / 185200,

		   _ => throw new NotSupportedException()
	   };
}
