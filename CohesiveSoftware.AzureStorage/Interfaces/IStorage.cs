using Microsoft.WindowsAzure.Storage;
using System.Collections.Generic;

namespace CohesiveSoftware.AzureStorage.Interfaces
{
    public interface IStorage
    {
        CloudStorageAccount Account { get; }
        Dictionary<string, ITable> Tables { get; }
        ITable GetTable(string tableName);
    }
}
