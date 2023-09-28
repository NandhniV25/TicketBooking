using TicketApi.Models.Ground;

namespace TicketApi.Service.Ground
{
    public interface IGroundService
    {
        List<GroundModelWithVenues> GetAll();
        int CreateGround(CreateGroundModel model);

        GroundModelWithVenues GetGroundById(int id);
    }
}
