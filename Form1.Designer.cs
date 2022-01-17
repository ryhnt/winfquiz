
namespace winfquiz
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
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.RadioButton();
            this.b = new System.Windows.Forms.RadioButton();
            this.c = new System.Windows.Forms.RadioButton();
            this.d = new System.Windows.Forms.RadioButton();
            this.pass = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.GroupBox();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(31, 44);
            this.a.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(110, 21);
            this.a.TabIndex = 1;
            this.a.TabStop = true;
            this.a.Text = "radioButton1";
            this.a.UseVisualStyleBackColor = true;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(289, 44);
            this.b.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(110, 21);
            this.b.TabIndex = 2;
            this.b.TabStop = true;
            this.b.Text = "radioButton2";
            this.b.UseVisualStyleBackColor = true;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(31, 110);
            this.c.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(110, 21);
            this.c.TabIndex = 3;
            this.c.TabStop = true;
            this.c.Text = "radioButton3";
            this.c.UseVisualStyleBackColor = true;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(289, 110);
            this.d.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(110, 21);
            this.d.TabIndex = 4;
            this.d.TabStop = true;
            this.d.Text = "radioButton4";
            this.d.UseVisualStyleBackColor = true;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(375, 415);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(124, 28);
            this.pass.TabIndex = 5;
            this.pass.Text = "Sonraki ";
            this.pass.UseVisualStyleBackColor = true;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(85, 415);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 28);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // group
            // 
            this.group.Controls.Add(this.b);
            this.group.Controls.Add(this.d);
            this.group.Controls.Add(this.a);
            this.group.Controls.Add(this.c);
            this.group.Location = new System.Drawing.Point(85, 206);
            this.group.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.group.Name = "group";
            this.group.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.group.Size = new System.Drawing.Size(464, 153);
            this.group.TabIndex = 8;
            this.group.TabStop = false;
            this.group.Text = "ŞIKLAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 559);
            this.Controls.Add(this.group);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Kim 500.000 $ ister?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton a;
        private System.Windows.Forms.RadioButton b;
        private System.Windows.Forms.RadioButton c;
        private System.Windows.Forms.RadioButton d;
        private System.Windows.Forms.Button pass;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox group;
    }
}

