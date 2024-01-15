using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our.Umbraco.StorageProviders.GCPCloudStorage.Services
{
    public interface IMimeTypeResolver
    {
        string Resolve(string filename);
    }
}
