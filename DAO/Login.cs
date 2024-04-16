using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AcessosUsuarios
    {
        public bool _formcompraAcesso;
        public bool _formConsultaCompraAcesso;
        public bool _formRelatorioCompraAcesso; //

        public bool _formcadastroFornecedorAcesso;
        public bool _formconsultaFornecedorAcesso;
        public bool _formRelatorioFornecedorAcesso; //

        public bool _formcadastroProdutoAcesso;
        public bool _formconsultaProdutoAcesso;
        public bool _formRelatorioProdutoAcesso; //

        public bool _formcadastroCategoriaAcesso;
        public bool _formcadastroSubCategoriaAcesso;
        public bool _formcadastroTipoDePagamentoAcesso;
        public bool _formcadastroUnidadeMedidaAcesso;
        public bool _formconsultaCategoriaAcesso;
        public bool _formconsultaSubCategoriaAcesso;
        public bool _formconsultaTipoDePagamentoAcesso;
        public bool _formconsultaUnidadeMedidaAcesso;

        public bool _formcadastroUsuarioAcesso;
        public bool _formconsultaUsuarioAcesso;
        public bool _formRelatorioUsuarioAcesso; // 

        public bool _formcadastroClienteAcesso; // 
        public bool _formConsultaClienteAcesso; //
        public bool _formRelatorioClienteAcesso; //

        public bool _formVendaAcesso;
        public bool _formConsultaVendaAcesso;
        public bool _formRelatorioVendaAcesso; //

        public bool _formPagamentoAcesso;
        public bool _formRecebimentoAcesso;

        public bool _formPrincipal;

        public AcessosUsuarios(bool VendaAcesso, bool CadastroCategoriaAcesso, bool cadastroFornecedorAcesso,
            bool cadastroProdutoAcesso, bool cadastroSubCategoriaAcesso, bool cadastroTipoDePagamentoAcesso,
            bool cadastroUnidadeMedidaAcesso, bool cadastroUsuarioAcesso, bool compraAcesso,
            bool consultaCategoriaAcesso, bool ConsultaCompraAcesso, bool consultaFornecedorAcesso,
            bool consultaProdutoAcesso, bool consultaSubCategoriaAcesso, bool consultaTipoDePagamentoAcesso,
            bool consultaUnidadeMedidaAcesso, bool consultaUsuarioAcesso, bool ConsultaVendaAcesso,
            bool PagamentoAcesso, bool RecebimentoAcesso, bool formPrincipal, bool RelatorioCompraAcesso,
            bool RelatorioFornecedorAcesso, bool RelatorioProdutoAcesso, bool RelatorioUsuarioAcesso,
            bool cadastroClienteAcesso, bool ConsultaClienteAcesso, bool RelatorioClienteAcesso,
            bool RelatorioVendaAcesso)
        {
            _formVendaAcesso = VendaAcesso;
            _formcadastroCategoriaAcesso = CadastroCategoriaAcesso;
            _formcadastroFornecedorAcesso = cadastroFornecedorAcesso;
            _formcadastroProdutoAcesso = cadastroProdutoAcesso;
            _formcadastroSubCategoriaAcesso = cadastroSubCategoriaAcesso;
            _formcadastroTipoDePagamentoAcesso = cadastroTipoDePagamentoAcesso;
            _formcadastroUnidadeMedidaAcesso = cadastroUnidadeMedidaAcesso;
            _formcadastroUsuarioAcesso = cadastroUsuarioAcesso;
            _formcompraAcesso = compraAcesso;
            _formconsultaCategoriaAcesso = consultaCategoriaAcesso;
            _formConsultaCompraAcesso = ConsultaCompraAcesso;
            _formconsultaFornecedorAcesso = consultaFornecedorAcesso;
            _formconsultaProdutoAcesso = consultaProdutoAcesso;
            _formconsultaSubCategoriaAcesso = consultaSubCategoriaAcesso;
            _formconsultaTipoDePagamentoAcesso = consultaTipoDePagamentoAcesso;
            _formconsultaUnidadeMedidaAcesso = consultaUnidadeMedidaAcesso;
            _formconsultaUsuarioAcesso = consultaUsuarioAcesso;
            _formConsultaVendaAcesso = ConsultaVendaAcesso;
            _formPagamentoAcesso = PagamentoAcesso;
            _formRecebimentoAcesso = RecebimentoAcesso;
            _formConsultaClienteAcesso = ConsultaClienteAcesso;
            _formcadastroClienteAcesso = cadastroClienteAcesso;
            _formPrincipal = formPrincipal;

            _formRelatorioCompraAcesso = RelatorioCompraAcesso;
            _formRelatorioFornecedorAcesso = RelatorioFornecedorAcesso;
            _formRelatorioProdutoAcesso = RelatorioProdutoAcesso;
            _formRelatorioUsuarioAcesso = RelatorioUsuarioAcesso;
            _formRelatorioClienteAcesso = RelatorioClienteAcesso;
            _formRelatorioVendaAcesso = RelatorioVendaAcesso;
        }
    }

    public class Vendedor : AUsuario
    {
        public Vendedor(string nome, string nivelAcesso) : base(nome, nivelAcesso,
            new AcessosUsuarios(
            VendaAcesso: true,
            CadastroCategoriaAcesso: false,
            cadastroFornecedorAcesso: false,
            cadastroProdutoAcesso: false,
            cadastroSubCategoriaAcesso: false,
            cadastroTipoDePagamentoAcesso: false,
            cadastroUnidadeMedidaAcesso: false,
            cadastroUsuarioAcesso: false,
            compraAcesso: false,
            consultaCategoriaAcesso: false,
            ConsultaCompraAcesso: false,
            consultaFornecedorAcesso: false,
            consultaProdutoAcesso: false,
            consultaSubCategoriaAcesso: false,
            consultaTipoDePagamentoAcesso: false,
            consultaUnidadeMedidaAcesso: false,
            consultaUsuarioAcesso: false,
            ConsultaVendaAcesso: false,
            PagamentoAcesso: false,
            RecebimentoAcesso: false,
            formPrincipal: true,
            RelatorioCompraAcesso: false,
            RelatorioFornecedorAcesso: false,
            RelatorioProdutoAcesso: false,
            RelatorioUsuarioAcesso: false,
            ConsultaClienteAcesso: false,
            cadastroClienteAcesso: false,
            RelatorioClienteAcesso: false,
            RelatorioVendaAcesso: false
            ))
        { }
    }

    public class Administrador : AUsuario
    {
        public Administrador(string nome, string nivelAcesso) : base(nome, nivelAcesso,
            new AcessosUsuarios(
            VendaAcesso: true,
            CadastroCategoriaAcesso: true,
            cadastroFornecedorAcesso: true,
            cadastroProdutoAcesso: true,
            cadastroSubCategoriaAcesso: true,
            cadastroTipoDePagamentoAcesso: true,
            cadastroUnidadeMedidaAcesso: true,
            cadastroUsuarioAcesso: true,
            compraAcesso: true,
            consultaCategoriaAcesso: true,
            ConsultaCompraAcesso: true,
            consultaFornecedorAcesso: true,
            consultaProdutoAcesso: true,
            consultaSubCategoriaAcesso: true,
            consultaTipoDePagamentoAcesso: true,
            consultaUnidadeMedidaAcesso: true,
            consultaUsuarioAcesso: true,
            ConsultaVendaAcesso: true,
            PagamentoAcesso: true,
            RecebimentoAcesso: true,
            formPrincipal: true,
            RelatorioCompraAcesso: true,
            RelatorioFornecedorAcesso: true,
            RelatorioProdutoAcesso: true,
            RelatorioUsuarioAcesso: true,
            ConsultaClienteAcesso: true,
            cadastroClienteAcesso: true,
            RelatorioClienteAcesso: true,
            RelatorioVendaAcesso: true
            ))
        { }
    }

    public class Gerente : AUsuario
    {
        public Gerente(string nome, string nivelAcesso) : base(nome, nivelAcesso,
            new AcessosUsuarios(
            VendaAcesso: true,
            CadastroCategoriaAcesso: false,
            cadastroFornecedorAcesso: true,
            cadastroProdutoAcesso: true,
            cadastroSubCategoriaAcesso: false,
            cadastroTipoDePagamentoAcesso: false,
            cadastroUnidadeMedidaAcesso: false,
            cadastroUsuarioAcesso: false,
            compraAcesso: true,
            consultaCategoriaAcesso: false,
            ConsultaCompraAcesso: true,
            consultaFornecedorAcesso: true,
            consultaProdutoAcesso: true,
            consultaSubCategoriaAcesso: false,
            consultaTipoDePagamentoAcesso: false,
            consultaUnidadeMedidaAcesso: false,
            consultaUsuarioAcesso: true,
            ConsultaVendaAcesso: true,
            PagamentoAcesso: true,
            RecebimentoAcesso: true,
            formPrincipal: true,
            RelatorioCompraAcesso: true,
            RelatorioFornecedorAcesso: true,
            RelatorioProdutoAcesso: true,
            RelatorioUsuarioAcesso: false,
            ConsultaClienteAcesso: true,
            cadastroClienteAcesso: true,
            RelatorioClienteAcesso: true,
            RelatorioVendaAcesso: true
            ))
        { }
    }

    public class AUsuario
    {
        protected string _nome;
        protected string _nivelAcesso;
        public AcessosUsuarios _acessoUsuario;

        public AUsuario(string nome, string nivelAcesso, AcessosUsuarios acessoUsuario)
        {
            this._nome = nome;
            this._nivelAcesso = nivelAcesso;
            this._acessoUsuario = acessoUsuario;
        }

        public string Nome { get { return _nome; } }
        public string NivelAcesso { get { return _nivelAcesso; } }
        public AcessosUsuarios NivelAcesso2 { get { return _acessoUsuario; } }

    }
}
