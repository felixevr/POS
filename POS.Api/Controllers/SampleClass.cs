namespace AssemblyExample
{
    public class SampleClass
    {
        public void Main()
        {
            var type = typeof(SampleClass);
            var assemblyName = type.Assembly.FullName;

            Console.WriteLine("Assembly Full Name: " + assemblyName);
        }
    }
}
