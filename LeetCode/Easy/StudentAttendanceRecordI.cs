namespace LeetCode.Easy
{
    internal static class StudentAttendanceRecordI
    {
        public static bool CheckRecord(string s)
        {
            bool absenceCriteria = true;
            bool lateCriteria = true;
            int absenceCounter = 0;
            int lateCounter = 0;

            foreach (char c in s)
                switch (c)
                {
                    case 'A':
                        lateCounter = 0;
                        absenceCounter++;
                        if (absenceCounter >= 2)
                            absenceCriteria = false;
                        break;
                    case 'L':
                        lateCounter++;
                        if (lateCounter >= 3)
                            absenceCriteria = false;
                        break;
                    default:
                        lateCounter = 0;
                        break;
                }

            return absenceCriteria && lateCriteria;
        }
    }
}
