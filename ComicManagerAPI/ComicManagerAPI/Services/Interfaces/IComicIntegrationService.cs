using ComicManagerAPI.Models;
using ComicManagerAPI.Models.ComicVine.Issue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicManagerAPI.Services.Interfaces
{
    public interface IComicIntegrationService
    {
        Task<List<Comic>> SearchIssues(string name, int issue_number);
    }
}
