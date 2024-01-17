using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;

namespace TimeTabler.Models
{
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
            return ColorTranslator.ToHtml(Color);
        }
    }

}
