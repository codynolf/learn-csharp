namespace learn.fpdeepdive;

public class Item
{
    public string Name { get; set; }
    public int Price { get; set; }
    public bool Taxable { get; set; }

    public ItemOptions Options { get; set; }
}
