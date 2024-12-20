namespace EmployeeControl.Model
{
    public class EmployeeModel
    {
        public int Id { get; private set; }

        public string? Name { get; private set; }
        public DateOnly DateOfBirth { get; private set; }

        public string? Position { get; private set; }
    }
}
