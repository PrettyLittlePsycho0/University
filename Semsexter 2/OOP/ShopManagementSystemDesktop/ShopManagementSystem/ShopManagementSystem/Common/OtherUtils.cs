namespace ShopManagementSystem.Common
{
    internal static class OtherUtils
    {
        public static bool IsAllDigits(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    return false;
                }
            }
            return s.Length > 0;
        }
        
        public static string GetConnectionString()
        {
            return "Server=localhost;Database=POS;Trusted_Connection=True;TrustServerCertificate=True;";
        }
        public static void ShowView<T>(this Panel container) where T : UserControl, new()
        {
            container.Controls.Clear();
            T view = new T();
            view.Dock = DockStyle.Fill;
            container.Controls.Add(view);
        }
        private static readonly Color hoverColor = Color.FromArgb(255, 160, 80);
        private static readonly Color defaultColor = Color.FromArgb(255, 192, 128);

        public static void ApplyHoverEffect(Button btn)
        {
            btn.BackColor = defaultColor;
            btn.MouseEnter += (s, e) =>
            {
                if (s is Button button)
                {
                    button.BackColor = hoverColor;
                }
            };
            btn.MouseLeave += (s, e) =>
            {
                if (s is Button button)
                {
                    button.BackColor = defaultColor;
                }
            };
        }
    }
}