using MediatR;

namespace Notes.App.Notes.Commands.DeleteCommand; 

public class DeleteNoteCommand: IRequest {
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
}