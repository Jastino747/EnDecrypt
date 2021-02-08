namespace EnDecrypt
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
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.buttonClose2 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecrypt.Location = new System.Drawing.Point(520, 386);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(251, 60);
            this.buttonDecrypt.TabIndex = 22;
            this.buttonDecrypt.TabStop = false;
            this.buttonDecrypt.Text = "Decrypt Text";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncrypt.Location = new System.Drawing.Point(25, 386);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(251, 60);
            this.buttonEncrypt.TabIndex = 21;
            this.buttonEncrypt.TabStop = false;
            this.buttonEncrypt.Text = "Encrypt Text";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(725, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "OUTPUT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "INPUT";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 55);
            this.label3.TabIndex = 18;
            this.label3.Text = "EnDecrypt";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(0, 500);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(800, 300);
            this.richTextBoxOutput.TabIndex = 17;
            this.richTextBoxOutput.TabStop = false;
            this.richTextBoxOutput.Text = "";
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(0, 80);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(800, 300);
            this.richTextBoxInput.TabIndex = 14;
            this.richTextBoxInput.Text = "";
            // 
            // buttonClose2
            // 
            this.buttonClose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose2.Location = new System.Drawing.Point(0, 0);
            this.buttonClose2.Name = "buttonClose2";
            this.buttonClose2.Size = new System.Drawing.Size(40, 40);
            this.buttonClose2.TabIndex = 16;
            this.buttonClose2.TabStop = false;
            this.buttonClose2.Text = "X";
            this.buttonClose2.UseVisualStyleBackColor = true;
            this.buttonClose2.Click += new System.EventHandler(this.buttonClose2_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(760, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "This program is case sensitive, so pay attention to your text input.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTest
            // 
            this.buttonTest.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTest.Location = new System.Drawing.Point(282, 386);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(232, 60);
            this.buttonTest.TabIndex = 24;
            this.buttonTest.TabStop = false;
            this.buttonTest.Text = "Test Keys";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.buttonClose2);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Button buttonClose2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTest;
    }
}

