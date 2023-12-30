
namespace final
{
    partial class addForm
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
            this.addtaskbtn = new System.Windows.Forms.Button();
            this.taskname = new System.Windows.Forms.TextBox();
            this.deadlinetxt = new System.Windows.Forms.TextBox();
            this.prioritytxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addtaskbtn
            // 
            this.addtaskbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtaskbtn.Location = new System.Drawing.Point(398, 342);
            this.addtaskbtn.Name = "addtaskbtn";
            this.addtaskbtn.Size = new System.Drawing.Size(144, 27);
            this.addtaskbtn.TabIndex = 0;
            this.addtaskbtn.Text = "ADD task";
            this.addtaskbtn.UseVisualStyleBackColor = true;
            this.addtaskbtn.Click += new System.EventHandler(this.addtaskbtn_Click);
            // 
            // taskname
            // 
            this.taskname.Location = new System.Drawing.Point(269, 73);
            this.taskname.Name = "taskname";
            this.taskname.Size = new System.Drawing.Size(201, 22);
            this.taskname.TabIndex = 1;
            this.taskname.TextChanged += new System.EventHandler(this.taskname_TextChanged);
            // 
            // deadlinetxt
            // 
            this.deadlinetxt.Location = new System.Drawing.Point(269, 275);
            this.deadlinetxt.Name = "deadlinetxt";
            this.deadlinetxt.Size = new System.Drawing.Size(201, 22);
            this.deadlinetxt.TabIndex = 3;
            this.deadlinetxt.TextChanged += new System.EventHandler(this.deadlinetxt_TextChanged);
            // 
            // prioritytxt
            // 
            this.prioritytxt.Location = new System.Drawing.Point(269, 174);
            this.prioritytxt.Name = "prioritytxt";
            this.prioritytxt.Size = new System.Drawing.Size(201, 22);
            this.prioritytxt.TabIndex = 2;
            this.prioritytxt.TextChanged += new System.EventHandler(this.prioritytxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Task Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Deadline:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Priority:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(212, 342);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(144, 27);
            this.backbtn.TabIndex = 7;
            this.backbtn.Text = "BACK";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(476, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "ex: 2000-7-5 12:am";
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::final.Properties.Resources.WhatsApp_Image_2023_12_26_at_1_24_39_PM;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prioritytxt);
            this.Controls.Add(this.deadlinetxt);
            this.Controls.Add(this.taskname);
            this.Controls.Add(this.addtaskbtn);
            this.Name = "addForm";
            this.Text = "addForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addtaskbtn;
        private System.Windows.Forms.TextBox taskname;
        private System.Windows.Forms.TextBox deadlinetxt;
        private System.Windows.Forms.TextBox prioritytxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label4;
    }
}