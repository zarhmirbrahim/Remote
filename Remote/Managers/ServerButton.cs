using System;
using System.Collections.Generic;

namespace Remote.Managers
{
    public class ServerButton
    {
        public readonly Guid ID = Guid.NewGuid();

        private Button Btn;

        public ServerButton(Panel panel, Image icon, int buttonsCount)
        {
            Btn = new Button();
            panel.Controls.Add(Btn);

            Btn.BackgroundImage = icon;
            Btn.Text = buttonsCount.ToString();
            Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Btn.FlatAppearance.BorderSize = 0;
            Btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Btn.FlatStyle = FlatStyle.Flat;
            Btn.Size = new Size(52, 52);
            Btn.TabIndex = buttonsCount;
            Btn.UseVisualStyleBackColor = true;

            SetYPosition(buttonsCount);
            Btn.Click += OnOpen;
        }

        public void Remove(Panel panel)
        {
            panel.Controls.Remove(Btn);
        }

        private void OnOpen(object? sender, EventArgs e)
        {
            if (ServerListManager.ActiveButton == this)
                return;
            ServerListManager.ActiveButton = this;

        }

        public void SetYPosition(int y)
        {
            Btn.Location = new Point(4, (6 + Btn.Size.Height) * y);
        }
    }
}
