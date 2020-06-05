﻿using LarynxModule;
using LarynxModule.SpeechRecognize;
using LarynxModule.SpeechRecognize.Google;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Larynx
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {

        // *Teclado virtual
        // *Configurar microfone
        // *Configurar caps ou apenas minúsculo
        // *Atalhos 
        //	->Volume por atalho
        //	->Passar música
        //	->Voltar
        //	->Pausar
        // *Configuração avançada de Flac e codificação
        // *Statusbar de ping

        public MainWindow()
        {
            InitializeComponent();

            GoogleSpeech googleSpeech = new GoogleSpeech();
            //Recorder recorder = new Recorder();
            FileStream fs1 = new FileStream(Path.Combine("FlacTests", "apenas_um_show.flac"), FileMode.Open);
            var googleTextResponses = googleSpeech.Recognize(fs1,
                                                            44100,
                                                            1,
                                                            AudioFormat.FLAC);
            FileStream fs2 = new FileStream(Path.Combine("FlacTests", "apenas_um_show2.flac"), FileMode.Open);
            googleTextResponses = googleSpeech.Recognize(fs2,
                                                            44100,
                                                            1,
                                                            AudioFormat.FLAC);
        }
    }
}
