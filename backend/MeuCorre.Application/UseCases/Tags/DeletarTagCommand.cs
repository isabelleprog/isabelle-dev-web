using MediatR;
using MeuCorre.Application.UseCases.Tags.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Application.UseCases.Tags
{
    public class DeletarTagCommand
    {
        required(ErrorMessage = "ID do usuário é obrigatório")]
        public required Guid UsuarioId { get; set; }

        [Required(ErrorMessage = "Id é obrigatório")]

    }
    internal class DeletarTagCommandHandler : IRequestHandler<DeletarTagCommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(DeletarTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
