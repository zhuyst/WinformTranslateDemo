using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class MultipleChoice : UserControl
    {
        /// <summary>
        /// 关闭窗口事件
        /// </summary>
        public event EventHandler CloseEvent;

        /// <summary>
        /// 小写字母表
        /// </summary>
        private static readonly char[] Letters = {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q',
            'r','s','t','u','v','w','x','y','z'
        };

        /// <summary>
        /// 目前的单词
        /// </summary>
        public string Word { get; set; } = "Word";

        /// <summary>
        /// 选项按钮数组
        /// </summary>
        private readonly RoundButton[] _buttons;

        private readonly Random _random;

        /// <summary>
        /// 缺失的字母
        /// </summary>
        private char _missLetter;

        /// <summary>
        /// 缺失的字母在原单词的位置
        /// </summary>
        private int _missPos;

        /// <summary>
        /// 正确选项按钮在数组中的位置
        /// </summary>
        private int _rightButtonPos;

        public MultipleChoice()
        {
            InitializeComponent();
            _random = new Random();

            _buttons = new RoundButton[4];
            _buttons[0] = roundButton1;
            _buttons[1] = roundButton2;
            _buttons[2] = roundButton3;
            _buttons[3] = roundButton4;
        }

        private void MultipleChoice_Load(object sender, EventArgs e)
        {
            InitWord();
            InitButtons();
        }

        /// <summary>
        /// 初始化单词
        /// </summary>
        private void InitWord()
        {
            _missPos = _random.Next(Word.Length - 1);
            _missLetter = Word[_missPos];
            wordLabel.Text = Word.Remove(_missPos, 1).Insert(_missPos, "_");
            //单词居中
            wordLabel.Left = (ClientSize.Width - wordLabel.Width) / 2;
        }

        /// <summary>
        /// 初始化选项按钮
        /// </summary>
        private void InitButtons()
        {
            _rightButtonPos = _random.Next(3);
            _buttons[_rightButtonPos].Text = _missLetter.ToString();
            SetButtonsText();
        }

        /// <summary>
        /// 设置选项按钮数组的字母
        /// </summary>
        private void SetButtonsText()
        {
            var exists = new HashSet<char> { _missLetter };
            for (var i = 0; i < _buttons.Length; i++)
            {
                if (i == _rightButtonPos) continue;
                while (true)
                {
                    var letter = Letters[_random.Next(Letters.Length - 1)];
                    if (exists.Contains(letter)) continue;

                    _buttons[i].Text = letter.ToString();
                    exists.Add(letter);
                    break;
                }
            }
        }

        /// <summary>
        /// 点击任一选项触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roundButton_Click(object sender, EventArgs e)
        {
            var circle = (RoundButton)sender;
            if (circle.Text == _missLetter.ToString())
            {
                MessageBox.Show("答案正确!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CloseEvent?.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("答案错误!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
