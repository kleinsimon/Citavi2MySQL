# Citavi2MySQL
Allows the export of Citavi 4 and 5 datasets to a MySQL table filtered by category (and group).

# Features
* Export whole Datasets to MySQL directly or using SSH tunnel
* Filter exported references by category or group
* Limit exported locations (for getting designated signatures)
* Gui and Headless mode

# Installation
Simply copy both .dll files to the folder "AddOns" in the citavi programm directory (eg C:\Programs\Citavi5\AddOns). Take care to catch the right version for Citavi 4 or 5

# Usage
You should now have two menu items under "Extra": 
* "MySQL Export Config", where you can set up the filters and export settings
* "Export References to MySQL". This is the headless version, where you can skip the gui and export directly.

Be aware that the MySQL table set in settings will be overwritten and automatically populated with the needed columns! I will take no responsability for lost data. This addon comes without any guarantee to work as expected or do anything useful.
