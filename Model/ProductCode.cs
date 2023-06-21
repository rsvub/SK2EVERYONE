namespace SK2EVERYONE.Model
{
    public class ProductCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int CodeTypeId { get; set; }
        public string CodeTypeName { get; set; }
        public int CodeGroupId { get; set; }
        public string CodeGroupName { get; set; }
        public int IsInternal { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
    }
}
