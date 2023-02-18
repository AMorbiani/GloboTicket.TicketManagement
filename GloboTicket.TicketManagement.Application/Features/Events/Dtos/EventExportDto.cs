namespace GloboTicket.TicketManagement.Application.Features.Events.Dtos
{
    public class EventExportDto
    {
        public Guid EventId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
