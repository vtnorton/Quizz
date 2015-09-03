using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Quizz
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int contador = 1;
        private int intPontosGrupoA = 0, intPontosGrupoB = 0;
        private string RespotaCorreta, RespostaSelecionada;
        private string Pergunta1 = "01. ";
        private string RespostaAP1 = "a) ";
        private string RespostaBP1 = "b) ";
        private string RespostaCP1 = "c) ";
        private string RespostaDP1 = "d) ";
        private string OpcaoCorretaP1 = "b)";
        private string Pergunta2 = "02. ";
        private string RespostaAP2 = "a) ";
        private string RespostaBP2 = "b) ";
        private string RespostaCP2 = "c) ";
        private string RespostaDP2 = "d) ";
        private string OpcaoCorretaP2 = "d)";
        private string Pergunta3 = "03. ";
        private string RespostaAP3 = "a) ";
        private string RespostaBP3 = "b) ";
        private string RespostaCP3 = "c) ";
        private string RespostaDP3 = "d) ";
        private string OpcaoCorretaP3 = "a)";
        private string Pergunta4 = "04. ";
        private string RespostaAP4 = "a) ";
        private string RespostaBP4 = "b) ";
        private string RespostaCP4 = "c) ";
        private string RespostaDP4 = "d) ";
        private string OpcaoCorretaP4 = "a)";
        private string Pergunta5 = "05. ";
        private string RespostaAP5 = "a) ";
        private string RespostaBP5 = "b) ";
        private string RespostaCP5 = "c) ";
        private string RespostaDP5 = "d) ";
        private string OpcaoCorretaP5 = "d)";
        private string Pergunta6 = "06. ";
        private string RespostaAP6 = "a) ";
        private string RespostaBP6 = "b) ";
        private string RespostaCP6 = "c) ";
        private string RespostaDP6 = "d) ";
        private string OpcaoCorretaP6 = "c)";
        private string Pergunta7 = "07. ";
        private string RespostaAP7 = "a) ";
        private string RespostaBP7 = "b) ";
        private string RespostaCP7 = "c) ";
        private string RespostaDP7 = "d) ";
        private string OpcaoCorretaP7 = "a)";
        private string Pergunta8 = "08. ";
        private string RespostaAP8 = "a) ";
        private string RespostaBP8 = "b) ";
        private string RespostaCP8 = "c) ";
        private string RespostaDP8 = "d) ";
        private string OpcaoCorretaP8 = "a)";
        private string Pergunta9 = "09. ";
        private string RespostaAP9 = "a) ";
        private string RespostaBP9 = "b) ";
        private string RespostaCP9 = "c) ";
        private string RespostaDP9 = "d) ";
        private string OpcaoCorretaP9 = "a)";
        private string Pergunta10 = "10. ";
        private string RespostaAP10 = "a) ";
        private string RespostaBP10 = "b) ";
        private string RespostaCP10 = "c) ";
        private string RespostaDP10 = "d) ";
        private string OpcaoCorretaP10 = "d)";

        private Brush selecionado = new SolidColorBrush(Colors.LightYellow);
        private Brush normal = new SolidColorBrush(Colors.Gray);
        private Brush corretobg = new SolidColorBrush(Colors.LightGreen);
        private Brush erradobg = new SolidColorBrush(Colors.LightSalmon);
        private Brush normalbg = new SolidColorBrush(Colors.DarkGray);
        private Brush correto = new SolidColorBrush(Colors.Green);
        private Brush errado = new SolidColorBrush(Colors.Red);

        private Boolean VerificarResposta()
        {
            
            if(RespostaSelecionada == RespotaCorreta)
            {
                switch(RespostaSelecionada)
                {
                    case "a)":
                        TelaR1.Background = correto;
                        break;
                    case "b)":
                        TelaR2.Background = correto;
                        break;
                    case "c)":
                        TelaR3.Background = correto;
                        break;
                    case "d)":
                        TelaR4.Background = correto;
                        break;

                }
                Principal.Background = corretobg;
                SelecionarGrupoA.Background = corretobg;
                SelecionarGrupoB.Background = corretobg;
                proximapergunta.Background = corretobg;
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                titleBar.BackgroundColor = Colors.LightGreen;
                titleBar.ButtonBackgroundColor = Colors.LightGreen;
                titleBar.ButtonInactiveBackgroundColor = Colors.LightGreen;
                return true;
                
            }
            else
            {
                switch (RespostaSelecionada)
                {
                    case "a)":
                        TelaR1.Background = errado;
                        break;
                    case "b)":
                        TelaR2.Background = errado;
                        break;
                    case "c)":
                        TelaR3.Background = errado;
                        break;
                    case "d)":
                        TelaR4.Background = errado;
                        break;
                }
                switch (RespotaCorreta)
                {
                    case "a)":
                        TelaR1.Background = correto;
                        break;
                    case "b)":
                        TelaR2.Background = correto;
                        break;
                    case "c)":
                        TelaR3.Background = correto;
                        break;
                    case "d)":
                        TelaR4.Background = correto;
                        break;
                }
                Principal.Background = erradobg;
                SelecionarGrupoA.Background = erradobg;
                SelecionarGrupoB.Background = erradobg;
                proximapergunta.Background = erradobg;
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                titleBar.BackgroundColor = Colors.Salmon;
                titleBar.ButtonBackgroundColor = Colors.Salmon;
                titleBar.ButtonInactiveBackgroundColor = Colors.Salmon;
                return false;
            }
        }
        private void TelaPergunta1()
        {
            TelaPergunta.Text = Pergunta1;
            TelaR1.Content = RespostaAP1;
            TelaR2.Content = RespostaBP1;
            TelaR3.Content = RespostaCP1;
            TelaR4.Content = RespostaDP1;
            RespotaCorreta = OpcaoCorretaP1.ToString();
        }
        private void TelaPergunta2()
        {
            TelaPergunta.Text = Pergunta2;
            TelaR1.Content = RespostaAP2;
            TelaR2.Content = RespostaBP2;
            TelaR3.Content = RespostaCP2;
            TelaR4.Content = RespostaDP2;
            RespotaCorreta = OpcaoCorretaP2.ToString();
        }
        private void TelaPergunta3()
        {
            TelaPergunta.Text = Pergunta3;
            TelaR1.Content = RespostaAP3;
            TelaR2.Content = RespostaBP3;
            TelaR3.Content = RespostaCP3;
            TelaR4.Content = RespostaDP3;
            RespotaCorreta = OpcaoCorretaP3.ToString();
        }
        private void TelaPergunta4()
        {
            TelaPergunta.Text = Pergunta4;
            TelaR1.Content = RespostaAP4;
            TelaR2.Content = RespostaBP4;
            TelaR3.Content = RespostaCP4;
            TelaR4.Content = RespostaDP4;
            RespotaCorreta = OpcaoCorretaP4.ToString();
        }
        private void TelaPergunta5()
        {
            TelaPergunta.Text = Pergunta5;
            TelaR1.Content = RespostaAP5;
            TelaR2.Content = RespostaBP5;
            TelaR3.Content = RespostaCP5;
            TelaR4.Content = RespostaDP5;
            RespotaCorreta = OpcaoCorretaP5.ToString();
        }
        private void TelaPergunta6()
        {
            TelaPergunta.Text = Pergunta6;
            TelaR1.Content = RespostaAP6;
            TelaR2.Content = RespostaBP6;
            TelaR3.Content = RespostaCP6;
            TelaR4.Content = RespostaDP6;
            RespotaCorreta = OpcaoCorretaP6.ToString();
        }
        private void TelaPergunta7()
        {
            TelaPergunta.Text = Pergunta7;
            TelaR1.Content = RespostaAP7;
            TelaR2.Content = RespostaBP7;
            TelaR3.Content = RespostaCP7;
            TelaR4.Content = RespostaDP7;
            RespotaCorreta = OpcaoCorretaP7.ToString();
        }
        private void TelaPergunta8()
        {
            TelaPergunta.Text = Pergunta8;
            TelaR1.Content = RespostaAP8;
            TelaR2.Content = RespostaBP8;
            TelaR3.Content = RespostaCP8;
            TelaR4.Content = RespostaDP8;
            RespotaCorreta = OpcaoCorretaP8.ToString();
        }
        private void TelaPergunta9()
        {
            TelaPergunta.Text = Pergunta9;
            TelaR1.Content = RespostaAP9;
            TelaR2.Content = RespostaBP9;
            TelaR3.Content = RespostaCP9;
            TelaR4.Content = RespostaDP9;
            RespotaCorreta = OpcaoCorretaP9.ToString();
        }
        private void TelaPergunta10()
        {
            TelaPergunta.Text = Pergunta10;
            TelaR1.Content = RespostaAP10;
            TelaR2.Content = RespostaBP10;
            TelaR3.Content = RespostaCP10;
            TelaR4.Content = RespostaDP10;
            RespotaCorreta = OpcaoCorretaP10.ToString();
        }

        private void SelecionarGrupoA_Click(object sender, RoutedEventArgs e)
        {
            if (VerificarResposta())
            {
                intPontosGrupoA++;
                if(intPontosGrupoA == 1)
                    PontosGrupoA.Text = intPontosGrupoA + " ponto";
                else
                    PontosGrupoA.Text = intPontosGrupoA + " pontos";
            }
            else
            {
                intPontosGrupoB++;
                if (intPontosGrupoB == 1)
                    PontosGrupoB.Text = intPontosGrupoB + " ponto";
                else
                    PontosGrupoB.Text = intPontosGrupoB + " pontos";
            }
        }

        private void SelecionarGrupoB_Click(object sender, RoutedEventArgs e)
        {
            if (VerificarResposta())
            {
                intPontosGrupoB++;
                if (intPontosGrupoB == 1)
                    PontosGrupoB.Text = intPontosGrupoB + " ponto";
                else
                    PontosGrupoB.Text = intPontosGrupoB + " pontos";
            }
            else
            {
                intPontosGrupoA++;
                if (intPontosGrupoA == 1)
                    PontosGrupoA.Text = intPontosGrupoA + " ponto";
                else
                    PontosGrupoA.Text = intPontosGrupoA + " pontos";
            }
        }

        private void TelaR1_Checked(object sender, RoutedEventArgs e)
        {
            RespostaSelecionada = "a)";
            TelaR1.Background = selecionado;
            TelaR2.Background = normal;
            TelaR3.Background = normal;
            TelaR4.Background = normal;
        }

        private void TelaR2_Checked(object sender, RoutedEventArgs e)
        {
            RespostaSelecionada = "b)";
            TelaR1.Background = normal;
            TelaR2.Background = selecionado;
            TelaR3.Background = normal;
            TelaR4.Background = normal;
        }

        private void TelaR3_Checked(object sender, RoutedEventArgs e)
        {
            RespostaSelecionada = "c)";
            TelaR1.Background = normal;
            TelaR2.Background = normal;
            TelaR3.Background = selecionado;
            TelaR4.Background = normal;

        }
        private void TelaR4_Checked(object sender, RoutedEventArgs e)
        {
            RespostaSelecionada = "d)";
            TelaR1.Background = normal;
            TelaR2.Background = normal;
            TelaR3.Background = normal;
            TelaR4.Background = selecionado;
        }

        private void proximapergunta_Click(object sender, RoutedEventArgs e)
        {
            contador++;
            TelaR1.Background = normal;
            TelaR2.Background = normal;
            TelaR3.Background = normal;
            TelaR4.Background = normal;
            SelecionarGrupoB.Background = normalbg;
            SelecionarGrupoA.Background = normalbg;
            Principal.Background = normalbg;
            proximapergunta.Background = normalbg;
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.BackgroundColor = Colors.DarkGray;
            titleBar.ButtonBackgroundColor = Colors.DarkGray;
            titleBar.ButtonInactiveBackgroundColor = Colors.DarkGray;
            switch (contador)
            {
                case 1:
                    TelaPergunta1();
                    break;
                case 2:
                    TelaPergunta2();
                    break;
                case 3:
                    TelaPergunta3();
                    break;
                case 4:
                    TelaPergunta4();
                    break;
                case 5:
                    TelaPergunta5();
                    break;
                case 6:
                    TelaPergunta6();
                    break;
                case 7:
                    TelaPergunta7();
                    break;
                case 8:
                    TelaPergunta8();
                    break;
                case 9:
                    TelaPergunta9();
                    break;
                case 10:
                    TelaPergunta10();
                    break;
            }
        }

        
        public MainPage()
        {
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.BackgroundColor = Colors.DarkGray;
            titleBar.InactiveBackgroundColor = Colors.DarkGray;
            titleBar.InactiveForegroundColor = Colors.Black;
            titleBar.ButtonInactiveForegroundColor = Colors.Black;
            titleBar.ButtonBackgroundColor = Colors.DarkGray;
            titleBar.ButtonInactiveBackgroundColor = Colors.DarkGray;
            this.InitializeComponent();
            TelaPergunta1();
        }
    }
}
