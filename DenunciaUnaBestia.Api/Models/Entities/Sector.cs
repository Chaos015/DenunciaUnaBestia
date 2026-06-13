namespace DenunciaUnaBestia.Api.Models.Entities
{

    public class Sector
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; 
        // Clave foránea: ID del municipio al que pertenece este sector
        public int MunicipalityId { get; set; }
        // Propiedad de navegación: el municipio asociado a este sector
        public Municipality? Municipality { get; set; }

    }
}
