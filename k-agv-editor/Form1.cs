using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Security.Cryptography;

namespace k_agv_editor
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }
       
        private void nud_res_ValueChanged(object sender, EventArgs e)
        {
            if (nud_res.Value == 0)
            {
                panel_editor.Refresh();
                gb_tools.Visible = false;
                return;
            }
            else
            {
                pb_export.Visible = true;
                gb_tools.Visible = true;
                res_offset = Convert.ToInt32(nud_res.Value);
                updateGrid();
                cleanMapArray();
            }
        }

       
        private void panel_editor_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            gp.FillRectangle(b
                , (e.X / res_offset) * res_offset
                , (e.Y / res_offset) * res_offset
                , res_offset
                , res_offset);
             */
            setImage(clickflag,e);
            setComboboxes(clickflag);
            buildMap(clickflag, e);
          
        }
       
        private void btn_entrance_Click(object sender, EventArgs e)
        {
            clickflag = "entrance";
            label1.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            clickflag = "exit";
            label2.Text = "";
        }

        private void btn_walls_Click(object sender, EventArgs e)
        {
            clickflag = "wall";
            label3.Text = "";
        }

        private void btn_carry_Click(object sender, EventArgs e)
        {
            clickflag = "loads";
            label4.Text = "";

        }

        private void pb_export_Click(object sender, EventArgs e)
        {
            exportMapToFile();
        }

    }
}
