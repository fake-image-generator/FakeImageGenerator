# FakeImageGenerator
<img align="left" width="100" height="100" src="fake-image-generator.png">

Generate a fake JPG or PNG image in any size between 1 KB and 2 GB.

This was made for generating big files that pose as images for testing purposes (for testing an image upload feature in an app, for example).

### Requirements

.NET Core 3.1

### Installation

```
Install-Package FakeImageGenerator
```

### Build

Simply build the solution in Visual Studio 2019.

### Usage

Use `Generator` class to generate a fake image like this:

```csharp
var generator = new Generator();
generator.Run(10000000, "Png", "C:/"); // generate a 10MB PNG image
```

Or if you want a byte array:

```csharp
var generator = new Generator();
var array = generator.Run(10000000, "Png"); // generate a 10MB PNG image
```

If you want to generate fake images for Xunit theories tests download the [FakeImageGenerator.Xunit](https://github.com/fake-image-generator/FakeImageGenerator.Xunit) package.