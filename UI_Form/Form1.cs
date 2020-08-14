using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypingCodeLibrary;

namespace UI_Form
{
    public partial class TypingCodeForm : Form
    {
        private readonly string _Text = "the quick brown fox jumped over the lazy dog";
        private TypingCode ob;
        private uint charCount { get; set;}
        private List<string> TypeText { get; set; }
        private uint TimeLimit { get; set; }
        private uint timeElapsed = 0;
        private uint TimeElapsed {
            get { return timeElapsed; }
            set
            {
                this.timeElapsed = value;
                if(this.timeElapsed == this.TimeLimit)
                {
                    this.GameOver();
                }
            }
        }
        public TypingCodeForm()
        {
            InitializeComponent();
            ob = new TypingCode();
            this.TypeText = new List<string>(_Text.Split());
            this.txtPane.Text = _Text;
            this.charCount = 0;
            this.TimeLimit = 60;
            ShowTime();
        }

        private string GetStats()
        {
            double words = this.charCount / 5.0;

        }
        private void ShowTime()
        {
            int timeLeft_seconds = (int)this.TimeLimit - (int)this.TimeElapsed;
            var span = new TimeSpan(0, 0, timeLeft_seconds); 
            var timeLeftDisplay = String.Format("{0}:{1:00}",
                                        (int)span.TotalMinutes,
                                        span.Seconds);
            this.lblTime.Text = timeLeftDisplay;
        }
        private void GameOver()
        {
            this.txtPane.Text = "TIME UP!";
            this.timer.Stop();
            this.txtInput.Enabled = false;
            this.lblStats.Text = "Stats:\n\r";
            //lblStats.Text += getStats();
        }

        private void Word_matched()
        {
            this.charCount += (uint)TypeText[0].Length;
            this.TypeText.RemoveAt(0);
            this.txtPane.Text = string.Join(" ", TypeText);
            this.txtInput.Text = null;
            if (this.TypeText.Count() == 0)
            {
                this.GameOver();
            }
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            this.timer.Enabled = true;
            if (this.TypeText.Count == 0) return;
            string target = TypeText[0];

            if (e.KeyCode == Keys.Enter)
            {
                return;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (this.txtInput.Text.TrimEnd() == target)
                {
                    this.Word_matched();
                    return;
                }
            }

            if (this.txtInput.Text.Length > target.Length)
            {
                this.txtInput.ForeColor = Color.Red;
                return;
            }

            
            if ( this.txtInput.Text == target.Substring(0, this.txtInput.Text.Length))
            {
                this.txtInput.ForeColor = Color.Green;
            }
            else
            {
                this.txtInput.ForeColor = Color.Red;
            }
            
        }


        private void timer_Tick(object sender, EventArgs e)
        {
           this.TimeElapsed += 1;
           this.ShowTime();
        }

      
    }
}
