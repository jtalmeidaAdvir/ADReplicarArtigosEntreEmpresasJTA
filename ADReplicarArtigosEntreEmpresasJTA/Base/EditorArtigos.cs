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
<<<<<<< HEAD
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

=======
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
                string descontoStr = desconto.ToString(CultureInfo.InvariantCulture);

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

                string pCMedioStr = pCMedio.ToString(CultureInfo.InvariantCulture);
                string pCUltimoStr = pCUltimo.ToString(CultureInfo.InvariantCulture);
                string ultDescComCompraStr = ultimoDescontoComercialCompra.ToString(CultureInfo.InvariantCulture);
                string ecovalorStr = ecovalor.ToString(CultureInfo.InvariantCulture);
                string pesoStr = peso.ToString(CultureInfo.InvariantCulture);
                string volumeStr = volume.ToString(CultureInfo.InvariantCulture);

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
                        string text3 = $"\r\n    UPDATE [PRI{text}].[dbo].[Artigo] SET \r\n        descricao = '{descricao}', \r\n        codBarras = '{codBarras}', \r\n        unidadeVenda = '{unidadeVenda}', \r\n        unidadeBase = '{unidadeBase}', \r\n        iva = '{iVA}', \r\n        desconto = '{descontoStr}', \r\n        sTKMinimo = {sTKMinimo}, \r\n        sTKMaximo = {sTKMaximo}, \r\n        sTKReposicao = {sTKReposicao}, \r\n        sTKActual = {stkActual}, \r\n        pCMedio = {pCMedioStr}, \r\n        pCUltimo = {pCUltimoStr}, \r\n        movStock = '{movStock}', \r\n        familia = NULLIF('{familia}', ''), \r\n        armazemSugestao = '{armazemSugestao}', \r\n        tipoArtigo = '{tipoArtigo}', \r\n        pCPadrao = {pCPadrao}, \r\n        sugestaoPrComposto = {sugestaoPrCustoComposto}, \r\n        ultDescontoComercialCompra = {ultDescComCompraStr}, \r\n        ultDespesaAdicionalCompra = {ultimaDespesaAdicionalCompra}, \r\n        prazoEntrega = {prazoEntrega}, \r\n        qtdEconomica = {quantEconomica}, \r\n        ultimoFornecedor = '{ultimoFornecedor}', \r\n        subFamilia = NULLIF('{subFamilia}', ''), \r\n        peso = {pesoStr}, \r\n        volume = {volumeStr}, \r\n        artigoAnulado = {(anulado ? 1 : 0)}, \r\n        tratamentoSeries = {(trataNumerosSerie ? 1 : 0)}, \r\n        tratamentoLotes = {(trataLotes ? 1 : 0)}, \r\n        loteFormulaEntradas = {(utilizaFormulaLotesEntrada ? 1 : 0)}, \r\n        loteEntradas = '{sugestaoLoteEntradas}', \r\n        loteFormulaSaidas = {(utilizaFormulaLotesSaida ? 1 : 0)}, \r\n        loteSaidas = '{sugestaoLoteSaidas}', \r\n        ultimoNumSerie = '{ultimoNumeroSerie}', \r\n        ultimoLote = '{ultimoLote}', \r\n        sujeitoRetencao = {(sujeitoRetencao ? 1 : 0)}, \r\n        observacoes = '{observacoes}', \r\n        operacaoTesouraria = {(operacaoTesouraria ? 1 : 0)}, \r\n        entidadeOPTesouraria = '{entidadeTesouraria}', \r\n        modelo = '{modelo}', \r\n        unidadeCompra = '{unidadeCompra}', \r\n        unidadeEntrada = '{unidadeEntrada}', \r\n        unidadeSaida = '{unidadeSaida}', \r\n        ultimaSerieDoc = '{ultimaSerieDocumentoCompra}', \r\n        deduzIvaNoImo = {(deduzIVA ? 1 : 0)}, \r\n        permiteDevolucao = {(sujeitoDevolucao ? 1 : 0)}, \r\n        tipoEntidadeOpTesouraria = '{tipoEntidadeTesouraria}', \r\n        utilizadoCCOP = {(utilizadoCCOP ? 1 : 0)}, \r\n        pesar = {(pesar ? 1 : 0)}, \r\n        sujeitoProRata = {(sujeitoProRata ? 1 : 0)}, \r\n        percIvaDedutivel = {percIvaDedutivel}, \r\n        sujeitoEcotaxa = {(sujeitoEcotaxa ? 1 : 0)}, \r\n        ecovalor = {ecovalorStr}, \r\n        afectaPCM = {(ecovalorAfectaPCM ? 1 : 0)}, \r\n        localizacaoSugestao = '{localizacaoSugestao}', \r\n        ordemDim = {ordemDim}, \r\n        rubDim1 = '{rubDimensao}', \r\n        rubDim2 = '{rubDimensao2}', \r\n        rubDim3 = '{rubDimensao3}', \r\n        fabCompAutoGPR = {(fabCompAuto ? 1 : 0)}, \r\n        calcNecessidadesGPR = {(calcNecessidades ? 1 : 0)}, \r\n        qtReservadaGPR = {qtReservada}, \r\n        qtReceberGPR = {qtReceber}, \r\n        desperdicioGPR = {desperdicio}, \r\n        utilizadoGPR = {(utilizadoGPR ? 1 : 0)}, \r\n        PercIncidenciaIVA = {percIncidenciaIVA}, \r\n        unidadeTaric = '{unidadeTaric}', \r\n        utilManutencao = {(utilizadoManutencao ? 1 : 0)}, \r\n        pesoLiquido = {pesoLiquido}, \r\n        gestaoSingular = {(gestaoSingular ? 1 : 0)}, \r\n        selo = '{selo}', \r\n        codigoBebidaEspirituosa = '{codigoBebidaEspirituosa}', \r\n        codigoEstampilha = '{codigoEstampilha}', \r\n        factorUnidadeSup = {factorUnidadeSup}, \r\n        isentoPagDireitos = {(isentoPagDireitos ? 1 : 0)}, \r\n        controlaTransformacaoValor = {(controlaTransformacaoValor ? 1 : 0)}, \r\n        sujeitoRetencaoArtigo = {(sujeitoRetencaoArtigo ? 1 : 0)}, \r\n        retencaoArtigoValor = {retencaoArtigoValor}, \r\n        retencaoArtigoTipoValor = {(retencaoArtigoTipoValor ? 1 : 0)}, \r\n        numeroONU = '{numeroONU}', \r\n        grauPlato = {grauPlato}, \r\n        calcNessidadesMultiploCompra = {calcNessidadesMultiploCompra}, \r\n        imovel = {(imovel ? 1 : 0)} \r\n    WHERE artigo = '{artigo}'\r\n";
                 //   PSO.MensagensDialogos.MostraMensagem(StdPlatBS100.StdBSTipos.TipoMsg.PRI_Detalhe, text3);
                    ((ProductContext)this).BSO.DSO.ExecuteSQL(text3);
                        string text4 = $"\r\n                        UPDATE [PRI{text}].[dbo].[ArtigoMoeda] SET \r\n                            pvp1 = '{pVP1}', \r\n                            pvp2 = '{pVP2}', \r\n                            pvp3 = '{pVP3}', \r\n                            pvp4 = '{pVP4}', \r\n                            pvp5 = '{pVP5}', \r\n                            pvp6 = '{pVP6}', \r\n                            unidade = '{unidade}', \r\n                            pvp1IvaIncluido = {(pVP1IvaIncluido ? 1 : 0)}, \r\n                            pvp2IvaIncluido = {(pVP2IvaIncluido ? 1 : 0)}, \r\n                            pvp3IvaIncluido = {(pVP3IvaIncluido ? 1 : 0)}, \r\n                            pvp4IvaIncluido = {(pVP4IvaIncluido ? 1 : 0)}, \r\n                            pvp5IvaIncluido = {(pVP5IvaIncluido ? 1 : 0)}, \r\n                            pvp6IvaIncluido = {(pVP6IvaIncluido ? 1 : 0)}\r\n                        WHERE artigo = '{artigo}' AND moeda = '{moeda}'\r\n                        ";
                        ((ProductContext)this).BSO.DSO.ExecuteSQL(text4);
                    }
                    else
                    {
                        string text5 = $"\r\n                        INSERT INTO [PRI{text}].[dbo].[Artigo] (\r\n                            artigo, descricao, codBarras, unidadeVenda, unidadeBase, iva, desconto, sTKMinimo, sTKMaximo, sTKReposicao, sTKActual,\r\n                            pCMedio, pCUltimo, movStock, dataUltEntrada, dataUltSaida, familia, armazemSugestao, \r\n                            tipoArtigo, pCPadrao, sugestaoPrComposto, ultDescontoComercialCompra, ultDespesaAdicionalCompra,\r\n                            prazoEntrega, qtdEconomica, ultimoFornecedor, subFamilia, peso, volume, artigoAnulado,\r\n                            tratamentoSeries, tratamentoLotes, loteFormulaEntradas, loteEntradas, loteFormulaSaidas, loteSaidas, \r\n                            ultimoNumSerie, ultimoLote,  dataUltimaActualizacao, sujeitoRetencao,\r\n                            observacoes,   operacaoTesouraria,\r\n                            entidadeOPTesouraria, modelo, unidadeCompra, unidadeEntrada, unidadeSaida, ultimaSerieDoc, deduzIvaNoImo, permiteDevolucao,\r\n                            tipoEntidadeOpTesouraria, utilizadoCCOP, pesar, sujeitoProRata, percIvaDedutivel, sujeitoEcotaxa, ecovalor,\r\n                            afectaPCM, localizacaoSugestao, ordemDim, rubDim1, rubDim2, rubDim3, fabCompAutoGPR,\r\n                            calcNecessidadesGPR, qtReservadaGPR, qtReceberGPR,  desperdicioGPR, utilizadoGPR, PercIncidenciaIVA,\r\n                   unidadeTaric, utilManutencao, pesoLiquido, gestaoSingular,\r\n                            selo, codigoBebidaEspirituosa, codigoEstampilha, factorUnidadeSup, isentoPagDireitos, \r\n                            controlaTransformacaoValor,   dataCustoPadrao, \r\n                            sujeitoRetencaoArtigo, retencaoArtigoValor, retencaoArtigoTipoValor,   numeroONU,\r\n                           grauPlato, calcNessidadesMultiploCompra, imovel\r\n                        ) VALUES (\r\n                            '{artigo}', '{descricao}', '{codBarras}', '{unidadeVenda}', '{unidadeBase}', '{iVA}', '{descontoStr}', {sTKMinimo}, {sTKMaximo}, {sTKReposicao}, {stkActual},\r\n                            {pCMedio}, {pCUltimo}, '{movStock}', '{dataUltimaEntrada:yyyy-MM-dd HH:mm:ss}', '{dataUltimaSaida:yyyy-MM-dd HH:mm:ss}', NULLIF('{familia}', ''),  '{armazemSugestao}',\r\n                            '{tipoArtigo}', {pCPadrao}, {sugestaoPrCustoComposto}, {ultimoDescontoComercialCompra}, {ultimaDespesaAdicionalCompra},\r\n                            {prazoEntrega}, {quantEconomica}, '{ultimoFornecedor}', NULLIF('{subFamilia}', ''),  {peso}, {volume},   {(anulado ? 1 : 0)},\r\n                            {(trataNumerosSerie ? 1 : 0)}, {(trataLotes ? 1 : 0)}, {(utilizaFormulaLotesEntrada ? 1 : 0)}, '{sugestaoLoteEntradas}', {(utilizaFormulaLotesSaida ? 1 : 0)}, '{sugestaoLoteSaidas}', \r\n                            '{ultimoNumeroSerie}', '{ultimoLote}',  '{dataUltimaActualizacao:yyyy-MM-dd HH:mm:ss}', {(sujeitoRetencao ? 1 : 0)},\r\n                            '{observacoes}', {(operacaoTesouraria ? 1 : 0)},\r\n                            '{entidadeTesouraria}', '{modelo}', '{unidadeCompra}', '{unidadeEntrada}', '{unidadeSaida}', '{ultimaSerieDocumentoCompra}', {(deduzIVA ? 1 : 0)}, {(sujeitoDevolucao ? 1 : 0)},\r\n                            '{tipoEntidadeTesouraria}', {(utilizadoCCOP ? 1 : 0)}, {(pesar ? 1 : 0)}, {(sujeitoProRata ? 1 : 0)}, {percIvaDedutivel}, {(sujeitoEcotaxa ? 1 : 0)}, {ecovalor},\r\n                            {(ecovalorAfectaPCM ? 1 : 0)}, '{localizacaoSugestao}',  {ordemDim}, '{rubDimensao}', '{rubDimensao2}', '{rubDimensao3}' , {(fabCompAuto ? 1 : 0)},\r\n                            {(calcNecessidades ? 1 : 0)}, {qtReservada}, {qtReceber},  {desperdicio}, {(utilizadoGPR ? 1 : 0)}, {percIncidenciaIVA},\r\n                            '{unidadeTaric}',  {(utilizadoManutencao ? 1 : 0)}, {pesoLiquido}, {(gestaoSingular ? 1 : 0)},\r\n                            '{selo}', '{codigoBebidaEspirituosa}', '{codigoEstampilha}', {factorUnidadeSup},{(isentoPagDireitos ? 1 : 0)}, \r\n                            {(controlaTransformacaoValor ? 1 : 0)}, '{dataCustoPadrao:yyyy-MM-dd HH:mm:ss}', \r\n                            {(sujeitoRetencaoArtigo ? 1 : 0)}, {retencaoArtigoValor}, {(retencaoArtigoTipoValor ? 1 : 0)},   '{numeroONU}', \r\n                            {grauPlato}, {calcNessidadesMultiploCompra}, {(imovel ? 1 : 0)}\r\n                        )";
                        ((ProductContext)this).BSO.DSO.ExecuteSQL(text5);
                        string text6 = $"\r\n                        INSERT INTO [PRI{text}].[dbo].[ArtigoMoeda] (\r\n                            artigo, moeda, pvp1, pvp2, pvp3, pvp4, pvp5, pvp6, unidade, \r\n                            pvp1IvaIncluido, pvp2IvaIncluido, pvp3IvaIncluido, pvp4IvaIncluido, pvp5IvaIncluido, pvp6IvaIncluido\r\n                        ) VALUES (\r\n                            '{artigo}', '{moeda}', {pVP1}, {pVP2}, {pVP3}, {pVP4}, {pVP5}, {pVP6}, '{unidade}', \r\n                            {(pVP1IvaIncluido ? 1 : 0)}, {(pVP2IvaIncluido ? 1 : 0)}, {(pVP3IvaIncluido ? 1 : 0)}, {(pVP4IvaIncluido ? 1 : 0)}, {(pVP5IvaIncluido ? 1 : 0)}, {(pVP6IvaIncluido ? 1 : 0)}\r\n                        )";
                        ((ProductContext)this).BSO.DSO.ExecuteSQL(text6);
                    }
>>>>>>> 6e6f50751d814cf6e29156b79ed421d7d9b0c070
                }
                catch (Exception ex)
                {
<<<<<<< HEAD
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

=======
                    MessageBox.Show("Erro ao replicar o artigo para a empresa BRIOSA: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
>>>>>>> 6e6f50751d814cf6e29156b79ed421d7d9b0c070
            }


            public override void DepoisDeAnular(string Artigo, ExtensibilityEventArgs e)
            {
<<<<<<< HEAD
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
=======
            }
        }

    
>>>>>>> 6e6f50751d814cf6e29156b79ed421d7d9b0c070
}
