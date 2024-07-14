namespace Constructur_
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.CreatedDate = DateTime.UtcNow;
            this.CreatedIp = Enviroment.
        }
        public int Id { get; set; }
        public string CreatedIp { get; set; } = null!;
        public DateTime CreatedDate { get; set; }



        private string? _updatedIp;

        public string? UpdatedIp 
        { 
            get=>_updatedIp;

            set 
            {
                _updatedIp = value;
                if (value != null) { this.UpdatedDate = DateTime.UtcNow; }
            } 
        }



        public DateTime? UpdatedDate { get;set; }
        public bool IsDeleted { get; set; }
    }
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; }= null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}