namespace Remote
{
    partial class RemoteChat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftSide = new System.Windows.Forms.Panel();
            this.rightSide = new System.Windows.Forms.Panel();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.channelsPanel = new System.Windows.Forms.Panel();
            this.rightSide.SuspendLayout();
            this.chatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftSide
            // 
            this.leftSide.AutoScroll = true;
            this.leftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.leftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSide.Location = new System.Drawing.Point(0, 0);
            this.leftSide.Name = "leftSide";
            this.leftSide.Size = new System.Drawing.Size(85, 673);
            this.leftSide.TabIndex = 0;
            // 
            // rightSide
            // 
            this.rightSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.rightSide.Controls.Add(this.chatPanel);
            this.rightSide.Controls.Add(this.usersPanel);
            this.rightSide.Controls.Add(this.channelsPanel);
            this.rightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightSide.Location = new System.Drawing.Point(102, 0);
            this.rightSide.Name = "rightSide";
            this.rightSide.Size = new System.Drawing.Size(1160, 673);
            this.rightSide.TabIndex = 1;
            this.rightSide.Paint += new System.Windows.Forms.PaintEventHandler(this.rightSide_Paint);
            // 
            // chatPanel
            // 
            this.chatPanel.Controls.Add(this.panel2);
            this.chatPanel.Controls.Add(this.panel1);
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatPanel.Location = new System.Drawing.Point(173, 0);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(780, 673);
            this.chatPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 622);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 51);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 616);
            this.panel1.TabIndex = 0;
            // 
            // usersPanel
            // 
            this.usersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.usersPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.usersPanel.Location = new System.Drawing.Point(953, 0);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Size = new System.Drawing.Size(207, 673);
            this.usersPanel.TabIndex = 1;
            // 
            // channelsPanel
            // 
            this.channelsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.channelsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.channelsPanel.Location = new System.Drawing.Point(0, 0);
            this.channelsPanel.Name = "channelsPanel";
            this.channelsPanel.Size = new System.Drawing.Size(173, 673);
            this.channelsPanel.TabIndex = 0;
            // 
            // RemoteChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.rightSide);
            this.Controls.Add(this.leftSide);
            this.Name = "RemoteChat";
            this.Text = "Remote";
            this.SizeChanged += new System.EventHandler(this.RemoteChat_SizeChanged);
            this.rightSide.ResumeLayout(false);
            this.chatPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel leftSide;
        private Panel rightSide;
        private Panel chatPanel;
        private Panel usersPanel;
        private Panel channelsPanel;
        private Panel panel2;
        private Panel panel1;
    }
}