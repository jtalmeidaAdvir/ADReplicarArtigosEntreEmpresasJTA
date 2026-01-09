<<<<<<< HEAD
using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
=======
using BasBE100;
using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using Primavera.Extensibility.Integration;
>>>>>>> 6e6f50751d814cf6e29156b79ed421d7d9b0c070
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using System.Windows.Forms;
>>>>>>> 6e6f50751d814cf6e29156b79ed421d7d9b0c070


namespace ADReplicarArtigosEntreEmpresasJTA.Base
{
    public class EditorFamilias : FichaFamilias
    {
        public override void DepoisDeGravar(string Familia, ExtensibilityEventArgs e)
        {
            try
            {
<<<<<<< HEAD
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

=======
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
>>>>>>> 6e6f50751d814cf6e29156b79ed421d7d9b0c070
                }
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                System.Windows.Forms.MessageBox.Show("Erro ao replicar família para a empresa BRIOSA: " + ex.Message, "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

=======
                MessageBox.Show("Erro ao replicar família para a empresa BRIOSA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
>>>>>>> 6e6f50751d814cf6e29156b79ed421d7d9b0c070
        }
    }
}
