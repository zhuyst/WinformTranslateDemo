using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class MultipleChoice : UserControl
    {
        private static readonly char[] Letters = {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q',
            'r','s','t','u','v','w','x','y','z'
        };

        public string Word { get; set; }

        private readonly RoundButton[] _buttons;

        private readonly Random _random;

        private char _missLetter;

        private int _missPos;

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

        private void InitWord()
        {
            _missPos = _random.Next(Word.Length - 1);
            _missLetter = Word[_missPos];
            wordLabel.Text = Word.Remove(_missPos, 1).Insert(_missPos, "_");
        }

        private void InitButtons()
        {
            _rightButtonPos = _random.Next(3);
            _buttons[_rightButtonPos].Text = _missLetter + "";
            SetButtonsText();
        }

        private void SetButtonsText()
        {
            var exists = new HashSet<char> {_missLetter};
            for(var i = 0;i < _buttons.Length;i++)
            {
                if(i == _rightButtonPos) continue;
                while (true)
                {
                    var letter = Letters[_random.Next(Letters.Length - 1)];
                    if (exists.Contains(letter)) continue;

                    _buttons[i].Text = letter + "";
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
            var circle = (RoundButton) sender;
            if (circle.Text == _missLetter + "")
            {

            }
        }
    }
}
