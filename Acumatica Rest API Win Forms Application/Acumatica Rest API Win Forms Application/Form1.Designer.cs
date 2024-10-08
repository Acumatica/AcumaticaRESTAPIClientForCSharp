namespace Acumatica_Rest_API_Win_Forms_Application
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
			label1 = new Label();
			testConnectionButton = new Button();
			urlBox = new TextBox();
			tenantBox = new TextBox();
			label2 = new Label();
			userBox = new TextBox();
			label3 = new Label();
			passwordBox = new TextBox();
			label4 = new Label();
			connectionStatusLabel = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(40, 25);
			label1.Name = "label1";
			label1.Size = new Size(38, 20);
			label1.TabIndex = 0;
			label1.Text = "URL:";
			// 
			// testConnectionButton
			// 
			testConnectionButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			testConnectionButton.Location = new Point(40, 172);
			testConnectionButton.Name = "testConnectionButton";
			testConnectionButton.Size = new Size(555, 29);
			testConnectionButton.TabIndex = 1;
			testConnectionButton.Text = "Test Connection";
			testConnectionButton.UseVisualStyleBackColor = true;
			testConnectionButton.Click += testConnectionButton_Click;
			// 
			// urlBox
			// 
			urlBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			urlBox.Location = new Point(126, 22);
			urlBox.Name = "urlBox";
			urlBox.Size = new Size(469, 27);
			urlBox.TabIndex = 2;
			urlBox.Text = "http://localhost/23r204";
			// 
			// tenantBox
			// 
			tenantBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tenantBox.Location = new Point(126, 55);
			tenantBox.Name = "tenantBox";
			tenantBox.Size = new Size(469, 27);
			tenantBox.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(40, 58);
			label2.Name = "label2";
			label2.Size = new Size(56, 20);
			label2.TabIndex = 4;
			label2.Text = "Tenant:";
			// 
			// userBox
			// 
			userBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			userBox.Location = new Point(126, 88);
			userBox.Name = "userBox";
			userBox.Size = new Size(469, 27);
			userBox.TabIndex = 7;
			userBox.Text = "admin";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(40, 91);
			label3.Name = "label3";
			label3.Size = new Size(41, 20);
			label3.TabIndex = 6;
			label3.Text = "User:";
			// 
			// passwordBox
			// 
			passwordBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			passwordBox.Location = new Point(126, 121);
			passwordBox.Name = "passwordBox";
			passwordBox.Size = new Size(469, 27);
			passwordBox.TabIndex = 9;
			passwordBox.Text = "123";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(40, 124);
			label4.Name = "label4";
			label4.Size = new Size(73, 20);
			label4.TabIndex = 8;
			label4.Text = "Password:";
			// 
			// connectionStatusLabel
			// 
			connectionStatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			connectionStatusLabel.AutoSize = true;
			connectionStatusLabel.Location = new Point(40, 217);
			connectionStatusLabel.Name = "connectionStatusLabel";
			connectionStatusLabel.Size = new Size(128, 20);
			connectionStatusLabel.TabIndex = 10;
			connectionStatusLabel.Text = "Connection Status";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(651, 246);
			Controls.Add(connectionStatusLabel);
			Controls.Add(passwordBox);
			Controls.Add(label4);
			Controls.Add(userBox);
			Controls.Add(label3);
			Controls.Add(tenantBox);
			Controls.Add(label2);
			Controls.Add(urlBox);
			Controls.Add(testConnectionButton);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button testConnectionButton;
		private TextBox urlBox;
		private TextBox tenantBox;
		private Label label2;
		private TextBox userBox;
		private Label label3;
		private TextBox passwordBox;
		private Label label4;
		private Label connectionStatusLabel;
	}
}