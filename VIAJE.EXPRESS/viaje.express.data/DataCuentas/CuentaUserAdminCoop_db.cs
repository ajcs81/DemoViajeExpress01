﻿using System;
using System.Collections.Generic;
using System.Text;

using viaje.express.model;
using viaje.express.model.ModelCuentas;
using Nimbussoft.BaseDeDatos;

namespace viaje.express.data.DataCuentas
{
    public class CuentaUserAdminCoop_db
    {
        internal BaseDeDatos db = BaseDeDatos.GetConection();
        private CuentaUsuario_db cuenta_usuario_db = new CuentaUsuario_db();
        private int id_rol = 2; // rol Usuario Administrador Cooperativa

    }
}
