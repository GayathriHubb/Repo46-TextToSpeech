using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Diagnostics;


namespace TextToSpeech
{
    public partial class FormSpeech : Form
    {
        public FormSpeech()
        {
            InitializeComponent();

            Debug.WriteLine($"Rate: {speechsynth.Rate} - Volume: {speechsynth.Volume}");
        }


        SpeechSynthesizer speechsynth = new SpeechSynthesizer();
        bool isdisposed = false;    

        private void BtnSpeak_Click(object sender, EventArgs e)
        {
            if (RTB1.Text != string.Empty)
            {
                speechsynth.Dispose();
                speechsynth = new SpeechSynthesizer();
                speechsynth.SpeakAsync(RTB1.Text);   
            }
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (speechsynth != null)
            {
                try
                {
                    if (speechsynth.State == SynthesizerState.Speaking)
                    {
                        speechsynth.Pause();
                    }
                }
                catch (ObjectDisposedException ex)
                {
                    Debug.WriteLine(ex.Message, "TTSpeech");
                    MessageBox.Show("An error occurred while pausing speech", "Error", 0, MessageBoxIcon.Error);
                }
                
            }
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            if (speechsynth != null)
            {
                try
                {
                    if (speechsynth.State == SynthesizerState.Paused)
                    {
                        speechsynth.Resume();
                    }
                }
                catch (ObjectDisposedException ex)
                {

                    Debug.WriteLine(ex.Message, "TTSpeech");

                    MessageBox.Show("An error occurred while resuming speech", "Error", 0, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "TTSpeech");
                    //MessageBox.Show(ex.Message);
                }

               
                
            }
        }
         
        private void BtnStop_Click(object sender, EventArgs e)
        {
            speechsynth?.Dispose();
            isdisposed = true;
        }

    }
}
