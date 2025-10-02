using BasBE100;
using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using Primavera.Extensibility.Integration.Modules.Platform.Services;
using StdBE100;
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
                // Verificar se artigo existe na empresa BRICLONE usando SQL
                string consultaSQL = $"SELECT COUNT(*) FROM PRIEMPRE.dbo.Artigos WHERE Artigo = '{Artigo}'";
                var resultado = Consulta(consultaSQL);

                bool existeArtigo = false;
                if (resultado.NumLinhas() > 0)
                {
                    existeArtigo = Convert.ToInt32(resultado.Valor("Expr1000")) > 0;
                }

                if (existeArtigo)
                {
                    UpdateArtigoSQL(ArtigoMoedaExportar);
                }
                else
                {
                    CriarArtigoSQL(ArtigoMoedaExportar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao replicar artigo: " + ex.Message);
            }
        }

        private void UpdateArtigo(BasBEArtigoMoeda ArtigoMoedaExportar)
        {
            try
            {
                // UPDATE do artigo principal
                string updateArtigoSQL = $@"
                    UPDATE Artigos SET 
                        Descricao = '{this.Artigo.Descricao.Replace("'", "''")}',
                        CodBarras = '{this.Artigo.CodBarras}',
                        UnidadeVenda = '{this.Artigo.UnidadeVenda}',
                        UnidadeBase = '{this.Artigo.UnidadeBase}',
                        Iva = {this.Artigo.Iva},
                        Desconto = {this.Artigo.Desconto},
                        Fornecedor = '{this.Artigo.Fornecedor}',
                        STKMinimo = {this.Artigo.STKMinimo},
                        STKMaximo = {this.Artigo.STKMaximo},
                        STKReposicao = {this.Artigo.STKReposicao},
                        Familia = '{this.Artigo.Familia}',
                        TipoArtigo = {this.Artigo.TipoArtigo},
                        Peso = {this.Artigo.Peso},
                        Volume = {this.Artigo.Volume},
                        Marca = '{this.Artigo.Marca}',
                        DataUltimaActualizacao = GETDATE()
                    WHERE Artigo = '{this.Artigo.Artigo}'";

                int resultArtigo = ExecuteSQL(updateArtigoSQL);

                // UPDATE dos preços
                string updatePrecosSQL = $@"
                    UPDATE ArtigosPrecos SET 
                        PVP1 = {ArtigoMoedaExportar.PVP1.ToString().Replace(",", ".")},
                        PVP2 = {ArtigoMoedaExportar.PVP2.ToString().Replace(",", ".")},
                        PVP3 = {ArtigoMoedaExportar.PVP3.ToString().Replace(",", ".")},
                        PVP4 = {ArtigoMoedaExportar.PVP4.ToString().Replace(",", ".")},
                        PVP5 = {ArtigoMoedaExportar.PVP5.ToString().Replace(",", ".")},
                        PVP6 = {ArtigoMoedaExportar.PVP6.ToString().Replace(",", ".")}
                    WHERE Artigo = '{this.Artigo.Artigo}' AND Moeda = 'EUR' AND Unidade = '{this.Artigo.UnidadeBase}'";

                int resultPrecos = ExecuteSQL(updatePrecosSQL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no UPDATE SQL: " + ex.Message);
            }
        }

        private void CriarArtigo(BasBEArtigoMoeda ArtigoMoedaExportar)
        {
            try
            {
                // INSERT do artigo principal
                string insertArtigoSQL = $@"
                    INSERT INTO Artigos (
                        Artigo, Descricao, CodBarras, UnidadeVenda, UnidadeBase, Iva, Desconto, 
                        Fornecedor, STKMinimo, STKMaximo, STKReposicao, STKActual, MovStock, 
                        Familia, TipoArtigo, TipoComponente, NecessarioRecalcPCM, ArtigoAnulado, 
                        TratamentoSeries, TratamentoLotes, TestaNumSerie, SujeitoRetencao, 
                        Peso, Volume, Marca, Garantia, DeduzIvaNoImo, PermiteDevolucao, 
                        SujeitoProRata, PercIvaDedutivel, SujeitoEcotaxa, AfectaPCM, 
                        PercIncidenciaIVA, DataUltimaActualizacao, UnidadeCompra, UnidadeEntrada, UnidadeSaida
                    ) VALUES (
                        '{this.Artigo.Artigo}', 
                        '{this.Artigo.Descricao.Replace("'", "''")}', 
                        '{this.Artigo.CodBarras}', 
                        '{this.Artigo.UnidadeVenda}', 
                        '{this.Artigo.UnidadeBase}', 
                        {this.Artigo.Iva}, 
                        {this.Artigo.Desconto}, 
                        '{this.Artigo.Fornecedor}', 
                        {this.Artigo.STKMinimo}, 
                        {this.Artigo.STKMaximo}, 
                        {this.Artigo.STKReposicao}, 
                        {this.Artigo.STKActual}, 
                        '{(this.Artigo.MovStock ? "S" : "N")}', 
                        '{this.Artigo.Familia}', 
                        {this.Artigo.TipoArtigo}, 
                        {this.Artigo.TipoComponente}, 
                        {(this.Artigo.NecessarioRecalcPCM ? 1 : 0)}, 
                        {(this.Artigo.ArtigoAnulado ? 1 : 0)}, 
                        {(this.Artigo.TratamentoSeries ? 1 : 0)}, 
                        {(this.Artigo.TratamentoLotes ? 1 : 0)}, 
                        {(this.Artigo.TestaNumSerie ? 1 : 0)}, 
                        {(this.Artigo.SujeitoRetencao ? 1 : 0)}, 
                        {this.Artigo.Peso}, 
                        {this.Artigo.Volume}, 
                        '{this.Artigo.Marca}', 
                        {this.Artigo.Garantia}, 
                        {(this.Artigo.DeduzIvaNoImo ? 1 : 0)}, 
                        {(this.Artigo.PermiteDevolucao ? 1 : 0)}, 
                        {(this.Artigo.SujeitoProRata ? 1 : 0)}, 
                        {this.Artigo.PercIvaDedutivel}, 
                        {(this.Artigo.SujeitoEcotaxa ? 1 : 0)}, 
                        {(this.Artigo.AfectaPCM ? 1 : 0)}, 
                        {this.Artigo.PercIncidenciaIVA}, 
                        GETDATE(), 
                        '{this.Artigo.UnidadeCompra}', 
                        '{this.Artigo.UnidadeEntrada}', 
                        '{this.Artigo.UnidadeSaida}'
                    )";

                int resultArtigo = ExecuteSQL(insertArtigoSQL);

                // INSERT dos preços
                string insertPrecosSQL = $@"
                    INSERT INTO ArtigosPrecos (
                        Artigo, Moeda, Unidade, PVP1, PVP2, PVP3, PVP4, PVP5, PVP6
                    ) VALUES (
                        '{this.Artigo.Artigo}', 
                        'EUR', 
                        '{this.Artigo.UnidadeBase}', 
                        {ArtigoMoedaExportar.PVP1.ToString().Replace(",", ".")}, 
                        {ArtigoMoedaExportar.PVP2.ToString().Replace(",", ".")}, 
                        {ArtigoMoedaExportar.PVP3.ToString().Replace(",", ".")}, 
                        {ArtigoMoedaExportar.PVP4.ToString().Replace(",", ".")}, 
                        {ArtigoMoedaExportar.PVP5.ToString().Replace(",", ".")}, 
                        {ArtigoMoedaExportar.PVP6.ToString().Replace(",", ".")}
                    )";

                int resultPrecos = ExecuteSQL(insertPrecosSQL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no INSERT SQL: " + ex.Message);
            }
        }

        private int ExecuteSQL(string sqlQuery)
        {
            try
            {
                return BSO.Plataforma.Registos.ExecutaComando(sqlQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar SQL: " + ex.Message);
                throw;
            }
        }

        public StdBELista Consulta(string strQuery)
        {
            return BSO.Consulta(strQuery);
        }

        private void UpdateArtigoSQL(BasBEArtigoMoeda ArtigoMoedaExportar)
        {
            try
            {
                // UPDATE cross-database do artigo principal
                string updateArtigoSQL = $@"
                    UPDATE PRIEMPRE.dbo.Artigos SET 
                        Descricao = '{this.Artigo.Descricao.Replace("'", "''")}',
                        CodBarras = '{this.Artigo.CodBarras}',
                        UnidadeVenda = '{this.Artigo.UnidadeVenda}',
                        UnidadeBase = '{this.Artigo.UnidadeBase}',
                        Iva = {this.Artigo.Iva},
                        Desconto = {this.Artigo.Desconto},
                        Fornecedor = '{this.Artigo.Fornecedor}',
                        STKMinimo = {this.Artigo.STKMinimo},
                        STKMaximo = {this.Artigo.STKMaximo},
                        STKReposicao = {this.Artigo.STKReposicao},
                        Familia = '{this.Artigo.Familia}',
                        TipoArtigo = {this.Artigo.TipoArtigo},
                        Peso = {this.Artigo.Peso},
                        Volume = {this.Artigo.Volume},
                        Marca = '{this.Artigo.Marca}',
                        DataUltimaActualizacao = GETDATE()
                    WHERE Artigo = '{this.Artigo.Artigo}'";

                ExecuteSQL(updateArtigoSQL);

                // UPDATE dos preços
                string updatePrecosSQL = $@"
                    UPDATE PRIEMPRE.dbo.ArtigosPrecos SET 
                        PVP1 = {ArtigoMoedaExportar.PVP1.ToString().Replace(",", ".")},
                        PVP2 = {ArtigoMoedaExportar.PVP2.ToString().Replace(",", ".")},
                        PVP3 = {ArtigoMoedaExportar.PVP3.ToString().Replace(",", ".")},
                        PVP4 = {ArtigoMoedaExportar.PVP4.ToString().Replace(",", ".")},
                        PVP5 = {ArtigoMoedaExportar.PVP5.ToString().Replace(",", ".")},
                        PVP6 = {ArtigoMoedaExportar.PVP6.ToString().Replace(",", ".")}
                    WHERE Artigo = '{this.Artigo.Artigo}' AND Moeda = 'EUR' AND Unidade = '{this.Artigo.UnidadeBase}'";

                ExecuteSQL(updatePrecosSQL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no UPDATE SQL cross-database: " + ex.Message);
            }
        }

        private void CriarArtigoSQL(BasBEArtigoMoeda ArtigoMoedaExportar)
        {
            try
            {
                // INSERT cross-database do artigo principal
                string insertArtigoSQL = $@"
                    INSERT INTO PRIEMPRE.dbo.Artigos (
                        Artigo, Descricao, CodBarras, UnidadeVenda, UnidadeBase, Iva, Desconto, 
                        Fornecedor, STKMinimo, STKMaximo, STKReposicao, STKActual, MovStock, 
                        Familia, TipoArtigo, TipoComponente, NecessarioRecalcPCM, ArtigoAnulado, 
                        TratamentoSeries, TratamentoLotes, TestaNumSerie, SujeitoRetencao, 
                        Peso, Volume, Marca, Garantia, DeduzIvaNoImo, PermiteDevolucao, 
                        SujeitoProRata, PercIvaDedutivel, SujeitoEcotaxa, AfectaPCM, 
                        PercIncidenciaIVA, DataUltimaActualizacao
                    ) VALUES (
                        '{this.Artigo.Artigo}', 
                        '{this.Artigo.Descricao.Replace("'", "''")}', 
                        '{this.Artigo.CodBarras}', 
                        '{this.Artigo.UnidadeVenda}', 
                        '{this.Artigo.UnidadeBase}', 
                        {this.Artigo.Iva}, 
                        {this.Artigo.Desconto}, 
                        '{this.Artigo.Fornecedor}', 
                        {this.Artigo.STKMinimo}, 
                        {this.Artigo.STKMaximo}, 
                        {this.Artigo.STKReposicao}, 
                        {this.Artigo.STKActual}, 
                        '{(this.Artigo.MovStock ? "S" : "N")}', 
                        '{this.Artigo.Familia}', 
                        {this.Artigo.TipoArtigo}, 
                        {this.Artigo.TipoComponente}, 
                        {(this.Artigo.NecessarioRecalcPCM ? 1 : 0)}, 
                        {(this.Artigo.ArtigoAnulado ? 1 : 0)}, 
                        {(this.Artigo.TratamentoSeries ? 1 : 0)}, 
                        {(this.Artigo.TratamentoLotes ? 1 : 0)}, 
                        {(this.Artigo.TestaNumSerie ? 1 : 0)}, 
                        {(this.Artigo.SujeitoRetencao ? 1 : 0)}, 
                        {this.Artigo.Peso}, 
                        {this.Artigo.Volume}, 
                        '{this.Artigo.Marca}', 
                        {this.Artigo.Garantia}, 
                        {(this.Artigo.DeduzIvaNoImo ? 1 : 0)}, 
                        {(this.Artigo.PermiteDevolucao ? 1 : 0)}, 
                        {(this.Artigo.SujeitoProRata ? 1 : 0)}, 
                        {this.Artigo.PercIvaDedutivel}, 
                        {(this.Artigo.SujeitoEcotaxa ? 1 : 0)}, 
                        {(this.Artigo.AfectaPCM ? 1 : 0)}, 
                        {this.Artigo.PercIncidenciaIVA}, 
                        GETDATE()
                    )";

                ExecuteSQL(insertArtigoSQL);

                // INSERT dos preços
                string insertPrecosSQL = $@"
                    INSERT INTO PRIEMPRE.dbo.ArtigosPrecos (
                        Artigo, Moeda, Unidade, PVP1, PVP2, PVP3, PVP4, PVP5, PVP6
                    ) VALUES (
                        '{this.Artigo.Artigo}', 
                        'EUR', 
                        '{this.Artigo.UnidadeBase}', 
                        {ArtigoMoedaExportar.PVP1.ToString().Replace(",", ".")}, 
                        {ArtigoMoedaExportar.PVP2.ToString().Replace(",", ".")}, 
                        {ArtigoMoedaExportar.PVP3.ToString().Replace(",", ".")}, 
                        {ArtigoMoedaExportar.PVP4.ToString().Replace(",", ".")}, 
                        {ArtigoMoedaExportar.PVP5.ToString().Replace(",", ".")}, 
                        {ArtigoMoedaExportar.PVP6.ToString().Replace(",", ".")}
                    )";

                ExecuteSQL(insertPrecosSQL);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no INSERT SQL cross-database: " + ex.Message);
            }
        }

        public override void DepoisDeAnular(string Artigo, ExtensibilityEventArgs e)
        {
            try
            {
                var nome = BSO.Contexto.UtilizadorActual;
                var pas = BSO.Contexto.PasswordUtilizadorActual;

                // Fechar conexão atual antes de abrir nova
                BSO.FechaEmpresaTrabalho();

                // Abrir conexão com BRICLONE
                BSO.AbreEmpresaTrabalho(StdBE100.StdBETipos.EnumTipoPlataforma.tpEvolution, "BRICLONE", nome, pas);

                var ExiteArtigo = BSO.Base.Artigos.Existe(Artigo);
                if (ExiteArtigo)
                {
                    // Anular o artigo na empresa BRICLONE
                    BSO.Base.Artigos.Remove(Artigo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao anular artigo: " + ex.Message);
            }
            finally
            {
                // Garantir que voltamos à empresa original
                try
                {
                    var nome = BSO.Contexto.UtilizadorActual;
                    var pas = BSO.Contexto.PasswordUtilizadorActual;
                    BSO.FechaEmpresaTrabalho();
                    BSO.AbreEmpresaTrabalho(StdBE100.StdBETipos.EnumTipoPlataforma.tpEvolution, "CL14072025", nome, pas);
                }
                catch { }
            }
        }

    }
}
