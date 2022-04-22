using Nyelvtanulas.Views;
using System.Collections.Generic;

namespace Nyelvtanulas.Documents
{
    public abstract class Document
    {
        private List<View> views;

        protected Document()
        {
            views = new List<View>();
        }
        public void AddView(View view)
        {
            views.Add(view);
        }

        public void RemoveView(View view)
        {
            views.Remove(view);
        }

        public void UpdateAllViews()
        {
            views.ForEach(value => value.OnUpdate());
        }
    }
}
