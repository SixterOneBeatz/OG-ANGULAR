using OG_ANGULAR_DATA;
using OG_ANGULAR_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OG_ANGULAR_BUSINESS
{
    public class BPersona
    {
        private DPersona _data = new DPersona();

        public List<EPersona> GetPersonas()
        {
            try
            {
                List<EPersona> personas = new List<EPersona>();
                DataTable dt = _data.GetPersonas();
                foreach (DataRow r in dt.Rows)
                {
                    personas.Add(new EPersona(r));
                }
                return personas;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public EPersona GetPersona(int Id)
        {
            try
            {
                EPersona persona;
                DataRow r = _data.GetPersona(Id);
                persona = new EPersona(r);
                return persona;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int Ingresar(EPersona persona)
        {
            try
            {
                int commandResult = 0;
                commandResult = _data.Ingresar(persona);
                return commandResult;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int Modificar(EPersona persona)
        {
            try
            {
                int commandResult = _data.Modificar(persona);
                return commandResult;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int Elminar(int id)
        {
            try
            {
                int commandResult = _data.Eliminar(id);
                return commandResult;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
