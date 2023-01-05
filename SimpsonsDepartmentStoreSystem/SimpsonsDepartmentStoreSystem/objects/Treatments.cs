using System;

namespace SimpsonsDepartmentStoreSystem.objects
{
    public class Treatments
    {
        int treatmentID;
        string treatmentName;
        int treatmentDuration;
        int treatmentCost;

        public Treatments()
        { 
            TreatmentID = 0;
            TreatmentName = "";
            TreatmentDuration = 0;
            TreatmentCost = 0;
        }

        public Treatments(int treatmentID, string treatmentName, int treatmentDuration, int treatmentCost)
        {
            TreatmentID = treatmentID;
            TreatmentName = treatmentName;
            TreatmentDuration = treatmentDuration;
            TreatmentCost = treatmentCost;
        }

        public int TreatmentID
        {
            get { return treatmentID; }
            set { treatmentID = value; }
        }

        public string TreatmentName
        {
            get { return treatmentName; }
            set { treatmentName = value; }
        }

        public int TreatmentDuration
        {
            get { return treatmentDuration; }
            set { treatmentDuration = value; }
        }

        public int TreatmentCost
        {
            get { return treatmentCost; }
            set { treatmentCost = value; }
        }
    }
}