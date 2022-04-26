using System;
using System.Windows.Forms;

namespace Nyelvtanulas.Views
{
    public interface IView
    {
        Action<UserControl> SetCurrentView { get; }
        void OnUpdate();
    }
}
