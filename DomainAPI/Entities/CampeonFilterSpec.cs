using DomainAPI.Entities;

public class CampeonFilterSpec : BaseSpecification<Campeones>
{
    public CampeonFilterSpec(string? nombre, string? region, int? dificultad, Rol? rol, string? ordenarPor, int skip, int tamañoPagina)
     : base(x =>
         (string.IsNullOrEmpty(nombre) || x.Nombre.Contains(nombre)) &&
         (string.IsNullOrEmpty(region) || x.Region == region) &&
         (!dificultad.HasValue || x.Dificultad == dificultad) &&
         (!rol.HasValue || x.RolPrincipal == rol)
     )
    {
        if (ordenarPor == "vida") AddOrderBy(x => x.VidaBase);
        else AddOrderBy(x => x.Nombre);
        if (ordenarPor == "Region".ToLower()) AddOrderBy(c => c.Region);
        ApplyPaging(skip, tamañoPagina);
    }
}