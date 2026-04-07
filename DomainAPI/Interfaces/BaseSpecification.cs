using InfrastructureAPI;
using System.Linq.Expressions;

public abstract class BaseSpecification<T> : ISpecification<T> where T : class
{
    public List<Expression<Func<T, object>>> Include { get; } = new List<Expression<Func<T, object>>>();


    protected BaseSpecification(Expression<Func<T, bool>> criteria)
    {
        Criteria = criteria;
    }

    public Expression<Func<T,object>> GroupBy { get; private set; }
    public Expression<Func<T, bool>> Criteria { get; }
    public Expression<Func<T, object>> OrderBy { get; private set; }
    public Expression<Func<T, object>> OrderByDescending { get; private set; }
    public int Take { get; private set; }
    public int Skip { get; private set; }
    public bool IsPagingEnabled { get; private set; }


    protected void AddGroupBy(Expression<Func<T, object>> groupby) => GroupBy = groupby;

    protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
    {
        OrderBy = orderByExpression;
    }
    protected void Relaciones(Expression<Func<T,object>> Incluir)
    {
        Include.Add(Incluir);
    }
    protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescExpression)
    {
        OrderByDescending = orderByDescExpression;
    }

    protected void ApplyPaging(int skip, int take)
    {
        Skip = skip;
        Take = take;
        IsPagingEnabled = true;
    }
}
