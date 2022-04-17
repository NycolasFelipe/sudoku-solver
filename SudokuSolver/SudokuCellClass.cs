using System;
using System.Windows.Forms;

namespace SudokuSolver
{
    public class SudokuCell : Button
    {
        public int Value { get; set; }
        public bool IsLocked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Clear()
        {
            this.Text = String.Empty;
            this.IsLocked = false;
        }
    }
}
