using EclesiaAPI.Data;
using EclesiaAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;

namespace EclesiaAPI.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public readonly DataContext _context;

        public MemberRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Member> Create(Member member)
        {
            _context.Members.Add(member);
            await _context.SaveChangesAsync();

            return member;
        }

        public async Task Delete(int id)
        {
            var MemberToDelete = await _context.Members.FindAsync(id);
            _context.Members.Remove(MemberToDelete);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Member>> Get()
        {
            return await _context.Members.ToListAsync();
        }

        public async Task<Member> Get(int id)
        {
            return await _context.Members.FindAsync(id);
        }

        public async Task Update(Member member)
        {
            _context.Entry(member).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
