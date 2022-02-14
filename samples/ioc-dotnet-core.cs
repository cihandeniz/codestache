namespace IoC
{
    public class IoCConfiguration
    {
        public void Configure(IServiceCollection service)
        {
            /* #scope */
            service.Register<_Class_>(Scope._Scope_); // #class
            /* / */
        }
    }
}