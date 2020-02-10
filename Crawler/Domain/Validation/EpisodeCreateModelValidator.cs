using System;
using FluentValidation;
using Content.Domain.Models;

namespace Content.Domain.Validation
{
    public partial class EpisodeCreateModelValidator
        : AbstractValidator<EpisodeCreateModel>
    {
        public EpisodeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.UrlHash).NotEmpty();
            RuleFor(p => p.EpisodeName).NotEmpty();
            RuleFor(p => p.EpisodeThumbnail).NotEmpty();
            RuleFor(p => p.EpisodeDate).NotEmpty();
            RuleFor(p => p.EpisodeLink).NotEmpty();
            RuleFor(p => p.EpisodeLinkHash).NotEmpty();
            RuleFor(p => p.ContentHash).NotEmpty();
            #endregion
        }

    }
}
