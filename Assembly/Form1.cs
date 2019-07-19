using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Assembly : Form
    {

        Dictionary<string, int> memory;
        public HashSet<string> keyWords = new HashSet<string>("load store add sub mult div jg je jl ju read print dc end".Split(' '));
        public static Dictionary<string, int> labels;

        public Assembly()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Assembly_Load(object sender, EventArgs e)
        {
            memory = new Dictionary<string, int>();
            lineBox.Text = String.Empty;
            memoryNameBox.Text = String.Empty;
            while (program.Items.Count > 0) program.Items.RemoveAt(0);
            while (memoryList.Items.Count > 0) memoryList.Items.RemoveAt(0);
            memory.Add("acc", 0);
            memoryList.Items.Add("ACC");
            labels = new Dictionary<string, int>();
        }

        private void reset()
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = memoryNameBox.Text.ToLower();
            if (name.Contains(" ") || memory.ContainsKey(name) || keyWords.Contains(name))
            {
                MessageBox.Show("Names of memory must be unique, alphanumeric, and cannot be key words. (Not case sensitive)", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                memoryList.Items.Add(name);
                memory.Add(name, 0);
                memoryNameBox.Text = String.Empty;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (memoryList.GetItemText(memoryList.SelectedItem).Equals("ACC")) MessageBox.Show("Cannot remove accumulator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                memory.Remove(memoryList.GetItemText(memoryList.SelectedItem));
                memoryList.Items.Remove(memoryList.SelectedItem);
            }
        }

        private void insertLineButton_Click(object sender, EventArgs e) 
        {
            if (program.SelectedIndex == -1) program.Items.Add(lineBox.Text);
            else program.Items.Insert(program.SelectedIndex + 1, lineBox.Text);
            if (program.SelectedIndex == program.Items.Count - 2 || program.SelectedIndex == -1) program.SelectedIndex = -1;
            else program.SelectedIndex++;
            lineBox.Text = String.Empty;
        }

        private void lineBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                insertLineButton_Click(sender, e);
            }
        }

        private void memoryNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton_Click(sender, e);
            }
        }

        private void program_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                removeLineButton_Click(sender, e);
            }
        }

        private void removeLineButton_Click(object sender, EventArgs e)
        {
            if (program.SelectedIndex != -1) program.Items.Remove(program.SelectedItem);
        }

        private void memoryList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                removeButton_Click(sender, e);
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (program.SelectedIndex > 0)
            {
                int index = program.SelectedIndex;
                string info = program.GetItemText(program.SelectedItem);
                program.Items.Remove(program.SelectedItem);
                program.Items.Insert(index - 1, info);
                program.SelectedIndex = index - 1;
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {

            if (program.SelectedIndex < program.Items.Count - 1)
            {
                int index = program.SelectedIndex;
                string info = program.GetItemText(program.SelectedItem);
                program.Items.Remove(program.SelectedItem);
                program.Items.Insert(index + 1, info);
                program.SelectedIndex = index + 1;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to save your work?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                Assembly_Load(sender, e);
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outBox.Text = String.Empty;
            List<Command> programArray = new List<Command>();
            for (int i = 0; i < program.Items.Count; i++) programArray.Add(new Command(program.GetItemText(program.Items[i]), i));
            int index = 0;
            int value;
            while (true)
            {
                value = execute(programArray[index]);
                if (value == -1) break;
                index = value;
            }
            MessageBox.Show("Done!");
        }

        private int execute(Command c)
        {
            switch (c.getCommand())
            {
                case "load":
                    if (c.getLoc() == null) memory["acc"] = c.getNumber();
                    else memory["acc"] = memory[c.getLoc()];
                    break;
                case "store":
                    memory[c.getLoc()] = memory["acc"];
                    break;
                case "add":
                    if (c.getLoc() == null) memory["acc"] += c.getNumber();
                    else memory["acc"] += memory[c.getLoc()];
                    break;
                case "sub":
                    if (c.getLoc() == null) memory["acc"] -= c.getNumber();
                    else memory["acc"] -= memory[c.getLoc()];
                    break;
                case "mult":
                    if (c.getLoc() == null) memory["acc"] *= c.getNumber();
                    else memory["acc"] *= memory[c.getLoc()];
                    break;
                case "div":
                    if (c.getLoc() == null) memory["acc"] /= c.getNumber();
                    else memory["acc"] /= memory[c.getLoc()];
                    break;
                case "je":
                    if (memory["acc"] == 0) return labels[c.getLoc()];
                    break;
                case "jg":
                    if (memory["acc"] > 0) return labels[c.getLoc()];
                    break;
                case "jl":
                    if (memory["acc"] < 0) return labels[c.getLoc()];
                    break;
                case "ju":
                    return labels[c.getLoc()];
                case "print":
                    outBox.Text = outBox.Text + "\n" + memory["acc"];
                    break;
                case "dc":
                    memory[c.getLoc()] = c.getNumber();
                    break;
                case "end":
                    return -1;
            }
            return c.getIndex() + 1;
        }

        private void inClearButton_Click(object sender, EventArgs e)
        {
            inBox.Text = String.Empty;
        }

        private void outClearButton_Click(object sender, EventArgs e)
        {
            outBox.Text = String.Empty;
        }
    }


    class Command : Assembly
    {

        private string loc, command;
        private int number, index;

        public Command(string line, int index)
        {
            string[] input = line.ToLower().Split(' ');
            this.index = index;

            //If input has one word
            if (input.Length == 1)
            {
                if (keyWords.Contains(input[0])) command = input[0];
                else MessageBox.Show("Error: One word command, not keyword"); //throw an error (one word command, not a keyword)                
            }

            //If input has two words
            else if(input.Length == 2)
            {
                //If first word is command
                if (keyWords.Contains(input[0]))
                {
                    command = input[0];
                    if (Int32.TryParse(input[1], out int num)) number = num; //Test if second word is a number
                    else loc = input[1];
                }

                //If second word is command
                else if(keyWords.Contains(input[1]))
                {
                    labels.Add(input[0], index);
                    command = input[1];
                }

                //If neither words are commands
                else
                {
                    MessageBox.Show("Error: Two words, neither are keywords"); //throw an error (two words, neither are keywords)
                }
            }

            //If input has three words
            else if(input.Length == 3)
            {
                //If command is dc
                if (input[1].Equals("dc"))
                {
                    command = "dc";
                    loc = input[0];
                    number = Int32.Parse(input[2]);
                }

                //If second word is command
                else if (keyWords.Contains(input[1]))
                {
                    command = input[1];
                    labels.Add(input[0], index);
                    loc = input[2];
                }

                //If there is no command
                else
                {
                    MessageBox.Show("Error: No command"); //throws an error (three words, command not second word)
                }
            }

        }

        public string getLoc() { return loc; }
        public string getCommand() { return command; }
        public int getNumber() { return number; }
        public int getIndex() { return index; }

    }

}
