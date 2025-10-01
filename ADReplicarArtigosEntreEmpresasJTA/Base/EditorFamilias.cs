using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADReplicarArtigosEntreEmpresasJTA.Base
{
    public class EditorFamilias : FichaFamilias
    {
        public override void DepoisDeGravar(string Familia, ExtensibilityEventArgs e)
        {
            base.DepoisDeGravar(Familia, e);
        }
    }
}
