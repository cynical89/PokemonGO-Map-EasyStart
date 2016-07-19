# PokemonGO-Map-EasyStart
Easy start application for PokemonGo-Map (https://github.com/AHAAAAAAA/PokemonGo-Map)

This is a wpf application made in C# and Visual Studio 2015. It's meant to make the executing of the python server for PokemonGo-Map easier. Enter the information in the input boxes for your account, select the steps and auth service, and press 'Start the map!'

This is execute the python command to start the server, and after 5 seconds will open a web browser.

## Requirements:

* [PokemonGo-Map](https://github.com/AHAAAAAAA/PokemonGo-Map)
* [Python 2.7.X](https://www.python.org/downloads/)

### Instructions

1. Clone down the repository.
	```
	git clone https://github.com/snollygolly/open-hearts.git
	```

2. Setup environment variables for Python
	- Check if 'C:\Python27' exists
	- If it exists, then open up your environment variables
	- Start Menu > type: 'Edit the system environment variables' (start typing 'environment') > hit enter
	- Click on the 'Environment Variables...' button
	- Under System variables, find the variable named "Path", and select it
	- Hit the 'Edit...' button
	- Add 'C:\Python35-32;C:\Python35-32\Lib\site-packages\;C:\Python35-32\Scripts\' to the list
	 
3. Install pip
    - Open the PokemonGo-Map repository on your local machine.
    - Navigate to the `Easy Setup` directory.
    - Run `setup.bat`
    
4. Copy the easy start files to PokemonGo-Map
    - Navigate to the PokemonGo-Map-EasyStart repository on your local machine
    - Executable is in `bin/Release/`
    - copy the 6 files from Release to the PokemonGo-Map repository (the same location as example.py)
    - Run `PokeGoMap-EasyButton.exe`
