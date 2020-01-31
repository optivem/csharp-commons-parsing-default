﻿using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using Optivem.Atomiv.Template.Core.Application.Orders.Commands;
using Optivem.Atomiv.Template.Core.Application.Orders.Repositories;
using Optivem.Atomiv.Template.Core.Domain.Orders;

namespace Optivem.Atomiv.Template.Infrastructure.Validation.Orders.Commands
{
    public class ArchiveOrderCommandValidator : BaseValidator<ArchiveOrderCommand>
    {
        public ArchiveOrderCommandValidator(IOrderReadonlyRepository orderReadonlyRepository)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .MustAsync((command, context, cancellation)
                    => orderReadonlyRepository.ExistsAsync(command.Id))
                .WithErrorCode(ValidationErrorCodes.NotFound);
        }
    }
}
