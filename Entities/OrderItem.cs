using System.Globalization;

namespace Projeto_Fixacao_Enum.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        /// <summary>
        /// Criar um objeto de um item do pedido vazio
        /// </summary>
        public OrderItem() { }

        /// <summary>
        /// Cria um objeto de um pedido com os dados
        /// </summary>
        /// <param name="quantity">Quantidade de um certo produto</param>
        /// <param name="price">preco do produto</param>
        /// <param name="product">nome do produto</param>
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal(){
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
