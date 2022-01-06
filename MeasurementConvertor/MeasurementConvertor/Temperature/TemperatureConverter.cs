

namespace MeasurementConverters.Temperature;

/// <summary>
/// Temperature convertion calculator
/// </summary>
public static class TemperatureConverter
{
	/// <summary>
	///	Manages the conversion of from the initial TemperatureUnit to the required TemperatureUnit
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Input TemperatureUnit type</param>
	/// <param name="outputUnit">Type of required TemperatureUnit</param>
	/// <returns type="double">The amount of the required TemperatureUnit as double</returns>
	public static double Convert(double quantity, TemperatureUnit inputUnit, TemperatureUnit outputUnit)
	{
		if (inputUnit == TemperatureUnit.C && outputUnit == TemperatureUnit.C)
			return quantity;
		var baseUnitAmount = ToBaseMeasure(quantity, inputUnit);
		return outputUnit == TemperatureUnit.C ? baseUnitAmount : FromBaseMeasure(baseUnitAmount, outputUnit);
	}

	/// <summary>
	/// Converts passed in value to the convertors base TemperatureUnit - (mph) Mile per hour
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Type of input TemperatureUnit</param>
	/// <returns type="double">weight in grams</returns>
	/// <exception cref="NotSupportedException"></exception>
	public static double ToBaseMeasure(double quantity, TemperatureUnit inputUnit) =>
		inputUnit switch
		{
			TemperatureUnit.F => quantity * -17.2222222,
			TemperatureUnit.K => quantity * -272.15,
			TemperatureUnit.R => quantity * -272.594444,
			_ => throw new NotSupportedException()
		};

	/// <summary>
	///  Converts passed in value from the convertors base TemperatureUnit - (mph) Mile per hour
	/// </summary>
	/// <param name="quantity">Amount of grams</param>
	/// <param name="outputUnit">Required TemperatureUnit type</param>
	/// <returns type="double" >Amount in requested TemperatureUnit type</returns>
	/// <exception cref="NotSupportedException"></exception>
	public static double FromBaseMeasure(double quantity, TemperatureUnit outputUnit) =>
	   outputUnit switch
	   {
		   TemperatureUnit.F => quantity / -17.2222222,
		   TemperatureUnit.K => quantity / -272.15,
		   TemperatureUnit.R => quantity / -272.594444,
		   _ => throw new NotSupportedException()
	   };
}
