using System;
using System.ComponentModel.Composition;
using GitHub.Models;

namespace GitHub.Services
{
    [Export(typeof(IPullRequestService))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class PullRequestService : IPullRequestService
    {
        public IObservable<IPullRequestModel> CreatePullRequest(IRepositoryHost host, ISimpleRepositoryModel repository, string title, string body, IBranch source, IBranch target)
        {
            return host.ModelService.CreatePullRequest(repository, title, body, source, target);
        }
    }
}