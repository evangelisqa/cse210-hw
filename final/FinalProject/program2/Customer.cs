public class Customer
{
  private string _customerName;
  private Address _customerAddress = new Address("street", "city", "state", "country");
  public Customer()
  { }
  public Customer(string name, Address address)
  {
    _customerName = name;
    _customerAddress = address;
  }

  public string GetCustomerName()
  {
    return _customerName;
  }

  public string GetCustomerAddress()
  {
    return _customerAddress.displayAddress();
  }

  public Boolean isInPHILIPPINES()
  {
    if (_customerAddress.isInPHILIPPINES())
    {
      return true;
    }
    return false;
  }

}