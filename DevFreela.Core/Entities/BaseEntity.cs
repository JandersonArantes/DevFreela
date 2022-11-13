namespace DevFreela.Core.Entities
{
    // Esta classe não é instanciada.
    public abstract class BaseEntity
    {
        public BaseEntity()
        {

        }
        public int Id { get; private set; }
    }
}
