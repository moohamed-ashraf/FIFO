
namespace final
{
    partial class menuForm
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
            this.addbtn = new System.Windows.Forms.Button();
            this.displaybtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.FIFO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Location = new System.Drawing.Point(74, 113);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(110, 51);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // displaybtn
            // 
            this.displaybtn.Location = new System.Drawing.Point(74, 195);
            this.displaybtn.Name = "displaybtn";
            this.displaybtn.Size = new System.Drawing.Size(110, 51);
            this.displaybtn.TabIndex = 1;
            this.displaybtn.Text = "Display";
            this.displaybtn.UseVisualStyleBackColor = true;
            this.displaybtn.Click += new System.EventHandler(this.displaybtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(74, 278);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(110, 51);
            this.updatebtn.TabIndex = 2;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(74, 364);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(110, 51);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "Delete ";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(74, 449);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(110, 51);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // FIFO
            // 
            this.FIFO.AutoSize = true;
            this.FIFO.BackColor = System.Drawing.Color.Transparent;
            this.FIFO.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIFO.Location = new System.Drawing.Point(445, 9);
            this.FIFO.Name = "FIFO";
            this.FIFO.Size = new System.Drawing.Size(174, 88);
            this.FIFO.TabIndex = 5;
            this.FIFO.Text = "FIFO";
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::final.Properties.Resources.WhatsApp_Image_2023_12_26_at_1_24_39_PM;
            this.ClientSize = new System.Drawing.Size(1008, 542);
            this.Controls.Add(this.FIFO);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.displaybtn);
            this.Controls.Add(this.addbtn);
            this.Name = "menuForm";
            this.Text = "menuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button displaybtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label FIFO;
    }
}