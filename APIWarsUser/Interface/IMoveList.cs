namespace APIWarsUser.Interface
{
    public interface IMoveList
    {
        public void MoveUp(int MoveBlock, string IPv6, string TypeDrone);
        //public void MoveUp45(int MoveBlock, string IPv6, string TypeDrone);
        public void MoveRight(int MoveBlock, string IPv6, string TypeDrone);
        //public void MoveDown135(int MoveBlock, string IPv6, string TypeDrone);
        public void MoveDown(int MoveBlock, string IPv6, string TypeDrone);
        //public void MoveDown225(int MoveBlock, string IPv6, string TypeDrone);
        public void MoveLeft(int MoveBlock, string IPv6, string TypeDrone);
        //public void MoveUp315(int MoveBlock, string IPv6, string TypeDrone);

    }
}
