using GloboTicket.TicketManagement.Application.Features.Categories.Dtos;

namespace GloboTicket.TicketManagement.Application.Features.Categories.ViewModels
{
    public class CategoryEventListVm
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<CategoryEventDto>? Events { get; set; }
    }
}
