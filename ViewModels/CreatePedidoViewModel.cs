﻿using CrudProduto.Models;

namespace CrudProduto.ViewModels
{
    public class CreatePedidoViewModel
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public bool Pago { get; set; }
        public List<ItensPedidoViewModel> ItensPedido { get; set; }
    }

    public class ItensPedidoViewModel
    {
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
    }
}
