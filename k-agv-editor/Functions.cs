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
        Graphics gp;
        int res_offset;
        
        PictureBox[] pb_array = new PictureBox[100];
        int array_counter = 0;

        string clickflag;

        /*
         * Map file
         * --------
         * 0=clean block
         * 1=entrance
         * 2=exit
         * 3=wall
         * 4=load
         */
        int[,] map;

        //md5 samples from MSDN
        /*
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
         * */

        private void init()
        {
            pb_export.Visible = false;

            gp = panel_editor.CreateGraphics();
            gb_tools.Visible = false;
            nud_res.Increment = 25;
            nud_res.Maximum = 100;
            cb_loads.Text = "";
            cb_entrance.Text = "";
            cb_exit.Text = "";
            cb_wall.Text = "";

            cb_loads.Enabled = false;
            cb_entrance.Enabled = false;
            cb_exit.Enabled = false;
            cb_wall.Enabled = false;

            cb_loads.Checked = false;
            cb_entrance.Checked = false;
            cb_exit.Checked = false;
            cb_wall.Checked = false;

            pb_export.Image = Image.FromFile(getResDir() + "export.png");
            pb_export.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void killPBs()
        {
            if (panel_editor.Controls.Count > 0)
            {
                panel_editor.Controls.Clear();
            }
        }

        private void updateGrid()
        {
            killPBs();
            panel_editor.Refresh();
            int a, b;
            gp.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
            using (Pen p = new Pen(Color.Black))
            {
                for (a = 0; a < panel_editor.Width; a += res_offset)
                {
                    gp.DrawLine(p, a, 0, a, panel_editor.Height);
                }

                for (b = 0; b < panel_editor.Height; b += res_offset)
                {
                    gp.DrawLine(p, 0, b, panel_editor.Width, b);
                }
                //Watch out.Grid's size is 500+1,350+1...+1 because the known border bug
            }

        }
        private void setComboboxes(string _clickflag)
        {
            if (_clickflag == "entrance")
            {
                cb_entrance.Text = "Correct!";
                cb_entrance.Checked = true;
            }
            else if (_clickflag == "exit")
            {
                cb_exit.Text = "Correct!";
                cb_exit.Checked = true;
            }
            else if (_clickflag == "wall")
            {
                cb_wall.Text = "Correct!";
                cb_wall.Checked = true;
            }
            else
            {
                cb_loads.Text = "Correct!";
                cb_loads.Checked = true;
            }

        }
        private void buildMap(string _clickflag, MouseEventArgs e)
        {
            if (_clickflag == "entrance")
            {
                map[(e.X / res_offset) , (e.Y / res_offset)] = 1;
            }
            else if (_clickflag == "exit")
            {
                map[(e.X / res_offset), (e.Y / res_offset)] = 2;
            }
            else if (_clickflag == "wall")
            {
                map[(e.X / res_offset), (e.Y / res_offset)]  = 3;
            }
            else
            {
                map[(e.X / res_offset), (e.Y / res_offset)] = 4;
            }
           
        }

        private string getResDir()
        {
             
            DirectoryInfo dir = new DirectoryInfo(
            Directory.GetCurrentDirectory());
            while (dir != null && !dir.GetFiles("*.sln").Any())
            {
                dir = dir.Parent;
            }
            return Convert.ToString(dir.FullName + "\\k-agv-editor\\Resources\\");
             
			 //RELEASE ONLY
            //MessageBox.Show(Convert.ToString(Directory.GetCurrentDirectory()+"\\"));
            //return Convert.ToString(Directory.GetCurrentDirectory()+"\\Resources\\");
            
            
        }
        private void setImage(string _clickflag, MouseEventArgs e)
        {
            try
            {
                pb_array[array_counter] = new PictureBox();
                Point _tempPoint = new Point((e.X / res_offset) * res_offset, (e.Y / res_offset) * res_offset);
                pb_array[array_counter].Name = _clickflag + "_"+array_counter.ToString();
                pb_array[array_counter].BackColor = panel_editor.BackColor;
                pb_array[array_counter].BorderStyle = BorderStyle.FixedSingle;
                pb_array[array_counter].Location = _tempPoint;
                pb_array[array_counter].Image = Image.FromFile(getResDir() + _clickflag + ".png");
                pb_array[array_counter].SizeMode = PictureBoxSizeMode.StretchImage;
                pb_array[array_counter].Size = new Size(res_offset, res_offset);
                pb_array[array_counter].Visible = true;
                panel_editor.Controls.Add(pb_array[array_counter]);
                array_counter++;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\nInternal problem.Check the resources");
            }
        }
        private void exportMapToFile()
        {
            
            sfd_map.Filter = "k-aGv Map (*.kmap)|*.kmap";
            if (sfd_map.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writeStream = new StreamWriter(sfd_map.FileName);

                writeStream.WriteLine("Map Info:");
                writeStream.WriteLine("Width_blocks: "
                                        + map.GetLength(0)
                                        + " Height_blocks: "
                                        + map.GetLength(1)
                                        + " Resolution: "
                                        + res_offset
                                        );
                writeStream.WriteLine();

                int i, z;
                for (z = 0; z < map.GetLength(1); z++)
                {
                    for (i = 0; i < map.GetLength(0); i++)
                    {
                        if (i == map.GetLength(0) - 1)
                        {
                            writeStream.Write(map[i, z]);
                        }
                        else
                        {
                            writeStream.Write(map[i, z] + " ");
                        }
                    }
                    if (z == map.GetLength(1) - 1)
                    { }
                    else
                    {
                        writeStream.WriteLine();
                    }
                }

                writeStream.Close();
                
                //md5 initialization
                /*
                StreamReader readOriginalFile = new StreamReader(sfd_map.FileName);
                string originalfile = readOriginalFile.ReadToEnd();
                readOriginalFile.Close();
                
                using (MD5 md5hash = MD5.Create())
                {
                    string hash = GetMd5Hash(md5hash, originalfile);
                    StreamWriter md5writer = new StreamWriter(sfd_map.FileName+".md5");
                    md5writer.WriteLine(hash);
                    md5writer.Close();
                }
                 */

                
            }
        }
        private void cleanMapArray()
        {
            map = new int[panel_editor.Width / Convert.ToInt32(nud_res.Value)
                          , panel_editor.Height / Convert.ToInt32(nud_res.Value)];
            //MessageBox.Show(map.GetLength(0)+"");//horizontal blocks -> 20
            //MessageBox.Show(map.GetLength(1) + "");//vertical blocks -> 14
            //map.GetLength(int Dimension);

            for (int z = 0; z < map.GetLength(1); z++)
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    map[i, z] = 0;//Full array's default flag with BLOCK type
                }
            }
        }



    }
}
