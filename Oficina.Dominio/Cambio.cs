using System.ComponentModel;

namespace Oficina.Dominio
{
    public enum Cambio
    {
        Manual = 1,

        [Description("Altomático")]
        Altomatico = 2,

        Altomatizado = 3,

        [Description("Semi Altomático")]
        SemiAltomatico = 3
    }
}