using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    /// <summary>
    /// Contains information about themes and colors.
    /// Provide tools to manage colors and brushes.
    /// </summary>
    [Serializable]
    public class Theme
    {
        private string name;
        private string textColor;
        private string backgroundColor;
        private string controlsColor;

        public Theme(string name, string textColor, string backgroundColor, string controlsColor)
        {
            this.name = name;
            this.textColor = textColor;
            this.backgroundColor = backgroundColor;
            this.controlsColor = controlsColor;
        }

        private Theme()
        {

        }


        public string Name { get { return name; } }
        public string TextColor{ get { return textColor; } }
        public string BackgroundColor { get { return backgroundColor; } }
        public string ControlsColor { get { return controlsColor; } }



        /// <summary>
        /// Create color to assign to color properites of WPF controls(e.g., Background)
        /// </summary>
        /// <param name="color">Initial color to create brush</param>
        /// <returns>Color brush requested</returns>
        public static System.Windows.Media.Brush CreateBrush(string color)
        {
            var converter = new System.Windows.Media.BrushConverter();

            try
            {
                return (System.Windows.Media.Brush)converter.ConvertFrom(color);
            }
            catch
            {
                return null;
            }
        }

        //public void Deserialize(string serializedObject)
        //{
        //    //List<Preferito> users = new List<Preferito>();
        //    Theme temp = new Theme();

        //    using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(serializedObject)))
        //    {
        //        BinaryFormatter bf = new BinaryFormatter();
        //        try
        //        {
        //            temp = (Theme)bf.Deserialize(ms);

        //            this.name = temp.name;
        //            this.textColor = temp.textColor;
        //            this.backgroundColor = temp.backgroundColor;
        //            this.controlsColor = temp.controlsColor;
        //        }
        //        catch
        //        {

        //        }
        //    }
        //}

        public static Theme Deserialize(string serializedObject)
        {
            Theme temp = new Theme();

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(serializedObject)))
            {
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    temp = (Theme)bf.Deserialize(ms);
                }
                catch
                {

                }
            }

            return temp;
        }

        public string Serialize()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, this);
                ms.Position = 0;
                byte[] buffer = new byte[(int)ms.Length];
                ms.Read(buffer, 0, buffer.Length);

                return Convert.ToBase64String(buffer);
            }
        }
    }
}
