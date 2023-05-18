namespace SK2EVERYONE.Model
{
    public class CommunicationSettings
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string DefWSDL { get; set; }
        public string DefURL { get; set; }
        public string DefSvc { get; set; }
        public string DefPrt { get; set; }
        public int TimeToAnswer { get; set; }
        public int CycleTime { get; set; }
        public int MaxRow { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string B2BAddress { get; set; }
    }
}
