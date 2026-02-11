using Microsoft.Data.SqlClient;

namespace Student
{
    internal class StudentRepository
    {
        public readonly string ConnectionString = "Server=localhost;Database=DBO;Trusted_Connection=True;TrustServerCertificate=True";
        public bool Create(StudentModel student)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Student (name, fatherName, contact, ecat_marks, fsc_marks, matric_marks)" +
                               " VALUES (@name, @fatherName, @contact, @ecat_marks, @fsc_marks, @matric_marks)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", student.name);
                cmd.Parameters.AddWithValue("@fatherName", student.fatherName);
                cmd.Parameters.AddWithValue("@contact", student.contact);
                cmd.Parameters.AddWithValue("@ecat_marks", student.ecat_marks);
                cmd.Parameters.AddWithValue("@fsc_marks", student.fsc_marks);
                cmd.Parameters.AddWithValue("@matric_marks", student.matric_marks);

                
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public bool Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "DELETE FROM Student WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public bool Update(StudentModel student)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "UPDATE Student SET name=@name, fatherName=@fatherName, contact=@contact, " +
                    "ecat_marks=@ecat_marks, fsc_marks=@fsc_marks, matric_marks=@matric_marks WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", student.id);
                cmd.Parameters.AddWithValue("@name", student.name);
                cmd.Parameters.AddWithValue("@fatherName", student.fatherName);
                cmd.Parameters.AddWithValue("@contact", student.contact);
                cmd.Parameters.AddWithValue("@ecat_marks", student.ecat_marks);
                cmd.Parameters.AddWithValue("@fsc_marks", student.fsc_marks);
                cmd.Parameters.AddWithValue("@matric_marks", student.matric_marks);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public List<StudentModel> GetAllStudebts()
        {
            List<StudentModel> students = new List<StudentModel>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                conn.Open();
                string query = "SELECT * FROM Students";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string name = reader["name"].ToString();
                    string fatherName = reader["fatherName"].ToString();
                    string contact = reader["contact"].ToString();
                    int ecat_marks = Convert.ToInt32(reader["ecat_marks"]);
                    int fsc_marks = Convert.ToInt32(reader["fsc_marks"]);
                    int matric_marks = Convert.ToInt32(reader["matric_marks"]);
                    students.Add(new StudentModel(id, name, fatherName, contact, ecat_marks, fsc_marks, matric_marks));
                }
            }
            return students;
        }

        

    }
}