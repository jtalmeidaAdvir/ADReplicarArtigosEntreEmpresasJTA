using BasBE100;
using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using Primavera.Extensibility.Integration.Modules.Platform.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ADReplicarArtigosEntreEmpresasJTA.Base
{
    public class EditorArtigos : FichaArtigos
    {
        public override void DepoisDeGravar(string Artigo, ExtensibilityEventArgs e)
        {

            BasBEArtigoMoeda ArtigoMoedaExportar;
            try
            {
                ArtigoMoedaExportar = BSO.Base.ArtigosPrecos.Edita(this.Artigo.Artigo, "EUR", this.Artigo.UnidadeBase);
            }
            catch (Exception ex)
            {
                return;
            }   


            try
            {
                BSO.AbreEmpresaTrabalho(StdBE100.StdBETipos.EnumTipoPlataforma.tpEvolution, "BRIOSA", "Cegid", "Advir2506");
                var ExiteArtigo = BSO.Base.Artigos.Existe(Artigo);
                if (ExiteArtigo)
                {
                    UpdateArtigo(ArtigoMoedaExportar);
                }
                else
                {
                    CriarArtigo(ArtigoMoedaExportar);
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar artigo: " + ex.Message);
            }


            BSO.AbreEmpresaTrabalho(StdBE100.StdBETipos.EnumTipoPlataforma.tpEvolution, "CASAPEDOME", "Cegid", "Advir2506");



        }

        private void UpdateArtigo(BasBEArtigoMoeda ArtigoMoedaExportar)
        {

            
            BSO.Base.Artigos.Actualiza(this.Artigo);
            BSO.Base.ArtigosPrecos.Actualiza(ArtigoMoedaExportar);
        }

        private void CriarArtigo(BasBEArtigoMoeda ArtigoMoedaExportar)
        {

            BasBEArtigoMoeda ArtigoMoeda = new BasBEArtigoMoeda();
            ArtigoMoeda.Artigo = this.Artigo.Artigo;
            ArtigoMoeda.Moeda = "EUR"; // Defina a moeda como EUR
            ArtigoMoeda.Unidade = this.Artigo.UnidadeBase;
            ArtigoMoeda.PVP1 = ArtigoMoedaExportar.PVP1;
            ArtigoMoeda.PVP2 = ArtigoMoedaExportar.PVP2;
            ArtigoMoeda.PVP3 = ArtigoMoedaExportar.PVP3;
            ArtigoMoeda.PVP4 = ArtigoMoedaExportar.PVP4;
            ArtigoMoeda.PVP5 = ArtigoMoedaExportar.PVP5;
            ArtigoMoeda.PVP6 = ArtigoMoedaExportar.PVP6;
            BSO.Base.Artigos.Actualiza(this.Artigo);

            BSO.Base.ArtigosPrecos.Actualiza(ArtigoMoeda);
        }
    }
}
