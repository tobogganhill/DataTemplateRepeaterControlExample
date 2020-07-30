using DataTemplateRepeaterControl.Models;
using DataTemplateRepeaterControl.Views.Cells;
using Xamarin.Forms;

namespace DataTemplateRepeaterControl.TemplateSelectors
{
    public class SimpleTemplateSelector : DataTemplateSelector
    {
        private DataTemplate _itemATemplate;

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (item)
            {
                case ItemA cellModel:
                    return _itemATemplate ?? (_itemATemplate = new DataTemplate(typeof(ItemACell)));

                default:
                    return null;
            }
        }
    }
}
