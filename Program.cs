namespace ConsoleApp49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var alex = new Patient("Alex", 45, "Heart attack");
            var dima = new Patient("Dima", 59, "Stroke");
            var misha = new Patient("Misha", 27, "Healthy");
            var hospital = new Hospital();
            hospital.AddPatient(alex);
            hospital.AddPatient(dima);
            hospital.AddPatient(misha);
            Console.WriteLine(hospital.ToString());
            hospital.ChangeDiagnosis(alex, "Healthy");
            Console.WriteLine(hospital.ToString());
            hospital.RemovePatient(dima);
            Console.WriteLine(hospital.ToString());
        }                                         
    }
}