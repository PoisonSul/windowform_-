﻿namespace Week09_02
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("베토밴");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("슈베르트");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("모짜르트");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("클래식", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Britney");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Spears");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Mariah Carey");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Capenters");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("팝", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("이승환");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("전인권");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("이효리");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("가요", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.png");
            this.imageList1.Images.SetKeyName(1, "CD.png");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 28);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "노드 추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "노드 삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(11, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "베토밴";
            treeNode1.Text = "베토밴";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "슈베르트";
            treeNode2.Text = "슈베르트";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "모짜르트";
            treeNode3.Text = "모짜르트";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "클래식";
            treeNode4.Text = "클래식";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "Britney";
            treeNode5.Text = "Britney";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "Spears";
            treeNode6.Text = "Spears";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "Mariah Carey";
            treeNode7.Text = "Mariah Carey";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "Capenters";
            treeNode8.Text = "Capenters";
            treeNode9.Name = "노드2";
            treeNode9.Text = "팝";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "이승환";
            treeNode10.Text = "이승환";
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "전인권";
            treeNode11.Text = "전인권";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "이효리";
            treeNode12.Text = "이효리";
            treeNode13.Name = "노드3";
            treeNode13.Text = "가요";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode9,
            treeNode13});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(248, 253);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "WEEK09-02";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView treeView1;
    }
}

