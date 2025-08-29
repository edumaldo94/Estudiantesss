using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Conexion : DataConnection
    {
        public Conexion() : base("PDHN1") { }
      //  public ITable<Estudiante> _Estudiante { get; set; }

        public ITable<Estudiante> _Estudiantes => this.GetTable<Estudiante>();

        //public ITable<Estudiante> _Estudiante { get { return GetTable<estudiante>(); } }
    }
}

