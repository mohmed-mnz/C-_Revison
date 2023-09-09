//namespace Rev
//{
//    //class employee
//    //{
//    //    public int Id { get; set; }
//    //    public string Name { get; set; }
//    //    public string Department { get; set; }
//    //    public decimal Salary { get; set; }


//    //    public override string ToString()
//    //    {
//    //        return $"ID : {Id} , Name : {Name} , Salary : {Salary} , Department : {Department} ";
//    //    }
//    //    public override bool Equals(object? obj)
//    //    {
//    //        if (obj == null || !(obj is employee)) return false;

//    //        var employee = obj as employee;
//    //        return this.Id==employee.Id 
//    //            && Name==employee.Name
//    //            &&Salary==employee.Salary
//    //            &&Department==employee.Department;
//    //    }
//    //    public static bool operator ==(employee left, employee right)=>left.Equals(right);

//    //    public static bool operator !=(employee left, employee right) => !(left.Equals(right));

//    //    public override int GetHashCode()
//    //    {
//    //        int hashCode = 13;
//    //        hashCode = (hashCode * 7) + Id.GetHashCode();
//    //        hashCode = (hashCode * 7) + Name.GetHashCode();
//    //        hashCode = (hashCode * 7) + Salary.GetHashCode(); 
//    //        hashCode = (hashCode * 7) + Department.GetHashCode();
//    //        return hashCode;
//    //    }
//    }
//} 