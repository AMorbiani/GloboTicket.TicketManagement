﻿using GloboTicket.TicketManagement.Application.Contracts.Persistance.Base;
using GloboTicket.TicketManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
    }
}
