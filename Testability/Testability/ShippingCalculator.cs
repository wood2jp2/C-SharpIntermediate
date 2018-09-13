namespace Testability
{

    // use 'interface' access modifier and put 'I' in front of name
    public interface IShippingCalculator
    {
        // no access modifier
        float CalculateShipping(Order order);
    }

    // read as 'ShippingCalculator implements IShippingCalculator'
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order) => 
            order.TotalPrice < 30f ? 
            order.TotalPrice * 0.1f : 
            0;
    }
}
