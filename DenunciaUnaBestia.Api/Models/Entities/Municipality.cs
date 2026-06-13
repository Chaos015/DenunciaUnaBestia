using System;

namespace DenunciaUnaBestia.Api.Models.Entities
{
    public class Municipality
    { 
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? PostalCode { get; set; }
        public bool IsActive { get; set; } = true;
        
    // Propiedad de navegación: un municipio tiene muchos sectores
        public List<Sector> Sectors { get; set; } = new List<Sector>();

    }
}

