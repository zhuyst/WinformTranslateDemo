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
    public partial class ChoiceForm : Form
    {
        private readonly string _word;

        public ChoiceForm(string word)
        {
            InitializeComponent();
            _word = word;
            multipleChoice.Word = _word;
        }
    }
}
