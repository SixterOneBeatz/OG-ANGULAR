using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OG_ANGULAR_ENTITIES
{
    public class EPersona
    {
        public EPersona()
        {

        }
        public EPersona(DataRow r)
        {
            Id = r["Id"] == DBNull.Value ? 0 : Convert.ToInt32(r["Id"]);
            Nombre = r["Nombre"] == DBNull.Value ? null : Convert.ToString(r["Nombre"]);
            AP = r["APaterno"] == DBNull.Value ? null : Convert.ToString(r["APaterno"]);
            AM = r["AMaterno"] == DBNull.Value ? null : Convert.ToString(r["AMaterno"]);
            Edad = r["Edad"] == DBNull.Value ? 0 : Convert.ToInt32(r["Edad"]);
            Estatura = r["Estatura"] == DBNull.Value ? 0 : Convert.ToDecimal(r["Estatura"]);
            Peso = r["Peso"] == DBNull.Value ? 0 : Convert.ToDecimal(r["Peso"]);
            FechaN = r["FechaN"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(r["FechaN"]);
            Activo = r["Activo"] == DBNull.Value ? false : Convert.ToBoolean(r["Activo"]);
        }
        public Nullable<int> Id { get; set; }
        public string Nombre { get; set; }
        public string AP { get; set; }
        public string AM { get; set; }
        public Nullable<int> Edad { get; set; }
        public Nullable<decimal> Estatura { get; set; }
        public Nullable<decimal> Peso { get; set; }
        public Nullable<DateTime> FechaN { get; set; }
        public bool Activo { get; set; }
    }
}
