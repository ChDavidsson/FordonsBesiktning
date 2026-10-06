namespace FordonsBesiktning;

public class Fordon
{
    public int Year;
    public bool HasInsurance;
     
    public string CheckInspection()
    {
        int age = 2026 - Year;
        bool isOld = age > 5;

        if (isOld && !HasInsurance)
        {
            return "Ej godkänt";
        }
        else if (!isOld && HasInsurance)
        {
            return "Godkänt";
        }
        else
        {
            return "Måste kompletteras";
        }
    }
}
