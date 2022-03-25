# WebView2 Base Template
A base project with webView2 (Using both C# and C++). It is made with visual studio and the webview2 package. This is a template browser made so that anyone can edit it to suit their needs. This project was made because I found existing documentation to be either hard to find or hard to understand, so I hope that this project helps someone out.

**Default Layout and Usage**
------------------------------------
The default layout of the program is deplayed below. It consists of 3 progress bars, 6 labels, an address bar, 2 background worker threads, and 5 buttons. Pressing run will execute the 2 background workers (currently they do nothing). The progress bar's value will also increment by one. As this is made as a template for webview2 projects, most of the code and interface is inactive and just there to as an idea of how to proceed. Pressing on the progress bar or stop will send a stop request to the background workers. The go button loads the webpage that is typed in the address bar. The load button will load information from a json file.

<img src="https://user-images.githubusercontent.com/100814612/160015485-d5b7e555-dce4-4e4d-97d9-8f8631d51c30.png"><img>

**Request Button**
------------------------------------
The request button loads the following form. Currently the form does not have a function, I have included code tied to the checkmarks if you want to add a process.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/160015820-705f4fb7-cd39-4922-a4e4-4a0761118e60.png"><img>
</p>

**User Agent**
------------------------------------
It is possible to now change the user agent to view the mobile and desktop version of websites. Below are some examples of how what type of input the user agent setting expects.

```
string mobile = "Mozilla/5.0 (iPhone; CPU iPhone OS 13_5_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.1.1 Mobile/15E148 Safari/604.1";
string edge = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36 Edg/91.0.864.59";
string chrome = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";

webView.CoreWebView2.Settings.UserAgent = edge;
```
**Json Files**
------------------------------------
To work with Json files, I recommend using the Newtonsoft.Json package. After installing that package, you should create a class to store the json file information. I will include files as examples in the json folder of this project. Below is an example of setting the progress bar information using the progressB class and the progressBarValues json file.

```
string fileName = @"c:\progressBarValues.json";
//Check if the file exists
if (File.Exists(fileName))
{
    //Give the class the values from the json
    List<progressB> searches = JsonConvert.DeserializeObject<List<progressB>>(File.ReadAllText(fileName));
    
    //Set
    progressBar1.Maximum = searches[0].maximum;
}
```
