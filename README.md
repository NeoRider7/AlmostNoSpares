# AlmostNoSpares
Mod for Planetbase that increases the time before Solar and Wind generators need repairs

## How to build
This mod was made as a submodule to https://github.com/Tahvohck/Planetbase-Mods
Simply download this repo and copy it to the Tahvohck's repo, then import new project to the solution in Visual Studio. Then right-click on .tt files and choose "Run Custom Tool". This will generate `Info.json` and `AssemblyVersions.cs` files. Once thats done you can build.
The file structure should look like this:
PLanetbase-Mods-master
|
|--AlmostNoSpares
    |
    |--AlmostNoSpares.csproj
    |
    |--AlmostNoSpares_Main.cs
    |
    |--Properties
|
|--other submodules
