using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Abogados
{
    /// <summary>
    /// This class is going to be use for loading all Facturas Status
    /// on each consult
    /// by this way every data will be hide and won't be shown on the data grids.
    /// </summary>
    public class facturacionBaseObj
    {
        // obejct properties //
        public string ID { get; set; }
        public string Cliente_ID { get; set; }
        public string Service_ID { get; set; }
        public string Case_ID { get; set; }
        public string TotalPago_Mensualidad { get; set; }
        public string Abono_Deposito { get; set; }
        public string fechaUltimoPago { get; set; }
        //end object properties //

        public facturacionBaseObj() { }
        public facturacionBaseObj(string pID, string pCID, string CaID, string tp, string ad, string sID, string fePa)
        {
            ID = pID;
            Cliente_ID = pCID;
            Service_ID = sID;
            Case_ID = CaID;
            TotalPago_Mensualidad = tp;
            Abono_Deposito = ad;
            fechaUltimoPago = fePa;
        }
    }
}
