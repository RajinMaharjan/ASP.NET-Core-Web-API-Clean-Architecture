namespace CleanArchitecute.Infrastructure.Common
{
    public interface IUnitOfWork
    {
        //This is used while using unit of work design pattern
        //Here all the services such as database, repositories are simplified to one.
        //i.e. unit of work can be used to call database operations
    }
}
