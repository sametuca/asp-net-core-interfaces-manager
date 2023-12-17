namespace AspNETCoreResolvers.Interfaces
{
    public interface IWriter<in TParam, out TResult>
    {
        public TResult Write(TParam param);
    }
}
