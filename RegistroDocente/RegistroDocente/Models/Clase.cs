using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDocente.Models
{
    public class Clase
    {
        #region Attributes
        private int iD;
        private string nombre;
        #endregion

        #region Constructor
        public Clase(string nomb)
        {
            this.nombre = nomb;
        }
        #endregion

        #region Properties
        public int ID { get => ID; set => ID = value; }
        public string Nombre { get => nombre; set => nombre = value; } 
        #endregion
    }
}
