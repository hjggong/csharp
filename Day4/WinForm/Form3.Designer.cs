namespace WinForm
{
    partial class frmMain
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
            this.btnModal = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(32, 31);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(75, 23);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(123, 31);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(75, 23);
            this.btnModaless.TabIndex = 1;
            this.btnModaless.Text = "Modaless";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(214, 31);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(105, 23);
            this.btnMessage.TabIndex = 2;
            this.btnMessage.Text = "MessageBox";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 86);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnModaless);
            this.Controls.Add(this.btnModal);
            this.Name = "frmMain";
            this.Text = "모달테스";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnModaless;
        private System.Windows.Forms.Button btnMessage;
    }
}