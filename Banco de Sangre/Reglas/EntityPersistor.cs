using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Reglas
{
    public class EntityPersistor<T>
    {
        private string _nombreArchivo;

        public EntityPersistor()
        {
            var path = System.Windows.Forms.Application.StartupPath;
            var nombreTipo = typeof(T).FullName;
            _nombreArchivo = path + "\\" + nombreTipo + ".json";
        }

        public void Grabar(T entidad)
        {
            var lista = new List<T>();
            lista.Add(entidad);
            Grabar(lista);
        }

        public void Grabar(IEnumerable<T> lista)
        {
            var listaSerializada = JsonConvert.SerializeObject(lista);
            System.IO.File.WriteAllText(_nombreArchivo, listaSerializada);
        }


        public IEnumerable<T> Recuperar()
        {
            if (!System.IO.File.Exists(_nombreArchivo))
                return new List<T>();

            var contenido = System.IO.File.ReadAllText(_nombreArchivo);
            var lista = JsonConvert.DeserializeObject<List<T>>(contenido);
            return lista;
        }
    }
}
