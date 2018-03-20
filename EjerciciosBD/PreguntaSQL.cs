using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBD
{
    public class PreguntaSQL
    {
        public int Id { get; set; }
        public String Pregunta { get; set; }

        public PreguntaSQL(int id, String pregunta)
        {
            Id = id;
            Pregunta = pregunta;
        }

        public override string ToString()
        {
            return Pregunta;
        }

        public static List<PreguntaSQL> fromJSON(String fileJson)
        {
            //TODO añadir excepción por archivo incorrecto
            DataSet ds = JsonConvert.DeserializeObject<DataSet>(fileJson);
            DataTable dt = ds.Tables["questions"];
            var aux = dt.Select();
            List<PreguntaSQL> listPreguntas = new List<PreguntaSQL>();
            foreach (var item in aux)
            {
                listPreguntas.Add(new PreguntaSQL(int.Parse(item[0].ToString()), item[1].ToString()));
            }
            return listPreguntas;
        }

    }
}
