namespace DesignPatternProgram.Behaviral_DesignPattern.VisitorDesignPattern
{
    public class Fruit : ItemElements
    {
        private int price;
        private string fruitName;
        private int weight;
        public Fruit(int price, string name,int weight)
        {
            this.price = price;
            this.fruitName = name;
            this.weight = weight;
        }

        public int getPrice()
        {
            return this.price;
        }
        public int getWeight()
        {
            return this.weight;
        }
        public string FruitName()
        {
            return this.fruitName;
        }

        public int Accept(ShoppingCartVisitor Visitor)
        {
            return Visitor.visit(this);
        }
    }
}