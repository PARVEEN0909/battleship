# battleship

1. Install Homebrew (if not already installed):

```
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
```

2. Install .NET Core

```
brew tap dotnet/dotnet
brew install dotnet
```

3. Verify Installation

```
dotnet --version
```

NOTE:
If you need a specific version of .NET Core 6

```
brew install dotnet --version 6.0.100
```

To update .NET Core 6 to the latest version

```
brew upgrade dotnet
```

# Project debug

```
dotnet build
```

Now attach debugger to debug code.