using BasBE100;
using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
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
            base.DepoisDeGravar(Familia, e);

            try
            {
                var nome2 = BSO.Contexto.UtilizadorActual;
                var pas2 = BSO.Contexto.PasswordUtilizadorActual;

                // Abrir empresa BRIOSA para replicar a fam�lia
                BSO.AbreEmpresaTrabalho(StdBE100.StdBETipos.EnumTipoPlataforma.tpEvolution, "BRIOSA", nome2, pas2);

                var ExisteFamilia = BSO.Base.Familias.Existe(Familia);
                if (ExisteFamilia)
                {
                    UpdateFamilia(this.Familia);
                }
                else
                {
                    CriarFamilia(this.Familia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao replicar fam�lia: " + ex.Message);
            }
            finally
            {
                // Voltar para a empresa original (CASAPEDOME)
                var nome = BSO.Contexto.UtilizadorActual;
                var pas = BSO.Contexto.PasswordUtilizadorActual;
                BSO.FechaEmpresaTrabalho();
                BSO.AbreEmpresaTrabalho(StdBE100.StdBETipos.EnumTipoPlataforma.tpEvolution, "CASAPEDOME", nome, pas);
            }
        }

        private void UpdateFamilia(BasBEFamilia familiaOriginal)
        {
            try
            {
                // Atualizar fam�lia existente
                BSO.Base.Familias.Actualiza(familiaOriginal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar fam�lia: " + ex.Message);
            }
        }

        private void CriarFamilia(BasBEFamilia familiaOriginal)
        {
            try
            {
                // Criar nova fam�lia
                BSO.Base.Familias.Actualiza(familiaOriginal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar fam�lia: " + ex.Message);
            }
        }
    }
}
