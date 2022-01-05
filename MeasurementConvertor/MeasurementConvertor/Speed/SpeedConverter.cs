

namespace MeasurementConverters.Speed;

/// <summary>
/// Speed convertion calculator
/// </summary>
public static class SpeedConverter
{
	/// <summary>
	///	Manages the conversion of from the initial SpeedUnit to the required SpeedUnit
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Input SpeedUnit type</param>
	/// <param name="outputUnit">Type of required SpeedUnit</param>
	/// <returns type="double">The amount of the required SpeedUnit as double</returns>
	public static double Convert(double quantity, SpeedUnit inputUnit, SpeedUnit outputUnit)
	{
		if (inputUnit == SpeedUnit.mph && outputUnit == SpeedUnit.mph)
			return quantity;
		var baseUnitAmount = ToBaseMeasure(quantity, inputUnit);
		return outputUnit == SpeedUnit.mph ? baseUnitAmount : FromBaseMeasure(baseUnitAmount, outputUnit);
	}

	/// <summary>
	/// Converts passed in value to the convertors base SpeedUnit - (mph) Mile per hour
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Type of input SpeedUnit</param>
	/// <returns type="double">weight in grams</returns>
	/// <exception cref="NotSupportedException"></exception>
	public static double ToBaseMeasure(double quantity, SpeedUnit inputUnit) =>
		inputUnit switch
		{
			SpeedUnit.kph => quantity * 0.62137119,
			SpeedUnit.fps => quantity * 0.68181818,
			SpeedUnit.mps => quantity * 2.23693629,
			SpeedUnit.knot => quantity * 1.15077945,
			SpeedUnit.mach => quantity * 767.269148,
			_ => throw new NotSupportedException()
		};

	/// <summary>
	///  Converts passed in value from the convertors base SpeedUnit - (mph) Mile per hour
	/// </summary>
	/// <param name="quantity">Amount of grams</param>
	/// <param name="outputUnit">Required SpeedUnit type</param>
	/// <returns type="double" >Amount in requested SpeedUnit type</returns>
	/// <exception cref="NotSupportedException"></exception>
	public static double FromBaseMeasure(double quantity, SpeedUnit outputUnit) =>
	   outputUnit switch
	   {
		   SpeedUnit.kph => quantity / 0.62137119,
		   SpeedUnit.fps => quantity / 0.68181818,
		   SpeedUnit.mps => quantity / 2.23693629,
		   SpeedUnit.knot => quantity / 1.15077945,
		   SpeedUnit.mach => quantity / 767.269148,
		   _ => throw new NotSupportedException()
	   };
}
