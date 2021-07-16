
namespace FirstApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showValue = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.non_preemtive = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.preemtive = new System.Windows.Forms.RadioButton();
            this.quantum = new System.Windows.Forms.TextBox();
            this.algo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.TextBox();
            this.arrival = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.burst = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clearAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showValue
            // 
            this.showValue.AutoSize = true;
            this.showValue.Location = new System.Drawing.Point(44, 439);
            this.showValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showValue.Name = "showValue";
            this.showValue.Size = new System.Drawing.Size(0, 20);
            this.showValue.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.existToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1319, 36);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 32);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // existToolStripMenuItem
            // 
            this.existToolStripMenuItem.Name = "existToolStripMenuItem";
            this.existToolStripMenuItem.Size = new System.Drawing.Size(55, 32);
            this.existToolStripMenuItem.Text = "Exit";
            // 
            // non_preemtive
            // 
            this.non_preemtive.AutoSize = true;
            this.non_preemtive.BackColor = System.Drawing.Color.Transparent;
            this.non_preemtive.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.non_preemtive.Location = new System.Drawing.Point(680, 331);
            this.non_preemtive.Margin = new System.Windows.Forms.Padding(4);
            this.non_preemtive.Name = "non_preemtive";
            this.non_preemtive.Size = new System.Drawing.Size(234, 41);
            this.non_preemtive.TabIndex = 10;
            this.non_preemtive.TabStop = true;
            this.non_preemtive.Text = "Non-Preemptive";
            this.non_preemtive.UseVisualStyleBackColor = false;
            this.non_preemtive.CheckedChanged += new System.EventHandler(this.non_preemtive_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // preemtive
            // 
            this.preemtive.AutoSize = true;
            this.preemtive.BackColor = System.Drawing.Color.Transparent;
            this.preemtive.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preemtive.Location = new System.Drawing.Point(432, 331);
            this.preemtive.Margin = new System.Windows.Forms.Padding(4);
            this.preemtive.Name = "preemtive";
            this.preemtive.Size = new System.Drawing.Size(173, 41);
            this.preemtive.TabIndex = 9;
            this.preemtive.TabStop = true;
            this.preemtive.Text = "Preemptive";
            this.preemtive.UseVisualStyleBackColor = false;
            this.preemtive.CheckedChanged += new System.EventHandler(this.preemtive_CheckedChanged);
            // 
            // quantum
            // 
            this.quantum.BackColor = System.Drawing.Color.White;
            this.quantum.Location = new System.Drawing.Point(878, 394);
            this.quantum.Margin = new System.Windows.Forms.Padding(4);
            this.quantum.Name = "quantum";
            this.quantum.Size = new System.Drawing.Size(193, 26);
            this.quantum.TabIndex = 12;
            // 
            // algo
            // 
            this.algo.BackColor = System.Drawing.Color.White;
            this.algo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algo.FormattingEnabled = true;
            this.algo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.algo.Items.AddRange(new object[] {
            "FCFS",
            "SJF",
            "Round Robin",
            "Priority"});
            this.algo.Location = new System.Drawing.Point(432, 276);
            this.algo.Margin = new System.Windows.Forms.Padding(4);
            this.algo.Name = "algo";
            this.algo.Size = new System.Drawing.Size(174, 28);
            this.algo.TabIndex = 8;
            this.algo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.algo.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.algo_ChangeUICues);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 470);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Arrival Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 544);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(706, 470);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Burst Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(706, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quantum";
            // 
            // priority
            // 
            this.priority.BackColor = System.Drawing.Color.White;
            this.priority.Location = new System.Drawing.Point(432, 552);
            this.priority.Margin = new System.Windows.Forms.Padding(4);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(193, 26);
            this.priority.TabIndex = 19;
            this.priority.TextChanged += new System.EventHandler(this.label1_Click);
            this.priority.Validated += new System.EventHandler(this.priority_Validated);
            // 
            // arrival
            // 
            this.arrival.BackColor = System.Drawing.Color.White;
            this.arrival.Location = new System.Drawing.Point(432, 470);
            this.arrival.Margin = new System.Windows.Forms.Padding(4);
            this.arrival.Name = "arrival";
            this.arrival.Size = new System.Drawing.Size(193, 26);
            this.arrival.TabIndex = 20;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(432, 394);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(193, 26);
            this.name.TabIndex = 21;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(314, 668);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 81);
            this.button2.TabIndex = 22;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 37);
            this.label6.TabIndex = 23;
            this.label6.Text = "Select Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(404, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(476, 64);
            this.label7.TabIndex = 24;
            this.label7.Text = "Algorithm Drawer";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.Red;
            this.addbtn.Location = new System.Drawing.Point(713, 533);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(145, 55);
            this.addbtn.TabIndex = 25;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // burst
            // 
            this.burst.BackColor = System.Drawing.Color.White;
            this.burst.Location = new System.Drawing.Point(878, 470);
            this.burst.Margin = new System.Windows.Forms.Padding(4);
            this.burst.Name = "burst";
            this.burst.Size = new System.Drawing.Size(193, 26);
            this.burst.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(916, 533);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 55);
            this.button1.TabIndex = 29;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.BackColor = System.Drawing.Color.Transparent;
            this.test.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.ForeColor = System.Drawing.Color.Red;
            this.test.Location = new System.Drawing.Point(816, 607);
            this.test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(82, 37);
            this.test.TabIndex = 27;
            this.test.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(706, 607);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 37);
            this.label8.TabIndex = 30;
            this.label8.Text = "Added:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(791, 690);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 33);
            this.label9.TabIndex = 31;
            this.label9.Text = "@NO_MERCY";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(46)))));
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAll.ForeColor = System.Drawing.Color.Red;
            this.clearAll.Location = new System.Drawing.Point(926, 249);
            this.clearAll.Margin = new System.Windows.Forms.Padding(4);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(167, 55);
            this.clearAll.TabIndex = 32;
            this.clearAll.Text = "CLEAR ALL";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::FirstApp.Properties.Resources.WhatsApp_Image_2021_04_24_at_11_02_42_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1319, 939);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.burst);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.arrival);
            this.Controls.Add(this.name);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.algo);
            this.Controls.Add(this.quantum);
            this.Controls.Add(this.non_preemtive);
            this.Controls.Add(this.preemtive);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Process Schuduler Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label showValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existToolStripMenuItem;
        private System.Windows.Forms.RadioButton non_preemtive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton preemtive;
        private System.Windows.Forms.TextBox quantum;
        private System.Windows.Forms.ComboBox algo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priority;
        private System.Windows.Forms.TextBox arrival;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox burst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button clearAll;
    }
}

