using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace TimeTabler.Models
{
    [TypeConverter(typeof(GroupModelConverter))]
    public class GroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; } = Color.White;

        public override string ToString()
        {
            return Name;
        }

        public string GetColorString()
        {
            return Color.HexValue;
        }
    }

    public class GroupModelConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                var group = new GroupModel();
                group.Name = value as string;
                return group;
            }
            return base.ConvertFrom(context, culture, value);
        }
    }

}
