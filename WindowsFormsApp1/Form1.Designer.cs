
namespace WindowsFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userControlProducts1 = new UserControlProduct.UserControlProducts();
            this.productsRandomFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 464);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControlProducts1
            // 
            this.userControlProducts1.Location = new System.Drawing.Point(13, 12);
            this.userControlProducts1.Name = "userControlProducts1";
            this.userControlProducts1.ProductModelId = 0;
            this.userControlProducts1.Size = new System.Drawing.Size(418, 446);
            this.userControlProducts1.TabIndex = 3;
            // 
            // productsRandomFlowLayoutPanel1
            // 
            this.productsRandomFlowLayoutPanel1.AutoScroll = true;
            this.productsRandomFlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsRandomFlowLayoutPanel1.Location = new System.Drawing.Point(437, 12);
            this.productsRandomFlowLayoutPanel1.Name = "productsRandomFlowLayoutPanel1";
            this.productsRandomFlowLayoutPanel1.Size = new System.Drawing.Size(1006, 676);
            this.productsRandomFlowLayoutPanel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1264, 694);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "ClickMeSeeProducts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 739);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.productsRandomFlowLayoutPanel1);
            this.Controls.Add(this.userControlProducts1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private UserControlProduct.UserControlProducts userControlProducts1;
        private System.Windows.Forms.FlowLayoutPanel productsRandomFlowLayoutPanel1;
        private System.Windows.Forms.Button button2;
    }
}

