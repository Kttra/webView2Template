# WebView2 Base Template
A base project with webView2 (Using both C# and C++). It is made with visual studio and the webview2 package. This is a template browser made so that anyone can edit it to suit their needs.

**Default Layout and Usage**
------------------------------------
The default layout of the program is deplayed below. It consists of 3 progress bars, 6 labels, an address bar, 2 background worker threads, and 5 buttons. Pressing run will execute the 2 background workers (currently they do nothing). The progress bar's value will also increment by one. As this is made as a template for webview2 projects, most of the code and interface is inactive and just there to as an idea of how to proceed. Pressing on the progress bar or stop will send a stop request to the background workers. The go button loads the webpage that is typed in the address bar. The load button will load information from a json file.

<img src="https://user-images.githubusercontent.com/100814612/160015485-d5b7e555-dce4-4e4d-97d9-8f8631d51c30.png"><img>

**Request Button**
------------------------------------
The request button loads the following form. Currently the form does not have a function, I have included code tied to the checkmarks if you want to add a process.

<img src="https://user-images.githubusercontent.com/100814612/160015820-705f4fb7-cd39-4922-a4e4-4a0761118e60.png"><img>

