namespace Store.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(int id, string entityName)
            : base($"{entityName} with is {id} doesn't exist in system")
        {

        }
    }
}
