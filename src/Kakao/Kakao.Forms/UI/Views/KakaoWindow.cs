﻿using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;
namespace Kakao.Forms.UI.Views
{
    public class KakaoWindow : JamesWindow
    {
        static KakaoWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KakaoWindow), new FrameworkPropertyMetadata(typeof(KakaoWindow)));
        }
    }
}
