# WebView2 Sample Template & C# Info
A base project with webView2 using both C# and C++. It is made with visual studio and the webview2 package. This is a template browser made so that anyone can edit it to suit their needs. This project was made because I found existing documentation to be either hard to find or hard to understand, so I hope that this project helps someone out. This project is primarily using C#.

**Packages**
------------------------------------
To use webview2, make sure you download the package for it. To download the package, right click on your project and click on manage NuGet package. From there, you can search up webview2 and download it. Additionally, if you want the program to work for others, you may need them to download the webview2 runtime or the microsoft edge insider versions like the Microsoft Edge Canary Channel.

In some cases, webview2 may not show up in your toolbar. If this happens, you will need to right click on anything in the toolbar, then press on choose items. Press browse and head to the directory where the webview2 package was downloaded to.

**Default Layout and Usage**
------------------------------------
The default layout of the program is deplayed below. It consists of 3 progress bars, 6 labels, an address bar, 2 background worker threads, and 5 buttons. Pressing run will execute the 2 background workers (currently they do nothing). The progress bar's value will also increment by one. As this is made as a template for webview2 projects, most of the code and interface is inactive and just there to as an idea of how to proceed. Pressing on the progress bar or stop will send a stop request to the background workers. The go button loads the webpage that is typed in the address bar. The load button will load information from a json file.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/160015485-d5b7e555-dce4-4e4d-97d9-8f8631d51c30.png"><img>
</p>

**Request Button**
------------------------------------
The request button loads the following form. Currently the form does not have a function, I have included code tied to the checkmarks if you want to add a process.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/160015820-705f4fb7-cd39-4922-a4e4-4a0761118e60.png"><img>
</p>

**Changing the User Agent**
------------------------------------
It is possible to now change the user agent to view the mobile and desktop version of websites. Below are some examples of how what type of input the user agent setting expects. You can also search up user agent strings and use them.

```csharp
string mobile = "Mozilla/5.0 (iPhone; CPU iPhone OS 13_5_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.1.1 Mobile/15E148 Safari/604.1";
string edge = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36 Edg/91.0.864.59";
string chrome = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";

webView.CoreWebView2.Settings.UserAgent = edge;
```
**Class File**
------------------------------------
Sometimes your project may use json files to read information, finding a way to store the information from the file is important. One way to store the information is by using a class. In this case, I create a class called progressB below. The class file is also available in the json folder.
```csharp
namespace webView2B
{
    [Serializable]
    class progressB
    {
        public int maximum;
        public int minimum;
        public int value;

    //Create class with no entries: progressB newEntry = new progressB();
    public progressB()
    {

    }
    //Create class with entries: progressB newEntry = new progressB(10, 10, 10);
    public progressB(int aMaximum, int aMinimum, int aValue)
    {
        maximum = aMaximum;
        minimum = aMinimum;
        value = aValue;
    }
    }
}
```
**Json Files**
------------------------------------
Now that we got our class file, how do we work with Json files? I recommend using the Newtonsoft.Json package. After installing that package, you should create a class to store the json file information. Below is an example of setting the progress bar information using the progressB class and the progressBarValues json file. The results and files used are in the json folder of this project (the below code could be placed in the loadButton_Click method).

```csharp
using Newtonsoft.Json; //Remember to include this at the top

string fileName = @"c:\progressBarValues.json"; //Directory of the file
//Check if the file exists
if (File.Exists(fileName))
{
    //Give the class the values from the json
    List<progressB> jsonInfo = JsonConvert.DeserializeObject<List<progressB>>(File.ReadAllText(fileName));
    
    //Set the maximum value the progress bar can be
    progressBar1.Maximum = jsonInfo[0].maximum;
    
    //Creates another progressB class, then assign one of the values
    progressB newEntry = new progressB();
    newEntry.maximum = 100;
    
    //Adds another entry into the list
    jsonInfo.Add(newEntry);
    
    //Creates a new json file with the edits we made
    File.WriteAllText("myobjects.json", JsonConvert.SerializeObject(jsonInfo));
}
```
**App Settings**
------------------------------------
Instead of working with json files, we can also use the app settings to store or load information. The settings can be accessed by going to the project properties and tehn heading to the settings tab. You can then add in parameters there. Here is an example of how it may look.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/160251053-beebfc42-2244-4464-bd34-e3a7ef0a65b4.png"><img>
</p>

Now after setting up these values, how exactly do we use them? Well, it's simple, we just need to reassign the their values if we wish to and then we need to make sure to save them. Now you can use these values to load up different settings saved by the user.

