
using System.Drawing;
using System;
using System.Windows.Forms;

namespace ZeldaRemake
{
    partial class Form1
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
            this.startBt = new System.Windows.Forms.Button();
            this.exitBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBt
            // 
            this.startBt.BackColor = System.Drawing.Color.Transparent;
            this.startBt.BackgroundImage = global::ZeldaRemake.Properties.Resources.btBackground;
            this.startBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startBt.FlatAppearance.BorderSize = 0;
            this.startBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBt.Location = new System.Drawing.Point(190, 145);
            this.startBt.Name = "startBt";
            this.startBt.Size = new System.Drawing.Size(150, 50);
            this.startBt.TabIndex = 0;
            this.startBt.Text = "START";
            this.startBt.UseVisualStyleBackColor = false;
            this.startBt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartBt);
            // 
            // exitBt
            // 
            this.exitBt.BackColor = System.Drawing.Color.Transparent;
            this.exitBt.BackgroundImage = global::ZeldaRemake.Properties.Resources.btBackground;
            this.exitBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBt.FlatAppearance.BorderSize = 0;
            this.exitBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBt.Location = new System.Drawing.Point(190, 232);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(150, 50);
            this.exitBt.TabIndex = 1;
            this.exitBt.Text = "EXIT";
            this.exitBt.UseVisualStyleBackColor = false;
            this.exitBt.Click += new System.EventHandler(this.ExitBt);
            // 
            // Form1
            // 
            this.BackgroundImage = global::ZeldaRemake.Properties.Resources.mainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.exitBt);
            this.Controls.Add(this.startBt);
            this.Name = "Form1";
            this.Text = "ZeldaRemake";
            this.ResumeLayout(false);

        }

        private Button startBt;
        private Button exitBt;
        #endregion
    }
}

