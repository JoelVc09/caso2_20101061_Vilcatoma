using System;
using System.Collections.Generic;

namespace caso2_20101061_Vilcatoma.Infraestructure.Data
{
    public partial class Patient
    {
        public int CategoriaId { get; set; }
        public string? FullName { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Phone { get; set; }
    }
}
