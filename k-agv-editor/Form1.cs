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
                panel_editor.Visible = true;
                pb_export.Visible = true;
                gb_tools.Visible = true;
                res_offset = Convert.ToInt32(nud_res.Value);
                updateGrid();
                cleanMapArray();
            }
        }

       
        private void panel_editor_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Right click pressed");
                return;//Sorcery return even its void.We leave function to not execute array calculations
            }
            if (array_counter == 0 )
            {
               
                MessageBox.Show("Please select an object for drawing");
                return;//Sorcery return even its void.We leave function to not execute array calculations
            }

            if (pressedEntrance)
            {
                if(isFirstEntryEntrance)
                {
                    clickflag = "entrance";
                    setImage(clickflag, e);
                    isFirstEntryEntrance = !isFirstEntryEntrance;
                }
                else
                {
                    pb_array[foundEntrance].Dispose();
                    updateGridOnly();
                    clickflag = "new_entrance";
                    setImage(clickflag, e);
                }
            }
            else if (pressedExit)
            {
                if (isFirstEntryExit)
                {
                    clickflag = "exit";
                    setImage(clickflag, e);
                    isFirstEntryExit = !isFirstEntryExit;  
                }
                else
                {
                    pb_array[foundExit].Dispose();
                    updateGridOnly();
                    clickflag = "new_exit";
                    setImage(clickflag, e);

                }
            }
            else if (pressedStation)
            {
                if (isFirstEntryStation)
                {
                    setImage(clickflag, e);
                    isFirstEntryStation = !isFirstEntryStation;
                    clickflag = "new_station";
                }
                else
                {
                    pb_array[foundStation].Dispose();
                    updateGridOnly();
                    setImage(clickflag, e);
                }
            }
            else
            {
                setImage(clickflag, e);
            }
                
            setComboboxes(clickflag);
            buildMap(clickflag, e);
          
        }
       
        private void btn_entrance_Click(object sender, EventArgs e)
        {
            if (panel_editor.Visible == false)
                panel_editor.Visible = true;

            pressedEntrance = true;
            pressedExit = false;
            pressedStation = false;
            if (isFirstEntryEntrance)
            {
                clickflag = "entrance";
                label1.Text = "";
            }
            else
            {
                clickflag = "new_entrance";
            } 
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (panel_editor.Visible == false)
                panel_editor.Visible = true;

            pressedEntrance = false ;
            pressedStation = false;
            pressedExit = true;
            if (isFirstEntryExit)
            {
                clickflag = "exit";
                label2.Text = "";
            }
            else
            {
                clickflag = "new_exit";
            }
           
        }
        private void btn_fuel_Click(object sender, EventArgs e)
        {
            if (panel_editor.Visible == false)
                panel_editor.Visible = true;

            pressedEntrance = false;
            pressedExit = false;
            pressedStation = true;
            if (isFirstEntryStation)
            {
                clickflag = "station";
                label1.Text = "";
            }
            else
            {
                clickflag = "new_station";
            }
        }

        private void btn_walls_Click(object sender, EventArgs e)
        {
            if (panel_editor.Visible == false)
                panel_editor.Visible = true;

            pressedEntrance = false;
            pressedExit = false;
            pressedStation = false;

            clickflag = "wall";
            label3.Text = "";
        }

        private void btn_carry_Click(object sender, EventArgs e)
        {
            if (panel_editor.Visible == false)
                panel_editor.Visible = true;

            pressedEntrance = false;
            pressedExit = false;
            pressedStation = false;
            clickflag = "loads";
            label4.Text = "";

        }
       
        private void pb_export_Click(object sender, EventArgs e)
        {
            exportMapToFile();
        }

        

       
    }
}
