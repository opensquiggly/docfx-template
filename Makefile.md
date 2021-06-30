Hot to use custom template?

First need to setup DocFx.
DocFX is an API documentation generator for .NET, which currently supports C#, VB and F#. 
It generates API reference documentation from triple-slash comments in your source code.
DocFX builds a static HTML website from your source code and Markdown files, 
which can be easily hosted on any web server (for example, github.io).
For more info can look: https://dotnet.github.io/docfx/tutorial/docfx_getting_started.html 

Our custom template generate static XML files, instead of HTML.

1. _docfx_temp - it is temp folder, for building template, 
	can change that in docfx.json file:
	...
	"build": {
		"content": [
			{
				"src": "_docfx_temp/backend",
	...

2. _docfx_site - it is folder with static HTML(default template) or XML(our custom template), 
	can change that in docfx.json file:
	...
	"dest": "_docfx_site",
	...

or both if we use default and custom template in json config file:
	...
	"template": [
		"default",
		"docfx_custom_template"
	],
	...

3. docfx.json - docFx config file, can change anything in config, for more info see:
   https://dotnet.github.io/docfx/tutorial/docfx.exe_user_manual.html


How to build custom template:

clean content in folders:
	rm -rf _docfx_temp
	rm -rf _docfx_site
	rm -rf obj

build default content for docfx folder:
	mono /usr/local/bin/docfx.exe build

build with custom template on Linux:
	mono /usr/local/bin/docfx.exe [-path to docfx json file-]/docfx.json build -t default,docfx_custom_template

build with custom template on Windows(use win cmd):	
	cd C:\docfx\
	docfx C:\[-path to docfx json file-]\docfx.json build

serve default static html files, if using default template:
	mono /usr/local/bin/docfx.exe serve _docfx_site
where _docfx_site - folder from 2. 

