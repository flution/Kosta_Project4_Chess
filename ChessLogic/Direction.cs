using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Direction
    {
        public readonly static Direction North = new Direction(-1, 0);
        public readonly static Direction South = new Direction(1, 0);
        public readonly static Direction East = new Direction(0, 1);
        public readonly static Direction West = new Direction(0, -1);
        public readonly static Direction NorthEast = North + East;
        public readonly static Direction NorthWest = North + West;
        public readonly static Direction SouthEast = South + East;
        public readonly static Direction SouthWest = South + West;
        public int RowDellta {  get; }

        public int ColumnDellta { get; }

        public Direction(int rowDellta, int columnDellta)
        {
            RowDellta = rowDellta;
            ColumnDellta = columnDellta;
        }

        public static Direction operator +(Direction dir1, Direction dir2)
        {
            return new Direction(dir1.RowDellta + dir2.RowDellta, dir1.ColumnDellta + dir2.ColumnDellta);
        }
        
        public static Direction operator *(int scalar, Direction dir)
        {
            return new Direction(scalar * dir.RowDellta, scalar = dir.ColumnDellta);
        }
    }
}
