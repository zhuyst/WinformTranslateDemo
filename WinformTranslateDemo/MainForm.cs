using Bing;
using SpeechLib;
using System;
using System.Windows.Forms;

namespace WinformTranslateDemo
{
    public partial class MainForm : Form
    {
        private TranslateApi translate;
        private TranslateResult result;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var list = Words.Words.GetWords();
            wordListBox.BeginUpdate();
            foreach (var item in list)
            {
                wordListBox.Items.Add(item);
            }
            wordListBox.EndUpdate();
            translate = new TranslateApi();
            wordListBox.SelectedIndex = 0;

        }

        /// <summary>
        /// 关闭翻译窗口时退出整个程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void sound_MouseDown(object sender, MouseEventArgs e)
        {
            SpeechVoiceSpeakFlags flag = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            SpVoice voice = new SpVoice();
            voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
            voice.Speak(word.Text, flag);


        }

        private void wordListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = wordListBox.SelectedItem.ToString();
            result = translate.EnToZh(text);
            word.Text = text;
            pho1.Text = $"美 [{result.Pronunciation.AmE}]";
            pho2.Text = $"英 [{result.Pronunciation.BrE}]";
            meansList.Clear();
            foreach (var item in result.Defs)
            {
                meansList.Add($"{item.Pos} { item.Def }");
            }
            ex1.Clear();
            ex1.Add(result.Sams[0].Eng);
            ex1.Add(result.Sams[0].Chn);
            ex2.Clear();
            ex2.Add(result.Sams[1].Eng);
            ex2.Add(result.Sams[1].Chn);
        }

        private void ex1Sound_MouseClick(object sender, MouseEventArgs e)
        {
            SpeechVoiceSpeakFlags flag = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            SpVoice voice = new SpVoice();
            voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
            voice.Speak(result.Sams[0].Eng, flag);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SpeechVoiceSpeakFlags flag = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            SpVoice voice = new SpVoice();
            voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
            voice.Speak(result.Sams[1].Eng, flag);
        }
    }
}
