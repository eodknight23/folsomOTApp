namespace FolsomOTApp.Layout.Client
{
    public partial class MainLayout
    {

        public bool ColapsedState { get; set; } = false;
        private int expandedWidth = 250;
        private int colapsedWidth = 0;
        private string sidebarStyle = "";
        private string mainStyle = "";

        public MainLayout()
        {
            sidebarStyle = $"width: {expandedWidth}px";
            mainStyle = $"margin-left: {expandedWidth}px";
        }

        public void Toggle()
        {
            if (ColapsedState)
            {
                sidebarStyle = $"width: {expandedWidth}px";
                mainStyle = $"margin-left: {expandedWidth}px";
                ColapsedState = false;
            }
            else
            {
                sidebarStyle = $"width: {colapsedWidth}px";
                mainStyle = $"margin-left: {colapsedWidth}px";
                ColapsedState = true;
            }
        }
    }
}
