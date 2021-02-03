﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Interfaces.SOLID.OCP.Solucao
{
    public interface IJuridica
    {
        string CNPJ { get; set; }
        string InscricaoEstadual { get; set; }
    }
}