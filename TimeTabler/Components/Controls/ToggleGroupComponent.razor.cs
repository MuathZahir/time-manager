using Microsoft.AspNetCore.Components;
using TimeTabler.Models;

namespace TimeTabler.Components.Controls
{
    public partial class ToggleGroupComponent<TItem>
    {
        [Parameter]
        public EventCallback<TItem> SelectedValueChanged { get; set; }
        private TItem _SelectedValue;
        [Parameter]
        public TItem SelectedValue
        {
            get => _SelectedValue;
            set
            {
                if (!_SelectedValue.Equals(value))
                {
                    _SelectedValue = value;
                    SelectedValueChanged.InvokeAsync(_SelectedValue);
                }
            }
        }

        // Tuple for Radio Button Value and ID
        [Parameter]
        public RenderFragment? RadioButtonList { get; set; }
    }
}
