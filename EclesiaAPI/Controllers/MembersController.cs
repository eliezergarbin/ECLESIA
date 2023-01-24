using EclesiaAPI.Model;
using EclesiaAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EclesiaAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberRepository _memberRepository;
        public MembersController(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Member>> GetMembers()
        {
            return await _memberRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Member>> GetMember(int id)
        {
            return await _memberRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Member>> CreateMember([FromBody] Member member)
        {
            var newMember = await _memberRepository.Create(member);
            return CreatedAtAction(nameof(GetMember), new { id = newMember.Id }, newMember);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateMember(int id, [FromBody] Member member) 
        {
            if (id != member.Id)
                return BadRequest();
            await _memberRepository.Update(member);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Member>> DeleteMember(int id)
        {
            var memberToDelete = await _memberRepository.Get(id);
            if (memberToDelete == null)
                return null;
            await _memberRepository.Delete(memberToDelete.Id);
            return NoContent();
        }



    }
}
