using DevExpress.XtraSplashScreen;
using System;

namespace toyshop
{
    public partial class Gioithieu : SplashScreen
    {
        public Gioithieu()
        {
            InitializeComponent();
           
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