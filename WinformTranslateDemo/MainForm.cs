using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTranslateDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            word.Text = "Nice";
            pho1.Text = "美 [naɪs]";
            pho2.Text = "英 [naɪs]";

            //词义分析
            meansList.Clear();
            meansList.Add("n.尼斯");
            meansList.Add("adj.令人愉快的；宜人的；吸引人的；用于形容词或副词前以加强语气");

            //例句
            ex1.Clear();
            ex1.Add("It was really nice to relax with my friends and let it sink in and to get some sun and just do nothing for a few days.");
            ex1.Add("能和朋友一起放松的感觉很棒，享受阳光，什么事都不做了几天。");
            ex2.Clear();
            ex2.Add("A nice 4 - 0 win against Wigan seems to have got things into a bit more perspective, regarding our current situation.");
            ex2.Add("我们现在的形式看，4-0大胜维甘似乎把让事态更明媚了些。");
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
    }
}
