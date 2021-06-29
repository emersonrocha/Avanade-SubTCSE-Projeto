namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole : BaseEntity<string> //Record define uma classe imutavel
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public EmployeeRole(string roleName)
        {
            RoleName = roleName;
        }        

        public string RoleName { get; init; } // o init garante que a propriedade seja alterada apenas no construtor e em nenhum outro método.
    }
}
