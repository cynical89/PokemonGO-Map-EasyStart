# PokemonGO-Map-EasyStart - [Latest Release!](https://github.com/cynical89/PokemonGO-Map-EasyStart/releases/latest)
Easy start application for PokemonGo-Map (https://github.com/AHAAAAAAA/PokemonGo-Map)

This is a wpf application made in C# and Visual Studio 2015. It's meant to make the executing of the python server for PokemonGo-Map easier. Enter the information in the input boxes for your account, select the steps and auth service, and press 'Start the map!'

This will execute the python command to start the server, and after 5 seconds will open a web browser.

<p align="center">
<img src="https://raw.githubusercontent.com/cynical89/PokemonGo-Map-EasyStart/master/head.png">
</p>

## Requirements:

* [PokemonGo-Map](https://github.com/AHAAAAAAA/PokemonGo-Map)
* [Python 2.7.X](https://www.python.org/downloads/)
* [Google Maps API key](https://console.developers.google.com/flows/enableapi?apiid=maps_backend,geocoding_backend,directions_backend,distance_matrix_backend,elevation_backend,places_backend&keyType=CLIENT_SIDE&reusekey=true)

### Instructions

1. For instructions on how to setup and run PokemonGO-Map, please refer to the original project's  [wiki](https://github.com/AHAAAAAAA/PokemonGo-Map/wiki) Once that is installed, you can continue below.

2. Clone down the repository.
	```
	git clone https://github.com/cynical89/PokemonGO-Map-EasyStart.git
	```
    
3. Build/Copy the easy start files to PokemonGo-Map
    - Navigate to the PokemonGo-Map-EasyStart repository on your local machine
    - Open in Visual studio and build the project.
    - Executable is in `bin/Release/` if you build for release, else it's in `bin/Debug/` if you compiled the project yourself.
    - Note : If you can't build the file, or don't want to, I have compiled the project for you  [here](https://github.com/cynical89/PokemonGO-Map-EasyStart/releases). Download and extract the files.
    - copy the 6 files from Release to the PokemonGo-Map repository (the same location as example.py)
    - Run `PokeGoMap-EasyButton.exe`
