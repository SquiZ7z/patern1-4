using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Patern_1.Command;
using static Patern_1.Iterator;

using Patern_1;
using System.Xml.Linq;

class Program
    {
        private static void Main(string[] args)
        {
            //lab1

            // Створити об'єкти класів
            Money price = new Money(10, 50);
            product product = new product("Product 1", price);
            Warehouse warehouse = new Warehouse("Warehouse 1", "pcs", price, 100, DateTime.Now);
            Reporting reporting = new Reporting();

            // Задати нову ціну для продукту
            product.DecreasePrice(new Money(1, 0));
            Console.WriteLine($"New price: {product.Price}");

            // Реєстрація надходження товару
            reporting.RegisterIncome(product, 50, DateTime.Now);

            // Реєстрація відвантаження товару
            reporting.RegisterOutcome(product, 20, DateTime.Now);

            // Звіт по інвентаризації
            reporting.InventoryReport(warehouse);

            //lab2
            // Abstract Factory Pattern

            AbstractFactory factory = new ConcreteFactoryAImpl();
            product productA = factory.CreateProduct("Product A", new Money(10, 99));
            Warehouse warehouseA = factory.CreateWarehouse("Warehouse A", "unit", new Money(5, 99), 10, DateTime.Now);
            factory = new ConcreteFactoryBImpl();
            product productB = factory.CreateProduct("Product B", new Money(20, 99));
            Warehouse warehouseB = factory.CreateWarehouse("Warehouse B", "unit", new Money(10, 99), 20, DateTime.Now);




            // Builder Pattern
            // екземпляр класу Builder
            Builder builder = new Builder();
            // продукт з іменем "Product 1" і ціною 10.50
            ProductBuilder product1 = builder.WithName("Product 1").WithPrice(new Money(10, 50)).Build();
            // продукт з іменем "Product 2" і ціною 20.00
            ProductBuilder product2 = builder.WithName("Product 2").WithPrice(new Money(20, 0)).Build();
            // Виведення інформації про продукти
            Console.WriteLine($"Product 1: {product1.Name} - {product1.Price}");
            Console.WriteLine($"Product 2: {product2.Name} - {product2.Price}");

            // Factory Method Pattern
            FactoryMethod factoryB = new ConcreteFactoryB();
            AbstractProduct productBB = factoryB.CreateProduct();
            productBB.DoSomething();

            // Prototype Pattern
            Prototype prototype = new Prototype();
            Product originalProduct = new Product { Name = "Original Product", Price = new Money(10, 50) };
            Product clonedProduct = (Product)prototype.Clone(originalProduct);
            Console.WriteLine($"Cloned Product: {clonedProduct.Name} - {clonedProduct.Price}");

            // Singleton Pattern
            Singleton singleton = Singleton.Instance;
            Console.WriteLine("Singleton instance created");

            //lab3

            // Adapter Pattern
            Money _price = new Money(10, 50);
            IMoney moneyAdapter = new MoneyAdapter(_price);
            Console.WriteLine($"Adapter: {moneyAdapter.GetValue()}");

            // Bridge Pattern
            product _product = new product("Product 1", price);
            ProductBridge bridge = new ConcreteProductBridge(_product);
            bridge.DecreasePrice(new Money(1, 0));
            Console.WriteLine($"Bridge: {product.Price}");

            // Composite Pattern
            ProductComposite composite = new ProductComposite("Composite Product", new Money(0, 0));
            composite.AddProduct(new product("Product 2", new Money(20, 0)));
            composite.AddProduct(new product("Product 3", new Money(30, 0)));
            composite.DecreasePrice(new Money(5, 0));
            Console.WriteLine("Composite: Decreased prices of all products");

            // Decorator Pattern
            product decoratedProduct = new Decorator("Decorator", new Money(10, 0), new product("Product 4", new Money(40, 0)));
            decoratedProduct.DecreasePrice(new Money(10, 0));
            Console.WriteLine("Decorator: Decreased price with additional behavior");




            // Flyweight Pattern
            ProductFlyweight flyweight = new ProductFlyweight("Product 5", new Money(50, 0));
            product flyweightProduct = new ProductWrapper(flyweight);
            Console.WriteLine($"Flyweight: {flyweightProduct.Name} - {flyweightProduct.Price}");

            // Proxy Pattern
            product proxyProduct = new ProductProxy("Product 6", new Money(60, 0));
            proxyProduct.DecreasePrice(new Money(20, 0));
            Console.WriteLine("Proxy: Decreased price with permission check");

            // Facade Pattern
            // Create a product
            product product11 = new product("Product A", new Money(10, 0));
            product product12 = new product("Product B", new Money(20, 0));
            // Create a warehouse facade
            WarehouseFacade facade = new WarehouseFacade();
            // Register income
            facade.RegisterIncome(productA, 50, DateTime.Now);
            facade.RegisterIncome(productB, 30, DateTime.Now);
            // Register outcome
            facade.RegisterOutcome(productA, 20, DateTime.Now);
            // Inventory report
            facade.InventoryReport();
            Console.ReadLine();

            //lab4
            //Chain of Responsibility
            Handler handlerA = new ConcreteHandlerA();
            Handler handlerB = new ConcreteHandlerB();
            Handler handlerC = new ConcreteHandlerC(); // create a new handler
            handlerA.SetNext(handlerB);
            handlerB.SetNext(handlerC); // set next to handlerC
            Request requestA = new Request { Type = "A" };
            Request requestB = new Request { Type = "B" };
            Request requestC = new Request { Type = "C" };
            handlerA.HandleRequest(requestA);
            handlerA.HandleRequest(requestB);
            handlerA.HandleRequest(requestC);



            //Command
            Receiver receiver = new Receiver();
            ICommand command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            invoker.SetCommand(command);

            invoker.ExecuteCommand();
            Console.WriteLine("State after execute: " + receiver.State);

            invoker.UndoCommand();
            Console.WriteLine("State after undo: " + receiver.State);



            //Iterator
            List<object> collection = new List<object> { "item1", "item2", "item3" };
            IIterator iterator = new ConcreteIterator(collection);
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }



            //Mediator
            Colleague1 colleague1 = new Colleague1();
            Colleague2 colleague2 = new Colleague2();
            IMediator mediator = new ConcreteMediator(colleague1, colleague2);
            mediator.Send("Hello", colleague1);



            //Originator
            Originator originator = new Originator { State = "First Value" };
            CareTaker careTaker = new CareTaker();
            careTaker.SaveMemento(originator);
            originator.State = "Second Value";
            careTaker.RestoreMemento(originator);
            Console.WriteLine(originator.State);


            //Observer
            Subject subject = new Subject();
            IObserver observer1 = new ConcreteObserver();
            IObserver observer2 = new ConcreteObserver();
            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);
            subject.NotifyObservers("Hello, observers!");



            //State
            Context context = new Context();
            context.Request();
            context.Request();




            //Strategy
            // Create a ContextStrategy instance with ConcreteStrategyA
            ContextStrategy contextA = new ContextStrategy(new ConcreteStrategyA());
            contextA.ExecuteStrategy(); // Output: Strategy A executing

            // Create a ContextStrategy instance with ConcreteStrategyB
            ContextStrategy contextB = new ContextStrategy(new ConcreteStrategyB());
            contextB.ExecuteStrategy(); // Output: Strategy B executing


            //Template
            AbstractClass concreteClassA = new ConcreteClassA();
            concreteClassA.TemplateMethod();
            AbstractClass concreteClassB = new ConcreteClassB();
            concreteClassB.TemplateMethod();




            //Visitor
            Element elementA = new ConcreteElementA { Name = "Element A" };
            Element elementB = new ConcreteElementB { Name = "Element B" };
            IVisitor visitor = new ConcreteVisitor();
            elementA.Accept(visitor);
            elementB.Accept(visitor);


        }
    }

