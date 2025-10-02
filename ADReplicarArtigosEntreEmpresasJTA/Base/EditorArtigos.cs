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
            try
            {

                var basedados = "BRIOSA";
              
                string artigo = this.Artigo.Artigo;
                string descricao = this.Artigo.Descricao;
                string codBarras = this.Artigo.CodBarras;
                string unidadeVenda = this.Artigo.UnidadeVenda;
                string unidadeBase = this.Artigo.UnidadeBase;
                string iva = this.Artigo.IVA;
                float desconto = this.Artigo.Desconto;
                double sTKMinimo = this.Artigo.STKMinimo;
                double sTKMaximo = this.Artigo.STKMaximo;
                double sTKReposicao = this.Artigo.STKReposicao;
                double sTKActual = this.Artigo.StkActual;
                double pCMedio = this.Artigo.PCMedio;
                double pCUltimo = this.Artigo.PCUltimo;
                string movStock = this.Artigo.MovStock;
                System.DateTime dataUltEntrada = this.Artigo.DataUltimaEntrada;
                System.DateTime dataUltSaida = this.Artigo.DataUltimaSaida;
                string familia = this.Artigo.Familia;
                string armazemSugestao = this.Artigo.ArmazemSugestao;
                string tipoArtigo = this.Artigo.TipoArtigo;
                double pCPadrao = this.Artigo.PCPadrao;
                int sugestaoPrComposto = this.Artigo.SugestaoPrCustoComposto;
                double ultDescontoComercialCompra = this.Artigo.UltimoDescontoComercialCompra;
                double ultDespesaAdicionalCompra = this.Artigo.UltimaDespesaAdicionalCompra;
                int prazoEntrega = this.Artigo.PrazoEntrega;
                double qtdEconomica = this.Artigo.QuantEconomica;
                string ultimoFornecedor = this.Artigo.UltimoFornecedor;
                string subFamilia = this.Artigo.SubFamilia;
                double peso = this.Artigo.Peso;
                double volume = this.Artigo.Volume;
                bool artigoAnulado = this.Artigo.Anulado;
                bool tratamentoSeries = this.Artigo.TrataNumerosSerie;
                bool tratamentoLotes = this.Artigo.TrataLotes;
                bool loteFormulaEntradas = this.Artigo.UtilizaFormulaLotesEntrada;
                string loteEntradas = this.Artigo.SugestaoLoteEntradas;
                bool loteFormulaSaidas = this.Artigo.UtilizaFormulaLotesSaida;
                string loteSaidas = this.Artigo.SugestaoLoteSaidas;
                string ultimoNumSerie = this.Artigo.UltimoNumeroSerie;
                string ultimoLote = this.Artigo.UltimoLote;
                DateTime dataUltimaActualizacao = this.Artigo.DataUltimaActualizacao;
                bool sujeitoRetencao = this.Artigo.SujeitoRetencao;
                string observacoes = this.Artigo.Observacoes;
                bool operacaoTesouraria = this.Artigo.OperacaoTesouraria;
                string entidadeOPTesouraria = this.Artigo.EntidadeTesouraria;
                string modelo = this.Artigo.Modelo;
                string unidadeCompra = this.Artigo.UnidadeCompra;
                string unidadeEntrada = this.Artigo.UnidadeEntrada;
                string unidadeSaida = this.Artigo.UnidadeSaida;
                string ultimaSerieDoc = this.Artigo.UltimaSerieDocumentoCompra;
                bool deduzIvaNoImo = this.Artigo.DeduzIVA;
                bool permiteDevolucao = this.Artigo.SujeitoDevolucao;
                string tipoEntidadeOpTesouraria = this.Artigo.TipoEntidadeTesouraria;
                bool utilizadoCCOP = this.Artigo.UtilizadoCCOP;
                bool pesar = this.Artigo.Pesar;
                bool sujeitoProRata = this.Artigo.SujeitoProRata;
                var percIvaDedutivel = this.Artigo.PercIvaDedutivel;
                bool sujeitoEcotaxa = this.Artigo.SujeitoEcotaxa;
                double ecovalor = this.Artigo.Ecovalor;
                bool afectaPCM = this.Artigo.EcovalorAfectaPCM;
                string localizacaoSugestao = this.Artigo.LocalizacaoSugestao;
                int ordemDim = this.Artigo.OrdemDim;
                string rubDim1 = this.Artigo.RubDimensao1;
                string rubDim2 = this.Artigo.RubDimensao2;
                string rubDim3 = this.Artigo.RubDimensao3;
                bool fabCompAutoGPR = this.Artigo.FabCompAuto;
                bool calcNecessidadesGPR = this.Artigo.CalcNecessidades;
                double qtReservadaGPR = this.Artigo.QtReservada;
                double qtReceberGPR = this.Artigo.QtReceber;
                double desperdicioGPR = this.Artigo.Desperdicio;
                bool utilizadoGPR = this.Artigo.UtilizadoGPR;
                double PercIncidenciaIVA = this.Artigo.PercIncidenciaIVA;

                string unidadeTaric = this.Artigo.UnidadeTaric;
    
                bool utilManutencao = this.Artigo.UtilizadoManutencao;
                double pesoLiquido = this.Artigo.PesoLiquido;
                bool gestaoSingular = this.Artigo.GestaoSingular;
                string selo = this.Artigo.Selo;
                string codigoBebidaEspirituosa = this.Artigo.CodigoBebidaEspirituosa;
                string codigoEstampilha = this.Artigo.CodigoEstampilha;
                double factorUnidadeSup = this.Artigo.FactorUnidadeSup;
        
                bool isentoPagDireitos = this.Artigo.IsentoPagDireitos;
    
                bool controlaTransformacaoValor = this.Artigo.ControlaTransformacaoValor;

                

                DateTime dataCustoPadrao = this.Artigo.DataCustoPadrao;
   
                bool sujeitoRetencaoArtigo = this.Artigo.SujeitoRetencaoArtigo;
                double retencaoArtigoValor = this.Artigo.RetencaoArtigoValor;
                bool retencaoArtigoTipoValor = this.Artigo.RetencaoArtigoTipoValor;
              
             
                string numeroONU = this.Artigo.NumeroONU;
         
              //  string classeArtigoTaxFree = this.Artigo.ClasseArtigoTaxFree;

                double grauPlato = this.Artigo.GrauPlato;
                double calcNessidadesMultiploCompra = this.Artigo.CalcNessidadesMultiploCompra;
                bool imovel = this.Artigo.Imovel;



                var artigoMoeda = BSO.Base.ArtigosPrecos.Edita(artigo, "EUR", this.Artigo.UnidadeBase);

                string moeda = artigoMoeda.Moeda;
                double pvp1 = artigoMoeda.PVP1;
                double pvp2 = artigoMoeda.PVP2;
                double pvp3 = artigoMoeda.PVP3;
                double pvp4 = artigoMoeda.PVP4;
                double pvp5 = artigoMoeda.PVP5;
                double pvp6 = artigoMoeda.PVP6;
                string unidade = artigoMoeda.Unidade;
                bool pvp1IvaIncluido = artigoMoeda.PVP1IvaIncluido;
                bool pvp2IvaIncluido = artigoMoeda.PVP2IvaIncluido;
                bool pvp3IvaIncluido = artigoMoeda.PVP3IvaIncluido;
                bool pvp4IvaIncluido = artigoMoeda.PVP4IvaIncluido;
                bool pvp5IvaIncluido = artigoMoeda.PVP5IvaIncluido;
                bool pvp6IvaIncluido = artigoMoeda.PVP6IvaIncluido;

                //verifica se Existe o Artigo ou nao se Insiste Insert se nao UPDATE
                string queryVerificaArtigo = $@"
                SELECT COUNT(*) as num FROM [PRI{basedados}].[dbo].[Artigo] WHERE Artigo = '{artigo}'";

                int count = BSO.Consulta(queryVerificaArtigo).DaValor<int>("num");
                MessageBox.Show("Count: " + count);
                //se count for 0 o artigo nao existe
                if (count > 0)
                {
                    // Artigo existe, faz UPDATE
                    var queryUpdateTabelaArtigo = $@"
    UPDATE [PRI{basedados}].[dbo].[Artigo] SET 
        descricao = '{descricao}', 
        codBarras = '{codBarras}', 
        unidadeVenda = '{unidadeVenda}', 
        unidadeBase = '{unidadeBase}', 
        iva = '{iva}', 
        desconto = {desconto}, 
        sTKMinimo = {sTKMinimo}, 
        sTKMaximo = {sTKMaximo}, 
        sTKReposicao = {sTKReposicao}, 
        sTKActual = {sTKActual}, 
        pCMedio = {pCMedio}, 
        pCUltimo = {pCUltimo}, 
        movStock = '{movStock}', 
        familia = NULLIF('{familia}', ''), 
        armazemSugestao = '{armazemSugestao}', 
        tipoArtigo = '{tipoArtigo}', 
        pCPadrao = {pCPadrao}, 
        sugestaoPrComposto = {sugestaoPrComposto}, 
        ultDescontoComercialCompra = {ultDescontoComercialCompra}, 
        ultDespesaAdicionalCompra = {ultDespesaAdicionalCompra}, 
        prazoEntrega = {prazoEntrega}, 
        qtdEconomica = {qtdEconomica}, 
        ultimoFornecedor = '{ultimoFornecedor}', 
        subFamilia = NULLIF('{subFamilia}', ''), 
        peso = {peso}, 
        volume = {volume}, 
        artigoAnulado = {(artigoAnulado ? 1 : 0)}, 
        tratamentoSeries = {(tratamentoSeries ? 1 : 0)}, 
        tratamentoLotes = {(tratamentoLotes ? 1 : 0)}, 
        loteFormulaEntradas = {(loteFormulaEntradas ? 1 : 0)}, 
        loteEntradas = '{loteEntradas}', 
        loteFormulaSaidas = {(loteFormulaSaidas ? 1 : 0)}, 
        loteSaidas = '{loteSaidas}', 
        ultimoNumSerie = '{ultimoNumSerie}', 
        ultimoLote = '{ultimoLote}', 
        sujeitoRetencao = {(sujeitoRetencao ? 1 : 0)}, 
        observacoes = '{observacoes}', 
        operacaoTesouraria = {(operacaoTesouraria ? 1 : 0)}, 
        entidadeOPTesouraria = '{entidadeOPTesouraria}', 
        modelo = '{modelo}', 
        unidadeCompra = '{unidadeCompra}', 
        unidadeEntrada = '{unidadeEntrada}', 
        unidadeSaida = '{unidadeSaida}', 
        ultimaSerieDoc = '{ultimaSerieDoc}', 
        deduzIvaNoImo = {(deduzIvaNoImo ? 1 : 0)}, 
        permiteDevolucao = {(permiteDevolucao ? 1 : 0)}, 
        tipoEntidadeOpTesouraria = '{tipoEntidadeOpTesouraria}', 
        utilizadoCCOP = {(utilizadoCCOP ? 1 : 0)}, 
        pesar = {(pesar ? 1 : 0)}, 
        sujeitoProRata = {(sujeitoProRata ? 1 : 0)}, 
        percIvaDedutivel = {percIvaDedutivel}, 
        sujeitoEcotaxa = {(sujeitoEcotaxa ? 1 : 0)}, 
        ecovalor = {ecovalor}, 
        afectaPCM = {(afectaPCM ? 1 : 0)}, 
        localizacaoSugestao = '{localizacaoSugestao}', 
        ordemDim = {ordemDim}, 
        rubDim1 = '{rubDim1}', 
        rubDim2 = '{rubDim2}', 
        rubDim3 = '{rubDim3}', 
        fabCompAutoGPR = {(fabCompAutoGPR ? 1 : 0)}, 
        calcNecessidadesGPR = {(calcNecessidadesGPR ? 1 : 0)}, 
        qtReservadaGPR = {qtReservadaGPR}, 
        qtReceberGPR = {qtReceberGPR}, 
        desperdicioGPR = {desperdicioGPR}, 
        utilizadoGPR = {(utilizadoGPR ? 1 : 0)}, 
        PercIncidenciaIVA = {PercIncidenciaIVA}, 
        unidadeTaric = '{unidadeTaric}', 
        utilManutencao = {(utilManutencao ? 1 : 0)}, 
        pesoLiquido = {pesoLiquido}, 
        gestaoSingular = {(gestaoSingular ? 1 : 0)}, 
        selo = '{selo}', 
        codigoBebidaEspirituosa = '{codigoBebidaEspirituosa}', 
        codigoEstampilha = '{codigoEstampilha}', 
        factorUnidadeSup = {factorUnidadeSup}, 
        isentoPagDireitos = {(isentoPagDireitos ? 1 : 0)}, 
        controlaTransformacaoValor = {(controlaTransformacaoValor ? 1 : 0)}, 
        sujeitoRetencaoArtigo = {(sujeitoRetencaoArtigo ? 1 : 0)}, 
        retencaoArtigoValor = {retencaoArtigoValor}, 
        retencaoArtigoTipoValor = {(retencaoArtigoTipoValor ? 1 : 0)}, 
        numeroONU = '{numeroONU}', 
        grauPlato = {grauPlato}, 
        calcNessidadesMultiploCompra = {calcNessidadesMultiploCompra}, 
        imovel = {(imovel ? 1 : 0)} 
    WHERE artigo = '{artigo}'
";

                    BSO.DSO.ExecuteSQL(queryUpdateTabelaArtigo);

                    var queryUpdateTabelaArtigoMoeda = $@"
                        UPDATE [PRI{basedados}].[dbo].[ArtigoMoeda] SET 
                            pvp1 = {pvp1}, 
                            pvp2 = {pvp2}, 
                            pvp3 = {pvp3}, 
                            pvp4 = {pvp4}, 
                            pvp5 = {pvp5}, 
                            pvp6 = {pvp6}, 
                            unidade = '{unidade}', 
                            pvp1IvaIncluido = {(pvp1IvaIncluido ? 1 : 0)}, 
                            pvp2IvaIncluido = {(pvp2IvaIncluido ? 1 : 0)}, 
                            pvp3IvaIncluido = {(pvp3IvaIncluido ? 1 : 0)}, 
                            pvp4IvaIncluido = {(pvp4IvaIncluido ? 1 : 0)}, 
                            pvp5IvaIncluido = {(pvp5IvaIncluido ? 1 : 0)}, 
                            pvp6IvaIncluido = {(pvp6IvaIncluido ? 1 : 0)}
                        WHERE artigo = '{artigo}' AND moeda = '{moeda}'
                        ";

                    BSO.DSO.ExecuteSQL(queryUpdateTabelaArtigoMoeda);

                }
                else
                {
                    var queryInsertTabelaArtigo = $@"
                        INSERT INTO [PRI{basedados}].[dbo].[Artigo] (
                            artigo, descricao, codBarras, unidadeVenda, unidadeBase, iva, desconto, sTKMinimo, sTKMaximo, sTKReposicao, sTKActual,
                            pCMedio, pCUltimo, movStock, dataUltEntrada, dataUltSaida, familia, armazemSugestao, 
                            tipoArtigo, pCPadrao, sugestaoPrComposto, ultDescontoComercialCompra, ultDespesaAdicionalCompra,
                            prazoEntrega, qtdEconomica, ultimoFornecedor, subFamilia, peso, volume, artigoAnulado,
                            tratamentoSeries, tratamentoLotes, loteFormulaEntradas, loteEntradas, loteFormulaSaidas, loteSaidas, 
                            ultimoNumSerie, ultimoLote,  dataUltimaActualizacao, sujeitoRetencao,
                            observacoes,   operacaoTesouraria,
                            entidadeOPTesouraria, modelo, unidadeCompra, unidadeEntrada, unidadeSaida, ultimaSerieDoc, deduzIvaNoImo, permiteDevolucao,
                            tipoEntidadeOpTesouraria, utilizadoCCOP, pesar, sujeitoProRata, percIvaDedutivel, sujeitoEcotaxa, ecovalor,
                            afectaPCM, localizacaoSugestao, ordemDim, rubDim1, rubDim2, rubDim3, fabCompAutoGPR,
                            calcNecessidadesGPR, qtReservadaGPR, qtReceberGPR,  desperdicioGPR, utilizadoGPR, PercIncidenciaIVA,
                   unidadeTaric, utilManutencao, pesoLiquido, gestaoSingular,
                            selo, codigoBebidaEspirituosa, codigoEstampilha, factorUnidadeSup, isentoPagDireitos, 
                            controlaTransformacaoValor,   dataCustoPadrao, 
                            sujeitoRetencaoArtigo, retencaoArtigoValor, retencaoArtigoTipoValor,   numeroONU,
                           grauPlato, calcNessidadesMultiploCompra, imovel
                        ) VALUES (
                            '{artigo}', '{descricao}', '{codBarras}', '{unidadeVenda}', '{unidadeBase}', '{iva}', {desconto}, {sTKMinimo}, {sTKMaximo}, {sTKReposicao}, {sTKActual},
                            {pCMedio}, {pCUltimo}, '{movStock}', '{dataUltEntrada:yyyy-MM-dd HH:mm:ss}', '{dataUltSaida:yyyy-MM-dd HH:mm:ss}', NULLIF('{familia}', ''),  '{armazemSugestao}',
                            '{tipoArtigo}', {pCPadrao}, {sugestaoPrComposto}, {ultDescontoComercialCompra}, {ultDespesaAdicionalCompra},
                            {prazoEntrega}, {qtdEconomica}, '{ultimoFornecedor}', NULLIF('{subFamilia}', ''),  {peso}, {volume},   {(artigoAnulado ? 1 : 0)},
                            {(tratamentoSeries ? 1 : 0)}, {(tratamentoLotes ? 1 : 0)}, {(loteFormulaEntradas ? 1 : 0)}, '{loteEntradas}', {(loteFormulaSaidas ? 1 : 0)}, '{loteSaidas}', 
                            '{ultimoNumSerie}', '{ultimoLote}',  '{dataUltimaActualizacao:yyyy-MM-dd HH:mm:ss}', {(sujeitoRetencao ? 1 : 0)},
                            '{observacoes}', {(operacaoTesouraria ? 1 : 0)},
                            '{entidadeOPTesouraria}', '{modelo}', '{unidadeCompra}', '{unidadeEntrada}', '{unidadeSaida}', '{ultimaSerieDoc}', {(deduzIvaNoImo ? 1 : 0)}, {(permiteDevolucao ? 1 : 0)},
                            '{tipoEntidadeOpTesouraria}', {(utilizadoCCOP ? 1 : 0)}, {(pesar ? 1 : 0)}, {(sujeitoProRata ? 1 : 0)}, {percIvaDedutivel}, {(sujeitoEcotaxa ? 1 : 0)}, {ecovalor},
                            {(afectaPCM ? 1 : 0)}, '{localizacaoSugestao}',  {ordemDim}, '{rubDim1}', '{rubDim2}', '{rubDim3}' , {(fabCompAutoGPR ? 1 : 0)},
                            {(calcNecessidadesGPR ? 1 : 0)}, {qtReservadaGPR}, {qtReceberGPR},  {desperdicioGPR}, {(utilizadoGPR ? 1 : 0)}, {PercIncidenciaIVA},
                            '{unidadeTaric}',  {(utilManutencao ? 1 : 0)}, {pesoLiquido}, {(gestaoSingular ? 1 : 0)},
                            '{selo}', '{codigoBebidaEspirituosa}', '{codigoEstampilha}', {factorUnidadeSup},{(isentoPagDireitos ? 1 : 0)}, 
                            {(controlaTransformacaoValor ? 1 : 0)}, '{dataCustoPadrao:yyyy-MM-dd HH:mm:ss}', 
                            {(sujeitoRetencaoArtigo ? 1 : 0)}, {retencaoArtigoValor}, {(retencaoArtigoTipoValor ? 1 : 0)},   '{numeroONU}', 
                            {grauPlato}, {calcNessidadesMultiploCompra}, {(imovel ? 1 : 0)}
                        )";

                    BSO.DSO.ExecuteSQL(queryInsertTabelaArtigo);

                    var queryInsertTabelaArtigoMoeda = $@"
                        INSERT INTO [PRI{basedados}].[dbo].[ArtigoMoeda] (
                            artigo, moeda, pvp1, pvp2, pvp3, pvp4, pvp5, pvp6, unidade, 
                            pvp1IvaIncluido, pvp2IvaIncluido, pvp3IvaIncluido, pvp4IvaIncluido, pvp5IvaIncluido, pvp6IvaIncluido
                        ) VALUES (
                            '{artigo}', '{moeda}', {pvp1}, {pvp2}, {pvp3}, {pvp4}, {pvp5}, {pvp6}, '{unidade}', 
                            {(pvp1IvaIncluido ? 1 : 0)}, {(pvp2IvaIncluido ? 1 : 0)}, {(pvp3IvaIncluido ? 1 : 0)}, {(pvp4IvaIncluido ? 1 : 0)}, {(pvp5IvaIncluido ? 1 : 0)}, {(pvp6IvaIncluido ? 1 : 0)}
                        )";

                    BSO.DSO.ExecuteSQL(queryInsertTabelaArtigoMoeda);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao replicar o artigo para a empresa BRIOSA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void DepoisDeAnular(string Artigo, ExtensibilityEventArgs e)
        {
            /*try
            {
                var basedados = "BRIOSA";

                // Verifica se o artigo existe antes de tentar deletar
                string queryVerificaArtigo = $@"
            SELECT COUNT(*) as num 
            FROM [PRI{basedados}].[dbo].[Artigo] 
            WHERE Artigo = '{Artigo}'";

                int count = BSO.Consulta(queryVerificaArtigo).DaValor<int>("num");

                if (count > 0)
                {
                    // Deleta primeiro da tabela de preços
                    string queryDeleteArtigoMoeda = $@"
                DELETE FROM [PRI{basedados}].[dbo].[ArtigoMoeda] 
                WHERE artigo = '{Artigo}'";

                    BSO.DSO.ExecuteSQL(queryDeleteArtigoMoeda);

                    // Depois deleta da tabela principal
                    string queryDeleteArtigo = $@"
                DELETE FROM [PRI{basedados}].[dbo].[Artigo] 
                WHERE artigo = '{Artigo}'";

                    BSO.DSO.ExecuteSQL(queryDeleteArtigo);

                }
                else
                {
                    MessageBox.Show($"Artigo {Artigo} não existe na empresa {basedados}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover o artigo da empresa BRIOSA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

    }
}
