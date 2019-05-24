using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer synt = new SpeechSynthesizer();
        PromptBuilder pbuilder = new PromptBuilder();
        SpeechRecognitionEngine rengine = new SpeechRecognitionEngine();
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);    

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void rengine_speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {


            switch (e.Result.Text)
            {

                case "SOS":
                    listBox1.Visible = true;
                    break;
                case "change":
                    System.Windows.Forms.SendKeys.Send("^{TAB}");
                    break;

                case "close":
                    System.Windows.Forms.SendKeys.Send("^{w}");
                    break;

                case "switch":
                    System.Windows.Forms.SendKeys.Send("%{TAB}");
                    break;

                case "open chrome":
                    System.Diagnostics.Process.Start("C:/Program Files (x86)/Google/Chrome/Application/chrome.exe");
                    System.Media.SystemSounds.Beep.Play();
                    break;

                case "hide":                   
                    this.Hide();
                    break;

                case "show":
                    this.Show();
                    break;

                case "exit":
                    Application.Exit();
                    System.Media.SystemSounds.Beep.Play();
                    break;

                case "open studio":
                    System.Diagnostics.Process.Start("C:/Program Files (x86)/Microsoft Visual Studio 12.0/Common7/IDE/devenv.exe");
                    System.Media.SystemSounds.Beep.Play();
                    break;

                case "shutdown":
                    string komut = "shutdown -s -t 3600";
                    Process Process = new Process();
                    ProcessStartInfo ProcessInfo;
                    ProcessInfo = new ProcessStartInfo("cmd.exe", "/C " + komut);
                    ProcessInfo.CreateNoWindow = true;
                    ProcessInfo.UseShellExecute = false;
                    Process = Process.Start(ProcessInfo);
                    Process.WaitForExit();
                    Process.Close();
                    break;

                case "cancel shutdown":
                    string komut2 = "shutdown -a";
                    Process Process2 = new Process();
                    ProcessStartInfo Process2Info;
                    Process2Info = new ProcessStartInfo("cmd.exe", "/C " + komut2);
                    Process2Info.CreateNoWindow = true;
                    Process2Info.UseShellExecute = false;
                    Process2 = Process.Start(Process2Info);
                    Process2.WaitForExit();
                    Process2.Close();
                    break;

                case "open facebook":
                    string komut3 = "start chrome.exe facebook.com";
                    Process Process3 = new Process();
                    ProcessStartInfo ProcessInfo3;
                    ProcessInfo3 = new ProcessStartInfo("cmd.exe", "/C " + komut3);
                    ProcessInfo3.CreateNoWindow = true;
                    ProcessInfo3.UseShellExecute = false;
                    Process3 = Process.Start(ProcessInfo3);
                    Process3.WaitForExit();
                    Process3.Close();
                    System.Media.SystemSounds.Beep.Play();
                    break;

                case "open d box":
                    string komut4 = "start chrome.exe dizibox1.com";
                    Process Process4 = new Process();
                    ProcessStartInfo ProcessInfo4;
                    ProcessInfo4 = new ProcessStartInfo("cmd.exe", "/C " + komut4);
                    ProcessInfo4.CreateNoWindow = true;
                    ProcessInfo4.UseShellExecute = false;
                    Process4 = Process.Start(ProcessInfo4);
                    Process4.WaitForExit();
                    Process4.Close();
                    System.Media.SystemSounds.Beep.Play();
                    break;

                case "open d lab":
                    string komut5 = "start chrome.exe dizilab.net";
                    Process Process5 = new Process();
                    ProcessStartInfo ProcessInfo5;
                    ProcessInfo5 = new ProcessStartInfo("cmd.exe", "/C " + komut5);
                    ProcessInfo5.CreateNoWindow = true;
                    ProcessInfo5.UseShellExecute = false;
                    Process5 = Process.Start(ProcessInfo5);
                    Process5.WaitForExit();
                    Process5.Close();
                    System.Media.SystemSounds.Beep.Play();
                    break;
 
            }
        }     
        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }

        private void nyX_Button1_Click(object sender, EventArgs e)
        {
            
            Choices list = new Choices();
            list.Add(new string[] {"SOS","close", "change", "switch", "open d lab", "open d box", "open facebook", "show", "hide", "exit", "open chrome", "open studio", "shutdown", "cancel shutdown" });
            Grammar gramer = new Grammar(new GrammarBuilder(list));

            try
            {
                rengine.RequestRecognizerUpdate();
                rengine.LoadGrammar(gramer);
                rengine.SpeechRecognized += rengine_speechRecognized;
                rengine.SetInputToDefaultAudioDevice();
                rengine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }  
        }

        private void nyX_Button2_Click(object sender, EventArgs e)
        {
            rengine.UnloadAllGrammars();  
        }

        private void nyX_Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nyX_Theme1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
