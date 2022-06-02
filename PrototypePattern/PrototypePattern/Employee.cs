namespace PrototypePattern.PrototypePattern
{
    public class Employee
    {
        private string Name { get; set; }
        private string Department { get; set; }
        
        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }
        
        public Employee(Employee originalEmployee)
        {
            Name = originalEmployee.Name;
            Department = originalEmployee.Department;
        }
        
        public override string ToString()
        {
            return $"Name: {Name}, Department: {Department}";
        }
    }
}