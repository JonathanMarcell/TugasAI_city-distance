
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
            this.rbUCS = new System.Windows.Forms.RadioButton();
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
            this.panelMap.Location = new System.Drawing.Point(12, 12);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(720, 360);
            this.panelMap.TabIndex = 0;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(522, 378);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(68, 65);
            this.buttonLoadFile.TabIndex = 1;
            this.buttonLoadFile.Text = "LOAD FILE";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonSTART
            // 
            this.buttonSTART.Location = new System.Drawing.Point(596, 378);
            this.buttonSTART.Name = "buttonSTART";
            this.buttonSTART.Size = new System.Drawing.Size(79, 65);
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
            this.richTextBox1.Location = new System.Drawing.Point(12, 378);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(504, 69);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAstar);
            this.groupBox1.Controls.Add(this.btnBfs);
            this.groupBox1.Controls.Add(this.rbUCS);
            this.groupBox1.Location = new System.Drawing.Point(683, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // radioButtonAstar
            // 
            this.radioButtonAstar.AutoSize = true;
            this.radioButtonAstar.Checked = true;
            this.radioButtonAstar.Location = new System.Drawing.Point(6, 52);
            this.radioButtonAstar.Name = "radioButtonAstar";
            this.radioButtonAstar.Size = new System.Drawing.Size(76, 17);
            this.radioButtonAstar.TabIndex = 2;
            this.radioButtonAstar.TabStop = true;
            this.radioButtonAstar.Text = "A-Star / A*";
            this.radioButtonAstar.UseVisualStyleBackColor = true;
            // 
            // btnBfs
            // 
            this.btnBfs.AutoSize = true;
            this.btnBfs.Location = new System.Drawing.Point(6, 33);
            this.btnBfs.Name = "btnBfs";
            this.btnBfs.Size = new System.Drawing.Size(45, 17);
            this.btnBfs.TabIndex = 1;
            this.btnBfs.TabStop = true;
            this.btnBfs.Text = "BFS";
            this.btnBfs.UseVisualStyleBackColor = true;
            // 
            // rbUCS
            // 
            this.rbUCS.AutoSize = true;
            this.rbUCS.Location = new System.Drawing.Point(7, 14);
            this.rbUCS.Name = "rbUCS";
            this.rbUCS.Size = new System.Drawing.Size(47, 17);
            this.rbUCS.TabIndex = 0;
            this.rbUCS.TabStop = true;
            this.rbUCS.Text = "UCS";
            this.rbUCS.UseVisualStyleBackColor = true;
            // 
            // buttonRedraw
            // 
            this.buttonRedraw.Location = new System.Drawing.Point(739, 316);
            this.buttonRedraw.Name = "buttonRedraw";
            this.buttonRedraw.Size = new System.Drawing.Size(60, 56);
            this.buttonRedraw.TabIndex = 6;
            this.buttonRedraw.Text = "ReDraw";
            this.buttonRedraw.UseVisualStyleBackColor = true;
            this.buttonRedraw.Click += new System.EventHandler(this.buttonRedraw_Click);
            // 
            // labelStartCity
            // 
            this.labelStartCity.AutoSize = true;
            this.labelStartCity.Location = new System.Drawing.Point(736, 38);
            this.labelStartCity.Name = "labelStartCity";
            this.labelStartCity.Size = new System.Drawing.Size(10, 13);
            this.labelStartCity.TabIndex = 7;
            this.labelStartCity.Text = "-";
            // 
            // labelGoalCity
            // 
            this.labelGoalCity.AutoSize = true;
            this.labelGoalCity.Location = new System.Drawing.Point(736, 93);
            this.labelGoalCity.Name = "labelGoalCity";
            this.labelGoalCity.Size = new System.Drawing.Size(10, 13);
            this.labelGoalCity.TabIndex = 8;
            this.labelGoalCity.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "START:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(736, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "GOAL:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(739, 268);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(60, 42);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // TUGAS_AI_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.RadioButton rbUCS;
        private System.Windows.Forms.Button buttonRedraw;
        private System.Windows.Forms.Label labelStartCity;
        private System.Windows.Forms.Label labelGoalCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
    }
}

