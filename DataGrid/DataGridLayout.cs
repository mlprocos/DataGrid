using System;
using Xamarin.Forms;

namespace Zumero
{
    class DataGridLayout : Layout<View>
    {
        private Func<View, Rectangle> GetBox { get; }

        public DataGridLayout(Func<View, Rectangle> f)
        {
            GetBox = f;
        }

        public void LayoutOneChild(View v)
        {
            Rectangle r = GetBox(v);
            v.Layout(r);
        }

        public void LayoutAllChildren()
        {
            foreach (View v in Children)
            {
                LayoutOneChild(v);
            }
        }

        protected override bool ShouldInvalidateOnChildAdded(View child)
        {
            return false;
        }

        protected override bool ShouldInvalidateOnChildRemoved(View child)
        {
            return false;
        }

        public bool CallOnChildMeasureInvalidated;
        protected override void OnChildMeasureInvalidated()
        {
            if (CallOnChildMeasureInvalidated)
                base.OnChildMeasureInvalidated();
        }

        protected override void LayoutChildren(double x, double y, double width, double height)
        {
            // TODO consider a flag here to suspend/resume.
            // maybe implement this by requiring all children insertions to be done
            // through a method?
            LayoutAllChildren();
        }
    }

}
