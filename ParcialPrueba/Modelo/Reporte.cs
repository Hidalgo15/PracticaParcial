using System.ComponentModel.DataAnnotations;

class Reporte{
   
    public string Id {get; set;} =string.Empty;
    public string matricula { get; set; }
    public string nombre { get; set; }    
    public string apellido { get; set; }
    public string curso { get; set; }
    public string motivo { get; set; }
}