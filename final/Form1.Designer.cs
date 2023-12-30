
namespace final
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
            this.taskcombobox = new System.Windows.Forms.ComboBox();
            this.newtaskname = new System.Windows.Forms.TextBox();
            this.newpirority = new System.Windows.Forms.TextBox();
            this.newdeadline = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskcombobox
            // 
            this.taskcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskcombobox.FormattingEnabled = true;
            this.taskcombobox.Location = new System.Drawing.Point(423, 58);
            this.taskcombobox.Name = "taskcombobox";
            this.taskcombobox.Size = new System.Drawing.Size(121, 24);
            this.taskcombobox.TabIndex = 0;
            // 
            // newtaskname
            // 
            this.newtaskname.Location = new System.Drawing.Point(444, 125);
            this.newtaskname.Name = "newtaskname";
            this.newtaskname.Size = new System.Drawing.Size(100, 22);
            this.newtaskname.TabIndex = 1;
            this.newtaskname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newpirority
            // 
            this.newpirority.Location = new System.Drawing.Point(444, 158);
            this.newpirority.Name = "newpirority";
            this.newpirority.Size = new System.Drawing.Size(100, 22);
            this.newpirority.TabIndex = 2;
            // 
            // newdeadline
            // 
            this.newdeadline.Location = new System.Drawing.Point(444, 201);
            this.newdeadline.Name = "newdeadline";
            this.newdeadline.Size = new System.Drawing.Size(100, 22);
            this.newdeadline.TabIndex = 3;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(495, 291);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 4;
            this.cancelbtn.Text = "cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(251, 291);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 6;
            this.updatebtn.Text = "update ";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.newdeadline);
            this.Controls.Add(this.newpirority);
            this.Controls.Add(this.newtaskname);
            this.Controls.Add(this.taskcombobox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox taskcombobox;
        private System.Windows.Forms.TextBox newtaskname;
        private System.Windows.Forms.TextBox newpirority;
        private System.Windows.Forms.TextBox newdeadline;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button updatebtn;
    }
}