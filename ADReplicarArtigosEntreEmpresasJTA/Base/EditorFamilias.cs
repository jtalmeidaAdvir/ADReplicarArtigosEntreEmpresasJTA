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
            try
            {
                var basedados = "BRIOSA";
                var familia = this.Familia.Familia;
                var descricao = this.Familia.Descricao;

                var queryVerificaFamilia = $"SELECT COUNT(*) as num FROM [PRI{basedados}].[dbo].[Familias] WHERE Familia = '{familia}'";
                var rsVerificaFamilia = BSO.Consulta(queryVerificaFamilia).DaValor<int>("num");

                if (rsVerificaFamilia == 0)
                {
                    var queryInsereFamilia = $"INSERT INTO [PRI{basedados}].[dbo].[Familias] (Familia, Descricao) VALUES ('{familia}', '{descricao}')";
                    BSO.DSO.ExecuteSQL(queryInsereFamilia);
                }
                else
                {
                    var queryAtualizaFamilia = $"UPDATE [PRI{basedados}].[dbo].[Familias] SET Descricao = '{descricao}' WHERE Familia = '{familia}'";
                    BSO.DSO.ExecuteSQL(queryAtualizaFamilia);

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao replicar família para a empresa BRIOSA: " + ex.Message, "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

        }
    }
}
