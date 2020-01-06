namespace DesignPatternProgram.Behaviral_DesignPattern.VisitorDesignPattern
{
    public class Book : ItemElements
    {

		private int price;
		private string isbnNumber;

		public Book(int cost, string isbn)
		{
			this.price = cost;
			this.isbnNumber = isbn;
		}

		public int getPrice()
		{
			return price;
		}

		public string getIsbnNumber()
		{
			return isbnNumber;
		}

		public int Accept(ShoppingCartVisitor Visitor)
		{
				return Visitor.visit(this);
		}

	}
}