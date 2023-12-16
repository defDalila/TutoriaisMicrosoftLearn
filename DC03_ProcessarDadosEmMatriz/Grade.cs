namespace PG03_ProcessarDadosEmMatriz;

public static class Grade
{
    public static string Definir(decimal nota)
    {
        string grade = "";

        switch (nota)
        {
            case >= 97:
                grade = "A+";
                break;
            case >= 93:
                grade = "A";
                break;
            case >= 90:
                grade = "A-";
                break;
            case >= 87:
                grade = "B+";
                break;
            case >= 83:
                grade = "B";
                break;
            case >= 80:
                grade = "B-";
                break;
            case >= 77:
                grade = "C+";
                break;
            case >= 73:
                grade = "C";
                break;
            case >= 70:
                grade = "C-";
                break;
            case >= 67:
                grade = "D+";
                break;
            case >= 63:
                grade = "D";
                break;
            case >= 60:
                grade = "D-";
                break;
            default:
                grade = "F";
                break;
        }

        return grade;
    }
}
