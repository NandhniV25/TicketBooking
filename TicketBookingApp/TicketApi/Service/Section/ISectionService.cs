using TicketApi.Models.Section;

namespace TicketApi.Service.Section
{
    public interface ISectionService
    {
        List<SectionModel> GetAll();
        int CreateSection(CreateSectionModel model);
    }
}
