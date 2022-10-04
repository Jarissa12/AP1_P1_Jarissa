using System.ComponentModel.DataAnnotations;
using AP1_P1_Jarissa;


namespace  AP1_P1_Jarissa .Model
{
     public class Aporte 
     {

          [Key]
          public int AporteId { get; set; }
          public String? Persona{ get; set;}

          public String? Observacion {get; set;}
          public  double Monto {get; set;} 
          public  DateTime Fecha{ get; set; }= DateTime.Now;



         // [Required(ErrorMessage = "La direccion es requerida")]
        //  [Range(1,int.MaxValue,ErrorMessage ="El selecionar una ocupacion")]
         
     }
           
}
