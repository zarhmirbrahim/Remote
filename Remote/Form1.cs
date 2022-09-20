namespace Remote
{
    public partial class RemoteChat : Form
    {
        private const int leftWidth = 85;
        private Managers.ServerListManager serverList;

        public static Managers.ServerManager ServerManager;

        public RemoteChat()
        {
            InitializeComponent();
            UpdatePanelLayout();

            serverList = new(leftSide);
            ServerManager = new(rightSide);
        }

        private void RemoteChat_SizeChanged(object sender, EventArgs e)
        {
            UpdatePanelLayout();
        }

        private void UpdatePanelLayout()
        {
            var size = leftSide.Size;
            size.Width = leftWidth;
            leftSide.Size = size;

            size = rightSide.Size;
            size.Width = this.ClientSize.Width - leftWidth;
            rightSide.Size = size;
        }


        static async Task test()
        {

        }

        private void rightSide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}