```csharp
//Assigning them values
Properties.Settings.Default.info1 = 1;
Properties.Settings.Default.info2 = 2;
Properties.Settings.Default.info3 = 3;

//Save the settings
Properties.Settings.Default.Save();

//Assign other variables to them if we wish to
int info1 = Properties.Settings.Default.info1;
int info2 = Properties.Settings.Default.info2;
int info3 = Properties.Settings.Default.info3;
```

**Working with Multiple Forms**
------------------------------------
Working with multiple forms can be confusing, so here's some information about it. Let's say you want to open form2 once a button is clicked in form1. In the button_click method, you would want create form2 and then show the form.

```csharp
form2 f2 = new form2();
f2.Show(); //Show form2, immediately execute code under
//f2.ShowDialog(); //Show form2, wait for form2 to close

//To Close form2, have this somewhere in the form2.cs file
this.Close();
```
There are two ways to show the form after creating it. Show will show the form and then execute the code under it immediately. While ShowDialog will show the form, wait for the form to close, and then execute the code that is under it. This is important to consider if you want to wait for form2 to update information before proceeding.

**Async Methods**
------------------------------------
I want to introduce the power of async methods. Async methods enable code to read like a sequence of statements. However, it executes them in a much more complicated order based on external resource allocation and when those tasks complete. They're important because they allow pauses between steps without freezing the UI. A simple use case would be if you want a task to repeat a number of times with pauses in between.
```csharp
private async void method1()
{
    for (int i = 0; i < 5; i++)
    {
        //Do stuff
        //Then wait 5 seconds
        await Task.Delay(5000);
    }
}
```
Now a more complex use case of async methods is if you want to run an async method multiple times without it overlapping. In the code below, method2 calls for method2Cont to run, then it waits until method2Cont finishes running before it continues onto the next loop.

```csharp
private async void method2()
{
    for(int i = 0; i < 5; i++)
    {
        Task t = method2Cont("String");
        await t;
    }
}
private async Task method2Cont(string type)
{
        for(int i = 0; i < 5; i++)
        {
            //Do stuff with the string
            //Wait 3 seconds
            await Task.Delay(3000);
        }
}
```
**Creating a Setup Wizard**
------------------------------------
First you need to install the extension. Go to Extensions > Manage Extensions > Online > Search, find, download and install Microsoft Visual Studio Installer Projects extension. You may need to restart visual studio.
Afterwards to add a setup wizard, right click on your solution, go to add, and add a new project. From there you can choose setup wizard. Name the setup anything you want and choose create a setup for a Windows application.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/161460394-87d7c476-72ca-4a43-bb49-2875bf44f0d0.png" width="500" height="383"/><img>
</p>

 Then hit next and check "Primary output from webView2B".
 
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/161460421-521c6a3f-8cd7-4c0e-8183-6ccd2642c4f9.png" width="500" height="383"/><img>
</p>

Alternatively you can try to publish your project using visual studio publish options.

**Customizing Your Setup Wizard**
------------------------------------
Right click on the setup project, click on view, and press on File System. From there you can create a desktop shortcut or programs menu shortcut to your primary output. If you left click on the setup project, on the properties window, you can change the icon picture, target platform (x64 or x86), author, manufacturer, and other details of your project.

One thing to take note of is in the system files application folder, these dll files should be there: Microsoft.Web.Webview2.Core.dll, Microsoft.Web.Webview2.Winform.dll, Microsoft.Web.Webview2.Wpf.dll, and WebView2Loader.dll. If one of them is missing, your project may not load properly. 

**Initializing the Browser**
------------------------------------
If you end up making a setup file for your webview project, you'll need to initialize the browser in a certain way or else the webpage of your project will end up being blank. Below the initialize component function, you should initialize your browser like so:
```csharp
public Form1()
{
    InitializeComponent();
    Task delayTask = InitializeBrowser();
    this.Resize += new System.EventHandler(this.Form_Resize);
    webView.NavigationStarting += EnsureHttps;
}
//Initializes the browser for the setup version
private async Task InitializeBrowser()
{
    var userDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AppName";
    var env = await CoreWebView2Environment.CreateAsync(null, userDataFolder);
    await webView.EnsureCoreWebView2Async(env);
    webView.Source = new Uri("https://bing.com"); //Use any webpage you want
}
```

**What This Project is About**
------------------------------------
Originally this started as a webview2 project, but eventually it became more about exploring C# in visual studio. I started this project to update one of my older programs that was still running on Webbrowser using C++. I had to learn C# from scratch since I had no prior experience using it. While I was working on this project, I had a lot of questions that I had trouble finding answers to. That's why I decided to change the direction of this project to be more focused on what C# can do. From this point on, this project will be more focused on how to do things in C# and visual studio.
