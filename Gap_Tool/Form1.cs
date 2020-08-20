using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gap_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        public int FileLoaded = 0;
        public int Bot_CurrentGapBeingWritten = 0;
        List<int> sv_list = new List<int>();
        List<string> gap_name_list = new List<string>();
        List<string> sv_gap_name_list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "All files (*.*)|*.*";
            ofd.SupportMultiDottedExtensions = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileLoaded = 1;
                read_state_01();
            }
            else
            {
                FileLoaded = 0;
            }
        }

        public void read_state_01()
        {
            Bot_CurrentGapBeingWritten = 0;
            gap.Items.Clear();
            sv_list.Clear();
            gap_name_list.Clear();
            sv_gap_name_list.Clear();
            BinaryReader reader = new BinaryReader(File.OpenRead(ofd.FileName));
            byte[] array = reader.ReadBytes(10).Skip(8).ToArray();
            int nog = BitConverter.ToInt16(array, 0);
            number_of_gaps.Text = "Number Of Gaps: " + nog;
            for (int nog_tracker = nog; nog_tracker > 0; nog_tracker--)
            {
                byte[] array2 = reader.ReadBytes(2);
                int sv = BitConverter.ToInt16(array2, 0);
                byte[] array3 = reader.ReadBytes(3).Skip(1).ToArray();
                Array.Reverse(array3);
                int sl = BitConverter.ToInt16(array3, 0);
                byte[] array4 = reader.ReadBytes(sl);
                string gap_name = Encoding.UTF8.GetString(array4, 0, array4.Length);
                gap.Items.Add(sv + " - " + gap_name);
                sv_list.Add(sv);
                gap_name_list.Add(gap_name);
                sv_gap_name_list.Add(sv + " - " + gap_name);
                //Console.WriteLine(sv);
                //Console.WriteLine(gap_name);
            }
            if (nog >= 1)
            {
                gap_pos_value.Maximum = nog;
            }
            else
            {
                gap_pos_value.Maximum = 1;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void save_file_button_Click(object sender, EventArgs e)
        {
            int User_CurrentListAmount = sv_gap_name_list.Count - 1;
            sfd.Filter = "All files (*.*)|*.*";
            sfd.SupportMultiDottedExtensions = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    byte[] array = { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                    byte[] array2 = BitConverter.GetBytes(User_CurrentListAmount + 1);
                    fileStream.Write(array, 0, 0x08);
                    fileStream.Write(array2, 0, 0x02);
                    for (int Bot_CurrentGap_Temp = 0; Bot_CurrentGap_Temp <= User_CurrentListAmount; Bot_CurrentGap_Temp++)
                    {
                        int Bot_CurrentGapScore = sv_list.ElementAt(Bot_CurrentGapBeingWritten);
                        byte[] array3 = BitConverter.GetBytes(Bot_CurrentGapScore);
                        fileStream.Write(array3, 0, 0x02);
                        byte[] array4 = { 0x00 };
                        fileStream.Write(array4, 0, 0x01);
                        string Bot_CurrentGapString = gap_name_list.ElementAt(Bot_CurrentGapBeingWritten);
                        int Bot_CurrentGapStringLength = Bot_CurrentGapString.Length;
                        byte[] array5 = BitConverter.GetBytes(Bot_CurrentGapStringLength);
                        Array.Reverse(array5, 0, 0x02);
                        fileStream.Write(array5, 0, 0x02);
                        byte[] array6 = Encoding.ASCII.GetBytes(Bot_CurrentGapString);
                        fileStream.Write(array6, 0, array6.Length);
                        Bot_CurrentGapBeingWritten++;
                    }
                }
            }
            else
            {
            }
        }

        private void gap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gap.SelectedIndex > -1)
            {
                gap_pos_value.Value = gap.SelectedIndex + 1;
                gap_sv.Value = sv_list[gap.SelectedIndex];
                gap_name.Text = gap_name_list[gap.SelectedIndex];
            }
        }

        private void update_gap_Click(object sender, EventArgs e)
        {
            int CurrentItemInList = gap.SelectedIndex;
            int User_CurrentItemInList = Convert.ToInt32(Math.Round(gap_pos_value.Value, 0)) - 1;
            int User_CurrentGapScore = Convert.ToInt32(Math.Round(gap_sv.Value, 0));
            string User_CurrentGapName = gap_name.Text;
            if (gap.SelectedIndex > -1)
            {
                sv_list.RemoveAt(CurrentItemInList);
                sv_list.Insert(User_CurrentItemInList, User_CurrentGapScore);
                gap_name_list.RemoveAt(CurrentItemInList);
                gap_name_list.Insert(User_CurrentItemInList, User_CurrentGapName);
                sv_gap_name_list.RemoveAt(CurrentItemInList);
                sv_gap_name_list.Insert(User_CurrentItemInList, (User_CurrentGapScore + " - " + User_CurrentGapName));
                gap.Items.RemoveAt(CurrentItemInList);
                gap.Items.Insert(User_CurrentItemInList, (User_CurrentGapScore + " - " + User_CurrentGapName));
            }
        }

        private void remove_gap_Click(object sender, EventArgs e)
        {
            int CurrentItemInList = gap.SelectedIndex;
            int User_CurrentListAmount = sv_gap_name_list.Count - 1;
            if (gap.SelectedIndex > -1)
            {
                sv_list.RemoveAt(CurrentItemInList);
                gap_name_list.RemoveAt(CurrentItemInList);
                sv_gap_name_list.RemoveAt(CurrentItemInList);
                gap.Items.RemoveAt(CurrentItemInList);
                number_of_gaps.Text = "Number Of Gaps: " + User_CurrentListAmount;
                gap_pos_value.Maximum = User_CurrentListAmount;
            }
        }

        private void add_gap_Click(object sender, EventArgs e)
        {
            int CurrentItemInList = gap.SelectedIndex;
            int User_CurrentItemInList = Convert.ToInt32(Math.Round(gap_pos_value.Value, 0)) - 1;
            int User_CurrentGapScore = Convert.ToInt32(Math.Round(gap_sv.Value, 0));
            int User_CurrentListAmount = sv_gap_name_list.Count + 2;
            string User_CurrentGapName = gap_name.Text;
                sv_list.Insert(User_CurrentItemInList, User_CurrentGapScore);
                gap_name_list.Insert(User_CurrentItemInList, User_CurrentGapName);
                sv_gap_name_list.Insert(User_CurrentItemInList, (User_CurrentGapScore + " - " + User_CurrentGapName));
                gap.Items.Insert(User_CurrentItemInList, (User_CurrentGapScore + " - " + User_CurrentGapName));
            gap_pos_value.Maximum = User_CurrentListAmount;
        }

        private void clear_all_Click(object sender, EventArgs e)
        {
            gap.Items.Clear();
            sv_list.Clear();
            gap_name_list.Clear();
            sv_gap_name_list.Clear();
            int User_CurrentListAmount = sv_gap_name_list.Count + 1;
            int User_CurrentListAmount_True = sv_gap_name_list.Count;
            number_of_gaps.Text = "Number Of Gaps: " + User_CurrentListAmount_True;
            gap_pos_value.Maximum = User_CurrentListAmount;
            gap_sv.Value = 0;
            gap_name.Text = ("");
        }

        private void export_to_text_Click(object sender, EventArgs e)
        {
            sfd.Filter = "All files (*.*)|*.*";
            sfd.SupportMultiDottedExtensions = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                    TextWriter tw = new StreamWriter(sfd.FileName);

                    foreach (String s in sv_gap_name_list)
                        tw.WriteLine(s);

                    tw.Close();
            }
            else
            {
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
