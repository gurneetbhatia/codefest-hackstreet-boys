namespace Domain
{
    public abstract class Person
    {
        public string Id =>  $"{FirstName.ToUpper()}-{LastName.ToUpper()}-{DOB:yyyyMMdd}";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
