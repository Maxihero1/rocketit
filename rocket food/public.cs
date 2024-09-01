public Form1()
{
    InitializeComponent();
    
    string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
    string pagePath = Path.Combine(currentDirectory, "web", "index.html");
    webBrowser1.Navigate(pagePath);
}
