using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvAssociacao
{
    public interface ILocalizacao
    {
        string Mapabase64(float latitude , float longitude);
    }
}
