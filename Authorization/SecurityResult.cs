namespace Authorization
{
    public interface ISecurityResult : IResult
    {
        string EntityKey { get; set; }
    }

    public class SecurityResult : Result, ISecurityResult
    {
        public string EntityKey { get; set; }
    }
}