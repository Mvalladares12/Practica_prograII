using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFVentas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        // TODO: agregue aquí sus operaciones de servicio

        [OperationContract]
        RespuestaUsuario InicioSesion(RespuestaUsuario datos);

        [OperationContract]
        Ventas GuardarVentas(Ventas datos);

        [OperationContract]
        Detalles VerVenta(Detalles ver);

        [OperationContract]
        GuardaUser creausuario(GuardaUser datos);

        [OperationContract]
        EditarUser editar(EditarUser datos);

        [OperationContract]
        EliminarUser eliminar(EliminarUser datos);

    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.

    [DataContract]
    public class RespuestaUsuario
    {
        [DataMember]
        public string Usuario { get; set; }

        [DataMember]
        public string Contrasena { get; set; }

        [DataMember]
        public string NombreUsuario { get; set; }
    }

    [DataContract]
    partial class Ventas
    {

        [DataMember]
        public int Producto { get; set; }

        [DataMember]
        public string Cliente { get; set; }

        [DataMember]
        public string Vendedor { get; set; }

        [DataMember]
        public int cantidad { get; set; }

        [DataMember]
        public DateTime Fecha { get; set; }

        [DataMember]
        public DateTime FechaI { get; set; }
    }

    [DataContract]
    public class Detalles
    {
        [DataMember]
        public string Producto { get; set; }

        [DataMember]
        public DateTime? Fecha { get; set; }

        [DataMember]
        public string Vendedor { get; set; }

        [DataMember]
        public int Id_venta { get; set; }
    }

    [DataContract]
    public class GuardaUser
    {
        [DataMember]
        public string Usuario { get; set;}

        [DataMember]
        public string Contraseña { get; set;}

        [DataMember]
        public string Usuario_Inserta  { get; set;}

        [DataMember]
        public DateTime Fecha_Inserta  { get; set;}

        [DataMember]
        public string Nombre_Usuario  { get; set;}
    }

    [DataContract]
    public class EditarUser
    {
        [DataMember]
        public int Id_usuario { get; set; }

        [DataMember]
        public string Usuario { get; set; }

        [DataMember]
        public string Contraseña { get; set; }

        [DataMember]
        public string Usuario_inserta { get; set; }

        [DataMember]
        public string Nombre_usuario { get; set; }

        [DataMember]
        public string Usuario_actualiza { get; set; }
    }

    [DataContract]
    public class EliminarUser
    {
        [DataMember]
        public int Id_usuario { get; set; }
    }
}
