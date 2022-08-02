class PMS
{
	private static List<Product> product = new List<Product>;


		public void save( Product p)
    {
		product.Add(p);
    }
	public Product getall()
    {
		return product;
    }

}