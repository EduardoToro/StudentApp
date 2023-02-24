using LinqToDB;
using LinqToDB.Data;
namespace Data
{
    public class Conexion : DataConnection
    {
        public Conexion() : base("APPESTUDIANTES1") { }
        
        public ITable<Estudiante> _Estudiante
        {
            get { return GetTable<Estudiante>(); }
        }
    }
}