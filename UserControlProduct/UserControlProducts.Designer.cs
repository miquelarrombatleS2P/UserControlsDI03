
namespace UserControlProduct
{
    partial class UserControlProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.colorFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sizeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.IdTextBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.sizeFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(16, 17);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(391, 183);
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 206);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(391, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // colorFlowLayoutPanel
            // 
            this.colorFlowLayoutPanel.Location = new System.Drawing.Point(16, 234);
            this.colorFlowLayoutPanel.Name = "colorFlowLayoutPanel";
            this.colorFlowLayoutPanel.Size = new System.Drawing.Size(391, 66);
            this.colorFlowLayoutPanel.TabIndex = 2;
            // 
            // sizeFlowLayoutPanel
            // 
            this.sizeFlowLayoutPanel.Controls.Add(this.flowLayoutPanel2);
            this.sizeFlowLayoutPanel.Location = new System.Drawing.Point(16, 306);
            this.sizeFlowLayoutPanel.Name = "sizeFlowLayoutPanel";
            this.sizeFlowLayoutPanel.Size = new System.Drawing.Size(391, 86);
            this.sizeFlowLayoutPanel.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // IdTextBox1
            // 
            this.IdTextBox1.Location = new System.Drawing.Point(307, 398);
            this.IdTextBox1.Name = "IdTextBox1";
            this.IdTextBox1.ReadOnly = true;
            this.IdTextBox1.Size = new System.Drawing.Size(100, 22);
            this.IdTextBox1.TabIndex = 4;
            // 
            // UserControlProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdTextBox1);
            this.Controls.Add(this.sizeFlowLayoutPanel);
            this.Controls.Add(this.colorFlowLayoutPanel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.productPictureBox);
            this.Name = "UserControlProducts";
            this.Size = new System.Drawing.Size(417, 428);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.sizeFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.FlowLayoutPanel colorFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel sizeFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox IdTextBox1;
    }
}
