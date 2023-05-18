using Academy__Business.Interface27;
using Academy__Business.Komekci;
using Academy__Business.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy__Business.Service;

public class GType_Service :Interface27.IGType_Service

{
    private object _gTypeRepository;
    private object _groupTypeRepository;

    public void Create(string type)
    {
        var exist = _groupTypeRepository.GetByName(type);
        if (exist != null) 
        {
            throw new exsist_exception(Helper.errors["exsist_exception"]);
        }
        string name=type.Trim();
        if (name.Length<=2)
        {
            throw new SizeException(Helper.errors["SizeException"]);
        }
        GroupType groupType = new GroupType(name);
        _gTypeRepository.Add( groupType);
    }

    public void Delete(string type)
    {
        throw new NotImplementedException();
    }

    public List<GType> GetAll()
    {
        throw new NotImplementedException();
    }

    public GType GetById(int id)
    {
        throw new NotImplementedException();
    }
}
