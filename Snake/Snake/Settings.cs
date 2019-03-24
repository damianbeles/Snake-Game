using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public sealed class Settings
    {
        private static Settings instance = null;
        private static readonly object padlock = new object();
        private Settings() { }

        private bool isSoundsOn = true;

        private Color boardColor = Color.Silver;
        private Color bodyColor = Color.ForestGreen;
        private Color foodColor = Color.Red;
        private Color headColor = Color.Orange;
        private Color wallColor = Color.Black;

        public static Settings Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new Settings();

                    return instance;
                }
            }
        }

        public bool IsSoundsOn { get => isSoundsOn; set => isSoundsOn = value; }

        public Color BoardColor { get => boardColor; set => boardColor = value; }
        public Color BodyColor { get => bodyColor; set => bodyColor = value; }
        public Color FoodColor { get => foodColor; set => foodColor = value; }
        public Color HeadColor { get => headColor; set => headColor = value; }
        public Color WallColor { get => wallColor; set => wallColor = value; }
    }
}
