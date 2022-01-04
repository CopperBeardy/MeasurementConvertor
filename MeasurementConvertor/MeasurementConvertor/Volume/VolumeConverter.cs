namespace MeasurementConvertor.Volume;

/// <summary>
/// Volume Convertion calculator
/// </summary>
public static class VolumeConverter
{
	/// <summary>
	///	Manages the conversion of from the initial VolumeUnit to the required VolumeUnit
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Input VolumeUnit type</param>
	/// <param name="outputUnit">Type of required VolumeUnit</param>
	/// <returns type="double">The amount of the required VolumeUnit as double</returns>
	public static double Convert(double quantity, VolumeUnit inputUnit, VolumeUnit outputUnit)
	{
		if (outputUnit == VolumeUnit.l)
			return quantity;
		var baseUnitAmout = ToBaseMeasure(quantity, inputUnit);

		return outputUnit == VolumeUnit.l ? baseUnitAmout : FromBaseMeasure(baseUnitAmout, outputUnit);
	}

	/// <summary>
	/// Converts required quantity of VolumeUnit to base VolumeUnit (l) Litre
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Type of input VolumeUnit</param>
	/// <returns type="double">volume in Litre's</returns>
	/// <exception cref="NotSupportedException"></exception>
	public static double ToBaseMeasure(double quantity, VolumeUnit inputUnit) =>
		inputUnit switch
		{
			VolumeUnit.floz => quantity * 0.02841308,
			VolumeUnit.ml => quantity * 0.001,
			VolumeUnit.pt_i => quantity * 0.5682615,
		  _ => throw new NotSupportedException()
		};

	/// <summary>
	/// Converts passed quantity of base VolumeUnit (l) Litre  to amount of required VolumeUnit
	/// </summary>
	/// <param name="quantity">Amount of Litres</param>
	/// <param name="outputUnit">Type of requested VolumeUnit</param>
	/// <returns type="double" >Amount in Litre's</returns>
	/// <exception cref="NotSupportedException"></exception>
	public static double FromBaseMeasure(double quantity, VolumeUnit outputUnit) =>
		outputUnit switch
		{
			VolumeUnit.floz => quantity * 35.1950642,
		   VolumeUnit.ml => quantity * 1000,
		   VolumeUnit.pt_i => quantity * 1.75975321 ,
		 _ => throw new NotSupportedException()
		};


}
