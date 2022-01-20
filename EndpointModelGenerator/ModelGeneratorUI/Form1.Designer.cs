namespace ModelGeneratorUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SelectProjectButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.EndpointTextBox = new System.Windows.Forms.TextBox();
            this.PathToModelTextBox = new System.Windows.Forms.TextBox();
            this.SchemaTextBox = new System.Windows.Forms.TextBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ArrayCollectionsCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endpoint:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Path to Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Step 2: Paste JSON schema into the box below:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Step 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Log";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "C# Project (*.csproj) | *.csproj";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // SelectProjectButton
            // 
            this.SelectProjectButton.Location = new System.Drawing.Point(155, 30);
            this.SelectProjectButton.Name = "SelectProjectButton";
            this.SelectProjectButton.Size = new System.Drawing.Size(605, 29);
            this.SelectProjectButton.TabIndex = 7;
            this.SelectProjectButton.Text = "Slect Project";
            this.SelectProjectButton.UseVisualStyleBackColor = true;
            this.SelectProjectButton.Click += new System.EventHandler(this.SelectProjectButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathTextBox.Enabled = false;
            this.PathTextBox.Location = new System.Drawing.Point(155, 71);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(605, 27);
            this.PathTextBox.TabIndex = 8;
            // 
            // EndpointTextBox
            // 
            this.EndpointTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndpointTextBox.Location = new System.Drawing.Point(155, 111);
            this.EndpointTextBox.Name = "EndpointTextBox";
            this.EndpointTextBox.Size = new System.Drawing.Size(605, 27);
            this.EndpointTextBox.TabIndex = 9;
            // 
            // PathToModelTextBox
            // 
            this.PathToModelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathToModelTextBox.Location = new System.Drawing.Point(155, 156);
            this.PathToModelTextBox.Name = "PathToModelTextBox";
            this.PathToModelTextBox.Size = new System.Drawing.Size(605, 27);
            this.PathToModelTextBox.TabIndex = 10;
            // 
            // SchemaTextBox
            // 
            this.SchemaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SchemaTextBox.Location = new System.Drawing.Point(155, 227);
            this.SchemaTextBox.Multiline = true;
            this.SchemaTextBox.Name = "SchemaTextBox";
            this.SchemaTextBox.Size = new System.Drawing.Size(605, 95);
            this.SchemaTextBox.TabIndex = 11;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.Location = new System.Drawing.Point(155, 411);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(605, 93);
            this.LogTextBox.TabIndex = 12;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(155, 363);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(605, 29);
            this.GenerateButton.TabIndex = 14;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ArrayCollectionsCheckbox
            // 
            this.ArrayCollectionsCheckbox.AutoSize = true;
            this.ArrayCollectionsCheckbox.Location = new System.Drawing.Point(155, 333);
            this.ArrayCollectionsCheckbox.Name = "ArrayCollectionsCheckbox";
            this.ArrayCollectionsCheckbox.Size = new System.Drawing.Size(347, 24);
            this.ArrayCollectionsCheckbox.TabIndex = 15;
            this.ArrayCollectionsCheckbox.Text = "Generate collections as Arrays (Lists are default)";
            this.ArrayCollectionsCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 516);
            this.Controls.Add(this.ArrayCollectionsCheckbox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.SchemaTextBox);
            this.Controls.Add(this.PathToModelTextBox);
            this.Controls.Add(this.EndpointTextBox);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.SelectProjectButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectProjectButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.TextBox EndpointTextBox;
        private System.Windows.Forms.TextBox PathToModelTextBox;
        private System.Windows.Forms.TextBox SchemaTextBox;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox ArrayCollectionsCheckbox;
    }
}
