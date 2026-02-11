using ShopManagementSystem.Common;
using System.Runtime.InteropServices;
namespace ShopManagementSystem
{
    public partial class MainForm : Form
    {
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        [DllImport("dwmapi.dll", PreserveSig = true)]
        private static extern int DwmSetWindowAttribute(
            IntPtr hwnd,
            int attr,
            ref int attrValue,
            int attrSize);

        
        public MainForm()
        {
            InitializeComponent();
            SetDarkMode();
            

        }

        private void SetDarkMode()
        {
            if (Handle != IntPtr.Zero)
            {
                // Set the value to 1 (TRUE) to enable dark mode for the window frame
                int attributeValue = 1;

                try
                {
                    // This call attempts to set the dark theme for the non-client area
                    DwmSetWindowAttribute(
                        Handle,
                        DWMWA_USE_IMMERSIVE_DARK_MODE,
                        ref attributeValue,
                        sizeof(int));
                }
                catch
                {
                    // Handle cases where dwmapi.dll isn't available (e.g., older Windows versions)
                }
            }
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            container.ShowView<mainMenuUI>();
        }
    }
}
