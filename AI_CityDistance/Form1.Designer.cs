
namespace AI_CityDistance
{
    partial class TUGAS_AI_1
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
            this.panelMap = new System.Windows.Forms.Panel();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonSTART = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAstar = new System.Windows.Forms.RadioButton();
            this.btnBfs = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonRedraw = new System.Windows.Forms.Button();
            this.labelStartCity = new System.Windows.Forms.Label();
            this.labelGoalCity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMap.Location = new System.Drawing.Point(16, 15);
            this.panelMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(960, 443);
            this.panelMap.TabIndex = 0;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(696, 465);
            this.buttonLoadFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(91, 80);
            this.buttonLoadFile.TabIndex = 1;
            this.buttonLoadFile.Text = "LOAD FILE";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonSTART
            // 
            this.buttonSTART.Location = new System.Drawing.Point(795, 465);
            this.buttonSTART.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSTART.Name = "buttonSTART";
            this.buttonSTART.Size = new System.Drawing.Size(105, 80);
            this.buttonSTART.TabIndex = 3;
            this.buttonSTART.Text = "START";
            this.buttonSTART.UseVisualStyleBackColor = true;
            this.buttonSTART.Click += new System.EventHandler(this.buttonSTART_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 465);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(671, 84);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAstar);
            this.groupBox1.Controls.Add(this.btnBfs);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(911, 460);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(155, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // radioButtonAstar
            // 
            this.radioButtonAstar.AutoSize = true;
            this.radioButtonAstar.Checked = true;
            this.radioButtonAstar.Location = new System.Drawing.Point(8, 64);
            this.radioButtonAstar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonAstar.Name = "radioButtonAstar";
            this.radioButtonAstar.Size = new System.Drawing.Size(95, 21);
            this.radioButtonAstar.TabIndex = 2;
            this.radioButtonAstar.TabStop = true;
            this.radioButtonAstar.Text = "A-Star / A*";
            this.radioButtonAstar.UseVisualStyleBackColor = true;
            // 
            // btnBfs
            // 
            this.btnBfs.AutoSize = true;
            this.btnBfs.Location = new System.Drawing.Point(8, 41);
            this.btnBfs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBfs.Name = "btnBfs";
            this.btnBfs.Size = new System.Drawing.Size(55, 21);
            this.btnBfs.TabIndex = 1;
            this.btnBfs.TabStop = true;
            this.btnBfs.Text = "BFS";
            this.btnBfs.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 17);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonRedraw
            // 
            this.buttonRedraw.Location = new System.Drawing.Point(985, 389);
            this.buttonRedraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRedraw.Name = "buttonRedraw";
            this.buttonRedraw.Size = new System.Drawing.Size(80, 69);
            this.buttonRedraw.TabIndex = 6;
            this.buttonRedraw.Text = "ReDraw";
            this.buttonRedraw.UseVisualStyleBackColor = true;
            this.buttonRedraw.Click += new System.EventHandler(this.buttonRedraw_Click);
            // 
            // labelStartCity
            // 
            this.labelStartCity.AutoSize = true;
            this.labelStartCity.Location = new System.Drawing.Point(981, 47);
            this.labelStartCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartCity.Name = "labelStartCity";
            this.labelStartCity.Size = new System.Drawing.Size(13, 17);
            this.labelStartCity.TabIndex = 7;
            this.labelStartCity.Text = "-";
            // 
            // labelGoalCity
            // 
            this.labelGoalCity.AutoSize = true;
            this.labelGoalCity.Location = new System.Drawing.Point(981, 114);
            this.labelGoalCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGoalCity.Name = "labelGoalCity";
            this.labelGoalCity.Size = new System.Drawing.Size(13, 17);
            this.labelGoalCity.TabIndex = 8;
            this.labelGoalCity.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(981, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "START:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(981, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "GOAL:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(985, 330);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 52);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // TUGAS_AI_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGoalCity);
            this.Controls.Add(this.labelStartCity);
            this.Controls.Add(this.buttonRedraw);
            this.Controls.Add(this.buttonSTART);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.panelMap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TUGAS_AI_1";
            this.Text = "Romania";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonSTART;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAstar;
        private System.Windows.Forms.RadioButton btnBfs;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonRedraw;
        private System.Windows.Forms.Label labelStartCity;
        private System.Windows.Forms.Label labelGoalCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
    }
}

