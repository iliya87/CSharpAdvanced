using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;


public static class ExtentionClass
{
    public static List<Student> WeeksStudents(this IList<Student> marks)
    {
        var result =
            from st in marks
            where (st.Marks.Count(x => x == 2) == 2)
            select st;
        return result.ToList();
    }
    public static List<Student> ExellentStudents(this IList<Student> marks)
    {
        var exellentStudents = from st in marks
            where (st.Marks.Max() == 6)
            select st;
        return exellentStudents.ToList();
    }

}