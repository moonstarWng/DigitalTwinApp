namespace DigitalTwinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            //string htmlPath = Path.Combine(Application.StartupPath, "Assets", "index.html");
            //string uri = new Uri(htmlPath).AbsoluteUri;
            string uri = "http://localhost:8000/Assets/index.html";
            await wvMain.EnsureCoreWebView2Async(null);
            wvMain.Source = new Uri(uri);
            wvMain.CoreWebView2.OpenDevToolsWindow();   // 打开控制台
        }
    }
}
