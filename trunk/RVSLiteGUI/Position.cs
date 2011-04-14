namespace RVSLite{
    internal class Position{
        public Position(int column, int row){
            Column = column;
            Row = row;
        }

        public int Column { set; get; }
        public int Row { set; get; }
    }
}