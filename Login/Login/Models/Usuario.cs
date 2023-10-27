using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Universidad.Models{
    public class Usuario{
        public int id_estudiante{get;set;}
        public string apellidos {get;set;}
        public string nombres {get;set;}

        public string pasword {get;set;}
    }
}