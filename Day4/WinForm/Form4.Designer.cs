namespace WinForm
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trv1 = new System.Windows.Forms.TreeView();
            this.lstv1 = new System.Windows.Forms.ListView();
            this.addRoot = new System.Windows.Forms.Button();
            this.addChild = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addChild);
            this.groupBox1.Controls.Add(this.addRoot);
            this.groupBox1.Controls.Add(this.lstv1);
            this.groupBox1.Controls.Add(this.trv1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TreeView & ListView";
            // 
            // trv1
            // 
            this.trv1.Location = new System.Drawing.Point(23, 32);
            this.trv1.Name = "trv1";
            this.trv1.Size = new System.Drawing.Size(183, 194);
            this.trv1.TabIndex = 0;
            // 
            // lstv1
            // 
            this.lstv1.Location = new System.Drawing.Point(231, 32);
            this.lstv1.Name = "lstv1";
            this.lstv1.Size = new System.Drawing.Size(183, 194);
            this.lstv1.TabIndex = 1;
            this.lstv1.UseCompatibleStateImageBehavior = false;
            this.lstv1.View = System.Windows.Forms.View.Details;
            // 
            // addRoot
            // 
            this.addRoot.Location = new System.Drawing.Point(59, 234);
            this.addRoot.Name = "addRoot";
            this.addRoot.Size = new System.Drawing.Size(111, 30);
            this.addRoot.TabIndex = 1;
            this.addRoot.Text = "루트추가";
            this.addRoot.UseVisualStyleBackColor = true;
            this.addRoot.Click += new System.EventHandler(this.addRoot_Click);
            // 
            // addChild
            // 
            this.addChild.Location = new System.Drawing.Point(267, 234);
            this.addChild.Name = "addChild";
            this.addChild.Size = new System.Drawing.Size(111, 30);
            this.addChild.TabIndex = 2;
            this.addChild.Text = "자식추가";
            this.addChild.UseVisualStyleBackColor = true;
            this.addChild.Click += new System.EventHandler(this.addChild_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 315);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "TreeView & ListView TEST";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addChild;
        private System.Windows.Forms.Button addRoot;
        private System.Windows.Forms.ListView lstv1;
        private System.Windows.Forms.TreeView trv1;
    }
}