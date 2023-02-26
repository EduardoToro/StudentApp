using LinqToDB;
using LinqToDB.Data;
namespace Data
{
    public class Conexion : DataConnection
    {
        public Conexion() : base("APPESTUDIANTES2") { }

        public ITable<Estudiante> _Estudiante => this.GetTable<Estudiante>();
    }
}