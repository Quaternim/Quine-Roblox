using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Quine_Roblox_V2
{
    public partial class Form1 : Form
    {
        ExploitAPI module = new ExploitAPI();

        public Form1()
        {
            InitializeComponent();
        }
        Point lastPoint;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void ScriptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{ScriptList.SelectedItem}");

        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            module.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();

        }

        private void RldSrpLsButton_Click(object sender, EventArgs e)
        {
            ScriptList.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(ScriptList, "./Scripts", "*.txt");
            Functions.PopulateListBox(ScriptList, "./Scripts", "*.lua");

        }

        private void ClearScript_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScriptList.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(ScriptList, "./Scripts", "*.txt");
            Functions.PopulateListBox(ScriptList, "./Scripts", "*.lua");

        }
    }
}
