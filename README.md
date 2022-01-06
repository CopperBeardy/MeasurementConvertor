.net 6  C#


### Features

- mass converter for -> g, kg, lb, oz, st, mg, dg, cg, μg, dag, hg, Mg, t,
- volume converter  for-> 	mL, L, floz, μL, cL, daL,	dL, hL, kL, ML,	gal_i, pt_i(Imperial)
- length converter for -> 	cm, m, inch, yard, ft, km, dm, mm, μ, mi, NM
- speed converter for -> 	mph, kph, fps, mps, knot, mach
- energy converter for -> J,	kJ, cal, kcal, kW, BTU, eV 
- temperature for -> C, F, K, R

# Example of usage
all converters follow the same pattern
/converter name/.Convert(amount, CurrentUnit, RequiredUnit)

C#	
``
	VolumeConvertor.Convert(1,VolumeUnit.ml,VolumeUnit.pt_i)
``
