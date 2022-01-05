
namespace MeasurementConverters.Mass;

/// <summary>
/// Mass convertion calculator
/// </summary>
public static class MassConverter
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
		if (inputUnit == MassUnit.g && outputUnit == MassUnit.g)
			return quantity;
		var baseUnitAmount = ToBaseMeasure(quantity, inputUnit);
		return outputUnit == MassUnit.g ? baseUnitAmount : FromBaseMeasure(baseUnitAmount, outputUnit);
	}

	/// <summary>
	/// Converts passed in value to the convertors base MassUnit - (g) Grams
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Type of input MassUnit</param>
	/// <returns type="double">weight in grams</returns>
	/// <exception cref="NotSupportedException"></exception>
	public static double ToBaseMeasure(double quantity, MassUnit inputUnit) =>
		inputUnit switch
		{
			MassUnit.kg => quantity * 1000,
			MassUnit.lb => quantity * 453.59237,
			MassUnit.oz => quantity * 28.3495231,
			MassUnit.st => quantity * 6350.29317,
			MassUnit.mg => quantity * 0.001,
			MassUnit.dg => quantity * 0.1,
			MassUnit.cg => quantity * 0.01,
			MassUnit.μg => quantity * 0.000001,
			MassUnit.dag => quantity * 10,
			MassUnit.hg => quantity * 100,
			MassUnit.Mg => quantity * 1000000,
			MassUnit.t => quantity * 1000000,

			_ => throw new NotSupportedException()
		};

	/// <summary>
	///  Converts passed in value from the convertors base MassUnit - (g) Grams
	/// </summary>
	/// <param name="quantity">Amount of grams</param>
	/// <param name="outputUnit">Required MassUnit type</param>
	/// <returns type="double" >Amount in requested MassUnit type</returns>
	/// <exception cref="NotSupportedException"></exception>
	public static double FromBaseMeasure(double quantity, MassUnit outputUnit) =>
	   outputUnit switch
	   {
		   MassUnit.kg => quantity / 1000,
		   MassUnit.lb => quantity / 453.59237,
		   MassUnit.oz => quantity / 28.3495231,
		   MassUnit.st => quantity / 6350.29317,
		   MassUnit.mg => quantity / 0.001,
		   MassUnit.dg => quantity / 0.1,
		   MassUnit.cg => quantity / 0.01,
		   MassUnit.μg => quantity / 0.000001,
		   MassUnit.dag => quantity / 10,
		   MassUnit.hg => quantity / 100,
		   MassUnit.Mg => quantity / 1000000,
		   MassUnit.t => quantity / 1000000,
		   _ => throw new NotSupportedException()
	   };
}
