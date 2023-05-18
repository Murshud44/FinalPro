using Academy__Business.Komekci;
using Academy__Business.Service.Exceptions;
using CodeAcademy.Core.Interfaces;
using CodeAcademy.Data_Acsess.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy__Business.Service;

public class GroupServicess : IGroupService
{
    private string? name;

   

    public GroupServicess()
    {
    }
     
       public GroupTypeRepository groupTypeRepository { get; }

        
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new SizeException(Helper.Errors["SizeException"]);
        }
        if (GroupRepository.GetByName(name) == null) ;
        {
            throw new exsist_exception(Helper.Errors["ExsistException"]) ;
        };
        var groupType
    }
    //public void Create(string groupName, int capacity)
    //{
    //    var name = groupName.Trim();
    //}

  

   
    
}
