using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arkanoid.Classes.Items;

namespace Arkanoid.Classes
{
    static class Physic
    {
       
        class Cell
        {
            public float x;
            public float y;
            public bool bat;
            public bool brick;
            public bool wall;
            public bool IsEmpty { get { return (bat || brick || wall) ? false : true; } }

            public Cell(float a, float b)
            {
                x = a; y = b;
                bat = false;
                brick = false;
                wall = false;
            }
        }
        public static List<Item> itemList = new List<Item>();
        public static Ball ball;
        public static double CellWidth = Constant.pnlH / SpaceSideCount;
        public static double CellHeight = Constant.pnlW / SpaceSideCount;
        const int SpaceSideCount = 20;
        static Cell[,] SpaceGrid = new Cell[SpaceSideCount, SpaceSideCount];


        static public void Init()
        {
            for (int i = 0; i < SpaceSideCount; i++)
                for (int j = 0; j < SpaceSideCount; j++)
                    SpaceGrid[i, j] = new Cell(i * SpaceSideCount, j * SpaceSideCount);
            foreach (Item item in itemList)
                if (item is Wall)
                    for (int i = (int)Math.Truncate(item.Left/CellWidth); i < (int)Math.Truncate((item.Right) / CellWidth); i++)
                        for (int j = (int)Math.Truncate(item.Top / CellHeight); j < (int)Math.Truncate((item.Bottom) / CellHeight); j++)
                            SpaceGrid[i, j].wall = true;
            
            CheckGridBat();
        }

        static public void CheckGridBat()
        {
            Item item = itemList.Find(x => x is Bat);
            for (int i = (int)Math.Truncate(item.Left / CellWidth); i < (int)Math.Truncate((item.Right) / CellWidth); i++)
                for (int j = (int)Math.Truncate(item.Top / CellHeight); j < (int)Math.Truncate((item.Bottom) / CellHeight); j++)
                    SpaceGrid[i, j].bat = true;
        }
    }
}
