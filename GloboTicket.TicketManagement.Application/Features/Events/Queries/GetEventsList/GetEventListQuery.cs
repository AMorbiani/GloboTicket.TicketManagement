using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistance.Base;
using GloboTicket.TicketManagement.Application.Features.Events.ViewModels;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Events.Querys.GetEventsList
{
    public class GetEventListQuery : IRequest<List<EventListVm>>
    {
    }

    public class GetEventListQueryHandler : IRequestHandler<GetEventListQuery, List<EventListVm>>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetEventListQueryHandler(IAsyncRepository<Event> eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<List<EventListVm>> Handle(GetEventListQuery request, CancellationToken cancellationToken)
        {
            var eventList = (await _eventRepository.ListAllAsync()).OrderBy(e => e.Date);
            return _mapper.Map<List<EventListVm>>(eventList);
        }
    }
}
