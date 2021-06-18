namespace Service.V2.Interfaces.Common
{
    public interface IAuthorizedIdentityService<out TIdentity>
    {
        TIdentity Identity { get; }
        int? IdentityId { get; }
    }
}