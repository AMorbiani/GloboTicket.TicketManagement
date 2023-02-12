using GloboTicket.TicketManagement.Application.Features.Orders.Dtos;

namespace GloboTicket.TicketManagement.Application.Features.Orders.ViewModels
{
    public class PagedOrdersForMonthVm
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
        public ICollection<OrdersForMonthDto>? OrdersForMonth { get; set; }
    }
}