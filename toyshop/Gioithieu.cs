using DevExpress.XtraSplashScreen;
using System;
using System.Threading;

namespace toyshop
{
    public partial class Gioithieu : SplashScreen
    {
        public Gioithieu()
        {
            InitializeComponent();
            WMPLib.WindowsMediaPlayer Player;
            Player = new WMPLib.WindowsMediaPlayer();

            Player.URL = @"E:\chuyen di cntt 2017\cong nghe phan mem\git_toyshop\toyshop\toyshop\music\DongMauLH.mp3";
            Player.controls.play();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}