namespace Remote
{
    public partial class RemoteChat : Form
    {
        private const int leftWidth = 85;
        private Managers.ServerListManager serverList;

        public RemoteChat()
        {
            InitializeComponent();
            UpdatePanelLayout();

            serverList = new(leftSide);
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
    }
}