namespace RandomTextGenerator
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
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.groupBoxRedundant = new System.Windows.Forms.GroupBox();
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCharLimit = new System.Windows.Forms.TextBox();
            this.textBoxStringLimit = new System.Windows.Forms.TextBox();
            this.buttonPhase1 = new System.Windows.Forms.Button();
            this.textBoxLoadFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRetundency = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonFinalWrite = new System.Windows.Forms.Button();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxResultFile = new System.Windows.Forms.TextBox();
            this.buttonPhase2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lableListLength = new System.Windows.Forms.Label();
            this.groupBoxCreate.SuspendLayout();
            this.groupBoxRedundant.SuspendLayout();
            this.groupBoxText.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.buttonPhase2);
            this.groupBoxCreate.Controls.Add(this.buttonPhase1);
            this.groupBoxCreate.Controls.Add(this.textBoxStringLimit);
            this.groupBoxCreate.Controls.Add(this.textBoxCharLimit);
            this.groupBoxCreate.Controls.Add(this.label3);
            this.groupBoxCreate.Controls.Add(this.label2);
            this.groupBoxCreate.Location = new System.Drawing.Point(464, 21);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(215, 139);
            this.groupBoxCreate.TabIndex = 0;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Create Unique Strings";
            // 
            // groupBoxRedundant
            // 
            this.groupBoxRedundant.Controls.Add(this.buttonFinalWrite);
            this.groupBoxRedundant.Controls.Add(this.buttonGenerate);
            this.groupBoxRedundant.Controls.Add(this.textBoxRetundency);
            this.groupBoxRedundant.Controls.Add(this.label5);
            this.groupBoxRedundant.Controls.Add(this.textBoxResultFile);
            this.groupBoxRedundant.Controls.Add(this.label6);
            this.groupBoxRedundant.Controls.Add(this.textBoxLoadFile);
            this.groupBoxRedundant.Controls.Add(this.label4);
            this.groupBoxRedundant.Location = new System.Drawing.Point(464, 179);
            this.groupBoxRedundant.Name = "groupBoxRedundant";
            this.groupBoxRedundant.Size = new System.Drawing.Size(215, 147);
            this.groupBoxRedundant.TabIndex = 1;
            this.groupBoxRedundant.TabStop = false;
            this.groupBoxRedundant.Text = "Create Redundency";
            // 
            // groupBoxText
            // 
            this.groupBoxText.Controls.Add(this.richTextBox1);
            this.groupBoxText.Location = new System.Drawing.Point(12, 12);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(446, 523);
            this.groupBoxText.TabIndex = 2;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "Show Text";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 489);
            this.richTextBox1.TabIndex = 1000;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Char Limit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "String Limit";
            // 
            // textBoxCharLimit
            // 
            this.textBoxCharLimit.Location = new System.Drawing.Point(76, 30);
            this.textBoxCharLimit.Name = "textBoxCharLimit";
            this.textBoxCharLimit.Size = new System.Drawing.Size(133, 20);
            this.textBoxCharLimit.TabIndex = 1;
            // 
            // textBoxStringLimit
            // 
            this.textBoxStringLimit.Location = new System.Drawing.Point(76, 60);
            this.textBoxStringLimit.Name = "textBoxStringLimit";
            this.textBoxStringLimit.Size = new System.Drawing.Size(133, 20);
            this.textBoxStringLimit.TabIndex = 2;
            // 
            // buttonPhase1
            // 
            this.buttonPhase1.Location = new System.Drawing.Point(11, 97);
            this.buttonPhase1.Name = "buttonPhase1";
            this.buttonPhase1.Size = new System.Drawing.Size(96, 23);
            this.buttonPhase1.TabIndex = 3;
            this.buttonPhase1.Text = "Show Phase 1";
            this.buttonPhase1.UseVisualStyleBackColor = true;
            this.buttonPhase1.Click += new System.EventHandler(this.buttonShowText_Click);
            // 
            // textBoxLoadFile
            // 
            this.textBoxLoadFile.Location = new System.Drawing.Point(104, 19);
            this.textBoxLoadFile.Name = "textBoxLoadFile";
            this.textBoxLoadFile.Size = new System.Drawing.Size(105, 20);
            this.textBoxLoadFile.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Output File Name";
            // 
            // textBoxRetundency
            // 
            this.textBoxRetundency.Location = new System.Drawing.Point(104, 71);
            this.textBoxRetundency.Name = "textBoxRetundency";
            this.textBoxRetundency.Size = new System.Drawing.Size(105, 20);
            this.textBoxRetundency.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Redundency Limit";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(10, 109);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 10;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonFinalWrite
            // 
            this.buttonFinalWrite.Enabled = false;
            this.buttonFinalWrite.Location = new System.Drawing.Point(134, 109);
            this.buttonFinalWrite.Name = "buttonFinalWrite";
            this.buttonFinalWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonFinalWrite.TabIndex = 11;
            this.buttonFinalWrite.Text = "Write";
            this.buttonFinalWrite.UseVisualStyleBackColor = true;
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.lableListLength);
            this.groupBoxStatus.Controls.Add(this.label7);
            this.groupBoxStatus.Location = new System.Drawing.Point(464, 435);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(200, 100);
            this.groupBoxStatus.TabIndex = 3;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Result File Name";
            // 
            // textBoxResultFile
            // 
            this.textBoxResultFile.Location = new System.Drawing.Point(105, 45);
            this.textBoxResultFile.Name = "textBoxResultFile";
            this.textBoxResultFile.Size = new System.Drawing.Size(104, 20);
            this.textBoxResultFile.TabIndex = 8;
            // 
            // buttonPhase2
            // 
            this.buttonPhase2.Location = new System.Drawing.Point(113, 97);
            this.buttonPhase2.Name = "buttonPhase2";
            this.buttonPhase2.Size = new System.Drawing.Size(96, 23);
            this.buttonPhase2.TabIndex = 4;
            this.buttonPhase2.Text = "Show Phase 2";
            this.buttonPhase2.UseVisualStyleBackColor = true;
            this.buttonPhase2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "List Length :";
            // 
            // lableListLength
            // 
            this.lableListLength.AutoSize = true;
            this.lableListLength.Location = new System.Drawing.Point(79, 25);
            this.lableListLength.Name = "lableListLength";
            this.lableListLength.Size = new System.Drawing.Size(0, 13);
            this.lableListLength.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 547);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBoxText);
            this.Controls.Add(this.groupBoxRedundant);
            this.Controls.Add(this.groupBoxCreate);
            this.Name = "Form1";
            this.Text = "Generate";
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            this.groupBoxRedundant.ResumeLayout(false);
            this.groupBoxRedundant.PerformLayout();
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.Button buttonPhase1;
        private System.Windows.Forms.TextBox textBoxStringLimit;
        private System.Windows.Forms.TextBox textBoxCharLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxRedundant;
        private System.Windows.Forms.Button buttonFinalWrite;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxRetundency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxResultFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLoadFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Button buttonPhase2;
        private System.Windows.Forms.Label lableListLength;
        private System.Windows.Forms.Label label7;
    }
}

