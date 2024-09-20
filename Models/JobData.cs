using System.Reflection;

namespace USANotary.Models
{
    public class JobData
    {
        public int Id { get; set; }
        public string TitleCompany { get; set; } = null!;
        public string ClosingType { get; set; } = null!;
        public string InternalReference { get; set; } = null!;
        public bool KBARequired { get; set; }
        public string PropertyAddress1 { get; set; } = null!;
        public string PropertyAddress2 { get; set; } = null!;
        public string PropertyCity { get; set; } = null!;
        public string PropertyState { get; set; } = null!;
        public string PropertyZipCode { get; set; } = null!;
    }
}
