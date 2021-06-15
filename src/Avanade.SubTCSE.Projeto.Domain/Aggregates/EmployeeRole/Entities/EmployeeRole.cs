using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole  //Record define uma classe imutavel
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public string Id { get; private set; } 

        public string RoleName { get; init; } // o init garante que a propriedade seja alterada apenas no construtor e em nenhum outro método.
    }   
}
