using System;

namespace UniversityofSarre_Assignment2
{
    public class Person
    {
        protected string mFirstName;
        protected string mLastName;
        protected string mEmail;

        public Person(string firstName, string lastName)
        {
            mFirstName = firstName;
            mLastName = lastName;
        }

        public string GetName()
        {
            return mFirstName;
        }
        public virtual string GetEmail()
        {
            return mEmail;
        }
    }

    public class Student : Person
    {
        string mStudentID;
        string mPersonalTutor;
        string mAddedBy;


        public Student(string firstName, string lastName, string personalTutor, string currentUser) : base(firstName, lastName)
        {
            
            int uniqieID = 100000;
            mStudentID = lastName.Substring(0,3) + DateTime.Now.Year.ToString().Substring(2,2) + (uniqieID + 1).ToString();
            mPersonalTutor = personalTutor;
            mAddedBy = currentUser;
        }

        public string GetID()
        {
            return mStudentID;
        }

        public string GetAdded()
        {
            return mAddedBy;
        }

        public string GetTutor()
        {
            return mPersonalTutor;
        }
        public override string GetEmail()
        {
            mEmail = mStudentID + "@sarre.ac.uk";
            return mEmail;
        }

    }
    public class Lecturer : Person
    {
        string mDept;
        string mPassword;

        public Lecturer(string firstName, string lastName, string dept, string pass) : base(firstName, lastName)
        {
            mDept = dept;
            mPassword = pass;

        }

        public string GetPass()
        {
            return mPassword;
        }

        public override string GetEmail()
        {
            mEmail = base.mFirstName + "." + base.mLastName + "@sarre.ac.uk";
            return mEmail;
        }
    }

    public class Admin : Person
    {
        string mDept;

        public Admin(string firstName, string lastName, string dept) : base(firstName, lastName)
        {
            mDept = dept;
        }

        public override string GetEmail()
        {
            int uniqieID = 100000;
            mEmail = base.mFirstName.Substring(0, 1) + base.mLastName.Substring(0, 1) + (uniqieID + 1).ToString() + "@sarre.ac.uk";
            return mEmail;
        }
    }
}
