namespace Student
{
    internal class StudentModel
    {
        public int id;
        public string name;
        public string fatherName;
        public string contact;
        public int ecat_marks;
        public int fsc_marks;
        public int matric_marks;

        public StudentModel(string name, string fatherName, string contact, int ecat_marks, int fsc_marks, int matric_marks)
        {
            this.name = name;
            this.fatherName = fatherName;
            this.contact = contact;
            this.ecat_marks = ecat_marks;
            this.fsc_marks = fsc_marks;
            this.matric_marks = matric_marks;
        }

        public StudentModel(int id, string name, string fatherName, string contact, int ecat_marks, int fsc_marks, int matric_marks)
        {
            this.id = id;
            this.name = name;
            this.fatherName = fatherName;
            this.contact = contact;
            this.ecat_marks = ecat_marks;
            this.fsc_marks = fsc_marks;
            this.matric_marks = matric_marks;
        }

        public override string ToString()
        {
            return $"{id}, {name}, {fatherName}, {contact}, {ecat_marks}, {fsc_marks}, {matric_marks}";
        }

    }
}