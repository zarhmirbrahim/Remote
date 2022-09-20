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

            //Managers.UsersTable v = new();
            //Managers.UserInfo user1, user2;

            //user1 = new();
            //user2 = new();

            //user1.SetName("brahim");
            //user2.SetName("yassine");

            //user1.SetIcon(@"C:\Users\brahim\Pictures\csharp\sharp\Remote\Remote\imgs\testpfp.png");

            //v.SetUser(Guid.NewGuid(), user1);
            //v.SetUser(Guid.NewGuid(), user2);

            //v.ToFile(@"C:\Users\brahim\Pictures\csharp\sharp\Remote\Remote\imgs\FUCK.json");
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

        private void rightSide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}