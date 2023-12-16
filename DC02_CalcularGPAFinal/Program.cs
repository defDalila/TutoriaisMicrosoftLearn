Console.Clear();

// Dados Fornecidos
string nomeAluno = "Sophia Johnson";
string nomeCurso1 = "English 101";
string nomeCurso2 = "Algebra 101";
string nomeCurso3 = "Biology 101";
string nomeCurso4 = "Computer Science I";
string nomeCurso5 = "Psychology 101";

int creditosCurso1 = 3;
int creditosCurso2 = 3;
int creditosCurso3 = 4;
int creditosCurso4 = 4;
int creditosCurso5 = 3;

// Parte 1 - Armazenar os valores de nota numérica de cada curso

int gradeA = 4;
int gradeB = 3;

string gradeCurso1 = "A";
string gradeCurso2 = "B";
string gradeCurso3 = "B";
string gradeCurso4 = "B";
string gradeCurso5 = "A";


int notaCurso1 = gradeA;
int notaCurso2 = gradeB;
int notaCurso3 = gradeB;
int notaCurso4 = gradeB;
int notaCurso5 = gradeA;

// Parte 2 - Calcular as somas de horas de crédito e pontos de nota

int totalCreditos = creditosCurso1 + creditosCurso2 + creditosCurso3 + creditosCurso4 + creditosCurso5;

// totalCreditHours += course1Credit;
// totalCreditHours += course2Credit;
// totalCreditHours += course3Credit;
// totalCreditHours += course4Credit;
// totalCreditHours += course5Credit;

int totaldePontosPorCreditos = creditosCurso1 * notaCurso1 + creditosCurso2 * notaCurso2 + 
		creditosCurso3 * notaCurso3 + creditosCurso4 * notaCurso4 + creditosCurso5 * notaCurso5;

/* Outra forma
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;
*/

decimal gradePointAverage = totaldePontosPorCreditos / (decimal) totalCreditos;



// Final - Formatação da Saída do Resultado

Console.WriteLine("                   CALCULO DO GPA FINAL                  ");
Console.WriteLine("---------------------------------------------------------");

Console.WriteLine($"\nAluna: {nomeAluno}\n");
Console.WriteLine($"Curso\t\t\tGrade\tNota\tHoras de Créditos");
Console.WriteLine($"{nomeCurso1}\t\t {gradeCurso1}\t {notaCurso1}\t\t{creditosCurso1}");
Console.WriteLine($"{nomeCurso2}\t\t {gradeCurso2}\t {notaCurso2}\t\t{creditosCurso2}");
Console.WriteLine($"{nomeCurso3}\t\t {gradeCurso3}\t {notaCurso3}\t\t{creditosCurso3}");
Console.WriteLine($"{nomeCurso4}\t {gradeCurso4}\t {notaCurso4}\t\t{creditosCurso4}");
Console.WriteLine($"{nomeCurso5}\t\t {gradeCurso5}\t {notaCurso5}\t\t{creditosCurso5}");
Console.WriteLine($"\nGPA Final:\t\t\t{gradePointAverage:F2}");
Console.WriteLine("---------------------------------------------------------");

/* Outra Forma de Formatar a Saida Decimal
int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10) % 10;

Suponha que gradePointAverage = 2.994573; em seguida, executar a operação nesses valores resultaria nas seguintes etapas:

int firstDigit = (int) (2.994573 * 10) % 10;
int firstDigit = 29 % 10;
int firstDigit = 9;

*/

Console.WriteLine("\n\nPressione qualquer tecla...");
Console.ReadKey();
Console.Clear();
