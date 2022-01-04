namespace MeasurementConvertor.Mass;

/// <summary>
/// Mass convertion calculator
/// </summary>
public static  class Convertor
{
	/// <summary>
	///	Manages the conversion of from the initial MassUnit to the required MassUnit
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Input MassUnit type</param>
	/// <param name="outputUnit">Type of required MassUnit</param>
	/// <returns type="double">The amount of the required MassUnit as double</returns>
	public static double Convert(double quantity, MassUnit inputUnit, MassUnit outputUnit)
	{
		if(outputUnit == MassUnit.g)
			return quantity;

		return FromBaseMeasure(ToBaseMeasure(quantity, inputUnit), outputUnit);
	}

	/// <summary>
	/// Converts passed in value to the convertors base MassUnit - (g) Grams
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Type of input MassUnit</param>
	/// <returns type="double">weight in grams</returns>
	/// <exception cref="NotSupportedException"></exception>
	private static double ToBaseMeasure(double quantity,MassUnit inputUnit) =>
		 inputUnit switch
		{
			MassUnit.kg => quantity * 0.001,
			MassUnit.lb => quantity * 453.59237,
			MassUnit.oz => quantity * 28.3495231,
			MassUnit.st => quantity * 6350.29317,
			MassUnit.mg => quantity * 1000,
			_ => throw new NotSupportedException()
		};

	/// <summary>
	///  Converts passed in value from the convertors base MassUnit - (g) Grams
	/// </summary>
	/// <param name="quantity">Amount of grams</param>
	/// <param name="outputUnit">Required MassUnit type</param>
	/// <returns type="double" >Amount in requested MassUnit type</returns>
	/// <exception cref="NotSupportedException"></exception>
	private static double FromBaseMeasure(double quantity, MassUnit outputUnit) =>
		outputUnit switch
		{
			MassUnit.kg => quantity * 1000,
			MassUnit.lb => quantity * 0.00220462,
			MassUnit.oz =>quantity * 0.03527396,
			MassUnit.st => quantity * 0.00015747,
			MassUnit.mg => quantity * 0.001,
			_ => throw new NotSupportedException()
		};
}
