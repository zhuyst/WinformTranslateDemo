using System.Windows.Forms;

namespace WinformTranslateDemo
{
    public partial class ChoiceForm : Form
    {
        public ChoiceForm(string word)
        {
            InitializeComponent();
            multipleChoice.Word = word;
            multipleChoice.CloseEvent += (sender, e) => { Close(); };
        }
    }
}
