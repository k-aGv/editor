namespace k_agv_editor
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
            this.panel_editor = new System.Windows.Forms.Panel();
            this.res_label = new System.Windows.Forms.Label();
            this.nud_res = new System.Windows.Forms.NumericUpDown();
            this.btn_entrance = new System.Windows.Forms.Button();
            this.gb_tools = new System.Windows.Forms.GroupBox();
            this.gb_laods = new System.Windows.Forms.GroupBox();
            this.btn_carry = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_walls = new System.Windows.Forms.GroupBox();
            this.btn_walls = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_exit = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_entrance = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_loads = new System.Windows.Forms.CheckBox();
            this.cb_wall = new System.Windows.Forms.CheckBox();
            this.cb_exit = new System.Windows.Forms.CheckBox();
            this.cb_entrance = new System.Windows.Forms.CheckBox();
            this.pb_export = new System.Windows.Forms.PictureBox();
            this.sfd_map = new System.Windows.Forms.SaveFileDialog();
            this.btn_fuel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_res)).BeginInit();
            this.gb_tools.SuspendLayout();
            this.gb_laods.SuspendLayout();
            this.gb_walls.SuspendLayout();
            this.gb_exit.SuspendLayout();
            this.gb_entrance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_export)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_editor
            // 
            this.panel_editor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel_editor.Location = new System.Drawing.Point(12, 12);
            this.panel_editor.Name = "panel_editor";
            this.panel_editor.Size = new System.Drawing.Size(501, 351);
            this.panel_editor.TabIndex = 0;
            this.panel_editor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_editor_MouseClick);
            // 
            // res_label
            // 
            this.res_label.AutoSize = true;
            this.res_label.Location = new System.Drawing.Point(520, 12);
            this.res_label.Name = "res_label";
            this.res_label.Size = new System.Drawing.Size(82, 13);
            this.res_label.TabIndex = 1;
            this.res_label.Text = "Grid Resolution:";
            // 
            // nud_res
            // 
            this.nud_res.Location = new System.Drawing.Point(608, 10);
            this.nud_res.Name = "nud_res";
            this.nud_res.Size = new System.Drawing.Size(53, 20);
            this.nud_res.TabIndex = 2;
            this.nud_res.ValueChanged += new System.EventHandler(this.nud_res_ValueChanged);
            // 
            // btn_entrance
            // 
            this.btn_entrance.Location = new System.Drawing.Point(6, 19);
            this.btn_entrance.Name = "btn_entrance";
            this.btn_entrance.Size = new System.Drawing.Size(75, 23);
            this.btn_entrance.TabIndex = 3;
            this.btn_entrance.Text = "Entrance";
            this.btn_entrance.UseVisualStyleBackColor = true;
            this.btn_entrance.Click += new System.EventHandler(this.btn_entrance_Click);
            // 
            // gb_tools
            // 
            this.gb_tools.Controls.Add(this.gb_laods);
            this.gb_tools.Controls.Add(this.gb_walls);
            this.gb_tools.Controls.Add(this.gb_exit);
            this.gb_tools.Controls.Add(this.gb_entrance);
            this.gb_tools.Controls.Add(this.cb_loads);
            this.gb_tools.Controls.Add(this.cb_wall);
            this.gb_tools.Controls.Add(this.cb_exit);
            this.gb_tools.Controls.Add(this.cb_entrance);
            this.gb_tools.Location = new System.Drawing.Point(523, 36);
            this.gb_tools.Name = "gb_tools";
            this.gb_tools.Size = new System.Drawing.Size(292, 343);
            this.gb_tools.TabIndex = 4;
            this.gb_tools.TabStop = false;
            this.gb_tools.Text = "Tools";
            // 
            // gb_laods
            // 
            this.gb_laods.Controls.Add(this.btn_carry);
            this.gb_laods.Controls.Add(this.label4);
            this.gb_laods.Location = new System.Drawing.Point(9, 257);
            this.gb_laods.Name = "gb_laods";
            this.gb_laods.Size = new System.Drawing.Size(180, 73);
            this.gb_laods.TabIndex = 9;
            this.gb_laods.TabStop = false;
            this.gb_laods.Text = "Loads";
            // 
            // btn_carry
            // 
            this.btn_carry.Location = new System.Drawing.Point(6, 19);
            this.btn_carry.Name = "btn_carry";
            this.btn_carry.Size = new System.Drawing.Size(75, 23);
            this.btn_carry.TabIndex = 3;
            this.btn_carry.Text = "Loads";
            this.btn_carry.UseVisualStyleBackColor = true;
            this.btn_carry.Click += new System.EventHandler(this.btn_carry_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Please select the load blocks!";
            // 
            // gb_walls
            // 
            this.gb_walls.Controls.Add(this.btn_fuel);
            this.gb_walls.Controls.Add(this.btn_walls);
            this.gb_walls.Controls.Add(this.label3);
            this.gb_walls.Location = new System.Drawing.Point(9, 178);
            this.gb_walls.Name = "gb_walls";
            this.gb_walls.Size = new System.Drawing.Size(180, 73);
            this.gb_walls.TabIndex = 8;
            this.gb_walls.TabStop = false;
            this.gb_walls.Text = "Walls and Fuel";
            // 
            // btn_walls
            // 
            this.btn_walls.Location = new System.Drawing.Point(6, 19);
            this.btn_walls.Name = "btn_walls";
            this.btn_walls.Size = new System.Drawing.Size(75, 23);
            this.btn_walls.TabIndex = 3;
            this.btn_walls.Text = "Walls";
            this.btn_walls.UseVisualStyleBackColor = true;
            this.btn_walls.Click += new System.EventHandler(this.btn_walls_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please select the wall blocks!";
            // 
            // gb_exit
            // 
            this.gb_exit.Controls.Add(this.btn_exit);
            this.gb_exit.Controls.Add(this.label2);
            this.gb_exit.Location = new System.Drawing.Point(9, 99);
            this.gb_exit.Name = "gb_exit";
            this.gb_exit.Size = new System.Drawing.Size(180, 73);
            this.gb_exit.TabIndex = 7;
            this.gb_exit.TabStop = false;
            this.gb_exit.Text = "Exit";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(6, 19);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please select the exit block!";
            // 
            // gb_entrance
            // 
            this.gb_entrance.Controls.Add(this.btn_entrance);
            this.gb_entrance.Controls.Add(this.label1);
            this.gb_entrance.Location = new System.Drawing.Point(9, 20);
            this.gb_entrance.Name = "gb_entrance";
            this.gb_entrance.Size = new System.Drawing.Size(180, 73);
            this.gb_entrance.TabIndex = 6;
            this.gb_entrance.TabStop = false;
            this.gb_entrance.Text = "Entrance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please select the entrance block!";
            // 
            // cb_loads
            // 
            this.cb_loads.AutoSize = true;
            this.cb_loads.Checked = true;
            this.cb_loads.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_loads.Location = new System.Drawing.Point(223, 298);
            this.cb_loads.Name = "cb_loads";
            this.cb_loads.Size = new System.Drawing.Size(63, 17);
            this.cb_loads.TabIndex = 4;
            this.cb_loads.Text = "Correct!";
            this.cb_loads.UseVisualStyleBackColor = true;
            // 
            // cb_wall
            // 
            this.cb_wall.AutoSize = true;
            this.cb_wall.Checked = true;
            this.cb_wall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_wall.Location = new System.Drawing.Point(223, 219);
            this.cb_wall.Name = "cb_wall";
            this.cb_wall.Size = new System.Drawing.Size(63, 17);
            this.cb_wall.TabIndex = 4;
            this.cb_wall.Text = "Correct!";
            this.cb_wall.UseVisualStyleBackColor = true;
            // 
            // cb_exit
            // 
            this.cb_exit.AutoSize = true;
            this.cb_exit.Checked = true;
            this.cb_exit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_exit.Location = new System.Drawing.Point(223, 140);
            this.cb_exit.Name = "cb_exit";
            this.cb_exit.Size = new System.Drawing.Size(63, 17);
            this.cb_exit.TabIndex = 4;
            this.cb_exit.Text = "Correct!";
            this.cb_exit.UseVisualStyleBackColor = true;
            // 
            // cb_entrance
            // 
            this.cb_entrance.AutoSize = true;
            this.cb_entrance.Checked = true;
            this.cb_entrance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_entrance.Location = new System.Drawing.Point(223, 61);
            this.cb_entrance.Name = "cb_entrance";
            this.cb_entrance.Size = new System.Drawing.Size(63, 17);
            this.cb_entrance.TabIndex = 4;
            this.cb_entrance.Text = "Correct!";
            this.cb_entrance.UseVisualStyleBackColor = true;
            // 
            // pb_export
            // 
            this.pb_export.Location = new System.Drawing.Point(227, 369);
            this.pb_export.Name = "pb_export";
            this.pb_export.Size = new System.Drawing.Size(40, 40);
            this.pb_export.TabIndex = 5;
            this.pb_export.TabStop = false;
            this.pb_export.Click += new System.EventHandler(this.pb_export_Click);
            // 
            // btn_fuel
            // 
            this.btn_fuel.Location = new System.Drawing.Point(96, 19);
            this.btn_fuel.Name = "btn_fuel";
            this.btn_fuel.Size = new System.Drawing.Size(75, 23);
            this.btn_fuel.TabIndex = 6;
            this.btn_fuel.Text = "Fuel";
            this.btn_fuel.UseVisualStyleBackColor = true;
            this.btn_fuel.Click += new System.EventHandler(this.btn_fuel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 415);
            this.Controls.Add(this.pb_export);
            this.Controls.Add(this.gb_tools);
            this.Controls.Add(this.nud_res);
            this.Controls.Add(this.res_label);
            this.Controls.Add(this.panel_editor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_res)).EndInit();
            this.gb_tools.ResumeLayout(false);
            this.gb_tools.PerformLayout();
            this.gb_laods.ResumeLayout(false);
            this.gb_laods.PerformLayout();
            this.gb_walls.ResumeLayout(false);
            this.gb_walls.PerformLayout();
            this.gb_exit.ResumeLayout(false);
            this.gb_exit.PerformLayout();
            this.gb_entrance.ResumeLayout(false);
            this.gb_entrance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_export)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_editor;
        private System.Windows.Forms.Label res_label;
        private System.Windows.Forms.NumericUpDown nud_res;
        private System.Windows.Forms.Button btn_entrance;
        private System.Windows.Forms.GroupBox gb_tools;
        private System.Windows.Forms.GroupBox gb_laods;
        private System.Windows.Forms.Button btn_carry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_walls;
        private System.Windows.Forms.Button btn_walls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_exit;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_entrance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_loads;
        private System.Windows.Forms.CheckBox cb_wall;
        private System.Windows.Forms.CheckBox cb_exit;
        private System.Windows.Forms.CheckBox cb_entrance;
        private System.Windows.Forms.PictureBox pb_export;
        private System.Windows.Forms.SaveFileDialog sfd_map;
        private System.Windows.Forms.Button btn_fuel;
    }
}

