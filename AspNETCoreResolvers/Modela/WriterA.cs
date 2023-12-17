using AspNETCoreResolvers.Interfaces;

namespace AspNETCoreResolvers.Modela
{
    public class WriterA : IWriter<string, string>
    {
        public string Write(string param)
        {
           return $"WriterA: {param}";
        }
    }

}
