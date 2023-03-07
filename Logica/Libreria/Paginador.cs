using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Logica.Libreria
{
    public class Paginador<T>
    {
        private List<T> _dataList;
        private Label _label;
        private static int maxReg, _regPorPag, pagCount, numPag = 1;

        public Paginador(List<T> dataList, Label label, int regPorPag)
        {
            _dataList = dataList;
            _label = label;
            _regPorPag = regPorPag;

            cargarDatos();
        }

        private void cargarDatos()
        {
            numPag = 1;
            maxReg = _dataList.Count;
            pagCount = (maxReg / _regPorPag);

            if ((maxReg%_regPorPag) > 0)
            {
                pagCount += 1;
            }
            _label.Text = $"Paginas 1/ {pagCount}";
        }

        public int PrimeraPag()
        {
            numPag = 1; 
            _label.Text = $"Paginas {numPag} / {pagCount}";
            
            return numPag;
        }

        public int AnteriorPag()
        {
            if (numPag > 1)
            {
                numPag -= 1;
                _label.Text = $"Paginas {numPag} / {pagCount}";
            }

            return numPag;
        }

        public int SiguientePag()
        {
            if (numPag == pagCount)
                numPag = 1;
            if (numPag < pagCount)
            {
                numPag += 1;
                _label.Text = $"Paginas {numPag} / {pagCount}";
            }
            
            return numPag;
        }
        
        public int UltimaPag()
        {
            numPag = pagCount; 
            _label.Text = $"Paginas {numPag} / {pagCount}";
            
            return numPag;
        }
    }
}