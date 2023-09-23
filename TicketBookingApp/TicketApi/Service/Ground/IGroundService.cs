using TicketApi.Models.Ground;

namespace TicketApi.Service.Ground
{
    public interface IGroundService
    {
        List<GroundModel> GetAll();
        int CreateGround(CreateGroundModel model);
    }
}
