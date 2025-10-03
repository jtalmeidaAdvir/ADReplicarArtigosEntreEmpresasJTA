using BasBE100;
using Primavera.Extensibility.Base.Editors;
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using Primavera.Extensibility.Integration;
using Primavera.Extensibility.Integration.Modules.Platform.Services;
using StdBE100;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                    string text = "BRIOSA";
                    string artigo = ((FichaArtigos)this).Artigo.Artigo;
                    string descricao = ((FichaArtigos)this).Artigo.Descricao;
                    string codBarras = ((FichaArtigos)this).Artigo.CodBarras;
                    string unidadeVenda = ((FichaArtigos)this).Artigo.UnidadeVenda;
                    string unidadeBase = ((FichaArtigos)this).Artigo.UnidadeBase;
                    string iVA = ((FichaArtigos)this).Artigo.IVA;
                    float desconto = ((FichaArtigos)this).Artigo.Desconto;
                    double sTKMinimo = ((FichaArtigos)this).Artigo.STKMinimo;
                    double sTKMaximo = ((FichaArtigos)this).Artigo.STKMaximo;
                    double sTKReposicao = ((FichaArtigos)this).Artigo.STKReposicao;
                    double stkActual = ((FichaArtigos)this).Artigo.StkActual;
                    double pCMedio = ((FichaArtigos)this).Artigo.PCMedio;
                    double pCUltimo = ((FichaArtigos)this).Artigo.PCUltimo;
                    string movStock = ((FichaArtigos)this).Artigo.MovStock;
                    DateTime dataUltimaEntrada = ((FichaArtigos)this).Artigo.DataUltimaEntrada;
                    DateTime dataUltimaSaida = ((FichaArtigos)this).Artigo.DataUltimaSaida;
                    string familia = ((FichaArtigos)this).Artigo.Familia;
                    string armazemSugestao = ((FichaArtigos)this).Artigo.ArmazemSugestao;
                    string tipoArtigo = ((FichaArtigos)this).Artigo.TipoArtigo;
                    double pCPadrao = ((FichaArtigos)this).Artigo.PCPadrao;
                    int sugestaoPrCustoComposto = ((FichaArtigos)this).Artigo.SugestaoPrCustoComposto;
                    double ultimoDescontoComercialCompra = ((FichaArtigos)this).Artigo.UltimoDescontoComercialCompra;
                    double ultimaDespesaAdicionalCompra = ((FichaArtigos)this).Artigo.UltimaDespesaAdicionalCompra;
                    int prazoEntrega = ((FichaArtigos)this).Artigo.PrazoEntrega;
                    double quantEconomica = ((FichaArtigos)this).Artigo.QuantEconomica;
                    string ultimoFornecedor = ((FichaArtigos)this).Artigo.UltimoFornecedor;
                    string subFamilia = ((FichaArtigos)this).Artigo.SubFamilia;
                    double peso = ((FichaArtigos)this).Artigo.Peso;
                    double volume = ((FichaArtigos)this).Artigo.Volume;
                    bool anulado = ((FichaArtigos)this).Artigo.Anulado;
                    bool trataNumerosSerie = ((FichaArtigos)this).Artigo.TrataNumerosSerie;
                    bool trataLotes = ((FichaArtigos)this).Artigo.TrataLotes;
                    bool utilizaFormulaLotesEntrada = ((FichaArtigos)this).Artigo.UtilizaFormulaLotesEntrada;
                    string sugestaoLoteEntradas = ((FichaArtigos)this).Artigo.SugestaoLoteEntradas;
                    bool utilizaFormulaLotesSaida = ((FichaArtigos)this).Artigo.UtilizaFormulaLotesSaida;
                    string sugestaoLoteSaidas = ((FichaArtigos)this).Artigo.SugestaoLoteSaidas;
                    string ultimoNumeroSerie = ((FichaArtigos)this).Artigo.UltimoNumeroSerie;
                    string ultimoLote = ((FichaArtigos)this).Artigo.UltimoLote;
                    DateTime dataUltimaActualizacao = ((FichaArtigos)this).Artigo.DataUltimaActualizacao;
                    bool sujeitoRetencao = ((FichaArtigos)this).Artigo.SujeitoRetencao;
                    string observacoes = ((FichaArtigos)this).Artigo.Observacoes;
                    bool operacaoTesouraria = ((FichaArtigos)this).Artigo.OperacaoTesouraria;
                    string entidadeTesouraria = ((FichaArtigos)this).Artigo.EntidadeTesouraria;
                    string modelo = ((FichaArtigos)this).Artigo.Modelo;
                    string unidadeCompra = ((FichaArtigos)this).Artigo.UnidadeCompra;
                    string unidadeEntrada = ((FichaArtigos)this).Artigo.UnidadeEntrada;
                    string unidadeSaida = ((FichaArtigos)this).Artigo.UnidadeSaida;
                    string ultimaSerieDocumentoCompra = ((FichaArtigos)this).Artigo.UltimaSerieDocumentoCompra;
                    bool deduzIVA = ((FichaArtigos)this).Artigo.DeduzIVA;
                    bool sujeitoDevolucao = ((FichaArtigos)this).Artigo.SujeitoDevolucao;
                    string tipoEntidadeTesouraria = ((FichaArtigos)this).Artigo.TipoEntidadeTesouraria;
                    bool utilizadoCCOP = ((FichaArtigos)this).Artigo.UtilizadoCCOP;
                    bool pesar = ((FichaArtigos)this).Artigo.Pesar;
                    bool sujeitoProRata = ((FichaArtigos)this).Artigo.SujeitoProRata;
                    double percIvaDedutivel = ((FichaArtigos)this).Artigo.PercIvaDedutivel;
                    bool sujeitoEcotaxa = ((FichaArtigos)this).Artigo.SujeitoEcotaxa;
                    double ecovalor = ((FichaArtigos)this).Artigo.Ecovalor;
                    bool ecovalorAfectaPCM = ((FichaArtigos)this).Artigo.EcovalorAfectaPCM;
                    string localizacaoSugestao = ((FichaArtigos)this).Artigo.LocalizacaoSugestao;
                    int ordemDim = ((FichaArtigos)this).Artigo.OrdemDim;
                    string rubDimensao = ((FichaArtigos)this).Artigo.RubDimensao1;
                    string rubDimensao2 = ((FichaArtigos)this).Artigo.RubDimensao2;
                    string rubDimensao3 = ((FichaArtigos)this).Artigo.RubDimensao3;
                    bool fabCompAuto = ((FichaArtigos)this).Artigo.FabCompAuto;
                    bool calcNecessidades = ((FichaArtigos)this).Artigo.CalcNecessidades;
                    double qtReservada = ((FichaArtigos)this).Artigo.QtReservada;
                    double qtReceber = ((FichaArtigos)this).Artigo.QtReceber;
                    double desperdicio = ((FichaArtigos)this).Artigo.Desperdicio;
                    bool utilizadoGPR = ((FichaArtigos)this).Artigo.UtilizadoGPR;
                    double percIncidenciaIVA = ((FichaArtigos)this).Artigo.PercIncidenciaIVA;
                    string unidadeTaric = ((FichaArtigos)this).Artigo.UnidadeTaric;
                    bool utilizadoManutencao = ((FichaArtigos)this).Artigo.UtilizadoManutencao;
                    double pesoLiquido = ((FichaArtigos)this).Artigo.PesoLiquido;
                    bool gestaoSingular = ((FichaArtigos)this).Artigo.GestaoSingular;
                    string selo = ((FichaArtigos)this).Artigo.Selo;
                    string codigoBebidaEspirituosa = ((FichaArtigos)this).Artigo.CodigoBebidaEspirituosa;
                    string codigoEstampilha = ((FichaArtigos)this).Artigo.CodigoEstampilha;
                    double factorUnidadeSup = ((FichaArtigos)this).Artigo.FactorUnidadeSup;
                    bool isentoPagDireitos = ((FichaArtigos)this).Artigo.IsentoPagDireitos;
                    bool controlaTransformacaoValor = ((FichaArtigos)this).Artigo.ControlaTransformacaoValor;
                    DateTime dataCustoPadrao = ((FichaArtigos)this).Artigo.DataCustoPadrao;
                    bool sujeitoRetencaoArtigo = ((FichaArtigos)this).Artigo.SujeitoRetencaoArtigo;
                    double retencaoArtigoValor = ((FichaArtigos)this).Artigo.RetencaoArtigoValor;
                    bool retencaoArtigoTipoValor = ((FichaArtigos)this).Artigo.RetencaoArtigoTipoValor;
                    string numeroONU = ((FichaArtigos)this).Artigo.NumeroONU;
                    double grauPlato = ((FichaArtigos)this).Artigo.GrauPlato;
                    double calcNessidadesMultiploCompra = ((FichaArtigos)this).Artigo.CalcNessidadesMultiploCompra;
                    bool imovel = ((FichaArtigos)this).Artigo.Imovel;
                    BasBEArtigoMoeda val = ((ProductContext)this).BSO.Base.ArtigosPrecos.Edita(artigo, "EUR", ((FichaArtigos)this).Artigo.UnidadeBase);
                    string moeda = val.Moeda;
              

                // ...

                string pVP1 = val.PVP1.ToString(CultureInfo.InvariantCulture);
                string pVP2 = val.PVP2.ToString(CultureInfo.InvariantCulture);
                string pVP3 = val.PVP3.ToString(CultureInfo.InvariantCulture);
                string pVP4 = val.PVP4.ToString(CultureInfo.InvariantCulture);
                string pVP5 = val.PVP5.ToString(CultureInfo.InvariantCulture);
                string pVP6 = val.PVP6.ToString(CultureInfo.InvariantCulture);

                string unidade = val.Unidade;
                    bool pVP1IvaIncluido = val.PVP1IvaIncluido;
                    bool pVP2IvaIncluido = val.PVP2IvaIncluido;
                    bool pVP3IvaIncluido = val.PVP3IvaIncluido;
                    bool pVP4IvaIncluido = val.PVP4IvaIncluido;
                    bool pVP5IvaIncluido = val.PVP5IvaIncluido;
                    bool pVP6IvaIncluido = val.PVP6IvaIncluido;
          
                    string text2 = "\r\n                SELECT COUNT(*) as num FROM [PRI" + text + "].[dbo].[Artigo] WHERE Artigo = '" + artigo + "'";
                    int num = ((ProductContext)this).BSO.Consulta(text2).DaValor<int>("num");
              
                    if (num > 0)
                    {
                        string text3 = $"\r\n    UPDATE [PRI{text}].[dbo].[Artigo] SET \r\n        descricao = '{descricao}', \r\n        codBarras = '{codBarras}', \r\n        unidadeVenda = '{unidadeVenda}', \r\n        unidadeBase = '{unidadeBase}', \r\n        iva = '{iVA}', \r\n        desconto = {desconto}, \r\n        sTKMinimo = {sTKMinimo}, \r\n        sTKMaximo = {sTKMaximo}, \r\n        sTKReposicao = {sTKReposicao}, \r\n        sTKActual = {stkActual}, \r\n        pCMedio = {pCMedio}, \r\n        pCUltimo = {pCUltimo}, \r\n        movStock = '{movStock}', \r\n        familia = NULLIF('{familia}', ''), \r\n        armazemSugestao = '{armazemSugestao}', \r\n        tipoArtigo = '{tipoArtigo}', \r\n        pCPadrao = {pCPadrao}, \r\n        sugestaoPrComposto = {sugestaoPrCustoComposto}, \r\n        ultDescontoComercialCompra = {ultimoDescontoComercialCompra}, \r\n        ultDespesaAdicionalCompra = {ultimaDespesaAdicionalCompra}, \r\n        prazoEntrega = {prazoEntrega}, \r\n        qtdEconomica = {quantEconomica}, \r\n        ultimoFornecedor = '{ultimoFornecedor}', \r\n        subFamilia = NULLIF('{subFamilia}', ''), \r\n        peso = {peso}, \r\n        volume = {volume}, \r\n        artigoAnulado = {(anulado ? 1 : 0)}, \r\n        tratamentoSeries = {(trataNumerosSerie ? 1 : 0)}, \r\n        tratamentoLotes = {(trataLotes ? 1 : 0)}, \r\n        loteFormulaEntradas = {(utilizaFormulaLotesEntrada ? 1 : 0)}, \r\n        loteEntradas = '{sugestaoLoteEntradas}', \r\n        loteFormulaSaidas = {(utilizaFormulaLotesSaida ? 1 : 0)}, \r\n        loteSaidas = '{sugestaoLoteSaidas}', \r\n        ultimoNumSerie = '{ultimoNumeroSerie}', \r\n        ultimoLote = '{ultimoLote}', \r\n        sujeitoRetencao = {(sujeitoRetencao ? 1 : 0)}, \r\n        observacoes = '{observacoes}', \r\n        operacaoTesouraria = {(operacaoTesouraria ? 1 : 0)}, \r\n        entidadeOPTesouraria = '{entidadeTesouraria}', \r\n        modelo = '{modelo}', \r\n        unidadeCompra = '{unidadeCompra}', \r\n        unidadeEntrada = '{unidadeEntrada}', \r\n        unidadeSaida = '{unidadeSaida}', \r\n        ultimaSerieDoc = '{ultimaSerieDocumentoCompra}', \r\n        deduzIvaNoImo = {(deduzIVA ? 1 : 0)}, \r\n        permiteDevolucao = {(sujeitoDevolucao ? 1 : 0)}, \r\n        tipoEntidadeOpTesouraria = '{tipoEntidadeTesouraria}', \r\n        utilizadoCCOP = {(utilizadoCCOP ? 1 : 0)}, \r\n        pesar = {(pesar ? 1 : 0)}, \r\n        sujeitoProRata = {(sujeitoProRata ? 1 : 0)}, \r\n        percIvaDedutivel = {percIvaDedutivel}, \r\n        sujeitoEcotaxa = {(sujeitoEcotaxa ? 1 : 0)}, \r\n        ecovalor = {ecovalor}, \r\n        afectaPCM = {(ecovalorAfectaPCM ? 1 : 0)}, \r\n        localizacaoSugestao = '{localizacaoSugestao}', \r\n        ordemDim = {ordemDim}, \r\n        rubDim1 = '{rubDimensao}', \r\n        rubDim2 = '{rubDimensao2}', \r\n        rubDim3 = '{rubDimensao3}', \r\n        fabCompAutoGPR = {(fabCompAuto ? 1 : 0)}, \r\n        calcNecessidadesGPR = {(calcNecessidades ? 1 : 0)}, \r\n        qtReservadaGPR = {qtReservada}, \r\n        qtReceberGPR = {qtReceber}, \r\n        desperdicioGPR = {desperdicio}, \r\n        utilizadoGPR = {(utilizadoGPR ? 1 : 0)}, \r\n        PercIncidenciaIVA = {percIncidenciaIVA}, \r\n        unidadeTaric = '{unidadeTaric}', \r\n        utilManutencao = {(utilizadoManutencao ? 1 : 0)}, \r\n        pesoLiquido = {pesoLiquido}, \r\n        gestaoSingular = {(gestaoSingular ? 1 : 0)}, \r\n        selo = '{selo}', \r\n        codigoBebidaEspirituosa = '{codigoBebidaEspirituosa}', \r\n        codigoEstampilha = '{codigoEstampilha}', \r\n        factorUnidadeSup = {factorUnidadeSup}, \r\n        isentoPagDireitos = {(isentoPagDireitos ? 1 : 0)}, \r\n        controlaTransformacaoValor = {(controlaTransformacaoValor ? 1 : 0)}, \r\n        sujeitoRetencaoArtigo = {(sujeitoRetencaoArtigo ? 1 : 0)}, \r\n        retencaoArtigoValor = {retencaoArtigoValor}, \r\n        retencaoArtigoTipoValor = {(retencaoArtigoTipoValor ? 1 : 0)}, \r\n        numeroONU = '{numeroONU}', \r\n        grauPlato = {grauPlato}, \r\n        calcNessidadesMultiploCompra = {calcNessidadesMultiploCompra}, \r\n        imovel = {(imovel ? 1 : 0)} \r\n    WHERE artigo = '{artigo}'\r\n";
                        ((ProductContext)this).BSO.DSO.ExecuteSQL(text3);
                        string text4 = $"\r\n                        UPDATE [PRI{text}].[dbo].[ArtigoMoeda] SET \r\n                            pvp1 = '{pVP1}', \r\n                            pvp2 = '{pVP2}', \r\n                            pvp3 = '{pVP3}', \r\n                            pvp4 = '{pVP4}', \r\n                            pvp5 = '{pVP5}', \r\n                            pvp6 = '{pVP6}', \r\n                            unidade = '{unidade}', \r\n                            pvp1IvaIncluido = {(pVP1IvaIncluido ? 1 : 0)}, \r\n                            pvp2IvaIncluido = {(pVP2IvaIncluido ? 1 : 0)}, \r\n                            pvp3IvaIncluido = {(pVP3IvaIncluido ? 1 : 0)}, \r\n                            pvp4IvaIncluido = {(pVP4IvaIncluido ? 1 : 0)}, \r\n                            pvp5IvaIncluido = {(pVP5IvaIncluido ? 1 : 0)}, \r\n                            pvp6IvaIncluido = {(pVP6IvaIncluido ? 1 : 0)}\r\n                        WHERE artigo = '{artigo}' AND moeda = '{moeda}'\r\n                        ";
                        ((ProductContext)this).BSO.DSO.ExecuteSQL(text4);
                    }
                    else
                    {
                        string text5 = $"\r\n                        INSERT INTO [PRI{text}].[dbo].[Artigo] (\r\n                            artigo, descricao, codBarras, unidadeVenda, unidadeBase, iva, desconto, sTKMinimo, sTKMaximo, sTKReposicao, sTKActual,\r\n                            pCMedio, pCUltimo, movStock, dataUltEntrada, dataUltSaida, familia, armazemSugestao, \r\n                            tipoArtigo, pCPadrao, sugestaoPrComposto, ultDescontoComercialCompra, ultDespesaAdicionalCompra,\r\n                            prazoEntrega, qtdEconomica, ultimoFornecedor, subFamilia, peso, volume, artigoAnulado,\r\n                            tratamentoSeries, tratamentoLotes, loteFormulaEntradas, loteEntradas, loteFormulaSaidas, loteSaidas, \r\n                            ultimoNumSerie, ultimoLote,  dataUltimaActualizacao, sujeitoRetencao,\r\n                            observacoes,   operacaoTesouraria,\r\n                            entidadeOPTesouraria, modelo, unidadeCompra, unidadeEntrada, unidadeSaida, ultimaSerieDoc, deduzIvaNoImo, permiteDevolucao,\r\n                            tipoEntidadeOpTesouraria, utilizadoCCOP, pesar, sujeitoProRata, percIvaDedutivel, sujeitoEcotaxa, ecovalor,\r\n                            afectaPCM, localizacaoSugestao, ordemDim, rubDim1, rubDim2, rubDim3, fabCompAutoGPR,\r\n                            calcNecessidadesGPR, qtReservadaGPR, qtReceberGPR,  desperdicioGPR, utilizadoGPR, PercIncidenciaIVA,\r\n                   unidadeTaric, utilManutencao, pesoLiquido, gestaoSingular,\r\n                            selo, codigoBebidaEspirituosa, codigoEstampilha, factorUnidadeSup, isentoPagDireitos, \r\n                            controlaTransformacaoValor,   dataCustoPadrao, \r\n                            sujeitoRetencaoArtigo, retencaoArtigoValor, retencaoArtigoTipoValor,   numeroONU,\r\n                           grauPlato, calcNessidadesMultiploCompra, imovel\r\n                        ) VALUES (\r\n                            '{artigo}', '{descricao}', '{codBarras}', '{unidadeVenda}', '{unidadeBase}', '{iVA}', {desconto}, {sTKMinimo}, {sTKMaximo}, {sTKReposicao}, {stkActual},\r\n                            {pCMedio}, {pCUltimo}, '{movStock}', '{dataUltimaEntrada:yyyy-MM-dd HH:mm:ss}', '{dataUltimaSaida:yyyy-MM-dd HH:mm:ss}', NULLIF('{familia}', ''),  '{armazemSugestao}',\r\n                            '{tipoArtigo}', {pCPadrao}, {sugestaoPrCustoComposto}, {ultimoDescontoComercialCompra}, {ultimaDespesaAdicionalCompra},\r\n                            {prazoEntrega}, {quantEconomica}, '{ultimoFornecedor}', NULLIF('{subFamilia}', ''),  {peso}, {volume},   {(anulado ? 1 : 0)},\r\n                            {(trataNumerosSerie ? 1 : 0)}, {(trataLotes ? 1 : 0)}, {(utilizaFormulaLotesEntrada ? 1 : 0)}, '{sugestaoLoteEntradas}', {(utilizaFormulaLotesSaida ? 1 : 0)}, '{sugestaoLoteSaidas}', \r\n                            '{ultimoNumeroSerie}', '{ultimoLote}',  '{dataUltimaActualizacao:yyyy-MM-dd HH:mm:ss}', {(sujeitoRetencao ? 1 : 0)},\r\n                            '{observacoes}', {(operacaoTesouraria ? 1 : 0)},\r\n                            '{entidadeTesouraria}', '{modelo}', '{unidadeCompra}', '{unidadeEntrada}', '{unidadeSaida}', '{ultimaSerieDocumentoCompra}', {(deduzIVA ? 1 : 0)}, {(sujeitoDevolucao ? 1 : 0)},\r\n                            '{tipoEntidadeTesouraria}', {(utilizadoCCOP ? 1 : 0)}, {(pesar ? 1 : 0)}, {(sujeitoProRata ? 1 : 0)}, {percIvaDedutivel}, {(sujeitoEcotaxa ? 1 : 0)}, {ecovalor},\r\n                            {(ecovalorAfectaPCM ? 1 : 0)}, '{localizacaoSugestao}',  {ordemDim}, '{rubDimensao}', '{rubDimensao2}', '{rubDimensao3}' , {(fabCompAuto ? 1 : 0)},\r\n                            {(calcNecessidades ? 1 : 0)}, {qtReservada}, {qtReceber},  {desperdicio}, {(utilizadoGPR ? 1 : 0)}, {percIncidenciaIVA},\r\n                            '{unidadeTaric}',  {(utilizadoManutencao ? 1 : 0)}, {pesoLiquido}, {(gestaoSingular ? 1 : 0)},\r\n                            '{selo}', '{codigoBebidaEspirituosa}', '{codigoEstampilha}', {factorUnidadeSup},{(isentoPagDireitos ? 1 : 0)}, \r\n                            {(controlaTransformacaoValor ? 1 : 0)}, '{dataCustoPadrao:yyyy-MM-dd HH:mm:ss}', \r\n                            {(sujeitoRetencaoArtigo ? 1 : 0)}, {retencaoArtigoValor}, {(retencaoArtigoTipoValor ? 1 : 0)},   '{numeroONU}', \r\n                            {grauPlato}, {calcNessidadesMultiploCompra}, {(imovel ? 1 : 0)}\r\n                        )";
                        ((ProductContext)this).BSO.DSO.ExecuteSQL(text5);
                        string text6 = $"\r\n                        INSERT INTO [PRI{text}].[dbo].[ArtigoMoeda] (\r\n                            artigo, moeda, pvp1, pvp2, pvp3, pvp4, pvp5, pvp6, unidade, \r\n                            pvp1IvaIncluido, pvp2IvaIncluido, pvp3IvaIncluido, pvp4IvaIncluido, pvp5IvaIncluido, pvp6IvaIncluido\r\n                        ) VALUES (\r\n                            '{artigo}', '{moeda}', {pVP1}, {pVP2}, {pVP3}, {pVP4}, {pVP5}, {pVP6}, '{unidade}', \r\n                            {(pVP1IvaIncluido ? 1 : 0)}, {(pVP2IvaIncluido ? 1 : 0)}, {(pVP3IvaIncluido ? 1 : 0)}, {(pVP4IvaIncluido ? 1 : 0)}, {(pVP5IvaIncluido ? 1 : 0)}, {(pVP6IvaIncluido ? 1 : 0)}\r\n                        )";
                        ((ProductContext)this).BSO.DSO.ExecuteSQL(text6);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao replicar o artigo para a empresa BRIOSA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }


            public override void DepoisDeAnular(string Artigo, ExtensibilityEventArgs e)
            {
            }
        }

    
}
