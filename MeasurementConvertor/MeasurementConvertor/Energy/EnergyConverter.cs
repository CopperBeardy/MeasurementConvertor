namespace MeasurementConverters.Energy;

/// <summary>
/// Energy convertion calculator
/// </summary>
public static class EnergyConverter
{
	/// <summary>
	///	Manages the conversion of from the initial EnergyUnit to the required EnergyUnit
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Input EnergyUnit type</param>
	/// <param name="outputUnit">Type of required EnergyUnit</param>
	/// <returns type="double">The amount of the required EnergyUnit as double</returns>
	public static double Convert(double quantity, EnergyUnit inputUnit, EnergyUnit outputUnit)
	{
		if (inputUnit == EnergyUnit.J && outputUnit == EnergyUnit.J)
			return quantity;
		var baseUnitAmount = ToBaseMeasure(quantity, inputUnit);
		return outputUnit == EnergyUnit.J ? baseUnitAmount : FromBaseMeasure(baseUnitAmount, outputUnit);
	}

	/// <summary>
	/// Converts passed in value to the convertors base EnergyUnit - (J) Joule
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="inputUnit">Type of input EnergyUnit</param>
	/// <returns type="double">weight in grams</returns>
	/// <exception cref="NotSupportedException"></exception>
	public static double ToBaseMeasure(double quantity, EnergyUnit inputUnit) =>
		inputUnit switch
		{
			EnergyUnit.cal => quantity * 4.184,
			EnergyUnit.kJ => quantity * 1000,
			EnergyUnit.kcal => quantity * 4184,
			EnergyUnit.kW => quantity * 3600000,
			EnergyUnit.BTU => quantity * 1055.05585,
			EnergyUnit.eV => quantity * 0.00000000000000000016022,
			_ => throw new NotSupportedException()
		};

	/// <summary>
	///  Converts passed in value from the convertors base EnergyUnit - (J) Joule
	/// </summary>
	/// <param name="quantity">Amount of input unit</param>
	/// <param name="outputUnit">Required EnergyUnit type</param>
	/// <returns type="double" >Amount in requested EnergyUnit type</returns>
	/// <exception cref="NotSupportedException"></exception>
	public static double FromBaseMeasure(double quantity, EnergyUnit outputUnit) =>
	   outputUnit switch
	   {
		   EnergyUnit.cal => quantity / 4.184,
		   EnergyUnit.kJ => quantity / 1000,
		   EnergyUnit.kcal => quantity / 4184,
		   EnergyUnit.kW => quantity / 3600000,
		   EnergyUnit.BTU => quantity / 1055.05585,
		   EnergyUnit.eV => quantity / 0.00000000000000000016022,

		   _ => throw new NotSupportedException()
	   };
}
