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
   public class AtualizarTagCommand
    {
        [Required(ErrorMessage = "ID do usuário é obrigatório")]
        public required Guid UsuarioId { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]

        public required string cor { get; set; }

        [Required(ErrorMessage = "cor é obrigatório")]

    }
    internal class AtualizarTagCommandHandler : IRequestHandler<AtualizarTagCommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(AtualizarTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
