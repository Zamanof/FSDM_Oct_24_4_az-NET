// Observer - Mushahidechi
// Also known as: Event-Subscriber, Listener

// Subject - Publisher
// Observer - Subscriber

ProductManager productManager = new ProductManager();
var customer = new CustomerObserver();
var employee = new EmployeeObserver();

productManager.Attach(customer);
productManager.Attach(employee);

productManager.UpdatePrice();

Console.WriteLine();
productManager.Detach(customer);
productManager.UpdatePrice();
