using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace EXP.Set
{
    public partial class Tracker : Form
    {
        public Tracker()
        {
            InitializeComponent();
        }

        private void Conf_Click(object sender, EventArgs e)
        {
            // removes all current dates
            //for (int i = 0; i < levelDeetsDataSet.Leveled_Up.Count; i++)
            //{
            //    leveled_UpBindingSource.RemoveAt(i);
            //    levelDeetsDataSet.Leveled_Up.Clear();
            //    leveled_UpTableAdapter.Update(this.levelDeetsDataSet.Leveled_Up);
            //}

            // Init/Store vars
            int read =0,lvl=0, total_Exp=0, current_Exp=0, overFlow=0, rowInc=0, required_Exp=0;
            int type1=0, type2=0, type3=0, type4=0, type5=0, type6=0;

            // >> var values >> program
            StreamReader expRe = new StreamReader(@"C:\\Users\\Camilo\\EXP_Tracker.txt");
            while (!expRe.EndOfStream) 
            {
                int.TryParse(expRe.ReadLine(), out read); lvl = read; int.TryParse(expRe.ReadLine(), out read); total_Exp = read;
                int.TryParse(expRe.ReadLine(), out read); current_Exp = read; int.TryParse(expRe.ReadLine(), out read); required_Exp = read;
                int.TryParse(expRe.ReadLine(), out read); rowInc = read; int.TryParse(expRe.ReadLine(), out read); type1 = read;
                int.TryParse(expRe.ReadLine(), out read); type2 = read; int.TryParse(expRe.ReadLine(), out read); type3 = read;
                int.TryParse(expRe.ReadLine(), out read); type4 = read; int.TryParse(expRe.ReadLine(), out read); type5 = read;
                int.TryParse(expRe.ReadLine(), out read); type6 = read;
            }
            expRe.Close();

            // Set gained exp
            if (xp_1.Checked)
            {
                current_Exp++;
                total_Exp++;
                type1++;
            }
            else if (xp_1_1.Checked)
            {
                current_Exp += 2;
                total_Exp += 2;
                type2++;
            }
            else if (xp_5.Checked)
            {
                current_Exp += 5;
                total_Exp += 5;
                type3++;
            }
            else if (xp_10.Checked)
            {
                current_Exp += 10;
                total_Exp += 10;
                type4++;
            }
            else if (xp_50.Checked)
            {
                current_Exp += 50;
                total_Exp += 50;
                type5++;
            }
            else if (TS.Checked)
            {
                current_Exp += 100;
                total_Exp += 100;
                type6++;
            }
            else
            {
                current_Exp += 0;
            }

            //DB code here
            if (current_Exp >= required_Exp)
            {
                // calculate leftover exp >> set required_Exp=0 so it doesn't stack
                overFlow = current_Exp - required_Exp;
                current_Exp = overFlow;
                required_Exp = 0;
                lvl++;

                // adds row to Leveled_Up table >> sets ["Date"] row to current time
                DataRow time = levelDeetsDataSet.Leveled_Up.NewRow();
                time["Date"] = DateTime.Now;
                levelDeetsDataSet.Leveled_Up.Rows.Add(time);

                // take next value from ["Experience"] >> move to next row
                int.TryParse(levelDeetsDataSet.Req_Exp.Rows[rowInc]["Experience"].ToString(), out required_Exp);
                Console.WriteLine(required_Exp);
                rowInc++;
            }

            show_lvl.Text = " Level " + lvl;
            total_lbl.Text = " Total EXP: " + total_Exp.ToString();
            exp_lbl.Text = current_Exp + " / " + required_Exp; // shows DataRow
            
            // Save values
            StreamWriter expWr = File.CreateText(@"C:\\Users\\Camilo\\EXP_Tracker.txt");

            expWr.WriteLine(lvl); expWr.WriteLine(total_Exp); expWr.WriteLine(current_Exp); expWr.WriteLine(required_Exp); expWr.WriteLine(rowInc);
            expWr.WriteLine(type1); expWr.WriteLine(type2); expWr.WriteLine(type3); expWr.WriteLine(type4); expWr.WriteLine(type5); expWr.WriteLine(type6);

            expWr.Close();
            MessageBox.Show("Done");

            // TODO: This line of code loads data into the 'levelDeetsDataSet.Leveled_Up' table. You can move, or remove it, as needed.
            this.leveled_UpTableAdapter.Update(this.levelDeetsDataSet.Leveled_Up);
            // TODO: This line of code loads data into the 'levelDeetsDataSet.Req_Exp' table. You can move, or remove it, as needed.
            //this.req_ExpTableAdapter.Fill(this.levelDeetsDataSet.Req_Exp);
        }

        private void Tracker_Load(object sender, EventArgs e)
        {
            int read = 0, lvl = 0, total_Exp = 0, current_Exp = 0, rowInc = 0, required_Exp = 0;
            int type1 = 0, type2 = 0, type3 = 0, type4 = 0, type5 = 0, type6 = 0;

            // Show current level / required_exp upon loading
            StreamReader expRe = new StreamReader(@"C:\\Users\\Camilo\\EXP_Tracker.txt");
            while (!expRe.EndOfStream)
            {
                int.TryParse(expRe.ReadLine(), out read); lvl = read; int.TryParse(expRe.ReadLine(), out read); total_Exp = read;
                int.TryParse(expRe.ReadLine(), out read); current_Exp = read; int.TryParse(expRe.ReadLine(), out read); required_Exp = read;
                int.TryParse(expRe.ReadLine(), out read); rowInc = read; int.TryParse(expRe.ReadLine(), out read); type1 = read;
                int.TryParse(expRe.ReadLine(), out read); type2 = read; int.TryParse(expRe.ReadLine(), out read); type3 = read;
                int.TryParse(expRe.ReadLine(), out read); type4 = read; int.TryParse(expRe.ReadLine(), out read); type5 = read;
                int.TryParse(expRe.ReadLine(), out read); type6 = read;
            }

            show_lvl.Text = " Level " + lvl;
            total_lbl.Text = " Total EXP: " + total_Exp.ToString();
            exp_lbl.Text = current_Exp + " / " + required_Exp;
            expRe.Close();

            // TODO: This line of code loads data into the 'levelDeetsDataSet.Leveled_Up' table. You can move, or remove it, as needed.
            this.leveled_UpTableAdapter.Fill(this.levelDeetsDataSet.Leveled_Up);
            // TODO: This line of code loads data into the 'levelDeetsDataSet.Req_Exp' table. You can move, or remove it, as needed.
            this.req_ExpTableAdapter.Fill(this.levelDeetsDataSet.Req_Exp);            
        }
    }
}
