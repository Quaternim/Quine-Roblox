
namespace Quine_Roblox_V2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DragPanel = new System.Windows.Forms.Panel();
            this.RldSrpLsButton = new System.Windows.Forms.Button();
            this.ClearScript = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Inject = new System.Windows.Forms.Button();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ScriptList = new System.Windows.Forms.ListBox();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.DragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DragPanel.Controls.Add(this.RldSrpLsButton);
            this.DragPanel.Controls.Add(this.ClearScript);
            this.DragPanel.Controls.Add(this.ExitButton);
            this.DragPanel.Controls.Add(this.MinimizeButton);
            this.DragPanel.Controls.Add(this.Title);
            this.DragPanel.Controls.Add(this.Inject);
            this.DragPanel.Controls.Add(this.ExecuteButton);
            this.DragPanel.Location = new System.Drawing.Point(-5, -6);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(925, 63);
            this.DragPanel.TabIndex = 0;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // RldSrpLsButton
            // 
            this.RldSrpLsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RldSrpLsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RldSrpLsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RldSrpLsButton.Image = global::Quine_Roblox_V2.Properties.Resources.refresh_FILL0_wght400_GRAD0_opsz48;
            this.RldSrpLsButton.Location = new System.Drawing.Point(744, 3);
            this.RldSrpLsButton.Name = "RldSrpLsButton";
            this.RldSrpLsButton.Size = new System.Drawing.Size(60, 59);
            this.RldSrpLsButton.TabIndex = 8;
            this.RldSrpLsButton.UseVisualStyleBackColor = false;
            this.RldSrpLsButton.Click += new System.EventHandler(this.RldSrpLsButton_Click);
            // 
            // ClearScript
            // 
            this.ClearScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClearScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClearScript.Image = global::Quine_Roblox_V2.Properties.Resources.backspace_FILL0_wght400_GRAD0_opsz48;
            this.ClearScript.Location = new System.Drawing.Point(810, 3);
            this.ClearScript.Name = "ClearScript";
            this.ClearScript.Size = new System.Drawing.Size(60, 59);
            this.ClearScript.TabIndex = 7;
            this.ClearScript.UseVisualStyleBackColor = false;
            this.ClearScript.Click += new System.EventHandler(this.ClearScript_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(896, 11);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(19, 19);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Lime;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.Lime;
            this.MinimizeButton.Location = new System.Drawing.Point(896, 36);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(19, 19);
            this.MinimizeButton.TabIndex = 5;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(399, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(120, 32);
            this.Title.TabIndex = 4;
            this.Title.Text = "Quine V2";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // Inject
            // 
            this.Inject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Inject.Image = global::Quine_Roblox_V2.Properties.Resources.file_download_FILL0_wght400_GRAD0_opsz48;
            this.Inject.Location = new System.Drawing.Point(3, 3);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(60, 59);
            this.Inject.TabIndex = 3;
            this.Inject.UseVisualStyleBackColor = false;
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExecuteButton.Image = global::Quine_Roblox_V2.Properties.Resources.play_arrow_FILL0_wght400_GRAD0_opsz48;
            this.ExecuteButton.Location = new System.Drawing.Point(69, 3);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(60, 59);
            this.ExecuteButton.TabIndex = 2;
            this.ExecuteButton.UseVisualStyleBackColor = false;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ScriptList
            // 
            this.ScriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ScriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptList.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ScriptList.ForeColor = System.Drawing.Color.White;
            this.ScriptList.FormattingEnabled = true;
            this.ScriptList.ItemHeight = 17;
            this.ScriptList.Location = new System.Drawing.Point(694, 76);
            this.ScriptList.Name = "ScriptList";
            this.ScriptList.Size = new System.Drawing.Size(213, 374);
            this.ScriptList.TabIndex = 4;
            this.ScriptList.SelectedIndexChanged += new System.EventHandler(this.ScriptList_SelectedIndexChanged);
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(261, 36);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.fastColoredTextBox1.BookmarkColor = System.Drawing.Color.Black;
            this.fastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox1.CharHeight = 18;
            this.fastColoredTextBox1.CharWidth = 10;
            this.fastColoredTextBox1.CommentPrefix = "--";
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 12F);
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '{';
            this.fastColoredTextBox1.Location = new System.Drawing.Point(12, 76);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.Black;
            this.fastColoredTextBox1.Size = new System.Drawing.Size(676, 374);
            this.fastColoredTextBox1.TabIndex = 5;
            this.fastColoredTextBox1.Text = "-- Made by Quaternim ;)\r\nPrint(\'Hello World\')";
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.Load += new System.EventHandler(this.fastColoredTextBox1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(919, 476);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.ScriptList);
            this.Controls.Add(this.DragPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragPanel.ResumeLayout(false);
            this.DragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Button Inject;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.ListBox ScriptList;
        private System.Windows.Forms.Label Title;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button RldSrpLsButton;
        private System.Windows.Forms.Button ClearScript;
    }
}

