﻿#pragma checksum "G:\windowsuniversalapps.multivix.quizz\Quizz\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7805434843CC31D8B7BDCA0C2E0AAB7F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quizz
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.proximapergunta = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.proximapergunta).Click += this.proximapergunta_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.SelecionarGrupoB = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 65 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SelecionarGrupoB).Click += this.SelecionarGrupoB_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.TelaResposta1BG = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.TelaResposta2BG = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5:
                {
                    this.TelaResposta3BG = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6:
                {
                    this.TelaResposta4BG = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.TelaR4 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 56 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.TelaR4).Checked += this.TelaR4_Checked;
                    #line default
                }
                break;
            case 8:
                {
                    this.TelaR3 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 53 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.TelaR3).Checked += this.TelaR3_Checked;
                    #line default
                }
                break;
            case 9:
                {
                    this.TelaR2 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 50 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.TelaR2).Checked += this.TelaR2_Checked;
                    #line default
                }
                break;
            case 10:
                {
                    this.TelaR1 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 47 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.TelaR1).Checked += this.TelaR1_Checked;
                    #line default
                }
                break;
            case 11:
                {
                    this.SelecionarGrupoA = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 37 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SelecionarGrupoA).Click += this.SelecionarGrupoA_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.PontosGrupoB = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.TelaPergunta = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.PontosGrupoA = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

