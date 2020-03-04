Title: Tuple Deconstruction
Published: 1/3/2019
Tags: C#, Note
---

Added in C# 7 

## Deconstruction (Tuples)

### Basic syntax

```csharp
var (name, address, city, zip) = contact.GetAddress();
```

it's possible to ignore fields by using the `_` placeholder.

```csharp
var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);
```
---
### Currently supported usages
- Declaration: `var (x, y) = e;`
- Assignment: `(x, y) = e;` *where x and y have already been declared*
- foreach `foreach(var(x, y) in e)` 

---
### Deconstructing user defined types

Need to add one or more `Deconstruct` methods.

```csharp
public void Deconstruct(out string firstname, out string lastname, out string middleinitial)
```

---
### Interesting Ideass
[Task WhenAll Extension](https://compiledexperience.com/blog/posts/abusing-tuples)

--- 
### Examples
- [`foreach` Deconstruction](https://github.com/daveteske/csharp-code/blob/master/Code/Tuple/ForEachDeconstruction.cs)
- [Custom Deconstruction](https://github.com/daveteske/csharp-code/blob/master/Code/Tuple/CustomDeconstruct.cs)

### Nifty I can do this right in GitHub
- and it works
  
