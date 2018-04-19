using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bing;
using System.Windows.Forms;

namespace WinformTranslateDemo
{
    public partial class MainForm : Form
    {
        private TranslateApi translate;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var list = Words.Words.GetWords();
            foreach (var item in list)
            {
                wordListView.Items.Add(item);
            }
            translate = new TranslateApi();
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

        }

        private void wordListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = wordListView.SelectedItem.ToString();
            var result = translate.EnToZh(text);
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
    }
}
