using MediatR;

namespace Notes.App.Notes.Queries.GetNoteList; 

public class GetNoteListQuery : IRequest<NoteListVm>
{
    public Guid UserId { get; set; }
}

