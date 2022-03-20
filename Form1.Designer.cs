namespace AssemblyCompiler_RISCV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paramaterBox2 = new System.Windows.Forms.ComboBox();
            this.InstructionBox = new System.Windows.Forms.ComboBox();
            this.paramaterBox3 = new System.Windows.Forms.ComboBox();
            this.paramaterBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.compileBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.binaryTxt = new System.Windows.Forms.Label();
            this.hexTxt = new System.Windows.Forms.Label();
            this.instructionTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paramaterBox2
            // 
            this.paramaterBox2.FormattingEnabled = true;
            this.paramaterBox2.Items.AddRange(new object[] {
            "X0",
            "X1",
            "X2",
            "X3",
            "X4",
            "X5",
            "X6",
            "X7",
            "X8",
            "X9",
            "X10",
            "X11",
            "X12",
            "X13",
            "X14",
            "X15",
            "X16",
            "X17",
            "X18",
            "X19",
            "X20",
            "X21",
            "X22",
            "X23",
            "X24",
            "X25",
            "X26",
            "X27",
            "X28",
            "X29",
            "X30",
            "X31"});
            this.paramaterBox2.Location = new System.Drawing.Point(344, 68);
            this.paramaterBox2.Name = "paramaterBox2";
            this.paramaterBox2.Size = new System.Drawing.Size(121, 23);
            this.paramaterBox2.TabIndex = 6;
            // 
            // InstructionBox
            // 
            this.InstructionBox.FormattingEnabled = true;
            this.InstructionBox.Items.AddRange(new object[] {
            "ADD",
            "SUB",
            "SLL",
            "SLT",
            "SLTU",
            "XOR",
            "SRL",
            "SRA",
            "OR",
            "AND"});
            this.InstructionBox.Location = new System.Drawing.Point(59, 68);
            this.InstructionBox.Name = "InstructionBox";
            this.InstructionBox.Size = new System.Drawing.Size(121, 23);
            this.InstructionBox.TabIndex = 4;
            // 
            // paramaterBox3
            // 
            this.paramaterBox3.FormattingEnabled = true;
            this.paramaterBox3.Items.AddRange(new object[] {
            "X0",
            "X1",
            "X2",
            "X3",
            "X4",
            "X5",
            "X6",
            "X7",
            "X8",
            "X9",
            "X10",
            "X11",
            "X12",
            "X13",
            "X14",
            "X15",
            "X16",
            "X17",
            "X18",
            "X19",
            "X20",
            "X21",
            "X22",
            "X23",
            "X24",
            "X25",
            "X26",
            "X27",
            "X28",
            "X29",
            "X30",
            "X31"});
            this.paramaterBox3.Location = new System.Drawing.Point(471, 68);
            this.paramaterBox3.Name = "paramaterBox3";
            this.paramaterBox3.Size = new System.Drawing.Size(121, 23);
            this.paramaterBox3.TabIndex = 7;
            // 
            // paramaterBox1
            // 
            this.paramaterBox1.FormattingEnabled = true;
            this.paramaterBox1.Items.AddRange(new object[] {
            "X0",
            "X1",
            "X2",
            "X3",
            "X4",
            "X5",
            "X6",
            "X7",
            "X8",
            "X9",
            "X10",
            "X11",
            "X12",
            "X13",
            "X14",
            "X15",
            "X16",
            "X17",
            "X18",
            "X19",
            "X20",
            "X21",
            "X22",
            "X23",
            "X24",
            "X25",
            "X26",
            "X27",
            "X28",
            "X29",
            "X30",
            "X31"});
            this.paramaterBox1.Location = new System.Drawing.Point(217, 68);
            this.paramaterBox1.Name = "paramaterBox1";
            this.paramaterBox1.Size = new System.Drawing.Size(121, 23);
            this.paramaterBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Instruction Format    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hex Format                :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Binary Format            :";
            // 
            // compileBtn
            // 
            this.compileBtn.Location = new System.Drawing.Point(607, 68);
            this.compileBtn.Name = "compileBtn";
            this.compileBtn.Size = new System.Drawing.Size(75, 23);
            this.compileBtn.TabIndex = 11;
            this.compileBtn.Text = "Compile";
            this.compileBtn.UseVisualStyleBackColor = true;
            this.compileBtn.Click += new System.EventHandler(this.compileBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(59, 217);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(120, 23);
            this.sendBtn.TabIndex = 12;
            this.sendBtn.Text = "Send To FPGA";
            this.sendBtn.UseVisualStyleBackColor = true;
            // 
            // binaryTxt
            // 
            this.binaryTxt.AutoSize = true;
            this.binaryTxt.Location = new System.Drawing.Point(185, 187);
            this.binaryTxt.Name = "binaryTxt";
            this.binaryTxt.Size = new System.Drawing.Size(100, 15);
            this.binaryTxt.TabIndex = 13;
            this.binaryTxt.Text = "0b 0b 0b 0b 0b 0b";
            this.binaryTxt.Visible = false;
            // 
            // hexTxt
            // 
            this.hexTxt.AutoSize = true;
            this.hexTxt.Location = new System.Drawing.Point(185, 153);
            this.hexTxt.Name = "hexTxt";
            this.hexTxt.Size = new System.Drawing.Size(94, 15);
            this.hexTxt.TabIndex = 14;
            this.hexTxt.Text = "0x 0x 0x 0x 0x 0x";
            this.hexTxt.Visible = false;
            // 
            // instructionTxt
            // 
            this.instructionTxt.AutoSize = true;
            this.instructionTxt.Location = new System.Drawing.Point(184, 120);
            this.instructionTxt.Name = "instructionTxt";
            this.instructionTxt.Size = new System.Drawing.Size(95, 15);
            this.instructionTxt.TabIndex = 15;
            this.instructionTxt.Text = "Instrctn p1 p2 p3";
            this.instructionTxt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 439);
            this.Controls.Add(this.instructionTxt);
            this.Controls.Add(this.hexTxt);
            this.Controls.Add(this.binaryTxt);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.compileBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paramaterBox3);
            this.Controls.Add(this.paramaterBox2);
            this.Controls.Add(this.paramaterBox1);
            this.Controls.Add(this.InstructionBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox paramaterBox2;
        private ComboBox InstructionBox;
        private ComboBox paramaterBox3;
        private ComboBox paramaterBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button compileBtn;
        private Button sendBtn;
        private Label binaryTxt;
        private Label hexTxt;
        private Label instructionTxt;
    }
}