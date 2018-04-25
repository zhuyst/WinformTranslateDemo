using System.Windows.Forms;
using SpeechLib;

namespace WindowsFormsControlLibrary
{
    public partial class ExampleSentence : UserControl
    {
        /// <summary>
        /// 英文例句
        /// </summary>
        private string _eng;

        /// <summary>
        /// 例句对应的中文翻译
        /// </summary>
        private string _chn;

        public string Eng
        {
            get => _eng;
            set
            {
                _eng = value;
                engLabel.Text = value;
            }
        }

        public string Chn
        {
            get => _chn;
            set
            {
                _chn = value;
                chnLabel.Text = value;
            }
        }

        public ExampleSentence()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 朗读例句
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exSound_Click(object sender, System.EventArgs e)
        {
            var flag = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            var voice = new SpVoice();
            voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
            voice.Speak(_eng, flag);
        }
    }
}
