namespace AssemblyCompiler_RISCV
{
    public partial class Form1 : Form
    {
        struct instructionStruct
        {
            public string opcode; //7 Bit
            public string rd; //5 Bit
            public string funct3; //3 Bit
            public string rs1; //5 Bit
            public string rs2; //5 Bit
            public string funct7; //5 Bit
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void compileBtn_Click(object sender, EventArgs e)
        {
            instructionStruct command = new instructionStruct();
            if (InstructionBox.Text == "ADD")
            {
                command.opcode = "0110011"; // 0x33
                command.rd = Convert.ToString(paramaterBox1.SelectedIndex, 2).PadLeft(5, '0');
                command.funct3 = "000";
                command.rs1 = Convert.ToString(paramaterBox2.SelectedIndex, 2).PadLeft(5, '0');
                command.rs2 = Convert.ToString(paramaterBox3.SelectedIndex, 2).PadLeft(5, '0');
                command.funct7 = "0000000";

                binaryTxt.Visible = Enabled;
                hexTxt.Visible = Enabled;
                binaryTxt.Text = command.funct7 + " " + command.rs2 + " " + command.rs1 + " " + command.funct3 + " " + command.rd + " " + command.opcode;
            }
            else if (InstructionBox.Text == "SUB")
            {
                command.opcode = "0110011"; // 0x33
                command.rd = Convert.ToString(paramaterBox1.SelectedIndex, 2).PadLeft(5, '0');
                command.funct3 = "000";
                command.rs1 = Convert.ToString(paramaterBox2.SelectedIndex, 2).PadLeft(5, '0');
                command.rs2 = Convert.ToString(paramaterBox3.SelectedIndex, 2).PadLeft(5, '0');
                command.funct7 = "0100000";

                binaryTxt.Visible = Enabled;
                binaryTxt.Text = command.funct7 + " " + command.rs2 + " " + command.rs1 + " " + command.funct3 + " " + command.rd + " " + command.opcode;
            }
            else if (InstructionBox.Text == "SLL")
            {
                command.opcode = "0110011"; // 0x33
                command.rd = Convert.ToString(paramaterBox1.SelectedIndex, 2).PadLeft(5, '0');
                command.funct3 = "001";
                command.rs1 = Convert.ToString(paramaterBox2.SelectedIndex, 2).PadLeft(5, '0');
                command.rs2 = Convert.ToString(paramaterBox3.SelectedIndex, 2).PadLeft(5, '0');
                command.funct7 = "0000000";

                binaryTxt.Visible = Enabled;
                binaryTxt.Text = command.funct7 + " " + command.rs2 + " " + command.rs1 + " " + command.funct3 + " " + command.rd + " " + command.opcode;
            }
            else if (InstructionBox.Text == "SLT")
            {
                command.opcode = "0110011"; // 0x33
                command.rd = Convert.ToString(paramaterBox1.SelectedIndex, 2).PadLeft(5, '0');
                command.funct3 = "010";
                command.rs1 = Convert.ToString(paramaterBox2.SelectedIndex, 2).PadLeft(5, '0');
                command.rs2 = Convert.ToString(paramaterBox3.SelectedIndex, 2).PadLeft(5, '0');
                command.funct7 = "0000000";

                binaryTxt.Visible = Enabled;
                binaryTxt.Text = command.funct7 + " " + command.rs2 + " " + command.rs1 + " " + command.funct3 + " " + command.rd + " " + command.opcode;
            }
            else if (InstructionBox.Text == "SLTU")
            {
                command.opcode = "0110011"; // 0x33
                command.rd = Convert.ToString(paramaterBox1.SelectedIndex, 2).PadLeft(5, '0');
                command.funct3 = "011";
                command.rs1 = Convert.ToString(paramaterBox2.SelectedIndex, 2).PadLeft(5, '0');
                command.rs2 = Convert.ToString(paramaterBox3.SelectedIndex, 2).PadLeft(5, '0');
                command.funct7 = "0000000";

                binaryTxt.Visible = Enabled;
                binaryTxt.Text = command.funct7 + " " + command.rs2 + " " + command.rs1 + " " + command.funct3 + " " + command.rd + " " + command.opcode;
            }
            else if (InstructionBox.Text == "XOR")
            {
                command.opcode = "0110011"; // 0x33
                command.rd = Convert.ToString(paramaterBox1.SelectedIndex, 2).PadLeft(5, '0');
                command.funct3 = "100";
                command.rs1 = Convert.ToString(paramaterBox2.SelectedIndex, 2).PadLeft(5, '0');
                command.rs2 = Convert.ToString(paramaterBox3.SelectedIndex, 2).PadLeft(5, '0');
                command.funct7 = "0000000";

                binaryTxt.Visible = Enabled;
                binaryTxt.Text = command.funct7 + " " + command.rs2 + " " + command.rs1 + " " + command.funct3 + " " + command.rd + " " + command.opcode;
            }
            else if (InstructionBox.Text == "SRL")
            {
                command.opcode = "0110011"; // 0x33
                command.rd = Convert.ToString(paramaterBox1.SelectedIndex, 2).PadLeft(5, '0');
                command.funct3 = "101";
                command.rs1 = Convert.ToString(paramaterBox2.SelectedIndex, 2).PadLeft(5, '0');
                command.rs2 = Convert.ToString(paramaterBox3.SelectedIndex, 2).PadLeft(5, '0');
                command.funct7 = "0000000";

                binaryTxt.Visible = Enabled;
                binaryTxt.Text = command.funct7 + " " + command.rs2 + " " + command.rs1 + " " + command.funct3 + " " + command.rd + " " + command.opcode;
            }
            else if (InstructionBox.Text == "SRA")
            {
                command.opcode = "0110011"; // 0x33
                command.rd = Convert.ToString(paramaterBox1.SelectedIndex, 2).PadLeft(5, '0');
                command.funct3 = "101";
                command.rs1 = Convert.ToString(paramaterBox2.SelectedIndex, 2).PadLeft(5, '0');
                command.rs2 = Convert.ToString(paramaterBox3.SelectedIndex, 2).PadLeft(5, '0');
                command.funct7 = "0100000";

                binaryTxt.Visible = Enabled;
                binaryTxt.Text = command.funct7 + " " + command.rs2 + " " + command.rs1 + " " + command.funct3 + " " + command.rd + " " + command.opcode;
            }
            else if (InstructionBox.Text == "OR")
            {
                command.opcode = "0110011"; // 0x33
                command.rd = Convert.ToString(paramaterBox1.SelectedIndex, 2).PadLeft(5, '0');
                command.funct3 = "110";
                command.rs1 = Convert.ToString(paramaterBox2.SelectedIndex, 2).PadLeft(5, '0');
                command.rs2 = Convert.ToString(paramaterBox3.SelectedIndex, 2).PadLeft(5, '0');
                command.funct7 = "0000000";

                binaryTxt.Visible = Enabled;
                binaryTxt.Text = command.funct7 + " " + command.rs2 + " " + command.rs1 + " " + command.funct3 + " " + command.rd + " " + command.opcode;
            }
            else if (InstructionBox.Text == "AND")
            {
                command.opcode = "0110011"; // 0x33
                command.rd = Convert.ToString(paramaterBox1.SelectedIndex, 2).PadLeft(5, '0');
                command.funct3 = "111";
                command.rs1 = Convert.ToString(paramaterBox2.SelectedIndex, 2).PadLeft(5, '0');
                command.rs2 = Convert.ToString(paramaterBox3.SelectedIndex, 2).PadLeft(5, '0');
                command.funct7 = "0000000";

                binaryTxt.Visible = Enabled;
                binaryTxt.Text = command.funct7 + " " + command.rs2 + " " + command.rs1 + " " + command.funct3 + " " + command.rd + " " + command.opcode;
            }
        }
    }
}