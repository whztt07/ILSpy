﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under MIT X11 license (for details please see \doc\license.txt)

namespace ICSharpCode.NRefactory.Demo
{
	partial class VBDemo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.codeView = new System.Windows.Forms.TextBox();
			this.editNodeButton = new System.Windows.Forms.Button();
			this.clearSpecialsButton = new System.Windows.Forms.Button();
			this.syntaxTree = new ICSharpCode.NRefactory.Demo.VBAstView();
			this.generateCodeButton = new System.Windows.Forms.Button();
			this.parseButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.codeView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.editNodeButton);
			this.splitContainer1.Panel2.Controls.Add(this.clearSpecialsButton);
			this.splitContainer1.Panel2.Controls.Add(this.syntaxTree);
			this.splitContainer1.Panel2.Controls.Add(this.generateCodeButton);
			this.splitContainer1.Panel2.Controls.Add(this.parseButton);
			this.splitContainer1.Size = new System.Drawing.Size(462, 391);
			this.splitContainer1.SplitterDistance = 173;
			this.splitContainer1.TabIndex = 1;
			// 
			// codeView
			// 
			this.codeView.AcceptsReturn = true;
			this.codeView.AcceptsTab = true;
			this.codeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.codeView.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.codeView.HideSelection = false;
			this.codeView.Location = new System.Drawing.Point(0, 0);
			this.codeView.Multiline = true;
			this.codeView.Name = "codeView";
			this.codeView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.codeView.Size = new System.Drawing.Size(462, 173);
			this.codeView.TabIndex = 0;
			this.codeView.Text = "Imports System\r\nClass Test\r\n    Public Sub Main(ByVal args As String())\r\n        " +
			" Console.WriteLine(\"Hello, World\")\r\n    End Sub\r\nEnd Class";
			this.codeView.WordWrap = false;
			// 
			// editNodeButton
			// 
			this.editNodeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.editNodeButton.Location = new System.Drawing.Point(331, 2);
			this.editNodeButton.Name = "editNodeButton";
			this.editNodeButton.Size = new System.Drawing.Size(100, 23);
			this.editNodeButton.TabIndex = 4;
			this.editNodeButton.Text = "Edit node";
			this.editNodeButton.UseVisualStyleBackColor = true;
			this.editNodeButton.Click += new System.EventHandler(this.EditNodeButtonClick);
			// 
			// clearSpecialsButton
			// 
			this.clearSpecialsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.clearSpecialsButton.Location = new System.Drawing.Point(225, 2);
			this.clearSpecialsButton.Name = "clearSpecialsButton";
			this.clearSpecialsButton.Size = new System.Drawing.Size(100, 23);
			this.clearSpecialsButton.TabIndex = 3;
			this.clearSpecialsButton.Text = "Clear 0 specials";
			this.clearSpecialsButton.UseVisualStyleBackColor = true;
			this.clearSpecialsButton.Click += new System.EventHandler(this.ClearSpecialsButtonClick);
			// 
			// syntaxTree
			// 
			this.syntaxTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.syntaxTree.Location = new System.Drawing.Point(3, 32);
			this.syntaxTree.Name = "syntaxTree";
			this.syntaxTree.Size = new System.Drawing.Size(459, 182);
			this.syntaxTree.TabIndex = 2;
			this.syntaxTree.Unit = null;
			// 
			// generateCodeButton
			// 
			this.generateCodeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.generateCodeButton.Location = new System.Drawing.Point(119, 2);
			this.generateCodeButton.Name = "generateCodeButton";
			this.generateCodeButton.Size = new System.Drawing.Size(100, 23);
			this.generateCodeButton.TabIndex = 1;
			this.generateCodeButton.Text = "Generate";
			this.generateCodeButton.UseVisualStyleBackColor = true;
			this.generateCodeButton.Click += new System.EventHandler(this.GenerateCodeButtonClick);
			// 
			// parseButton
			// 
			this.parseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.parseButton.Location = new System.Drawing.Point(13, 2);
			this.parseButton.Name = "parseButton";
			this.parseButton.Size = new System.Drawing.Size(100, 23);
			this.parseButton.TabIndex = 0;
			this.parseButton.Text = "Parse";
			this.parseButton.UseVisualStyleBackColor = true;
			this.parseButton.Click += new System.EventHandler(this.ParseButtonClick);
			// 
			// VBDemo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "VBDemo";
			this.Size = new System.Drawing.Size(462, 391);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button clearSpecialsButton;
		private System.Windows.Forms.Button editNodeButton;
		private ICSharpCode.NRefactory.Demo.VBAstView syntaxTree;
		private System.Windows.Forms.TextBox codeView;
		private System.Windows.Forms.Button generateCodeButton;
		private System.Windows.Forms.Button parseButton;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}
