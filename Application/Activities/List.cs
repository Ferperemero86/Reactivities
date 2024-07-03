using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<Activity>> {} // Mediatr interface

        public class Handler : IRequestHandler<Query, List<Activity>> // We pass the Query class from above and Returns the List of activities
        {
            private readonly DataContext _context;
            public Handler(DataContext context) // We need to inhect the DB context
            {
                _context = context;
            }
            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Activities.ToListAsync();
            }
        }
    }
}