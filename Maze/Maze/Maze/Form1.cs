using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        //定数
        const int THICKNESS = 4;
        Color BACK_COLOR = Color.LightCyan;

        private Graphics graphics;

        //描画用ペン
        private Pen wallPen;
        private Pen backPen;
        private SolidBrush backBrush;
        //壁の間隔
        private int INTERVAL = 25;


        public Form1()
        {
            InitializeComponent();
            
            graphics = Maze_Panel.CreateGraphics();
            wallPen = new Pen(Color.Black, THICKNESS);
            backPen = new Pen(BACK_COLOR, THICKNESS);
            backBrush = new SolidBrush(BACK_COLOR);

        }

        private void MazeGenerateButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(BACK_COLOR);
            int row,column = 20;
            //サイズ変更
            //きれいに見たいので、固定サイズ...
            if(size1.Checked)
            {
                row = column = 10;
                INTERVAL = 50;
            }
            else if(size3.Checked)
            {
                row = column = 50;
                INTERVAL = 10;
            }
            else
            {
                row = column = 20;
                INTERVAL = 25;
            }
            //迷路を生成
            Maze maze = new Maze(row, column);
            maze.isRandom = isRandom.Checked;
            maze.Generate();
            //迷路をPanelに描画する
            DrawMaze(maze);
        }

        private void DrawMaze(Maze maze)
        {
            int row, column = 0;
            int halfThickness = THICKNESS / 2;


            foreach (Maze.Cell cell in maze.Cells)
            {
                if (cell.Walls[Maze.Cell.LEFT_WALL])
                {
                    Console.WriteLine(cell.row);

                    row = cell.row;
                    column = cell.column;
                    graphics.DrawLine(wallPen, row * INTERVAL,
                                                column * INTERVAL + halfThickness,
                                                (row + 1) * INTERVAL + THICKNESS,
                                                column * INTERVAL + halfThickness);
                }
                if (cell.Walls[Maze.Cell.RIGHT_WALL])
                {
                    row = cell.row;
                    column = cell.column + 1;
                    graphics.DrawLine(wallPen, row * INTERVAL,
                                                column * INTERVAL + halfThickness,
                                                (row + 1) * INTERVAL + THICKNESS,
                                                column * INTERVAL + halfThickness);
                }
                if (cell.Walls[Maze.Cell.UP_WALL])
                {
                    row = cell.row;
                    column = cell.column;
                    graphics.DrawLine(wallPen, row * INTERVAL + halfThickness,
                                                column * INTERVAL,
                                                row * INTERVAL + halfThickness,
                                                (column + 1) * INTERVAL + THICKNESS);
                }
                if (cell.Walls[Maze.Cell.DOWN_WALL])
                {
                    row = cell.row + 1;
                    column = cell.column;
                    graphics.DrawLine(wallPen, row * INTERVAL + halfThickness,
                                                column * INTERVAL ,
                                                row * INTERVAL + halfThickness,
                                                (column + 1) * INTERVAL + THICKNESS);
                }
            }

            //スタートセル
            graphics.FillRectangle(new SolidBrush(Color.Orange), THICKNESS, 
                                                                 THICKNESS,
                                                                 INTERVAL - THICKNESS,
                                                                 INTERVAL - THICKNESS);
            //ゴールセル
            graphics.FillRectangle(new SolidBrush(Color.LightGreen), (maze.Max_Column_Index * INTERVAL) + THICKNESS,
                                                                     (maze.Max_Row_Index * INTERVAL) + THICKNESS,
                                                                     INTERVAL - THICKNESS,
                                                                     INTERVAL - THICKNESS);

        }
    }
}
