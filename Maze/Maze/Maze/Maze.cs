using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Maze
    {
        //セル配列
        public Cell[,] Cells;
        //行と列
        public int Max_Row_Index { get; }
        public int Max_Column_Index { get; }
        //セルランダム選択フラグ
        public bool isRandom = true;

        //乱数生成
        System.Random RND = new System.Random();

        public Maze(int row, int column)
        {
            Max_Row_Index = row - 1;
            Max_Column_Index = column - 1;
            //初期化
            Cells = new Cell[row, column];
            for(int r = 0; r < row; r++)
            {
                for(int c = 0; c < row; c++)
                {
                    Cells[r, c] = new Cell(r, c);
                }
            }

        }

        //ランダムPrimで迷路生成
        public void Generate()
        {
            //乱数生成変数
            //System.Random RND = new System.Random();

            //また全ての壁を操作しなかったセルリスト
            List<Cell> cellList = new List<Cell>();

            //開始セルを（0,0）と設定する
            Cell cell = Cells[0, 0];
            cell.visited = true;

            Cell next_Cell = null;

            cellList.Add(cell);

            while(cellList.Count != 0)
            {
                //隣接セル選択
                next_Cell = SelectNeighboringCells(cell);

                if (next_Cell != null)
                {
                    //壁削除
                    DestroyWall(cell, next_Cell);

                    //訪問済み
                    next_Cell.visited = true;

                    cellList.Add(next_Cell);
                }
                else
                {
                    cellList.Remove(cell);
                }

                //ランダムで次操作するセル選択
                if(cellList.Count > 0)
                {
                    if (isRandom)
                    {
                        cell = cellList[RND.Next(0, cellList.Count)];
                    }
                    else
                    {
                        cell = cellList[cellList.Count - 1];
                    }
                }
            }
        }

        //ランダムで隣接セルを選択
        private Cell SelectNeighboringCells(Cell cell)
        {
            int row, column = 0;
            Cell retCell = null;

            //訪問可能のセルリスト
            List<Cell> cellList = new List<Cell>();

            Cell tempCell = null;
            row = cell.row;
            column = cell.column;
            //左→上→右→下の順で隣接セルが訪問できるか判断
            //できるセルをセルリストに追加して、ランダムで選択する
            if(column != 0 && cell.Walls[Cell.LEFT_WALL] != false)
            {
                tempCell = Cells[row, column - 1];
                if (tempCell.visited == false)
                {
                    cellList.Add(tempCell);
                }
            }
            if(row != 0 && cell.Walls[Cell.UP_WALL] != false)
            {
                tempCell = Cells[row - 1, column];
                if (tempCell.visited == false)
                {
                    cellList.Add(tempCell);
                }
            }
            if(column != Max_Column_Index && cell.Walls[Cell.RIGHT_WALL] != false)
            {
                tempCell = Cells[row, column + 1];
                if (tempCell.visited == false)
                {
                    cellList.Add(tempCell);
                }
            }
            if(row != Max_Row_Index && cell.Walls[Cell.DOWN_WALL] != false)
            {
                tempCell = Cells[row + 1, column];
                if (tempCell.visited == false)
                {
                    cellList.Add(tempCell);
                }
            }
            //訪問可能なセルある場合、ランダムで選択する
            if(cellList.Count > 0)
            {
                retCell = cellList[RND.Next(0, cellList.Count)];
            }

            return retCell;
        }

        //壁を削除
        private void DestroyWall(Cell cell_1, Cell cell_2)
        {
            //共通の壁を削除
            if(cell_1.row == cell_2.row)
            {
                switch(cell_1.column - cell_2.column)
                {
                    //cell_1はcell_2の左セル
                    case -1:
                        cell_1.Walls[Cell.RIGHT_WALL] = false;
                        cell_2.Walls[Cell.LEFT_WALL] = false;
                        break;
                    //cell_1はcell_2の右セル
                    case 1:
                        cell_1.Walls[Cell.LEFT_WALL] = false;
                        cell_2.Walls[Cell.RIGHT_WALL] = false;
                        break;
                    //同じセル
                    default:
                        break;
                }
            }
            else if (cell_1.column == cell_2.column)
            {
                switch (cell_1.row - cell_2.row)
                {
                    //cell_1はcell_2の上セル
                    case -1:
                        cell_1.Walls[Cell.DOWN_WALL] = false;
                        cell_2.Walls[Cell.UP_WALL] = false;
                        break;
                    //cell_1はcell_2の下セル
                    case 1:
                        cell_1.Walls[Cell.UP_WALL] = false;
                        cell_2.Walls[Cell.DOWN_WALL] = false;
                        break;
                    //同じセル
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine(String.Format("不正操作Cell[{0},{1}],Cell[{2},{3}]",cell_1.row,
                                                                                      cell_1.column,
                                                                                      cell_2.row,
                                                                                      cell_2.column));
            }
        }

        //セルクラス
        public class Cell
        {
            //壁のIndex
            public const int LEFT_WALL = 0;
            public const int RIGHT_WALL = 1;
            public const int UP_WALL = 2;
            public const int DOWN_WALL = 3;

            //壁配列（初期値を各方向の壁は全部有と設定）
            public bool[] Walls = new bool[4] {true, true, true, true };

            //訪問済みフラグ
            public bool visited { set; get; }

            //自分の位置
            public int row { get; }
            public int column { get; }

            public Cell(int row, int column)
            {
                this.row = row;
                this.column = column;
                this.visited = false;
            }
        }
    }
}
