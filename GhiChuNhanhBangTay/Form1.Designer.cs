namespace GhiChuNhanhBangTay
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
            pnlCanvas = new Panel();
            lblViTri = new Label();
            pnlCanvas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCanvas
            // 
            pnlCanvas.BackColor = Color.White;
            pnlCanvas.Controls.Add(lblViTri);
            pnlCanvas.Location = new Point(3, 1);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(796, 452);
            pnlCanvas.TabIndex = 0;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
            pnlCanvas.MouseDown += pnlCanvas_MouseDown;
            pnlCanvas.MouseMove += pnlCanvas_MouseMove;
            pnlCanvas.MouseUp += pnlCanvas_MouseUp;
            // 
            // lblViTri
            // 
            lblViTri.AutoSize = true;
            lblViTri.Location = new Point(9, 432);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(42, 20);
            lblViTri.TabIndex = 0;
            lblViTri.Text = "Vị Trí";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCanvas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlCanvas.ResumeLayout(false);
            pnlCanvas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCanvas;
        private Label lblViTri;
    }
}
