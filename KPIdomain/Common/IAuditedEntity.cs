namespace KPIdomain.Common
{
    public interface IAuditedEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
