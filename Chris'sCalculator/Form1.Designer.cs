using System;

namespace Chris_sCalculator
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
            this.components = new System.ComponentModel.Container();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Multiply.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Multiply.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.Multiply.Location = new System.Drawing.Point(41, 127);
            this.Multiply.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(200, 100);
            this.Multiply.TabIndex = 0;
            this.Multiply.Text = "Multiply";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Divide.Location = new System.Drawing.Point(477, 331);
            this.Divide.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(200, 100);
            this.Divide.TabIndex = 1;
            this.Divide.Text = "Divide";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ADD.Location = new System.Drawing.Point(913, 137);
            this.ADD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(200, 100);
            this.ADD.TabIndex = 2;
            this.ADD.Text = "Add";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.Add_Click);
            // 
            // Subtract
            // 
            this.Subtract.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Subtract.Location = new System.Drawing.Point(25, 500);
            this.Subtract.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(200, 100);
            this.Subtract.TabIndex = 3;
            this.Subtract.Text = "Subtract";
            this.Subtract.UseVisualStyleBackColor = false;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Message.Location = new System.Drawing.Point(894, 511);
            this.Message.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(200, 100);
            this.Message.TabIndex = 4;
            this.Message.Text = "Special Msg";
            this.Message.UseVisualStyleBackColor = false;
            this.Message.Click += new System.EventHandler(this.Message_Click);
            this.Message.MouseHover += new System.EventHandler(this.Message_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 5;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 755);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("MV Boli", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Christopher\'s Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}

