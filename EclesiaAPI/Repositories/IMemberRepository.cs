using EclesiaAPI.Model;

namespace EclesiaAPI.Repositories
{
    public interface IMemberRepository
    {
        Task<IEnumerable<Member>> Get();
        Task<Member> Get(int id);
        Task<Member> Create(Member member);
        Task Update(Member member);
        Task Delete(int id);
    }
}
