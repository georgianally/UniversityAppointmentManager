using System;

namespace UniversityofSarre_Assignment2
{
    public class Appointment
    {
        private DateTime mDate;
        private DateTime mTime;
        private string mWithLec;
        private bool mAttended;
        private string mName;
        protected string mType;

        public Appointment(DateTime date, DateTime time, string lecturer, bool attend, string name, string ty)
        {
            mDate = date;
            mTime = time;
            mWithLec = lecturer;
            mAttended = attend;
            mName = name;
            mType = ty;
        }

        public DateTime GetDate()
        {
            return mDate;
        }

        public DateTime GetTime()
        {
            return mTime;
        }

        public string GetWith()
        {
            return mWithLec;
        }

        public bool GetAttend()
        {
            return mAttended;
        }

        public string GetName()
        {
            return mName;
        }
        public virtual string GetTy()
        {
            return mType;
        }
    }

    public class Personal : Appointment
    {
        private string mNotes;
        private bool mConfidential;

        public Personal(DateTime date, DateTime time, string lecturer, bool attend, string name, string type, string note, bool confi) : base(date, time, lecturer, attend, name, type)
        {
            mNotes = note;
            mConfidential = confi;
        }
        public override string GetTy()
        {
            return mType + "\t";
        }
    }

    public class Attendance : Appointment
    {
        private string mRating;
        protected string mMadeBy;
        public Attendance(DateTime date, DateTime time, string lecturer, bool attend, string name, string type, string current, string rating) : base(date, time, lecturer, attend, name, type)
        {
            mRating = rating;
            mMadeBy = current;
        }
        public string GetMadeBy()
        {
            return mMadeBy;
        }
    }

    public class Academic : Appointment
    {
        private string mNotes;

        public Academic(DateTime date, DateTime time, string lecturer, bool attend, string name, string type, string note) : base(date, time, lecturer, attend, name, type)
        {
            mNotes = note;
        }
        public override string GetTy()
        {
            return mType + "\t";
        }
    }
}
