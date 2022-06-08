namespace CoffeeShopClasses;

public class Customer
{
    // fields and properties
    // name
    private string _fullName = "Tim"; // field
    public string FullName
    {
        get { return $"The customer's name is {_fullName}";  }
        set
        {
            // validation
            // check for empty string
            // capitalise name
            _fullName = value;
        }
    }

    // Id
    //private Guid _id; // field
    //public Guid Id // property
    //{
    //    // accessors
    //    get { return _id; }
    //    set { _id = value;  }
    //}

    public Guid Id { get; private set; }

    public string FavDrink { get; set; }

    // constructor
    public Customer()
    {
        Id = Guid.NewGuid();
    }

    public Customer(string providedName) : this()
    {
        FullName = providedName;
    }

    public Customer(string providedName, string providedDrink = "oatmilk latte") : this(providedName)
    {
        FavDrink = providedDrink;
    }

    // methods
    public virtual int GenerateDiscount()
    {
        return 0;
    }



}

