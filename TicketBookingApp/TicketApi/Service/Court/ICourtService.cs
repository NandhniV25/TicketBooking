using TicketApi.Models.Court;

namespace TicketApi.Service.Court
{
    public interface ICourtService
    {
        List<CourtModel> GetAll();
        int CreateCourt(CreateCourtModel model);
    }
}
