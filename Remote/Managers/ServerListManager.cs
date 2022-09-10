using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote.Managers
{
    public class ServerListManager
    {
        private Panel panel;
        private int buttonsCount = 0;

        public ServerListManager(Panel panel)
        {
            this.panel = panel;

            for (int i = 0; i < 100; i++)
            {
                AddServer(i.ToString());
            }

            RemoveServer(2);
        }

        public void AddServer(string name)
        {
            var button = new Button();
            panel.Controls.Add(button);

            button.BackgroundImage = Image.FromFile(@"C:\Users\brahim\Pictures\csharp\sharp\Remote\Remote\imgs\testpfp.png");
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.Name = "server_" + name;
            button.Text = name;
            button.Size = new Size(52, 52);
            button.Location = new Point(4, (6 + button.Size.Height) * buttonsCount);
            button.TabIndex = buttonsCount;
            button.UseVisualStyleBackColor = true;

            buttonsCount++;
        }


        public void RemoveServer(int id)
        {
            if (id >= panel.Controls.Count && buttonsCount > 0)
                return;

            panel.Controls.RemoveAt(id);
            --buttonsCount;

            for (int i = id; i < panel.Controls.Count; i++)
            {
                var button = panel.Controls[i] as Button;
                if (button != null)
                    button.Location = new Point(4, (6 + button.Size.Height) * i);
            }
        }
    }
}
