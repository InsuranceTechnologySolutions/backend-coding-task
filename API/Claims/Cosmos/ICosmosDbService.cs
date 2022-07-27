namespace Claims.Cosmos
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Claim>> GetClaimsAsync();
        Task<Claim> GetClaimAsync(string id);
        Task AddItemAsync(Claim item);
        Task DeleteItemAsync(string id);
    }
}
