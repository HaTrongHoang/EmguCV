
namespace EmguCV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnChonVung = new System.Windows.Forms.Button();
            this.btnAnhChon = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(29, 34);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(75, 23);
            this.btnChonAnh.TabIndex = 0;
            this.btnChonAnh.Text = "Chon anh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnChonVung
            // 
            this.btnChonVung.Location = new System.Drawing.Point(157, 34);
            this.btnChonVung.Name = "btnChonVung";
            this.btnChonVung.Size = new System.Drawing.Size(90, 23);
            this.btnChonVung.TabIndex = 1;
            this.btnChonVung.Text = "Chon vung";
            this.btnChonVung.UseVisualStyleBackColor = true;
            this.btnChonVung.Click += new System.EventHandler(this.btnChonVung_Click);
            // 
            // btnAnhChon
            // 
            this.btnAnhChon.Location = new System.Drawing.Point(287, 34);
            this.btnAnhChon.Name = "btnAnhChon";
            this.btnAnhChon.Size = new System.Drawing.Size(118, 23);
            this.btnAnhChon.TabIndex = 2;
            this.btnAnhChon.Text = "Anh khoan vung";
            this.btnAnhChon.UseVisualStyleBackColor = true;
            this.btnAnhChon.Click += new System.EventHandler(this.btnAnhChon_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(420, 34);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tim";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(571, 9);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(281, 86);
            this.treeView.TabIndex = 4;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic.Location = new System.Drawing.Point(29, 101);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(977, 434);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 5;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 547);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnAnhChon);
            this.Controls.Add(this.btnChonVung);
            this.Controls.Add(this.btnChonAnh);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnChonVung;
        private System.Windows.Forms.Button btnAnhChon;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.PictureBox pic;
    }
}

