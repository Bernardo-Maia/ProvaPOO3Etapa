using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1BERNARDO5.Code.DTO
{
    class InventarioDTO
    {
        private int _id;
        private string _produto;
        private int _quantidade;

        public int Id { get => _id; set => _id = value; }
        public string Produto { get => _produto; set => _produto = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
    }
}
