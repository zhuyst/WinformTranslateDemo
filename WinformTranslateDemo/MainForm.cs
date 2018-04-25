using Bing;
using SpeechLib;
using System;
using System.Windows.Forms;
using WindowsFormsControlLibrary;

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
            //例句
            exFlowPanel.Controls.Clear();
            foreach (var item in _result.Sams)
            {
                exFlowPanel.Controls.Add(new ExampleSentence { Eng = item.Eng, Chn = item.Chn });
            }
            ExAutoSize();
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
            var flag = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            var voice = new SpVoice();
            voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
            voice.Speak(word.Text, flag);
        }

        /// <summary>
        /// 自动调整例句区域的高度
        /// </summary>
        private void ExAutoSize()
        {
            exFlowPanel.Height = exFlowPanel.Parent.Height - (meansList.Top + meansList.Height) - 80;
        }
    }
}
