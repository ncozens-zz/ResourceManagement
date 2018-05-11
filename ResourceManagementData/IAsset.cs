using ResourceManagementData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceManagementData
{
    public interface IAsset
    {
        IEnumerable<Asset> GetAll();
        Asset GetById(int Id);
    }
}
