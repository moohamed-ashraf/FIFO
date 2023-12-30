
namespace final
{
    partial class updateForm
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
            this.backbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prioritytxt = new System.Windows.Forms.TextBox();
            this.deadlinetxt = new System.Windows.Forms.TextBox();
            this.tasknamesearchtxt = new System.Windows.Forms.TextBox();
            this.updatetaskbtn = new System.Windows.Forms.Button();
            this.newnametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(236, 397);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(144, 27);
            this.backbtn.TabIndex = 23;
            this.backbtn.Text = "BACK";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Priority:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Deadline:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Task Name to update:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // prioritytxt
            // 
            this.prioritytxt.Location = new System.Drawing.Point(293, 229);
            this.prioritytxt.Name = "prioritytxt";
            this.prioritytxt.Size = new System.Drawing.Size(201, 22);
            this.prioritytxt.TabIndex = 18;
            this.prioritytxt.TextChanged += new System.EventHandler(this.prioritytxt_TextChanged);
            // 
            // deadlinetxt
            // 
            this.deadlinetxt.Location = new System.Drawing.Point(293, 330);
            this.deadlinetxt.Name = "deadlinetxt";
            this.deadlinetxt.Size = new System.Drawing.Size(201, 22);
            this.deadlinetxt.TabIndex = 19;
            this.deadlinetxt.TextChanged += new System.EventHandler(this.deadlinetxt_TextChanged);
            // 
            // tasknamesearchtxt
            // 
            this.tasknamesearchtxt.Location = new System.Drawing.Point(284, 49);
            this.tasknamesearchtxt.Name = "tasknamesearchtxt";
            this.tasknamesearchtxt.Size = new System.Drawing.Size(201, 22);
            this.tasknamesearchtxt.TabIndex = 17;
            this.tasknamesearchtxt.TextChanged += new System.EventHandler(this.taskname_TextChanged);
            // 
            // updatetaskbtn
            // 
            this.updatetaskbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatetaskbtn.Location = new System.Drawing.Point(422, 397);
            this.updatetaskbtn.Name = "updatetaskbtn";
            this.updatetaskbtn.Size = new System.Drawing.Size(144, 27);
            this.updatetaskbtn.TabIndex = 16;
            this.updatetaskbtn.Text = "Update";
            this.updatetaskbtn.UseVisualStyleBackColor = true;
            this.updatetaskbtn.Click += new System.EventHandler(this.updatetaskbtn_Click);
            // 
            // newnametxt
            // 
            this.newnametxt.Location = new System.Drawing.Point(284, 150);
            this.newnametxt.Name = "newnametxt";
            this.newnametxt.Size = new System.Drawing.Size(201, 22);
            this.newnametxt.TabIndex = 17;
            this.newnametxt.TextChanged += new System.EventHandler(this.taskname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "New Task Name:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::final.Properties.Resources.WhatsApp_Image_2023_12_26_at_1_24_39_PM;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prioritytxt);
            this.Controls.Add(this.deadlinetxt);
            this.Controls.Add(this.newnametxt);
            this.Controls.Add(this.tasknamesearchtxt);
            this.Controls.Add(this.updatetaskbtn);
            this.Name = "updateForm";
            this.Text = "updateForm";
            this.Load += new System.EventHandler(this.updateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prioritytxt;
        private System.Windows.Forms.TextBox deadlinetxt;
        private System.Windows.Forms.TextBox tasknamesearchtxt;
        private System.Windows.Forms.Button updatetaskbtn;
        private System.Windows.Forms.TextBox newnametxt;
        private System.Windows.Forms.Label label4;
    }
}