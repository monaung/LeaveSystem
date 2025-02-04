namespace HR.LeaveManagement.Domain
{
    public abstract class BasedEntity
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
