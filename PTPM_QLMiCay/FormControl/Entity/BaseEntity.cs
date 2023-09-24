namespace DataHelper.Entity
{
    public abstract class BaseEntity
    {
        private int id { get; set; }

        public int ID() { return id; }
        public void ID(int Id) { id = Id; }
    }
}
