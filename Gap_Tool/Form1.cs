using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public int fileLoaded = 0;
        public int currentGapBeingWritten = 0;
        List<int> scoreValueList = new List<int>();
        List<string> gapNameList = new List<string>();
        List<string> scoreValueAndGapNameList = new List<string>();
        private void openAndReadFile(object sender, EventArgs e)
        {
            ofd.Filter = "All files (*.*)|*.*";
            ofd.SupportMultiDottedExtensions = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileLoaded = 1;
                ReadState();
            }
            else
            {
                fileLoaded = 0;
            }
        }

        public void ReadState()
        {
            currentGapBeingWritten = 0;
            gap.Items.Clear();
            scoreValueList.Clear();
            gapNameList.Clear();
            scoreValueAndGapNameList.Clear();
            BinaryReader reader = new BinaryReader(File.OpenRead(ofd.FileName));
            byte[] arrayHeader = reader.ReadBytes(10).Skip(8).ToArray();
            int numberOfGaps = BitConverter.ToInt16(arrayHeader, 0);
            numberOfGapsText.Text = "Number Of Gaps: " + numberOfGaps;
            for (int numberOfGapsTracker = numberOfGaps; numberOfGapsTracker > 0; numberOfGapsTracker--)
            {
                byte[] arrayUserCurrentListAmount = reader.ReadBytes(2);
                int scoreValue = BitConverter.ToInt16(arrayUserCurrentListAmount, 0);
                byte[] arraySaveCurrentGapScore = reader.ReadBytes(3).Skip(1).ToArray();
                Array.Reverse(arraySaveCurrentGapScore);
                int scoreList = BitConverter.ToInt16(arraySaveCurrentGapScore, 0);
                byte[] arrayPadding = reader.ReadBytes(scoreList);
                string gapName = Encoding.UTF8.GetString(arrayPadding, 0, arrayPadding.Length);
                gap.Items.Add(scoreValue + " - " + gapName);
                scoreValueList.Add(scoreValue);
                gapNameList.Add(gapName);
                scoreValueAndGapNameList.Add(scoreValue + " - " + gapName);
            }
            if (numberOfGaps >= 1)
            {
                curEditGapPositionInListValueText.Maximum = numberOfGaps += 1;
            }
            else
            {
                curEditGapPositionInListValueText.Maximum = 1;
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            int userCurrentListAmount = scoreValueAndGapNameList.Count - 1;
            sfd.Filter = "All files (*.*)|*.*";
            sfd.SupportMultiDottedExtensions = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    byte[] arrayHeader = { 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                    byte[] arrayUserCurrentListAmount = BitConverter.GetBytes(userCurrentListAmount + 1);
                    fileStream.Write(arrayHeader, 0, 0x08);
                    fileStream.Write(arrayUserCurrentListAmount, 0, 0x02);
                    for (int saveCurrentGapTemp = 0; saveCurrentGapTemp <= userCurrentListAmount; saveCurrentGapTemp++)
                    {
                        int saveCurrentGapScore = scoreValueList.ElementAt(currentGapBeingWritten);
                        byte[] arraySaveCurrentGapScore = BitConverter.GetBytes(saveCurrentGapScore);
                        fileStream.Write(arraySaveCurrentGapScore, 0, 0x02);
                        byte[] arrayPadding = { 0x00 };
                        fileStream.Write(arrayPadding, 0, 0x01);
                        string saveCurrentGapString = gapNameList.ElementAt(currentGapBeingWritten);
                        int saveCurrentGapStringLength = saveCurrentGapString.Length;
                        byte[] arraySaveCurrentGapStringLength = BitConverter.GetBytes(saveCurrentGapStringLength);
                        Array.Reverse(arraySaveCurrentGapStringLength, 0, 0x02);
                        fileStream.Write(arraySaveCurrentGapStringLength, 0, 0x02);
                        byte[] arraySaveCurrentGapString = Encoding.ASCII.GetBytes(saveCurrentGapString);
                        fileStream.Write(arraySaveCurrentGapString, 0, arraySaveCurrentGapString.Length);
                        currentGapBeingWritten++;
                    }
                    fileStream.Close();
                }
            }
            else
            {
            }
        }

        private void curEditGapPositionInListUpdate(object sender, EventArgs e)
        {
            if (gap.SelectedIndex > -1)
            {
                curEditGapPositionInListValueText.Value = gap.SelectedIndex + 1;
                curEditGapScoreValueText.Value = scoreValueList[gap.SelectedIndex];
                curEditGapNameValueText.Text = gapNameList[gap.SelectedIndex];
            }
        }

        private void UpdateGap(object sender, EventArgs e)
        {
            int currentItemInList = gap.SelectedIndex;
            int userCurrentItemInList = Convert.ToInt32(Math.Round(curEditGapPositionInListValueText.Value, 0)) - 1;
            int userCurrentGapScore = Convert.ToInt32(Math.Round(curEditGapScoreValueText.Value, 0));
            string userCurrentGapName = curEditGapNameValueText.Text;
            if (gap.SelectedIndex > -1)
            {
                scoreValueList.RemoveAt(currentItemInList);
                scoreValueList.Insert(userCurrentItemInList, userCurrentGapScore);
                gapNameList.RemoveAt(currentItemInList);
                gapNameList.Insert(userCurrentItemInList, userCurrentGapName);
                scoreValueAndGapNameList.RemoveAt(currentItemInList);
                scoreValueAndGapNameList.Insert(userCurrentItemInList, (userCurrentGapScore + " - " + userCurrentGapName));
                gap.Items.RemoveAt(currentItemInList);
                gap.Items.Insert(userCurrentItemInList, (userCurrentGapScore + " - " + userCurrentGapName));
            }
        }

        private void RemoveGap(object sender, EventArgs e)
        {
            int currentItemInList = gap.SelectedIndex;
            int userCurrentListAmount = scoreValueAndGapNameList.Count - 1;
            if (gap.SelectedIndex > -1)
            {
                scoreValueList.RemoveAt(currentItemInList);
                gapNameList.RemoveAt(currentItemInList);
                scoreValueAndGapNameList.RemoveAt(currentItemInList);
                gap.Items.RemoveAt(currentItemInList);
                numberOfGapsText.Text = "Number Of Gaps: " + userCurrentListAmount;
                curEditGapPositionInListValueText.Maximum = userCurrentListAmount;
            }
        }

        private void AddGap(object sender, EventArgs e)
        {
            int currentItemInList = gap.SelectedIndex;
            int userCurrentItemInList = Convert.ToInt32(Math.Round(curEditGapPositionInListValueText.Value, 0)) - 1;
            int userCurrentGapScore = Convert.ToInt32(Math.Round(curEditGapScoreValueText.Value, 0));
            int userCurrentListAmount = scoreValueAndGapNameList.Count + 2;
            string userCurrentGapName = curEditGapNameValueText.Text;
            scoreValueList.Insert(userCurrentItemInList, userCurrentGapScore);
            gapNameList.Insert(userCurrentItemInList, userCurrentGapName);
            scoreValueAndGapNameList.Insert(userCurrentItemInList, (userCurrentGapScore + " - " + userCurrentGapName));
            gap.Items.Insert(userCurrentItemInList, (userCurrentGapScore + " - " + userCurrentGapName));
            curEditGapPositionInListValueText.Maximum = userCurrentListAmount;
        }

        private void ClearAllGaps(object sender, EventArgs e)
        {
            gap.Items.Clear();
            scoreValueList.Clear();
            gapNameList.Clear();
            scoreValueAndGapNameList.Clear();
            int userCurrentListAmount = scoreValueAndGapNameList.Count + 1;
            int userCurrentListAmountTrue = scoreValueAndGapNameList.Count;
            numberOfGapsText.Text = "Number Of Gaps: " + userCurrentListAmountTrue;
            curEditGapPositionInListValueText.Maximum = userCurrentListAmount;
            curEditGapScoreValueText.Value = 0;
            curEditGapNameValueText.Text = ("");
        }

        private void ExportListToTxtFile(object sender, EventArgs e)
        {
            sfd.Filter = "All files (*.*)|*.*";
            sfd.SupportMultiDottedExtensions = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                    TextWriter tw = new StreamWriter(sfd.FileName);

                    foreach (String s in scoreValueAndGapNameList)
                        tw.WriteLine(s);

                    tw.Close();
            }
            else
            {
            }
        }
    }
}
