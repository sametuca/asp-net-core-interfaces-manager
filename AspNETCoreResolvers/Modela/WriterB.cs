using AspNETCoreResolvers.Interfaces;

namespace AspNETCoreResolvers.Modela
{
    public class WriterB : IWriter<string, string>
    {
        public string Write(string param)
        {
            return $"WriterB: {param}";
        }
    }
}
