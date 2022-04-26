using Nyelvtanulas.Views;
using System.Collections.Generic;

namespace Nyelvtanulas.Documents
{
    public abstract class Document
    {
        private List<IView> views;

        protected Document()
        {
            views = new List<IView>();
        }
        public void AddView(IView view)
        {
            views.Add(view);
        }

        public void RemoveView(IView view)
        {
            views.Remove(view);
        }

        public void UpdateAllViews()
        {
            views.ForEach(value => value.OnUpdate());
        }
    }
}
