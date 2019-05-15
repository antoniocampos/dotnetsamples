# Multi-Targeting and Porting a .NET Library to .NET Core 2.0
This solution has 3 projects

[LibExample](https://github.com/antoniocampos/dotnetsamples/tree/master/MultiTarget/LibExemplo) -> Compiles both to .net Full Framework 4.0 and .net Standard 2.0

[ConsoleApp1CORE](https://github.com/antoniocampos/dotnetsamples/tree/master/MultiTarget/ConsoleApp1CORE) -> References LibExemplo and consumes it as Net Standard 2.0

[ConsoleApp1NET40](https://github.com/antoniocampos/dotnetsamples/tree/master/MultiTarget/ConsoleApp1NET40) -> References LibExemplo and consumes it as Full Framework (4.0)

All this is possible just editing the Class Library [csproj](https://github.com/antoniocampos/dotnetsamples/blob/master/MultiTarget/LibExemplo/LibExemplo.csproj), with some changes you can have the same library compiling with two diferent framework targets.

If you're using Visual Studio the intellisense will warn you of the functions not available in both frameworks you're targeting.

As example i included the PostgresQL nuget package, with a twist! each target framework use a diferent version! If you use the full .net 4.0 you will use a diferent version from the used if you use from .net core.