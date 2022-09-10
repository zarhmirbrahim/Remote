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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rightSide.SuspendLayout();
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
            this.rightSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.rightSide.Controls.Add(this.richTextBox1);
            this.rightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightSide.Location = new System.Drawing.Point(102, 0);
            this.rightSide.Name = "rightSide";
            this.rightSide.Size = new System.Drawing.Size(1160, 673);
            this.rightSide.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(190, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(125, 120);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
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
            this.ResumeLayout(false);

        }

        #endregion

        private Panel leftSide;
        private Panel rightSide;
        private RichTextBox richTextBox1;
    }
}