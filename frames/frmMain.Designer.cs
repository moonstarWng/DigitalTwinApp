namespace DigitalTwinApp
{
    partial class frmMain
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
            wvMain = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)wvMain).BeginInit();
            SuspendLayout();
            // 
            // wvMain
            // 
            wvMain.AllowExternalDrop = true;
            wvMain.CreationProperties = null;
            wvMain.DefaultBackgroundColor = Color.White;
            wvMain.Dock = DockStyle.Fill;
            wvMain.Location = new Point(0, 0);
            wvMain.Name = "wvMain";
            wvMain.Size = new Size(800, 450);
            wvMain.TabIndex = 0;
            wvMain.ZoomFactor = 1D;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wvMain);
            Name = "frmMain";
            Text = "数字孪生测试";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)wvMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvMain;
    }
}
