using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MemeGenerator.Services
{
    public interface IMemeWebClient
    {
        Task<string> GetString(string Uri);
    }
}
