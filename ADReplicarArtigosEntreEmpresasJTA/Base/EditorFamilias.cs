using BasBE100;
using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using Primavera.Extensibility.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ADReplicarArtigosEntreEmpresasJTA.Base
{
    public class EditorFamilias : FichaFamilias
    {
        public override void DepoisDeGravar(string Familia, ExtensibilityEventArgs e)
        {
            try
            {
                string text = "BRIOSA";
                string familia = ((FichaFamilias)this).Familia.Familia;
                string descricao = ((FichaFamilias)this).Familia.Descricao;
                string text2 = "SELECT COUNT(*) as num FROM [PRI" + text + "].[dbo].[Familias] WHERE Familia = '" + familia + "'";
                if (((ProductContext)this).BSO.Consulta(text2).DaValor<int>("num") == 0)
                {
                    string text3 = "INSERT INTO [PRI" + text + "].[dbo].[Familias] (Familia, Descricao) VALUES ('" + familia + "', '" + descricao + "')";
                    ((ProductContext)this).BSO.DSO.ExecuteSQL(text3);
                }
                else
                {
                    string text4 = "UPDATE [PRI" + text + "].[dbo].[Familias] SET Descricao = '" + descricao + "' WHERE Familia = '" + familia + "'";
                    ((ProductContext)this).BSO.DSO.ExecuteSQL(text4);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao replicar família para a empresa BRIOSA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
