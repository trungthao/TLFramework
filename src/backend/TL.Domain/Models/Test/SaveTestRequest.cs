namespace TL.Domain.Models
{
    public class SaveTestRequest : SaveBaseEntityRequest
    {
        public int TestId { get; set; }

        public string TestName { get; set; }
    }
}