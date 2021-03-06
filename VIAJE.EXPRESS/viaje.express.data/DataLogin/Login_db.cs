using Nimbussoft.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Text;
using viaje.express.model.ModelLogin;

namespace viaje.express.data.DataLogin
{
    public class Login_db
    {
        internal BaseDeDatos db = BaseDeDatos.GetConection();

        public BaseResultadoLogin login(string correo, string clave, string token)
        {
            Consulta consulta = new Consulta("[proc_login] @correo, @clave, @token");
            consulta.AgregarParametro(db.CrearParametro("@correo", correo));
            consulta.AgregarParametro(db.CrearParametro("@clave", clave));
            consulta.AgregarParametro(db.CrearParametro("@token", token));

            return db.EjecutarFilaUnica<BaseResultadoLogin>(consulta);
        }

        public ResultadoLoginCliente loginCliente(string correo, string clave, string token)
        {
            Consulta consulta = new Consulta("[proc_login_cliente] @correo, @clave, @token");
            consulta.AgregarParametro(db.CrearParametro("@correo", correo));
            consulta.AgregarParametro(db.CrearParametro("@clave", clave));
            consulta.AgregarParametro(db.CrearParametro("@token", token));

            return db.EjecutarFilaUnica<ResultadoLoginCliente>(consulta);
        }

    }
}
