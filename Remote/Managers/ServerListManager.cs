using System;
using System.Collections.Generic;
using System.Linq;

namespace Remote.Managers
{
    public class ServerListManager
    {
        private Panel panel;
        private List<ServerButton> serverButtons = new();
        
        public static ServerButton? ActiveButton = null;

        public ServerListManager(Panel panel)
        {
            this.panel = panel;

            for (int i = 0; i < 100; i++)
            {
                AddServer(Image.FromFile(@"C:\Users\brahim\Pictures\csharp\sharp\Remote\Remote\imgs\testpfp.png"));
            }

            RemoveServer(serverButtons[10].ID);
        }

        public void AddServer(Image icon)
        {
            serverButtons.Add(new(panel, icon, serverButtons.Count));
        }


        public void RemoveServer(Guid id)
        {
            for (int i = 0; i < serverButtons.Count; i++)
            {
                var button = serverButtons[i];
                if (button.ID == id)
                {
                    button.Remove(panel);
                    serverButtons.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < serverButtons.Count; i++)
            {
                serverButtons[i].SetYPosition(i);
            }
        }
    }
}
