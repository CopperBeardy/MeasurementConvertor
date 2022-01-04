### Features

- mass converter for -> g, kg, lb, st
- volume converter  for-> ml, l, pt(imperial), floz

# Example of usage
all converter follow the same pattern
	/converter name/.Convert(amount, CurrentUnit, RequiredUnit)

```C#	
	VolumeConvertor.Convert(1,VolumeUnit.ml,VolumeUnit.pt_i)
```
