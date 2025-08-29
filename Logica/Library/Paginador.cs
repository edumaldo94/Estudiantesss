using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class Paginador<T>
    {
        private List<T> _dataList;
        private Label _laber;
        private static int maxReg, _reg_por_pagina, pageCount, numPagi = 1;

        public Paginador(List<T> dataList, Label label, int reg_por_pagina)
        {
            _dataList = dataList;
            _laber = label;
            _reg_por_pagina = reg_por_pagina;
            cargarDatos();
        }
        private void cargarDatos()
        {
            numPagi = 1;
            maxReg = _dataList.Count;
            pageCount = (maxReg / _reg_por_pagina);

            if((maxReg % _reg_por_pagina) > 0)
                pageCount++;
            _laber.Text = $"Paginas 1/ +{pageCount}";

        }
        public int primero()
        {
            numPagi = 1;
            _laber.Text = $"Paginas 1/ + {numPagi}/{pageCount}";
            return numPagi;
        }
        public int anterior()
        {
            if (numPagi > 1)
                numPagi--;
            _laber.Text = $"Paginas 1/ + {numPagi}/{pageCount}";
            return numPagi;
        }
        public int siguiente()
        {
            if (numPagi < pageCount)
                numPagi++;
            _laber.Text = $"Paginas 1/ + {numPagi}/{pageCount}";
            return numPagi;
        }
        public int ultimo()
        {
            numPagi = pageCount;
            _laber.Text = $"Paginas 1/ + {numPagi}/{pageCount}";
            return numPagi;
        }
    }
}
