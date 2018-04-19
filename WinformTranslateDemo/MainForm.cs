using Bing;
using SpeechLib;
using System;
using System.Windows.Forms;

namespace WinformTranslateDemo
{
    public partial class MainForm : Form
    {
        private TranslateApi _translate;
        private TranslateResult _result;

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
            _translate = new TranslateApi();
            wordListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 选中单词列表中的单词时触发，更新翻译结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = wordListBox.SelectedItem.ToString();
            _result = _translate.EnToZh(text);
            word.Text = text;
            pho1.Text = $"美 [{_result.Pronunciation.AmE}]";
            pho2.Text = $"英 [{_result.Pronunciation.BrE}]";
            meansList.Clear();
            foreach (var item in _result.Defs)
            {
                meansList.Add($"{item.Pos} { item.Def }");
            }
            ex1.Clear();
            ex1.Add(_result.Sams[0].Eng);
            ex1.Add(_result.Sams[0].Chn);
            ex2.Clear();
            ex2.Add(_result.Sams[1].Eng);
            ex2.Add(_result.Sams[1].Chn);
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

        /// <summary>
        /// 朗读单词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sound_MouseClick(object sender, MouseEventArgs e)
        {
            SpeechVoice(word.Text);
        }

        /// <summary>
        /// 朗读例句1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ex1Sound_MouseClick(object sender, MouseEventArgs e)
        {
            SpeechVoice(_result.Sams[0].Eng);
        }

        /// <summary>
        /// 朗读例句2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ex2Sound_MouseClick(object sender, MouseEventArgs e)
        {
            SpeechVoice(_result.Sams[1].Eng);
        }

        private void SpeechVoice(string text)
        {
            var flag = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            var voice = new SpVoice();
            voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
            voice.Speak(text, flag);
        }
    }
}
