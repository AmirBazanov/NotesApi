using MediatR;

namespace Notes.App.Notes.Queries.GetNoteDetails; 

public class GetNoteDetailsQuery: IRequest<NoteDetailsVm> {
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
}
