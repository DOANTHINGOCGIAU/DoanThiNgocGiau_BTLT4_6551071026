namespace ToDoList
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
            components = new System.ComponentModel.Container();
            cmsCongViec = new ContextMenuStrip(components);
            đánhDấuHoànThànhToolStripMenuItem = new ToolStripMenuItem();
            xóaCôngViệcNàyToolStripMenuItem = new ToolStripMenuItem();
            xóaTấtCảToolStripMenuItem = new ToolStripMenuItem();
            lblCongViecMoi = new Label();
            txtCongViecMoi = new TextBox();
            btnThem = new Button();
            lstCongViec = new ListBox();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new Size(20, 20);
            cmsCongViec.Items.AddRange(new ToolStripItem[] { đánhDấuHoànThànhToolStripMenuItem, xóaCôngViệcNàyToolStripMenuItem, xóaTấtCảToolStripMenuItem });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new Size(221, 76);
            // 
            // đánhDấuHoànThànhToolStripMenuItem
            // 
            đánhDấuHoànThànhToolStripMenuItem.Name = "đánhDấuHoànThànhToolStripMenuItem";
            đánhDấuHoànThànhToolStripMenuItem.Size = new Size(220, 24);
            đánhDấuHoànThànhToolStripMenuItem.Text = "Đánh dấu hoàn thành";
            đánhDấuHoànThànhToolStripMenuItem.Click += đánhDấuHoànThànhToolStripMenuItem_Click;
            // 
            // xóaCôngViệcNàyToolStripMenuItem
            // 
            xóaCôngViệcNàyToolStripMenuItem.Name = "xóaCôngViệcNàyToolStripMenuItem";
            xóaCôngViệcNàyToolStripMenuItem.Size = new Size(220, 24);
            xóaCôngViệcNàyToolStripMenuItem.Text = "Xóa công việc này";
            xóaCôngViệcNàyToolStripMenuItem.Click += xóaCôngViệcNàyToolStripMenuItem_Click;
            // 
            // xóaTấtCảToolStripMenuItem
            // 
            xóaTấtCảToolStripMenuItem.Name = "xóaTấtCảToolStripMenuItem";
            xóaTấtCảToolStripMenuItem.Size = new Size(220, 24);
            xóaTấtCảToolStripMenuItem.Text = "Xóa tất cả";
            xóaTấtCảToolStripMenuItem.Click += xóaTấtCảToolStripMenuItem_Click;
            // 
            // lblCongViecMoi
            // 
            lblCongViecMoi.AutoSize = true;
            lblCongViecMoi.Location = new Point(12, 79);
            lblCongViecMoi.Name = "lblCongViecMoi";
            lblCongViecMoi.Size = new Size(106, 20);
            lblCongViecMoi.TabIndex = 1;
            lblCongViecMoi.Text = "Công Việc Mới";
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Location = new Point(201, 72);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(400, 27);
            txtCongViecMoi.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThem.Location = new Point(306, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(137, 47);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lstCongViec
            // 
            lstCongViec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(86, 134);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(617, 304);
            lstCongViec.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCongViec);
            Controls.Add(btnThem);
            Controls.Add(txtCongViecMoi);
            Controls.Add(lblCongViecMoi);
            Name = "Form1";
            Text = "Form1";
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem đánhDấuHoànThànhToolStripMenuItem;
        private ToolStripMenuItem xóaCôngViệcNàyToolStripMenuItem;
        private ToolStripMenuItem xóaTấtCảToolStripMenuItem;
        private Label lblCongViecMoi;
        private TextBox txtCongViecMoi;
        private Button btnThem;
        private ListBox lstCongViec;
    }
}
