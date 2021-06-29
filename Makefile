
clean:
	rm -rf _docfx_temp
	rm -rf _docfx_site
	rm -rf obj

metadata:
	mono /usr/local/bin/docfx.exe metadata

build:
	mono /usr/local/bin/docfx.exe build

build with custom template:
	mono /usr/local/bin/docfx.exe build -t default,_docfx_custom_template

build with custom template on windows(use win cmd):	
	cd C:\docfx\
	docfx C:\[-path to docfx json file-]\docfx.json build

serve:
	mono /usr/local/bin/docfx.exe serve _docfx_site

