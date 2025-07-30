using Primavera.Extensibility.Sales.Editors;
using Primavera.Extensibility.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using System.Windows.Forms;


namespace ADReplicarArtigosEntreEmpresasJTA.Base
{
    public class EditorDeVendas : EditorVendas
    {
        private bool ClienteBriosaIdentificado = false;

        public override void ClienteIdentificado(string Cliente, ref bool Cancel, ExtensibilityEventArgs e)
        {
            try
            {
                //verifica se o cliente e o "BRIOSA"
                if (Cliente == "2000")
                {
                    ClienteBriosaIdentificado = true;
                }
                else
                {
                    ClienteBriosaIdentificado = false;
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao identificar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
      

            }
        }

        public override void ArtigoIdentificado(string Artigo, int NumLinha, ref bool Cancel, ExtensibilityEventArgs e)
        {
            if (ClienteBriosaIdentificado)
            {

                var linha = this.DocumentoVenda.Linhas.GetEdita(NumLinha);
                var linhaartigo = linha.Artigo;
                var ArtigoCompleto = BSO.Base.Artigos.Edita(linhaartigo);

                // Aplica 5% ao valor de PCUltimo
                var pCULtimoComAcrescimo = ArtigoCompleto.PCUltimo * 1.05;


                // (Opcional) Exemplo de uso:
                linha.PrecUnit = pCULtimoComAcrescimo;
                linha.Desconto1 = 0; // Zera o desconto, se necessário

            }
        }

        public override void DepoisDeTransformar(ExtensibilityEventArgs e)
        {
            //vai linha a linha e atuliza o precUnit com o valor de PCUltimo + 5%  FOR

            if (ClienteBriosaIdentificado)
            {
                var numlinhas = this.DocumentoVenda.Linhas.NumItens;

                for (int i = 1; i < numlinhas + 1; i++)
                {
                    var linha = this.DocumentoVenda.Linhas.GetEdita(i);
                    var linhaartigo = linha.Artigo;
                    // se o artigo na o exitir passa a frente
                    if (string.IsNullOrEmpty(linhaartigo))
                    {
                        continue;
                    }
                    var ArtigoCompleto = BSO.Base.Artigos.Edita(linhaartigo);

                    // Aplica 5% ao valor de PCUltimo
                    var pCULtimoComAcrescimo = ArtigoCompleto.PCUltimo * 1.05;

                    // Atualiza o Preço Unitário da linha
                    linha.PrecUnit = pCULtimoComAcrescimo;

                }
            }

        }

    }
}
